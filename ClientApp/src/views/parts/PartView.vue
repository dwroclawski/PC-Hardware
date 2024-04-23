<template>
  <div>
    <div class="content">
      <div class="filters">
        <h1 class="title">{{ partName }}</h1>
        <div class="filter" v-for="filter in filtersVisible" :key="filter.name">
          <label class="sub-title">{{ filter.label }}:</label>
          <div v-if="filter.type === 'enum' && displayedFieldValues[filter.name]">
            <div v-for="(count, value) in displayedFieldValues[filter.name]" :key="value">
              <input
                type="checkbox"
                :id="value.toString()"
                :value="value"
                v-model="filterValues[filter.name]"
                @change="fetchData(filter.name)"
              />
              <label :for="value.toString">{{ value }} ({{ count }})</label>
            </div>
            <button
              class="extend-filters"
              v-if="Object.keys(sortedFieldValues[filter.name]).length > filtersToShow"
              @click="extendedFilters[filter.name] = !extendedFilters[filter.name]"
            >
              <span v-if="extendedFilters[filter.name]"> - Less </span>
              <span v-else>
                + More ({{
                  Object.keys(sortedFieldValues[filter.name]).length -
                  Object.keys(displayedFieldValues[filter.name]).length
                }})
              </span>
            </button>
          </div>
          <input
            v-else-if="filter.type === 'number'"
            type="number"
            :id="filter.name"
            v-model="filterValues[filter.name]"
            @change="fetchData(filter.name)"
          />
          <input
            v-else-if="filter.type === 'text'"
            type="text"
            :id="filter.name"
            v-model="filterValues[filter.name]"
            @change="fetchData(filter.name)"
          />
        </div>
        <button
          class="show-hidden-filters"
          v-if="!showHiddenFilters"
          @click="showHiddenFilters = !showHiddenFilters"
        >
          Show All Filters
        </button>
      </div>
      <FilterModal
        :show="showHiddenFilters"
        :filters="filters"
        :filterValues="filterValues"
        :fieldValues="fieldValues"
        @update:show="showHiddenFilters = $event"
        @update:filterValues="filterValues = $event"
        @fetch-data="fetchData"
      />
      <table>
        <div class="spinner-container" v-if="loading">
          <SpinnerWheel :visible="loading" />
        </div>
        <thead>
          <tr>
            <th v-for="field in fields" :key="field.key">{{ field.label }}</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="item in items" :key="item.id">
            <td v-for="field in fields" :key="field.key" class="limited-text">
              <!-- Check if the current field value is an array -->
              <span v-if="Array.isArray(item[field.key])">
                <!-- If it is, use the displayArray method to display the array -->
                {{ displayArray(item[field.key]) }}
              </span>
              <span v-else>
                <!-- If it's not an array, display the value as is -->
                {{ item[field.key] }}
              </span>
            </td>
            <td><button class="select-button" @click="selectPart(item)">Add</button></td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import { usePartsStore } from '@/stores/parts'
import router from '@/router'
import SpinnerWheel from '@/components/SpinnerWheel.vue'
import FilterModal from '@/components/FilterModal.vue'
import { getCompatibilityFilters } from '@/stores/compatibility'

interface Field {
  key: string
  label: string
}

interface Filter {
  name: string
  label: string
  type: string
  visible: boolean
}

interface Part {
  [key: string]: string | number | boolean | Part[] | null
}

interface Data {
  loading: boolean
  items: any[] | null
  filterValues: Record<string, any[] | null>
  fieldValues: { [key: string]: any[] }
  showHiddenFilters: boolean
  lastChangedFilter: string | null
  recievedFilterParams: string | null
  extendedFilters: Record<string, boolean>
  filtersToShow: number
}

export default defineComponent({
  components: {
    SpinnerWheel,
    FilterModal
  },
  props: {
    partName: {
      type: String,
      required: true
    },
    partType: {
      type: String,
      required: true
    },
    fields: {
      type: Array as () => Field[],
      required: true
    },
    filters: {
      type: Array as () => Filter[],
      required: true
    }
  },
  data(): Data {
    return {
      loading: false,
      items: null,
      fieldValues: this.initializeFieldValues(),
      filterValues: this.initializeFilterValues(),
      extendedFilters: this.initializeExtendedFilters(),
      showHiddenFilters: false,
      lastChangedFilter: null,
      recievedFilterParams: null as string | null,
      filtersToShow: 4
    }
  },
  async created() {
    await this.fetchFilterOptions()
    this.recievedFilterParams = await getCompatibilityFilters(this.partType)
  },
  mounted() {
    this.fetchData()
  },
  watch: {
    recievedFilterParams: {
      immediate: false,
      handler(newValue, oldValue) {
        if (newValue !== oldValue) {
          this.updateFilterValuesFromParams(newValue)
          this.fetchData()
        }
      }
    }
  },
  computed: {
    sortedFieldValues() {
      return this.sortFieldValues(this.fieldValues)
    },
    filtersVisible() {
      return this.filters.filter((filter) => filter.visible)
    },
    displayedFieldValues() {
      return this.getDisplayedFieldValues(this.sortedFieldValues)
    }
  },
  methods: {
    getDisplayedFieldValues(sortedFieldValues: Record<string, Record<string, number>>) {
      const displayed: Record<string, Record<string, number>> = {}
      for (const key in sortedFieldValues) {
        const values = sortedFieldValues[key]
        displayed[key] = this.extendedFilters[key]
          ? values
          : Object.fromEntries(Object.entries(values).slice(0, this.filtersToShow))
      }
      return displayed
    },
    sortFieldValues(fieldValues: { [key: string]: any[] }) {
      const sorted: Record<string, Record<string, number>> = {
        ...(fieldValues as unknown as Record<string, Record<string, number>>)
      }
      for (const key in sorted) {
        const values = sorted[key]
        sorted[key] = Object.entries(values)
          .sort(([, aCount], [, bCount]) => bCount - aCount)
          .reduce((obj: Record<string, number>, [value, count]) => {
            obj[value] = count
            return obj
          }, {})
      }
      return sorted
    },
    updateFilterValuesFromParams(paramsString: string) {
      const params = new URLSearchParams(paramsString)
      for (const [key, value] of params) {
        console.log(key, value)
        if (this.filters.find((filter) => filter.name === key)?.type === 'number') {
          this.filterValues[key] = [parseInt(value)]
          return
        }
        if (this.filters.find((filter) => filter.name === key)?.type === 'text') {
          this.filterValues[key] = [value]
          return
        }
        if (!(value in this.fieldValues[key])) {
          ;(this.fieldValues[key] as { [key: string]: any })[value] = 0
        }
        if (this.filterValues[key] && !this.filterValues[key]?.includes(value)) {
          this.filterValues[key]?.push(value)
        } else {
          this.recievedFilterParams =
            this.recievedFilterParams?.replace(key + '=' + value, '') ?? null
        }
      }
    },
    initializeFieldValues() {
      return this.fields.reduce((values: Record<string, any[]>, field) => {
        const correspondingFilter = this.filters.find(
          (filter) => filter.name === field.key && filter.type === 'enum'
        )
        if (correspondingFilter) {
          values[field.key] = []
        }
        return values
      }, {})
    },

    initializeFilterValues() {
      return this.filters.reduce((acc, filter) => ({ ...acc, [filter.name]: [] }), {})
    },

    initializeExtendedFilters() {
      return this.filters.reduce((acc, filter) => ({ ...acc, [filter.name]: false }), {})
    },
    displayArray(array: { name: string }[]) {
      return array.map((obj) => obj.name).join(', ')
    },
    selectPart(part: any): void {
      this.$emit('part-selected', part)
      const store = usePartsStore()
      store.setSelectedPart(this.partType, part)
      router.push('/configurator')
    },
    async fetchFilterOptions(): Promise<void> {
      try {
        const response = await fetch(process.env.API_URL + this.partType + '/Get')
        const json = await response.json()
        this.fieldValues = this.updateFieldValues(json)
      } catch (error) {
        console.error('Error fetching filters:', error)
        await new Promise((resolve) => setTimeout(resolve, 1000))
      }
    },
    updateFieldValues(json: any[]) {
      return this.fields.reduce((values: Record<string, any[]>, field) => {
        const correspondingFilter = this.filters.find(
          (filter) => filter.name === field.key && filter.type === 'enum'
        )
        if (correspondingFilter) {
          values[field.key] = this.countValues(json, field.key)
        }
        return values
      }, {})
    },
    countValues(json: any[], key: string) {
      return json.reduce((acc: Record<string, number>, item: Record<string, any>) => {
        const value = item[key]
        if (Array.isArray(value)) {
          value.forEach((v) => {
            const key = v.name
            acc[key] = (acc[key] || 0) + 1
          })
        } else {
          const key = typeof value === 'object' ? value.name : value
          acc[key] = (acc[key] || 0) + 1
        }
        return acc
      }, {})
    },
    async fetchData(changedFilter: string | null = null): Promise<void> {
      this.items = null
      this.loading = true
      const params = this.getFilterParams(changedFilter)
      while (this.loading) {
        try {
          const response = await fetch(
            process.env.API_URL + this.partType + '/Filter?' + params.toString()
          )
          const json = await response.json()
          this.items = json
          this.updateFieldValuesFromItems(json)

          this.loading = false
        } catch (error) {
          console.error('Error fetching data:', error)
          await new Promise((resolve) => setTimeout(resolve, 1000))
        }
      }
    },
    updateFieldValuesFromItems(items: Part[]) {
      for (const field of this.fields) {
        const newCounts = this.countValues(items, field.key)
        for (const value in this.fieldValues[field.key]) {
          if (newCounts[value]) {
            this.fieldValues[field.key][value] = newCounts[value]
          } else {
            this.fieldValues[field.key][value] = 0
          }
        }
      }
    },
    getFilterParams(changedFilter: string | null) {
      const params = new URLSearchParams()
      for (const filter of this.filters) {
        const values: string | string[] | null = this.filterValues[filter.name]
        if (values !== null) {
          if (Array.isArray(values)) {
            for (const value of values) {
              params.append(filter.name, value)
            }
          } else {
            params.append(filter.name, values)
          }
        }
      }
      if (this.recievedFilterParams) {
        const recievedParams = new URLSearchParams(this.recievedFilterParams)
        for (const [key, value] of recievedParams) {
          if (this.filterValues[key] && (this.filterValues[key]?.length ?? 0) > 0) {
            params.append(key, value)
          }
        }
      }
      this.lastChangedFilter = changedFilter
      return params
    }
  }
})
</script>

<style scoped>
.filters {
  position: absolute;
  left: 0.5rem;
  top: 4rem;
  width: 14rem;
  border: 0.15rem solid var(--color-border);
  padding: 0.5rem;
  background-color: var(--color-background-soft);
}

.filter {
  display: flex;
  flex-direction: column;
}

.filters input {
  width: 8rem;
  height: 1.25rem;
  text-align: center;
}

.filters input[type='checkbox'] {
  width: 0.9rem;
  height: 0.9rem;
  margin-right: 0.5rem;
}

.filters label {
  margin-bottom: 0.25rem;
}

.show-hidden-filters {
  width: 12rem;
  height: 1.5rem;
  align-self: center;
  text-align: center;
  font-size: 18px;
  outline: none;
  border-color: var(--color-border);
  background-color: var(--vt-c-white-mute);
  border-radius: 0.5rem;
  margin-top: 0.5rem;
}

.extend-filters {
  width: auto;
  height: auto;
  text-align: left;
  color: var(--color-text);
  outline: none;
  border: none;
  background-color: #ffffff00;
  border-radius: 5px;
  cursor: pointer;
}

.title {
  text-align: left;
  font-size: 32px;
  font-weight: bold;
}

.sub-title {
  text-align: left;
  margin-top: 0.5rem;
  margin-bottom: 0.1rem;
  font-size: 16px;
  font-weight: bold;
}

table {
  border-collapse: collapse;
  margin-top: 4rem;
  margin-bottom: 4rem;
  margin-left: 15rem;
  font-size: 12px;
}

.limited-text {
  white-space: normal;
  overflow-wrap: break-word;
  word-wrap: break-word;
}

th,
td {
  text-align: center;
  border: 0.15rem solid var(--color-border);
}

td:last-child {
  border: none;
  width: 0;
}

th {
  background-color: var(--color-background-soft);
  text-align: center;
  padding-top: 0;
  font-weight: bold;
}

.spinner-container {
  display: flex;
  justify-content: center;
  align-items: center;
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
}
</style>

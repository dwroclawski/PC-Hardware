<template>
  <div v-if="show" class="modal">
    <div class="modal-content">
      <span class="close" @click="closeModal">&times;</span>
      <div class="filter" v-for="filter in filters" :key="filter.name">
        <label class="sub-title">{{ filter.label }}:</label>
        <div v-if="filter.type === 'enum' && fieldValues[filter.name]" class="checkbox-wrapper">
          <div v-for="(count, value) in fieldValues[filter.name]" :key="value">
            <input
              type="checkbox"
              :id="value.toString()"
              :value="value"
              v-model="localFilterValues[filter.name]"
              @change="handleInputChange"
            />
            <label :for="value.toString">{{ value }} ({{ count }})</label>
          </div>
        </div>
        <input
          v-else-if="filter.type === 'number'"
          type="number"
          :id="filter.name"
          v-model="localFilterValues[filter.name]"
          @change="handleInputChange"
        />
        <input
          v-else-if="filter.type === 'text'"
          type="text"
          :id="filter.name"
          v-model="localFilterValues[filter.name]"
          @change="handleInputChange"
        />
        <!-- Add more input types as needed -->
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
interface Filter {
  name: string
  label: string
  type: string
  visible: boolean
}
export default defineComponent({
  props: {
    show: {
      type: Boolean,
      required: true
    },
    filters: {
      type: Array as () => Filter[],
      required: true
    },
    filterValues: {
      type: Object as () => Record<string, any[] | null>,
      required: true
    },
    fieldValues: {
      type: Object as () => Record<string, any[]>,
      required: true
    }
  },
  data() {
    return {
      localFilterValues: { ...this.filterValues }
    }
  },
  watch: {
    filterValues: {
      handler(newValue) {
        this.localFilterValues = { ...newValue }
      },
      immediate: true,
      deep: true
    }
  },
  methods: {
    handleInputChange() {
      this.$emit('update:filterValues', this.localFilterValues)
      this.fetchData()
    },
    closeModal() {
      this.$emit('update:show', false)
    },
    fetchData() {
      this.$emit('fetch-data')
    }
  }
})
</script>

<style scoped>
.modal {
  display: block;
  position: fixed;
  z-index: 10;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  overflow: auto;
  background-color: rgba(0, 0, 0, 0.75);
}

.modal-content {
  background-color: var(--color-background-mute);
  margin: 2.5% auto;
  padding: 20px;
  padding-top: 0px;
  border: 2px solid var(--color-border);
  width: 75%;
}

.filter {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 10px;
  justify-content: space-between;
  margin-bottom: 5px;
  width: 100%;
}

.close {
  color: #aaa;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: black;
  text-decoration: none;
  cursor: pointer;
}
</style>

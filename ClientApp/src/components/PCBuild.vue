<template>
  <div class="build">
    <h1>{{ title }}</h1>
    <ul>
      <li v-for="part in filteredParts" :key="part.path">
        <span class="part-name">{{ part.name }}</span
        ><span class="part-value">{{ build[part.path].name }}</span>
      </li>
    </ul>
    <button class="select-button" @click="selectBuild()">Select</button>
    <button v-if="isRemovable" class="remove-button" @click="removeBuild()">Remove</button>
    <div v-if="isExportable" class="dropdown">
      <button class="misc-button">Export</button>
      <div class="dropdown-content">
        <a href="#" @click.prevent="exportBuild('json')">Export to JSON</a>
        <a href="#" @click.prevent="exportBuild('csv')">Export to CSV</a>
        <a href="#" @click.prevent="exportBuild('xml')">Export to XML</a>
        <a href="#" @click.prevent="exportBuild('pdf')">Export to PDF</a>
        <a href="#" @click.prevent="exportBuild('txt')">Export to TXT</a>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
const parts = [
  { path: 'motherboard', name: 'Motherboard' },
  { path: 'cpu', name: 'CPU' },
  { path: 'cpucooler', name: 'CPU Cooling' },
  { path: 'gpu', name: 'GPU' },
  { path: 'ram', name: 'RAM' },
  { path: 'ssd', name: 'SSD' },
  { path: 'hdd', name: 'HDD' },
  { path: 'psu', name: 'PSU' },
  { path: 'case', name: 'Case' },
  { path: 'casecooler', name: 'Case Fans' }
]
import router from '@/router'
import { usePartsStore } from '@/stores/parts'
export default {
  props: {
    title: {
      type: String,
      default: 'title'
    },
    build: {
      type: Object,
      required: true
    },
    isRemovable: {
      type: Boolean,
      default: false
    },
    isExportable: {
      type: Boolean,
      default: false
    },
    id: {
      type: Number,
      default: -1
    }
  },
  data() {
    return {
      parts
    }
  },
  computed: {
    filteredParts() {
      return this.parts.filter((part) => this.build && this.build[part.path])
    }
  },
  methods: {
    selectBuild() {
      const store = usePartsStore()
      if (this.build) store.setSelectedParts(this.build)
      router.push('/configurator')
      window.scrollTo({ top: 0, behavior: 'smooth' })
    },
    removeBuild() {
      const store = usePartsStore()
      store.removeSavedBuild(this.id)
    },
    exportBuild(format: string) {
      const store = usePartsStore()
      store.exportBuild(this.id, format)
    }
  }
}
</script>

<style scoped>
.build {
  display: flex;
  flex-direction: column;
}
h1 {
  font-size: 24px;
  text-align: center;
  font-weight: bold;
}
ul {
  display: flex;
  flex-direction: column;
  list-style-type: none;
  padding: 0;
}
li {
  display: flex;
  justify-content: space-between;
  margin-bottom: 0.1rem;
  border: 0.15rem solid var(--color-border);
  border-radius: 0.5rem;
  padding: 0.25rem 0.5rem 0.25rem 0.5rem;
}

.select-button,
.remove-button,
.misc-button {
  margin: auto;
  width: 15rem;
  margin-top: 0.1rem;
  margin-bottom: 0.1rem;
}

.misc-button {
  cursor: context-menu;
}

.part-name {
  margin-right: 1rem;
}

.part-value {
  margin-left: 1rem;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}

.dropdown {
  margin: 0 auto 1rem auto;
}

.dropdown-content {
  display: none;
  position: absolute;
  min-width: 9rem;
  z-index: 1;
  background-color: var(--color-yellow);
}

.dropdown-content a {
  color: black;
  padding: 0.2rem 0.2rem;
  text-decoration: none;
  display: block;
}

.dropdown-content a:hover {
  background-color: var(--color-yellow-dark);
}

.dropdown:hover .dropdown-content {
  display: block;
}
</style>

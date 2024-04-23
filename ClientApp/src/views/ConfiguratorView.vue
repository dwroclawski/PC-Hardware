<script setup lang="ts">
import { computed, ref, onMounted } from 'vue'
import { usePartsStore } from '@/stores/parts'
import { useAuth0 } from '@auth0/auth0-vue'
import PCBuild from '@/components/PCBuild.vue'
const store = usePartsStore()

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

const { user } = useAuth0()
const totalPowerRequirement = computed(() => store.getTotalPowerRequirement)
const totalPrice = computed(() => store.getTotalPrice)
const psuWattage = computed(() => store.getPsuWattage ?? 0)
const selectedParts = computed(() => store.selectedParts)
const selectedPartsNames = computed(() => store.getSelectedPartsNames)
const removePart = (type: string) => {
  store.removeSelectedPart(type)
}
const buildName = ref('')
const saveBuild = async () => {
  if (buildName.value && user && user.value?.sub) {
    if (Object.keys(store.selectedParts).length === 0) {
      alert('No parts selected')
      return
    }
    if ((await store.fetchSavedBuildsCount(user.value.sub)) >= 10) {
      alert('You can only save up to 10 builds')
      return
    }
    if (buildName.value.length > 20) {
      alert('Build name too long')
      return
    }
    store.saveBuild(user.value?.sub ?? '', buildName.value)
  }
  buildName.value = ''
}

const pc3000 = ref({})
const pc6000 = ref({})
const pc10k = ref({})
onMounted(async () => {
  const module = await import('@/builds/pc_3000.json')
  pc3000.value = module.default
  const module2 = await import('@/builds/pc_6000.json')
  pc6000.value = module2.default
  const module3 = await import('@/builds/pc_10000.json')
  pc10k.value = module3.default

  console.log(JSON.stringify(store.getSelectedPartsNames))
})
</script>

<template>
  <div class="configurator">
    <h1 class="title">Choose your components:</h1>

    <div class="save-build" v-if="user">
      <input v-model="buildName" placeholder="Enter build name" />
      <button class="select-button" @click="saveBuild">Save</button>
    </div>

    <table class="content">
      <tr>
        <th>Component</th>
        <th>Selected</th>
        <th>
          <button
            class="clear-button"
            v-if="Object.keys(selectedParts).length > 0"
            @click="store.clearSelectedParts"
          >
            X
          </button>
        </th>
      </tr>

      <tr v-for="part in parts" :key="part.path">
        <td>
          <router-link :to="`/parts/${part.path}`">
            {{ part.name }}
          </router-link>
        </td>
        <td>
          {{ selectedPartsNames[part.path] || '' }}
        </td>
        <td>
          <button
            class="clear-button"
            v-if="selectedParts[part.path]"
            @click="removePart(part.path)"
          >
            X
          </button>
        </td>
      </tr>
    </table>

    <h3>
      Total Estimated Price:
      <span>{{ totalPrice.toFixed(2) }} PLN</span>
    </h3>

    <h3>
      Total Estimated Power Requirement:
      <span
        :class="{
          green: totalPowerRequirement <= psuWattage,
          red: totalPowerRequirement > psuWattage
        }"
      >
        {{ totalPowerRequirement.toFixed(0) }}
      </span>
      Watts
    </h3>
    <h3>
      Power Supply Wattage:
      <span
        :class="{
          green: totalPowerRequirement <= psuWattage,
          red: totalPowerRequirement > psuWattage
        }"
      >
        {{ psuWattage.toFixed(0) }}
      </span>
      Watts
    </h3>

    <h1 class="builds-title">Recommended Builds</h1>
    <div class="builds">
      <PCBuild :title="'3000 PLN'" :build="pc3000" />
      <PCBuild :title="'6000 PLN'" :build="pc6000" />
      <PCBuild :title="'10000 PLN'" :build="pc10k" />
    </div>
  </div>
</template>

<style scoped>
.configurator {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.content {
  text-align: left;
  table-layout: fixed;
  width: 80%;
  border-collapse: collapse;
}

.content th,
.content td {
  padding: 0.5rem 0.5rem;
  text-align: left;
  border: 0.15rem solid var(--color-background-mute);
}

.content th {
  font-weight: bold;
  background-color: var(--color-background-mute);
}

.content tr:nth-child(odd) {
  background-color: var(--color-background-soft);
}

.clear-button {
  background-color: #ffffff00;
  color: var(--color-red);
  border: none;
  cursor: pointer;
  padding: 0;
  font-weight: bold;
  transform: scaleX(1.25);
}

.clear-button:hover {
  color: var(--color-red-dark);
}

.title {
  padding-top: 4rem;
}

.content td:last-child,
.content th:last-child {
  border: none;
  width: 0%;
}

.content td:first-child,
.content th:first-child {
  width: 12.5%;
}

.builds {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  column-gap: 2rem;
}

.save-build {
  display: flex;
  justify-content: center;
  margin-top: 0.25rem;
  margin-bottom: 0.25rem;
  width: 50%;
}

.save-build input {
  margin-right: 0.5rem;
}
</style>

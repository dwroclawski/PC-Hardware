<template>
  <PartView partName="SSD" partType="ssd" :fields="fields" :filters="filters" />
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import PartView from './PartView.vue'
import { fields } from '@/stores/fields'
import { filters } from '@/stores/filters'

export default defineComponent({
  components: {
    PartView
  },
  data() {
    return {
      fields: [...fields.base, ...fields.ssd, ...fields.dimensions],
      filters: [...filters.ssd]
    }
  }
})
</script>

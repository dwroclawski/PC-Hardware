<template>
  <PartView partName="PSU" partType="psu" :fields="fields" :filters="filters" />
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
      fields: [...fields.base, ...fields.psu, ...fields.dimensions],
      filters: [...filters.psu]
    }
  }
})
</script>

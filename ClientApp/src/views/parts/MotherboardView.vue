<template>
  <PartView partName="Motherboard" partType="motherboard" :fields="fields" :filters="filters" />
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
      fields: [...fields.base, ...fields.motherboard],
      filters: [...filters.motherboard]
    }
  }
})
</script>

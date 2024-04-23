<template>
  <div class="button">
    <button @click="getRandomNumber()">Get a random number</button>
  </div>
  <div class="number">
    {{ num }}
  </div>
</template>

<script lang="ts">
/// <reference types="node" />
import { ref } from 'vue'
export default {
  setup() {
    const num = ref(0)

    async function getRandomNumber() {
      const response = await fetch(process.env.API_URL + 'randomnumber')
      num.value = await response.json()
    }

    return {
      num,
      getRandomNumber: getRandomNumber
    }
  },
  mounted() {
    this.getRandomNumber()
  }
}
</script>

<style>
.button,
.number {
  display: flex;
  align-items: center;
}
.number {
  margin-left: 1rem;
}
</style>

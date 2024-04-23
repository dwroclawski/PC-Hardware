<script setup lang="ts">
const parts = [
  { path: 'case', name: 'Case' },
  { path: 'coolingsystem', name: 'Cooling' },
  { path: 'cpu', name: 'CPU' },
  { path: 'gpu', name: 'GPU' },
  { path: 'hdd', name: 'HDD' },
  { path: 'motherboard', name: 'Motherboard' },
  { path: 'psu', name: 'PSU' },
  { path: 'ram', name: 'RAM' },
  { path: 'ssd', name: 'SSD' }
]
</script>

<template>
  <div class="title">
    <h1>PC Parts</h1>
  </div>
  <div class="body">
    <router-link v-for="part in parts" :key="part.path" :to="`/parts/${part.path}`">{{
      part.name
    }}</router-link>
  </div>
</template>

<style scoped>
.title,
.body {
  display: flex;
  align-items: center;
  flex-direction: column;
}
.title {
  padding-top: 60px;
  min-height: 10vh;
}
</style>

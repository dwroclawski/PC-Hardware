<script setup lang="ts">
import UsernameLabel from './UsernameLabel.vue'

defineProps<{
  msg: string
}>()
</script>

<template>
  <div class="greetings">
    <h1 class="green">{{ msg }}</h1>
    <UsernameLabel />
    <h3>
      This is a PC Hardware configurator. You can choose your components and we will tell you if
      they are compatible.
    </h3>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 500;
  font-size: 2.6rem;
  position: relative;
  top: -10px;
}

h3 {
  font-size: 1.2rem;
}

.greetings h1,
.greetings h3 {
  text-align: center;
}

.greetings h1,
.greetings h3 {
  text-align: left;
}
</style>

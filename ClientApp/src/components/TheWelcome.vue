<script setup lang="ts">
import WelcomeItem from './WelcomeItem.vue'
import SupportIcon from './icons/IconSupport.vue'
import RandomNumber from './RandomNumber.vue'
import IconTooling from './icons/IconTooling.vue'
</script>

<template>
  <WelcomeItem>
    <template #icon>
      <IconTooling />
    </template>
    <template #heading>Welcome to the PC Hardware Configurator</template>

    This is a PC Hardware configurator. You can choose your components and we will tell you if they
    are compatible.
  </WelcomeItem>

  <WelcomeItem>
    <template #icon>
      <SupportIcon />
    </template>
    <template #heading>Backend test</template>

    <div class="button">
      <RandomNumber />
    </div>
  </WelcomeItem>
</template>

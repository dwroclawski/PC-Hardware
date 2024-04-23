<script setup lang="ts">
import { useAuth0 } from '@auth0/auth0-vue'

const isAuthenticated = useAuth0().isAuthenticated
const user = useAuth0().user
</script>

<template>
  <div v-if="isAuthenticated && user" class="user-info">
    <div class="username-container">
      <p>{{ user.name }}</p>
    </div>
  </div>
</template>

<style scoped>
.user-info {
  display: flex;
  align-items: center;
}

.username-container {
  display: inline-block;
}
</style>

<script setup lang="ts">
import { useAuth0 } from '@auth0/auth0-vue'

const isAuthenticated = useAuth0().isAuthenticated
const user = useAuth0().user
</script>

<template>
  <div v-if="isAuthenticated && user" class="profile-picture-container">
    <img class="profile-picture" :src="user.picture" alt="Profile Picture" />
  </div>
</template>

<style scoped>
.profile-picture {
  border-radius: 50%;
  width: 35px;
  height: 35px;
}
</style>

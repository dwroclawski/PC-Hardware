<template>
  <div>
    <span v-if="isAuthenticated" @click="logout">Log out</span>
  </div>
</template>

<script lang="ts">
import { useAuth0 } from '@auth0/auth0-vue'

export default {
  setup() {
    const { isAuthenticated, logout } = useAuth0()

    return {
      isAuthenticated,
      logout: () => {
        logout({ logoutParams: { returnTo: window.location.origin } })
      }
    }
  }
}
</script>

<style scoped>
span {
  cursor: pointer;
}
</style>

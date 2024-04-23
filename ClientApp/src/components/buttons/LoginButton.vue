<template>
  <div>
    <span v-if="!isAuthenticated" @click="login">Log in</span>
  </div>
</template>

<script lang="ts">
import { useAuth0 } from '@auth0/auth0-vue'

export default {
  setup() {
    const { loginWithRedirect, isAuthenticated } = useAuth0()

    return {
      login: () => {
        if (!isAuthenticated.value) {
          loginWithRedirect()
        }
      },
      isAuthenticated
    }
  }
}
</script>

<style scoped>
span {
  cursor: pointer;
}
</style>

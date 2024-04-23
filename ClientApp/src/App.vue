<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { useAuth0 } from '@auth0/auth0-vue'
import LoginButton from './components/buttons/LoginButton.vue'
import SpinnerWheel from './components/SpinnerWheel.vue'
import ProfilePicture from '@/components/ProfilePicture.vue'
const { isAuthenticated, isLoading } = useAuth0()
</script>

<template>
  <header>
    <div class="wrapper">
      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/configurator">PC Configurator</RouterLink>
        <!--<RouterLink to="/parts">PC Parts</RouterLink>-->
        <RouterLink to="/certifications">Certifications</RouterLink>
        <RouterLink to="/faq">FAQ</RouterLink>
        <RouterLink to="/contact">Contact</RouterLink>
        <div class="auth-container">
          <a>
            <LoginButton v-if="!isAuthenticated && !isLoading" />
          </a>
          <RouterLink to="/profile">
            <ProfilePicture v-if="isAuthenticated" class="profile-picture" />
            <SpinnerWheel :visible="isLoading" v-else />
          </RouterLink>
        </div>
      </nav>
    </div>
  </header>

  <RouterView />
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100rem;
}

nav {
  position: fixed;
  top: 0%;
  left: 0%;
  right: 0%;
  width: 100%;
  height: 3.5rem;
  text-align: center;
  background-color: var(--color-background-mute);
  border-bottom: 2px solid var(--color-border);
  display: flex;
  justify-content: flex-start;
  align-items: center;
  text-align: left;
  font-size: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  z-index: 5;
}

.auth-container {
  margin-left: auto;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-child {
  border-left: none;
}

nav a:last-child:hover {
  background-color: unset;
}

.spinner {
  border: 10px solid #f3f3f3;
  border-top: 10px solid #34dbb7;
  width: 35px;
  height: 35px;
  position: relative;
  left: 0%;
}
</style>

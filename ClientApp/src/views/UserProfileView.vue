<template>
  <div v-if="user" class="user-profile">
    <div v-if="isAuthenticated">
      <img :src="user.picture" alt="User Picture" />
      <p>Name: {{ user.name }}</p>
      <p>Email: {{ user.email }}</p>
      <p>Id: {{ user.sub }}</p>
      <LogoutButton class="remove-button" />
    </div>
    <h1 class="builds-title">Saved Builds</h1>
    <div class="spinner-container">
      <SpinnerWheel :visible="isLoadingBuilds" />
    </div>
    <div class="builds">
      <PCBuild
        v-for="build in savedBuilds"
        :key="Number(build.id)"
        :title="build.name"
        :build="build"
        isRemovable
        isExportable
        :id="Number(build.id)"
      />
    </div>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted, computed } from 'vue'
import { useAuth0 } from '@auth0/auth0-vue'
import SpinnerWheel from '@/components/SpinnerWheel.vue'
import LogoutButton from '@/components/buttons/LogoutButton.vue'
import PCBuild from '@/components/PCBuild.vue'
import { usePartsStore } from '@/stores/parts'

const { user, isAuthenticated } = useAuth0()
const store = usePartsStore()

const savedBuilds = computed(() => store.savedBuilds)
const isLoadingBuilds = ref(false)

onMounted(async () => {
  if (user.value && user.value.sub) {
    isLoadingBuilds.value = true
    await store.fetchSavedBuilds(user.value.sub)
    isLoadingBuilds.value = false
  }
})
</script>

<style scoped>
.user-profile {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin-top: 5rem;
  margin-bottom: 5rem;
}

.user-profile img {
  width: 100px;
  height: 100px;
  margin-bottom: 1rem;
  display: block;
  margin-left: auto;
  margin-right: auto;
}

h1 {
  font-size: 2rem;
  margin-bottom: 1rem;
}

p {
  margin-top: 0.5rem;
}

.spinner-container {
  display: flex;
  justify-content: center;
}

.remove-button {
  padding: 0;
  margin: auto;
  width: 5rem;
  margin-top: 0.5rem;
  margin-bottom: 0.1rem;
  text-align: center;
  color: black;
}

.builds {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  column-gap: 2rem;
}
</style>

import { createRouter, createWebHistory } from 'vue-router'
import { authGuard } from '@auth0/auth0-vue'

const parts = [
  'Case',
  'CaseCooler',
  'CPU',
  'CPUCooler',
  'GPU',
  'HDD',
  'Motherboard',
  'PSU',
  'RAM',
  'SSD'
]

const routes = [
  {
    path: '/',
    component: () => import('@/views/HomeView.vue')
  },
  {
    path: '/certifications',
    component: () => import('@/views/CertificationsView.vue')
  },
  {
    path: '/configurator',
    component: () => import('@/views/ConfiguratorView.vue')
  },
  {
    path: '/parts',
    component: () => import('@/views/PartsView.vue')
  },
  ...parts.map((part) => ({
    path: `/parts/${part}`,
    component: () => import(`@/views/parts/${part}View.vue`)
  })),
  {
    path: '/profile',
    component: () => import('@/views/UserProfileView.vue'),
    beforeEnter: authGuard
  },
  {
    path: '/faq',
    component: () => import('@/views/FAQView.vue')
  },
  {
    path: '/contact',
    component: () => import('@/views/ContactView.vue')
  }
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

export default router

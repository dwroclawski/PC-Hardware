import './assets/main.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'
import { createAuth0 } from '@auth0/auth0-vue'

import App from './App.vue'
import router from './router'

const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(
  createAuth0({
    domain: 'pc-hardware.eu.auth0.com',
    clientId: '2pbKHKdfO88KeNiOMFTxQoFIjyQacBAn',
    authorizationParams: {
      redirect_uri: window.location.origin
    }
  })
)

app.mount('#app')

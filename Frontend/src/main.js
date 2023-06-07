import { createApp } from 'vue';
import App from './App.vue';
import router from './router';

// import Vueaxios from 'vue-axios'

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap/dist/js/bootstrap.bundle'

const app =createApp(App)
app.config.globalProperties.hostname = "https://localhost:7172"
app.use(router)
app.mount('#app')

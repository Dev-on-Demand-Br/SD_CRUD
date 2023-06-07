import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

//Lazy loaded routes
const Dashboard = () => import("../components/Dashboard.vue")
const NotFound = () => import("../components/404.vue")


const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/404',
    name: '404',
    component: NotFound
  },
  {
    path: '/Dashboard',
    name: 'Dashboard',
    component: Dashboard,
  },
  // {
  //   path: '/about',
  //   name: 'about',
  //   // route level code-splitting
  //   // this generates a separate chunk (about.[hash].js) for this route
  //   // which is lazy-loaded when the route is visited.
  //   component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  // },
  {
    path: '/CadastroProduto',
    name: 'CadastroProduto',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/CadastroProduto.vue')
  },
  {
    path: '/CadastroCategoria',
    name: 'CadastroCategoria',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/CadastroCategoria.vue')
  },
  {
    path: '/Produtos',
    name: 'Produtos',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/Produto.vue')
  },
  {
    path: '/Login',
    name: 'Login',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../components/Login.vue')
  },
  {
    path: '/Register',
    name: 'Register',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../components/Register.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});
// router.beforeEach((to, from, next) =>{
//   const publicPages = ['/login', '/register'];
//   const authRequired = !publicPages.includes(to.path);
//   const loggedId = localStorage.getItem('token');

//   if (authRequired && !loggedIn) {
//     next('/login');
//     } else {
//       next();
//     }
//     if (authRequired){
//       next('/login');
//     } else {
//       next();
//     }
//     if (authRequired){
//       next('/login');
//     } else{
//       next();
//     }
//   });


export default router;

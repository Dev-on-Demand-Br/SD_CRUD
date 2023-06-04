<template>  

    <Navbar/>

  <router-view/>

</template>

<script>
import Navbar from "./components/Navbar.vue"

export default {
  components: {
    Navbar
  }
}
</script>
<style>
*{
  /* background: #EAEAEA; */
  font-family: 'Poppins', sans-serif;
  font-size: small;
}

</style>

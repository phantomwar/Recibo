<template>
  <div id="app">
    <Recibo/>
   
  </div>
</template>

<script>
//import HelloWorld from './components/HelloWorld.vue'
import Recibo from './components/Recibo/Recibo'

export default {
  name: 'App',
  components: {
    //HelloWorld,
    Recibo
  }
}
</script>

<style>
#app {
   margin-left: 30%;
   margin-right: 30%;
}
</style>

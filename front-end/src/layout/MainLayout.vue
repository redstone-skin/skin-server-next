<template>
  <div>
    <NavBar class="fixed top-0 right-0 left-0"></NavBar>
    <router-view />
  </div>
</template>
<script lang="ts" setup>
import NavBar from "../components/NavBar.vue";
</script>

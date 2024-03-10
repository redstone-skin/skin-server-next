<script setup lang="ts">
const route = useRoute();
useHead({
  title: "红石 MC 首页",
});
</script>

<template>
  <div class="pt-16">
    <h1>Nuxt Routing set up successfully!</h1>
    <p>Current route: {{ route.path }}</p>
    <a
      href="https://nuxt.com/docs/getting-started/routing"
      target="_blank"
    >Learn more about Nuxt Routing</a>
  </div>
</template>

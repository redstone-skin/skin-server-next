<template>
  <div class="about">
    <h1 class="text-3xl font-bold underline">Hello world!</h1>
    <RButton>testttest</RButton>
  </div>
</template>

<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
<script setup lang="ts">
import RButton from "@/components/controls/RButton.vue";
</script>

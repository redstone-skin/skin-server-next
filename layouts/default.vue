<script lang="ts" setup>
const { background } = useLauncherStore();
</script>

<template>
  <div
    class="relative h-screen bg-cover bg-center transition-[background-image] duration-1000"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <div
      class="absolute inset-0 z-10 bg-page-light/40 backdrop-blur-2xl backdrop-brightness-100 backdrop-saturate-200 dark:bg-page-dark/40"
    ></div>
    <div class="absolute inset-0 z-20 flex h-screen flex-col">
      <RSAppBar />
      <div class="flex flex-1">
        <RSSideBar />
        <NuxtPage class="flex-1 rounded-lg" />
      </div>
    </div>
  </div>
</template>

<script lang="ts" setup>
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);
</script>

<template>
  <div
    class="relative h-screen bg-cover bg-center"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <div
      class="absolute inset-0 z-10 bg-page-light/40 backdrop-blur-2xl dark:bg-page-dark/40"
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

<script lang="ts" setup>
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);
</script>

<template>
  <div
    class="relative bg-cover bg-center"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <div
      class="flex h-screen flex-col bg-bar-light dark:bg-bar-dark bg-opacity-50 dark:bg-opacity-50 backdrop-blur-2xl transition-colors duration-100"
    >
      <RSAppBar />
      <div class="flex flex-1">
        <RSSideBar />
        <NuxtPage class="flex-1 rounded-lg" />
      </div>
    </div>
  </div>
</template>

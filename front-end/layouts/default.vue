<script lang="ts" setup>
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);
</script>

<template>
  <div
    class="bg-cover bg-center h-screen"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <div
      class="flex h-screen z-20 flex-col bg-bar-light dark:bg-bar-dark bg-opacity-50 dark:bg-opacity-50 transition-colors duration-200 ease-in-out"
    >
      <RSAppBar />
      <div class="flex flex-1">
        <RSSideBar />
        <NuxtPage class="flex-1 rounded-lg" />
      </div>
    </div>
  </div>
</template>

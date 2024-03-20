<script setup lang="ts">
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);

useHead({
  title: "红石 MC 首页",
});
</script>

<template>
  <div
    class="h-full w-full relative bg-cover bg-fixed bg-center origin-center"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  ></div>
</template>

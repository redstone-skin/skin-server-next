<script setup lang="ts">
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);

useHead({
  title: "红石 MC 首页",
});
</script>

<template>
  <div
    class="transition-all duration-300 ease-in-out h-full w-full relative bg-cover bg-fixed bg-center"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <!--Launcher-->
    <div class="absolute bottom-4 left-1/2">
      111
    </div>
  </div>
</template>

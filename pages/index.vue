<script setup lang="ts">
import defaultLauncherBackground from "@/assets/images/launcher-background.jpg";

const background = ref(defaultLauncherBackground);

useHead({
  title: "红石 MC 首页",
});
</script>

<template>
  <div
    class="relative size-full bg-cover bg-fixed bg-center"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <!-- Profile Select -->
    <div class="absolute right-6 top-6 size-0">
      <div class="absolute -translate-x-full">
        <div
          class="cursor-pointer rounded-xl border-2 border-solid border-transparent bg-white/40 px-3 py-1 backdrop-blur-2xl transition-all duration-300 hover:border-primary-500 hover:bg-gray-400 dark:bg-black/30 dark:hover:bg-grey-800/70"
        >
          <div class="flex h-16 w-60 items-center gap-4">
            <div class="size-12 rounded-md bg-white/60 dark:bg-white/50"></div>
            <div class="flex flex-col justify-start">
              <div class="text-lg">未选择角色</div>
              <div class="text-sm text-gray-800 dark:text-gray-300">
                点击选择角色
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!--Dyn Island-->
    <div class="absolute bottom-12 left-1/2 size-0">
      <div
        class="absolute h-16 w-72 -translate-x-1/2 -translate-y-full rounded-[3rem] border-2 border-solid border-grey-400 bg-grey-900 text-white"
      >
        <div
          class="flex size-full cursor-pointer items-stretch justify-center overflow-hidden"
        >
          <div
            v-tooltip.left="'启动设置'"
            class="flex h-full flex-1 items-center justify-center rounded-l-[3rem] bg-transparent p-4 transition-colors duration-200 hover:bg-grey-700"
          >
            <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
            <i class="pi pi-cog text-white"></i>
          </div>
          <div
            class="flex h-full w-40 flex-col items-center justify-center bg-transparent text-center transition-colors duration-200 hover:bg-grey-700"
          >
            <div class="text-xl font-bold">启动游戏</div>
            <div class="text-sm text-gray-400">1.20.4</div>
          </div>
          <div
            v-tooltip="'游戏列表'"
            class="flex h-full flex-1 items-center justify-center rounded-r-[3rem] bg-transparent p-4 transition-colors duration-200 hover:bg-grey-700"
          >
            <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
            <i class="pi pi-th-large text-white"></i>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup lang="ts">
const { background } = useLauncherStore();

useHead({
  title: "红石 MC 首页",
});
</script>

<template>
  <div
    class="relative size-full bg-cover bg-fixed bg-center transition-[background-image] duration-1000"
    :style="{
      backgroundImage: `url(${background})`,
    }"
  >
    <!--Launcher Island-->
    <div class="absolute bottom-12 left-1/2 size-0">
      <div
        class="absolute flex -translate-x-1/2 -translate-y-full flex-col items-center gap-6"
      >
        <div
          class="cursor-pointer rounded-xl bg-grey-900/45 p-3 text-white backdrop-blur-lg backdrop-saturate-200 transition-all duration-100 hover:bg-grey-700/65 hover:backdrop-blur-2xl"
        >
          <div class="flex w-60 items-center gap-4">
            <div
              class="size-10 rounded-md bg-contain bg-center"
              :style="{
                'background-image':
                  'url(https://mcskin.com.cn/avatar/1?size=36)',
              }"
            ></div>
            <div class="flex flex-1 flex-col justify-start">
              <div class="font-bold">中文名称</div>
              <div class="text-xs text-gray-300">红石 MC</div>
            </div>
            <div
              v-tooltip="$t('launcher.profile.refresh')"
              class="flex size-8 items-center justify-center rounded-md hover:bg-white/30"
            >
              <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
              <i class="pi pi-refresh"></i>
            </div>
          </div>
        </div>

        <div
          class="h-16 w-72 rounded-[3rem] bg-grey-900/45 text-white backdrop-blur-lg backdrop-saturate-200"
        >
          <div
            class="flex size-full cursor-pointer items-stretch justify-center overflow-hidden"
          >
            <div
              v-tooltip.left="'启动设置'"
              class="flex h-full flex-1 items-center justify-center rounded-l-[3rem] bg-transparent p-4 transition-colors duration-200 hover:bg-grey-700/70"
            >
              <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
              <i class="pi pi-cog text-white"></i>
            </div>
            <div
              class="flex h-full w-40 flex-col items-center justify-center bg-transparent text-center transition-colors duration-200 hover:bg-grey-700/70"
            >
              <div class="text-xl font-bold">启动游戏</div>
              <div class="text-sm text-gray-300">1.20.4</div>
            </div>
            <div
              v-tooltip="'游戏列表'"
              class="flex h-full flex-1 items-center justify-center rounded-r-[3rem] bg-transparent p-4 transition-colors duration-200 hover:bg-grey-700/70"
            >
              <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
              <i class="pi pi-th-large text-white"></i>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

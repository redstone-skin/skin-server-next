<template>
  <div class="h-14">
    <div class="flex h-full items-center justify-between px-4">
      <div>
        <NuxtLink to="/" class="text-xl font-bold text-black dark:text-white">
          {{ $t("navbar.title") }}
        </NuxtLink>
      </div>
      <div class="flex-1"></div>
      <div class="flex gap-2">
        <ClientOnly>
          <div
            class="flex cursor-pointer items-center justify-center rounded-lg p-3 hover:bg-black/10 dark:hover:bg-white/20"
            @click="toggleTheme"
          >
            <!-- eslint-disable-next-line tailwindcss/no-custom-classname-->
            <i class="pi pi-moon text-sm"></i>
          </div>
        </ClientOnly>
      </div>
    </div>
  </div>
</template>

<script lang="ts" setup>
const colorMode = useColorMode();

const theme = computed(() => colorMode.value);

const toggleTheme = () => {
  if (theme.value === "light") {
    colorMode.preference = "dark";
  } else {
    colorMode.preference = "light";
  }
};
</script>

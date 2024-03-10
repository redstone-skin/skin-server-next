<template>
  <div
    class="h-16 fixed left-0 right-0 drop-shadow-lg bg-gray-300 bg-opacity-35 dark:bg-gray-900 dark:bg-opacity-35 backdrop-blur"
  >
    <div class="flex justify-between items-center h-full px-4">
      <div>
        <NuxtLink
          to="/"
          class="font-bold text-2xl text-primary-500 dark:text-primary-500"
        >
          {{ $t("navbar.title") }}
        </NuxtLink>
      </div>
      <div class="ml-8 font-bold">
        <NuxtLink
          to="/"
          class="text-xl"
        >
          {{ $t("navbar.skins") }}
        </NuxtLink>
        <NuxtLink
          to="/about"
          class="ml-4 text-xl"
        >
          {{ $t("navbar.servers") }}
        </NuxtLink>
      </div>

      <div class="flex-1"></div>
      <div class="flex gap-2">
        <Button
          :icon="'pi' + (theme === 'light' ? ' pi-moon' : ' pi-sun')"
          severity="secondary"
          text
          rounded
          @click="toggleTheme"
        />
      </div>
    </div>
  </div>
</template>

<script lang="ts" setup>
const colorMode = useColorMode();

const theme = computed(() => colorMode.value);

const toggleTheme = () => {
  if (theme.value === "light") {
    colorMode.value = "dark";
  } else {
    colorMode.value = "light";
  }
};
</script>

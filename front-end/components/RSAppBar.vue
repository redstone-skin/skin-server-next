<template>
  <div class="h-14">
    <div class="flex justify-between items-center h-full px-4">
      <div>
        <NuxtLink
          to="/"
          class="font-bold text-xl text-black dark:text-white"
        >
          {{ $t("navbar.title") }}
        </NuxtLink>
      </div>
      <div class="flex-1"></div>
      <div class="flex gap-2">
        <ClientOnly>
          <Button
            :icon="'pi' + (theme === 'light' ? ' pi-moon' : ' pi-sun')"
            severity="secondary"
            text
            rounded
            size="small"
            @click="toggleTheme"
          />
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

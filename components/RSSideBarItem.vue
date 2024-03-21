<script lang="ts" setup>
const props = defineProps<{
  icon: string;
  label: string;
  to?: string;
  active?: boolean;
}>();
</script>

<template>
  <NuxtLink
    v-tooltip="props.label"
    :to="props.to"
    class="block cursor-pointer overflow-hidden rounded-lg"
    active-class="bg-primary-500 dark:bg-primary-500 shadow-md text-white"
    :class="{
      'bg-primary-500 text-white shadow-md': props.active,
    }"
  >
    <div
      class="flex size-12 items-center justify-center transition-colors duration-200 hover:bg-primary-500/80 hover:text-white dark:hover:bg-primary-500/80"
    >
      <i :class="props.icon"></i>
    </div>
  </NuxtLink>
</template>

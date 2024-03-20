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
    class="rounded-lg overflow-hidden block cursor-pointer"
    active-class="bg-primary-500 bg-opacity-60 dark:bg-opacity-60 shadow-md text-white"
    :class="{
      'bg-primary-500 bg-opacity-60 dark:bg-opacity-60 shadow-md text-white':
        props.active,
    }"
  >
    <div
      class="w-12 h-12 hover:bg-primary-500 bg-opacity-60 dark:hover:bg-primary-500 dark:bg-opacity-60 hover:text-white flex justify-center items-center transition-colors duration-200"
    >
      <i :class="props.icon"></i>
    </div>
  </NuxtLink>
</template>

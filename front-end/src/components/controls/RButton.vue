<template>
  <div class="r-button" @click="emit('click')">
    <slot></slot>
    {{ props.icon }}
  </div>
</template>
<script setup lang="ts">

export interface RButtonProps {
  icon?: string;
  outline?: boolean;
  round?: boolean;
  color?: string;
}


const props = withDefaults(defineProps<RButtonProps>(), {
  icon: () => "",
  outline: () => false,
  round: () => false,
  string: () => ""
});

const emit = defineEmits(["click"]);

</script>
<style scoped>
.r-button {
  padding: 4px 8px;
  border-radius: 4px;
}
</style>

<template>
  <q-avatar>
    <img v-if="src" :src="src" />
    <q-icon v-else name="account"></q-icon>
    <q-badge v-if="type === 'official'" floating color="primary">V</q-badge>
    <q-badge v-if="type === 'team'" floating color="blue">V</q-badge>
  </q-avatar>
</template>
<script lang="ts" setup>
interface UserAvatarProps {
  src?: string;
  type: 'normal' | 'official' | 'team';
}

const props = defineProps<UserAvatarProps>();
</script>

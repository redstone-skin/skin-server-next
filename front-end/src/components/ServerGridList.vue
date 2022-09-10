<template>
  <div class="row">
    <template v-if="loading">
      <div
        class="col-lg-2 col-md-3 col-sm-4 col-xs-6 q-pa-sm"
        v-for="i in 12"
        :key="'loading-' + i"
      >
        <q-card>
          <q-skeleton height="200px" square />
        </q-card>
      </div>
    </template>
    <template v-else>
      <div
        class="col-lg-2 col-md-3 col-sm-4 col-xs-6 q-pa-sm"
        v-for="i in 12"
        :key="'server-' + i"
      >
        <ServerCard></ServerCard>
      </div>
    </template>
  </div>
</template>
<script lang="ts" setup>
import ServerCard from './ServerCard.vue';

const props = defineProps({
  loading: {
    type: Boolean,
    required: false,
    default: () => false,
  },
});
</script>
<style lang="scss" scoped></style>

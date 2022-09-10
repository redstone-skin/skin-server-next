<template>
  <q-card bordered>
    <q-card-section>
      <div class="text-subtitle1">怎样更换皮肤?</div>
      <div class="text-body q-mt-sm">
        我们提供了两种常见的皮肤更换方法,即安装皮肤mod与外置登陆。
      </div>
    </q-card-section>
    <q-card-section>
      <q-btn
        class="full-width"
        :ripple="false"
        outline
        @click="onClickLearnMore"
        >了解更多</q-btn
      >
    </q-card-section>
  </q-card>
</template>
<script lang="ts" setup>
import { useQuasar } from 'quasar';
import GuideDialog from 'src/components/GuideDialog.vue';
const $q = useQuasar();

const onClickLearnMore = () => {
  $q.dialog({
    component: GuideDialog,
  });
};
</script>

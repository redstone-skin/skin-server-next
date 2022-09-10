<template>
  <div class="rs-skin-preview-card">
    <q-card
      bordered
      class="rs-skin-preview-card-img"
      @mouseover="onMouseOver"
      @mouseout="onMouseOut"
    >
      <q-img :ratio="9 / 9" src="https://mcskin.cn/preview/38460?height=150">
        <div class="rs-skin-info" :class="{ show: showInfo }">
          <div>红石皮肤站4周年</div>
          <div>红石皮肤站 9-9</div>
        </div>
        <!-- 收藏，使用，更多 -->
        <div class="rs-skin-tool" :class="{ show: showInfo }">
          <q-btn
            class="rs-skin-preview-card-btn"
            round
            dense
            flat
            icon="favorite_border"
          />
          <q-btn
            class="rs-skin-preview-card-btn"
            round
            dense
            flat
            icon="check"
          />
          <q-space></q-space>
          <q-btn
            class="rs-skin-preview-card-btn"
            round
            dense
            flat
            icon="more_vert"
          />
        </div>
      </q-img>
    </q-card>
  </div>
</template>
<script lang="ts" setup>
import { ref } from 'vue';

const showInfo = ref(false);

const onMouseOver = () => {
  showInfo.value = true;
};

const onMouseOut = () => {
  showInfo.value = false;
};
</script>
<style lang="scss" scoped>
.rs-skin-preview-card-img {
  cursor: pointer;
}

.rs-skin-tool {
  display: flex;
  padding: 0 8px;
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  opacity: 0;
  transition: opacity 0.3s;

  &.show {
    color: white;
    background: rgba(0, 0, 0, 0.47);
    opacity: 1;
  }
}

.rs-skin-info {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  opacity: 0;
  transition: opacity 0.3s;

  padding: 8px;

  &.show {
    opacity: 1;
  }
}
</style>

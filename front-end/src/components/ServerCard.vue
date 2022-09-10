<template>
  <div class="rs-server-card">
    <q-card
      bordered
      class="rs-skin-preview-card-img"
      @mouseover="onMouseOver"
      @mouseout="onMouseOut"
    >
      <q-img :ratio="9 / 9" src="https://mcskin.cn/preview/38460?height=150">
        <div class="rs-server-info" :class="{ show: showInfo }">
          <div>红石皮肤站官方服务器</div>
          <div>延迟: 24ms 人数: 24/50</div>
        </div>
        <!-- 收藏，使用，更多 -->
        <div class="rs-server-tool" :class="{ show: showInfo }">
          <q-btn
            class="rs-server-card-btn"
            round
            dense
            flat
            icon="favorite_border"
          />
          <q-btn class="rs-server-card-btn" round dense flat icon="check" />
          <q-space></q-space>
          <q-btn class="rs-server-card-btn" round dense flat icon="more_vert" />
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
.rs-server-card-img {
  cursor: pointer;
}

.rs-server-tool {
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

.rs-server-info {
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

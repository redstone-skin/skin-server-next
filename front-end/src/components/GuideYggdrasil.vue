<template>
  <div>
    <q-stepper v-model="step" vertical flat color="primary" animated>
      <q-step
        :name="1"
        title="向启动器添加验证服务器"
        icon="settings"
        :done="step > 1"
      >
        <div>
          皮肤站的 Yggdrasil API 认证服务器地址为
          <pre>https://mcskin.cn/api/yggdrasil</pre>
          <br />
          将下方按钮拖至启动器可快速添加 Yggdrasil 服务器
        </div>
        <q-stepper-navigation>
          <q-btn
            color="primary"
            label="将此按钮拖至启动器"
            draggable="true"
            :ripple="false"
            outline
            @dragstart="onDragStart"
            @dragend="onDragEnd"
          />
        </q-stepper-navigation>
      </q-step>
    </q-stepper>
    <!--全屏悬浮窗-->
    <div v-if="dragging" class="full-screen-tip">
      <div class="text">请将按钮拖动至你的启动器完成添加</div>
    </div>
  </div>
</template>
<script lang="ts" setup>
import { ref } from 'vue';

const step = ref(1);
const dragging = ref(false);

const onDragStart = (event: any) => {
  setTimeout(() => {
    dragging.value = true;
  }, 100);

  event.dataTransfer.setData(
    'text',
    `authlib-injector:yggdrasil-server:${encodeURIComponent(
      'https://mcskin.cn/api/yggdrasil'
    )}`
  );
};

const onDragEnd = () => {
  dragging.value = false;
};
</script>

<style lang="scss" scoped>
.full-screen-tip {
  position: fixed;
  top: 0;
  left: 0;
  z-index: 99999;
  width: 100vw;
  height: 100vh;

  pointer-events: none;

  background-color: rgba(77, 77, 77, 0.6);

  display: flex;
  justify-content: center;
  align-items: center;

  .text {
    font-size: 28px;
    color: white;
    padding: 32px;

    text-align: center;

    max-width: 80%;

    border-style: dashed;
    border-width: 10px;
    border-color: white;
    border-radius: 12px;
  }
}
</style>

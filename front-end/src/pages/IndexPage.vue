<template>
  <q-page>
    <!-- 首页大图 -->
    <div class="home-hero-warpper" :style="{ 'background-image': `url(${background})` }">
      <div class="home-hero">
        <div>
          <div class="text-h3">使用皮肤来装扮MC中的角色</div>
          <!--一段简介-->
          <div class="text-subtitle2 q-mt-lg">
            我们提供了数以万计的皮肤，你可以寻找你喜欢的皮肤，并通过皮肤Mod或使用红石账号登陆MC来使用皮肤。
          </div>
          <!--引导按钮-->
          <div class="q-mt-lg q-flex">
            <q-btn color="primary" label="开始使用" to="/skin" />
            <q-btn class="q-ml-sm" color="secondary" outline label="浏览皮肤" to="/skin" />
            <q-btn class="q-ml-sm" color="accent" label="用户中心" to="/skin" />
          </div>
        </div>
      </div>
    </div>
    <!--快速上手:提供常见使用方案教程-->
    <div class="container">
      <div class="q-mt-lg">
        <div class="text-h4 text-center">快速上手</div>
        <div>
          <q-tabs v-model="tab" dense align="left" class="text-grey" active-color="primary" indicator-color="primary"
            narrow-indicator>
            <q-tab name="mod" label="皮肤MOD" />
            <q-tab name="yggdrasil" label="外置登陆" />
          </q-tabs>
          <q-tab-panels v-model="tab" animated>
            <q-tab-panel name="mod">
              <GuideMod></GuideMod>
            </q-tab-panel>
            <q-tab-panel name="yggdrasil">
              <div class="text-h6">Alarms</div>
              Lorem ipsum dolor sit amet consectetur adipisicing elit.
            </q-tab-panel>
          </q-tab-panels>
        </div>
      </div>
    </div>
  </q-page>
</template>

<script setup lang="ts">
import { ref } from 'vue'
import GuideMod from '../components/GuideMod.vue'

import BackgroundDay from '../assets/images/home-bg-0.png'
import BackgroundWillNight from '../assets/images/home-bg-1.png'
import BackgroundNight from '../assets/images/home-bg-2.png'
import BackgroundWillDay from '../assets/images/home-bg-3.png'

const tab = ref('mod')

const background = ref('')


// 根据时间变化背景
const date = new Date()
const hour = date.getHours()
if (hour >= 6 && hour < 18) {
  background.value = BackgroundDay
} else if (hour >= 18 && hour < 19) {
  background.value = BackgroundWillNight
} else if (hour >= 19 || hour < 4) {
  background.value = BackgroundNight
} else {
  background.value = BackgroundWillDay
}



</script>
<style lang="scss" scoped>
.home-hero-warpper {
  height: 100vh;
  background-image: url(../assets/images/home-bg-3.png);
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;


  .home-hero {
    display: flex;

    justify-content: center;
    align-items: center;

    width: 100%;
    height: 100%;

    // 半透明背景
    background: rgba(0, 0, 0, 0.01);

    color: #fff;
    text-align: center;
  }

}

.quick-intro {
  display: flex;
  justify-content: center;

  min-height: 200px;

  margin-top: 16px;

  .desc {
    max-width: 256px;
  }
}
</style>

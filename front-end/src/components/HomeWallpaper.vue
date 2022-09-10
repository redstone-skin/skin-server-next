<template>
  <!--首页头图，根据时间变化-->
  <div class="wallpaper" :style="{ 'background-image': `url(${image})` }">
    <!-- 右上角时间 -->
    <div class="container content">红石皮肤站V10早期预览版</div>
  </div>
</template>
<script lang="ts" setup>
import { ref } from 'vue';

import Image0 from '../assets/images/home-bg-0.png';
import Image1 from '../assets/images/home-bg-1.png';
import Image2 from '../assets/images/home-bg-2.png';
import Image3 from '../assets/images/home-bg-3.png';

const imageList = [Image0, Image1, Image2, Image3];

const image = ref(imageList[0]);
// 根据时间变化背景

const date = new Date();
const hour = date.getHours();
if (hour >= 6 && hour < 18) {
  image.value = imageList[0];
} else if (hour >= 18 && hour < 19) {
  image.value = imageList[1];
} else if (hour >= 19 || hour < 4) {
  image.value = imageList[2];
} else {
  image.value = imageList[3];
}
</script>
<style lang="scss" scoped>
.wallpaper {
  height: 240px;
  background-image: url(../assets/images/home-bg-0.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;

  color: white;

  .content {
    padding: 8px;
  }
}
</style>

<template>
  <q-page>
    <!-- 首页横幅 -->
    <div class="home-hero-warpper" :style="{ 'background-image': `url(${background})` }">
      <div class="home-hero">
        <div class="title-splash-warpper">
          <div class="text-h4 title-shadow">红石皮肤站
          </div>
          <div class="title-splash">{{ splash }}</div>
          <!--一段简介-->
          <div class="text-subtitle2 q-mt-lg">
            为 Minecraft 玩家提供一站式游戏辅助服务。
          </div>
        </div>
      </div>
    </div>
    <!--动态内容区-->
    <div class="container q-mt-lg q-pt-lg">
      <!-- 分栏布局，左侧是分类 -->
      <div class="row">
        <div class="col-md-3 col-sm-4 gt-xs q-pa-lg">
          <q-card bordered>
            <q-list class="rounded-borders" separator>
              <q-item clickable>
                <q-item-section avatar>
                  <q-icon name="inbox" />
                </q-item-section>

                <q-item-section>全部</q-item-section>
              </q-item>

              <q-item clickable>
                <q-item-section avatar>
                  <q-icon name="texture" />
                </q-item-section>

                <q-item-section>材质</q-item-section>
              </q-item>

              <q-item clickable>
                <q-item-section avatar>
                  <q-icon name="dns" />
                </q-item-section>

                <q-item-section>服务器</q-item-section>
              </q-item>

              <q-item clickable>
                <q-item-section avatar>
                  <q-icon name="send" />
                </q-item-section>

                <q-item-section>动态</q-item-section>
              </q-item>
            </q-list>
          </q-card>
        </div>
        <div class="col q-pt-lg">
          <ActNormalCard></ActNormalCard>
        </div>
        <div class="col-3 q-pa-lg gt-sm">
          <LearnMoreCard></LearnMoreCard>
        </div>
      </div>
    </div>
  </q-page>
</template>



<script lang="ts">
import { preFetch } from 'quasar/wrappers'
import { useHomeStore } from '../stores/home-store'
import { slogan } from '../http-api/misc'


export default {
  preFetch: preFetch(async ({ store }) => {
    const homeStore = useHomeStore(store)
    const content = await slogan()
    homeStore.setSplash(content)
  })
}
</script>

<script lang="ts" setup>
import { ref } from 'vue'

import BackgroundDay from '../assets/images/home-bg-0.png'
import BackgroundWillNight from '../assets/images/home-bg-1.png'
import BackgroundNight from '../assets/images/home-bg-2.png'
import BackgroundWillDay from '../assets/images/home-bg-3.png'


import LearnMoreCard from '../components/cards/LearnMoreCard.vue'
import ActNormalCard from 'src/components/cards/ActNormalCard.vue'


const homeStore = useHomeStore()

const splash = ref(homeStore.splash)

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
  height: 256px;
  background-image: url(../assets/images/home-bg-3.png);
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;

  overflow: hidden;

  .home-hero {
    display: flex;

    justify-content: center;
    align-items: center;
    width: 100%;
    height: 100%;


    // 半透明背景
    background: rgba(0, 0, 0, 0.1);

    color: #fff;
    text-align: center;

    user-select: none;
  }

}

.title-shadow {
  text-shadow: #000 1px 1px 4px;
}

@keyframes splash {
  0% {
    transform: rotate(30deg) scale(1);
  }

  50% {
    transform: rotate(30deg) scale(1.2);
  }

  100% {
    transform: rotate(30deg) scale(1);
  }
}

.title-splash {
  position: absolute;
  right: -12px;
  top: -12px;
  transform: rotate(30deg);

  color: yellow;
  font-size: 20px;
  font-weight: blod;
  font-family: 'Minecraft';

  text-shadow: #000 1px 1px 4px;

  // Ani
  animation-name: splash;
  animation-duration: .5s;
  animation-timing-function: ease;
  animation-iteration-count: infinite;

  &-warpper {
    position: relative;
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

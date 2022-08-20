<template>
  <q-page>
    <div class="container">
      <!--上面显示一排标签-->
      <div class="tags-container">
        <div class="tag-item" :class="getTagColor(0)">#马赛克</div>
        <div class="tag-item" :class="getTagColor(1)">#高清</div>
        <div class="tag-item" :class="getTagColor(2)">#主播</div>
        <div class="tag-item" :class="getTagColor(3)">#二次元</div>
        <div class="tag-item" :class="getTagColor(4)">#妹子</div>
      </div>

      <q-tabs no-caps switch-indicator align="left" class="text-pimary" indicator-color="primary">
        <q-tab name="skins" label="皮肤" />
        <q-tab name="dress" label="装扮" />
        <q-tab name="capes" label="披风" />
        <q-tab name="servers" label="服务器" />
      </q-tabs>
    </div>
  </q-page>
</template>




<script lang="ts" setup>
import { ref } from 'vue'

import LearnMoreCard from '../components/cards/LearnMoreCard.vue'
import ActNormalCard from 'src/components/cards/ActNormalCard.vue'

const getTagColor = (index: number) => {
  const colors = ['blue', 'green', 'yellow', 'pink', 'purple']

  return 'tag-' + colors[index % (colors.length - 1)]
}



</script>
<style lang="scss" scoped>
.tags-container {
  display: flex;

  padding: 12px;
  margin-top: 16px;
  justify-content: center;

  .tag-item {
    padding: 8px 32px;
    border-radius: 8px;

    margin: 0 8px;

    cursor: pointer;

    color: white;

    &.tag-blue {
      background-color: #5365ff;
    }

    &.tag-green {
      background-color: #07c700;
    }

    &.tag-yellow {
      background-color: #c0b020;
    }

    &.tag-pink {
      background-color: #d564d4;
    }

    &.tag-purple {
      background-color: #c050f3;
    }
  }

}
</style>

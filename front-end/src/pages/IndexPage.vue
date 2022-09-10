<template>
  <q-page>
    <!--上面显示一排标签-->
    <div style="overflow-x: auto">
      <div class="tags-container">
        <div
          v-for="(item, index) in tags"
          :key="index"
          class="tag-item"
          :class="getTagColor(index)"
        >
          #{{ item }}
        </div>
      </div>
    </div>
    <div class="container">
      <q-tabs
        no-caps
        switch-indicator
        align="left"
        class="text-pimary"
        indicator-color="primary"
        :ripper="false"
      >
        <q-route-tab
          v-for="(item, index) in tabs"
          :key="index"
          :to="item.to"
          :label="item.label"
          exact
        />
      </q-tabs>

      <router-view></router-view>
    </div>
  </q-page>
</template>

<script lang="ts" setup>
import { useMeta } from 'quasar';
import { ref } from 'vue';

useMeta({
  title: '首页',
});

const tags = ref<string[]>([
  '二次元',
  '原版',
  '高清',
  '二创',
  '搬运',
  '主播',
  '恶搞',
]);

const tabs = ref([
  {
    label: '皮肤',
    to: '/',
  },
  /*
  {
    label: '装扮',
    to: '/dress',
  },
  */
  {
    label: '披风',
    to: '/cape',
  },
  {
    label: '服务器',
    to: '/server',
  },
]);
const getTagColor = (index: number) => {
  const colors = ['blue', 'green', 'yellow', 'pink', 'purple'];

  return 'tag-' + colors[index % (colors.length - 1)];
};
</script>
<style lang="scss" scoped>
.tags-container {
  display: flex;

  padding: 12px;
  margin-top: 16px;
  justify-content: center;

  min-width: fit-content;

  .tag-item {
    padding: 8px 32px;
    border-radius: 8px;
    margin: 0 8px;
    cursor: pointer;
    color: white;
    white-space: nowrap;

    &.tag-blue {
      background-color: #5365ff;
    }

    &.tag-green {
      background-color: #07c700;
    }

    &.tag-yellow {
      background-color: #938400;
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

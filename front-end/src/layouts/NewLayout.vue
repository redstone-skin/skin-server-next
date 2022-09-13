<template>
  <q-layout view="hHh lpR fff">
    <q-header class="text-grey-600" style="background: none">
      <SiteHeader @draw="drawer = !drawer"></SiteHeader>
    </q-header>

    <q-drawer v-model="drawer" overlay :width="200" elevated behavior="mobile">
      <q-scroll-area class="fit">
        <q-toolbar>
          <q-btn flat round dense icon="menu" @click="drawer = !drawer" />
          <q-toolbar-title>红石·皮肤站</q-toolbar-title>
        </q-toolbar>
        <q-list>
          <template v-for="(menuItem, index) in menuList" :key="index">
            <q-item clickable :active="menuItem.label === 'Outbox'" v-ripple>
              <q-item-section avatar>
                <q-icon :name="menuItem.icon" />
              </q-item-section>
              <q-item-section>
                {{ menuItem.label }}
              </q-item-section>
            </q-item>
            <q-separator :key="'sep' + index" v-if="menuItem.separator" />
          </template>
        </q-list>
      </q-scroll-area>
    </q-drawer>

    <q-page-container>
      <router-view />
    </q-page-container>

    <q-footer class="q-pt-md q-pb-md bg-black">
      <div class="row items-center q-gutter-sm justify-center">
        <a href="https://github.com/redstone-skin" target="_blank"> Github </a>
        <a href="https://afdian.net/@hempflower" target="_blank"> 捐赠我们 </a>
        <a href="https://www.mcbbs.net/thread-829044-1-1.html" target="_blank">
          MCBBS宣传贴
        </a>
        <a href="https://status.mcskin.cn/" target="_blank"> 状态监控 </a>
      </div>
      <div class="text-center">这里是备案号</div>
      <div class="text-center">© {{ new Date().getFullYear() }} 红石皮肤站</div>
    </q-footer>

    <q-ajax-bar position="top" color="primary" size="10px" skip-hijack />
  </q-layout>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import SiteHeader from '../components/SiteHeader.vue';

const drawer = ref(false);
const menuList = ref([
  {
    icon: 'compare',
    label: '皮肤',
    separator: false,
  },
  /*
    {
        icon: 'image',
        label: '装扮',
        separator: false
    },
    */
  {
    icon: 'image',
    label: '披风',
    separator: false,
  },
  {
    icon: 'dns',
    label: '服务器',
    separator: true,
  },
  {
    icon: 'settings',
    label: '设置',
    separator: false,
  },
  {
    icon: 'feedback',
    label: '反馈',
    separator: false,
  },
  {
    icon: 'help',
    iconColor: 'primary',
    label: '帮助',
    separator: false,
  },
]);
</script>
<style scoped lang="scss">
.rs-site-bg-img {
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  background-image: url(../assets/images/home-bg-0.png);

  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;

  z-index: -999;

  filter: brightness(0.8);
}
</style>

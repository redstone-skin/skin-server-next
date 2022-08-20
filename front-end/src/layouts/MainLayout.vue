<template>
  <q-layout view="hHh lpR fff">
    <q-header bordered class="navbar-bg">
      <q-toolbar>
        <q-btn flat round dense icon="menu" class="lt-sm" />
        <q-toolbar-title shrink>
          红石皮肤站
        </q-toolbar-title>
        <q-tabs class="gt-xs">
          <q-tab name="tab1" label="首页" />
          <q-tab name="tab2" label="皮肤" />
          <q-tab name="tab2" label="披风" />
          <q-tab name="tab3" label="服务器" />
          <q-tab name="tab4" label="帮助" />
          <q-tab name="tab5" label="关于" />
        </q-tabs>
        <q-space></q-space>
        <q-btn flat round :ripple="false">
          <q-avatar size="28px">
            <img src="https://avatars.githubusercontent.com/u/22955496?v=4" />
          </q-avatar>
        </q-btn>
        <q-btn flat round icon="mail_outline" :ripple="false">
          <q-badge color="primary" floating>4</q-badge>
        </q-btn>
        <q-btn flat round :icon="$q.dark.isActive ? 'dark_mode' : 'light_mode'" :ripple="false" @click="toggleTheme" />
        <q-btn flat round icon="file_upload" :ripple="false" />
      </q-toolbar>
    </q-header>

    <q-page-container class="q-pb-lg">
      <router-view />
    </q-page-container>

    <q-footer class="bg-black text-white footer">
      <div class="nav-controller">
        <div>
          红石皮肤站(Redstone Skin)为Minecraft玩家提供免费的皮肤站服务。<br> 你可以使用皮肤站上传你的皮肤，或者下载其他玩家的皮肤。
        </div>
      </div>
      <!--Copyright and icp-->
      <div>
        <div class="text-center">
          <span>© 2021 Redstone Skin</span>
          <span> | </span>
          <span>京ICP备2021000000号</span>
        </div>
      </div>
    </q-footer>

    <div class="inside-watermark">
      <div style="font-size: 24px;">Redstone Skin Alpha</div>
      <div style="font-size: 16px;">红石皮肤站早期预览版</div>
    </div>

    <q-ajax-bar position="top" color="primary" size="10px" skip-hijack />
  </q-layout>
</template>

<script setup lang="ts">
import { useQuasar } from 'quasar'
const $q = useQuasar()

const toggleTheme = () => {
  $q.dark.toggle();
}

</script>
<style scoped lang="scss">
.site-name:hover {
  background-color: rgba($color: #000000, $alpha: 0.3);
}

.body--dark {
  .navbar-bg {
    background-color: $dark;
  }
}

.body--light {
  .navbar-bg {
    background-color: #353535;
  }
}

.footer {
  padding: 16px;
  padding-bottom: 4px;

  margin-top: 16px;

  .nav-controller {
    margin: 0 auto;
    max-width: 1140px;
    display: flex;

    padding: 16px;
  }
}

.inside-watermark {
  position: fixed;
  bottom: 64px;
  right: 64px;
  opacity: 0.8;
  z-index: 9999;
  padding: 8px;
  color: rgb(139, 139, 139);
  pointer-events: none;
}
</style>

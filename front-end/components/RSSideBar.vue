<script lang="ts" setup>
const { t } = useI18n();

const menuList = ref<
  {
    icon: string;
    label: string;
    to: string;
  }[]
>([
  {
    icon: "pi pi-box",
    label: t("sidebar.home"),
    to: "/",
  },
  {
    icon: "pi pi-briefcase",
    label: t("sidebar.skins"),
    to: "/skins",
  },
  {
    icon: "pi pi-server",
    label: t("sidebar.servers"),
    to: "/servers",
  },
  {
    icon: "pi pi-download",
    label: t("sidebar.library"),
    to: "/library",
  },
]);
</script>

<template>
  <div class="h-full w-20 flex flex-col items-center">
    <div class="flex-1 flex flex-col items-center gap-2 mt-4">
      <RSSideBarItem
        v-for="item in menuList"
        :key="item.label"
        :icon="item.icon"
        :label="item.label"
        :to="item.to"
      />
    </div>
    <div class="mb-4 flex flex-col items-center gap-2">
      <RSSideBarItem
        icon="pi pi-plus"
        label="安装游戏"
        active
      />
      <RSSideBarItem
        icon="pi pi-cog"
        label="设置"
        to="/settings"
      />
      <!-- Avatar -->
      <Avatar
        class="cursor-pointer"
        size="large"
        shape="circle"
        label="P"
      />
    </div>
  </div>
</template>

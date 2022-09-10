<template>
  <!--Redstone Helper-->
  <div class="redstone-helper">
    <!--主要的文本区域-->
    <div class="redstone-helper-content">
      <div class="text-subtitle2">点击右侧的图标可以把我隐藏</div>
    </div>
    <!--右侧图标区域-->
    <div class="redstone-helper-icon">
      <q-icon size="24px" name="reorder" />
    </div>
  </div>
</template>
<style lang="scss" scoped>
.redstone-helper {
  position: fixed;
  top: 20%;
  left: 0;
  width: 256px;

  $helper-bg: rgba($primary, 0.6);

  background-color: $helper-bg;

  display: flex;

  cursor: pointer;

  &-content {
    width: 256px;
    padding: 12px;
  }

  &-icon {
    margin: 0;
    padding: 12px 20px;

    transition: background 0.3s;
  }

  &-icon:hover {
    background-color: darken($color: $helper-bg, $amount: 30%);
  }
}
</style>

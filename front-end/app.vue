<template>
  <NuxtLoadingIndicator />
  <NuxtLayout>
    <NuxtPage />
  </NuxtLayout>
</template>
<script lang="ts" setup>
const { t } = useI18n();

useHead({
  title: "hello",
  titleTemplate: t("meta.titleTemplate"),
  meta: [
    { charset: "utf-8" },
    { name: "viewport", content: "width=device-width, initial-scale=1" },
    { name: "description", content: t("meta.description") },
    {
      name: "keywords",
      content: t("meta.keywords"),
    },
  ],
});
</script>

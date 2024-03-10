// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  devtools: {
    enabled: true,
    timeline: {
      enabled: true,
    },
  },
  css: ["~/assets/css/app.css", "primeicons/primeicons.css"],
  modules: [
    "@pinia/nuxt",
    "@nuxtjs/tailwindcss",
    "@nuxtjs/eslint-module",
    "@nuxtjs/i18n",
    "nuxt-primevue",
    "@nuxtjs/color-mode",
  ],
  runtimeConfig: {
    public: {
      siteName: "站点名称",
      description: "红石 MC 致力于为 Minecraft 玩家提供良好的联机体验",
      apiServer: process.env.API_SERVER || "http://localhost:3000",
    },
  },
  primevue: {
    options: {
      unstyled: true,
    },
    importPT: { from: "~/presets/redstone/" },
  },
  colorMode: {
    classSuffix: "",
  },
  postcss: {
    plugins: {
      tailwindcss: {},
      autoprefixer: {},
    },
  },
  tailwindcss: {
    configPath: "~/tailwind.config.js",
  },
});

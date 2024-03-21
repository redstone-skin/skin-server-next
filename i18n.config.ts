import zh_Hans from "./langs/zh_Hans.json";

export default defineI18nConfig(() => ({
  legacy: false,
  locale: "zh_Hans",
  messages: {
    zh_Hans: zh_Hans,
  },
}));

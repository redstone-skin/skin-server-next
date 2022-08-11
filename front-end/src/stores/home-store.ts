import { defineStore } from 'pinia';

export const useHomeStore = defineStore('homeStore', {
  state: () => ({
    splash: 'Unknown',
  }),
  actions: {
    setSplash(content: string) {
      this.splash = content
    },
  },
});

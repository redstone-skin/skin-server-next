import defaultLauncherBackgroundLight from "@/assets/images/launcher-background-light.jpg";
import defaultLauncherBackgroundDark from "@/assets/images/launcher-background-dark.jpg";

export const useLauncherStore = defineStore("launcher", () => {
  const colorMode = useColorMode();
  const customBackground = ref("");

  const defaultBackground = computed(() => {
    if (colorMode.value === "dark") {
      return defaultLauncherBackgroundDark;
    } else {
      return defaultLauncherBackgroundLight;
    }
  });

  const background = computed(() => {
    if (customBackground.value) {
      return customBackground;
    } else {
      return defaultBackground;
    }
  });

  const changeBackground = (newBackground: string) => {
    customBackground.value = newBackground;
  };

  return {
    background,
    changeBackground,
  };
});

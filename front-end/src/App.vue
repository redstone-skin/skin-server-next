<template>
  <router-view />
</template>

<script setup lang="ts">
import { useQuasar, Cookies, useMeta } from 'quasar'
import { useSSRContext, watch } from 'vue'


const $q = useQuasar()

// calling here; equivalent to when component is created


const ssrContext = process.env.SERVER ? useSSRContext() : null

const cookies = ssrContext ? Cookies.parseSSR(ssrContext) : Cookies
// 从cookie中读取主题
if (cookies.get('theme') === 'dark') {
  $q.dark.set(true)
} else {
  $q.dark.set(false)
}

watch(() => $q.dark.isActive, (val) => {
  // 保存主题到cookie
  if (val) {
    cookies.set('theme', 'dark')
  } else {
    cookies.set('theme', 'light')
  }

  if ($q.dark.isActive) {
    // 向html中添加dark主题
    document.documentElement.style.setProperty('color-scheme', 'dark')
  } else {
    document.documentElement.style.setProperty('color-scheme', 'light')
  }
})


const metaData = {
  titleTemplate: (title: string) => `${title} - 红石皮肤站`,
  meta: {
    description: { name: 'description', content: '红石皮肤站为Minecaft提供免费的皮肤托管服务。玩家可以上传，下载以及通过皮肤mod使用皮肤。' },
    keywords: { name: 'keywords', content: 'Minecraft,我的世界,MC,麦块,皮肤站,mcskin,红石,红石皮肤站,skin,cape,server' },
  }
}

useMeta(metaData)

</script>

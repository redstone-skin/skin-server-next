<template>
    <q-toolbar class="rs-header-bg">
        <q-btn flat round dense icon="menu" @click="emit('draw')" />
        <q-toolbar-title class="rs-header-title non-selectable cursor-pointer">
            <span class="relative-position">红石·皮肤站
                <q-badge floating align="top">Beta</q-badge>
            </span>
        </q-toolbar-title>
        <q-space />
        <q-input outlined dense v-model="search" input-class="text-left" class="q-mr-md gt-xs" placeholder="红石皮肤站官方服务器">
            <template v-slot:append>
                <q-icon v-if="search === ''" name="search" />
                <q-icon v-else name="clear" class="cursor-pointer" @click="search = ''" />
            </template>
        </q-input>
        <!--投稿按钮-->
        <q-btn-dropdown unelevated rounded color="primary" label="发布作品" class="q-mr-md gt-xs">
            <q-list separator>
                <q-item clickable v-close-popup>
                    <q-item-section>
                        <q-item-label>皮肤</q-item-label>
                    </q-item-section>
                </q-item>

                <q-item clickable v-close-popup>
                    <q-item-section>
                        <q-item-label>披风</q-item-label>
                    </q-item-section>
                </q-item>

                <q-item clickable v-close-popup>
                    <q-item-section>
                        <q-item-label>服务器</q-item-label>
                    </q-item-section>
                </q-item>
            </q-list>
        </q-btn-dropdown>
        <!--头像-->
        <q-btn round :ripple="false" unelevated class="q-mr-md">
            <q-avatar>
                <img src="https://cdn.quasar.dev/img/avatar.png" />
            </q-avatar>
            <q-menu style="min-width: 200px">
                <q-item>
                    <q-item-section avatar>
                        <q-avatar square>
                            <img src="https://cdn.quasar.dev/img/boy-avatar.png">
                        </q-avatar>
                    </q-item-section>
                    <q-item-section>
                        <q-item-label>麻花awa <q-badge>Lv3</q-badge>
                        </q-item-label>
                        <q-item-label caption>@hempflower</q-item-label>
                    </q-item-section>
                </q-item>
                <!--等级信息-->
                <div class="q-pb-sm q-pl-md q-pr-md">
                    <q-linear-progress :value="0.5">
                    </q-linear-progress>
                    <div class="text-weight-light text-caption">距离下一级还差 556 经验值</div>
                </div>
                <q-separator />
                <q-list>
                    <q-item clickable v-close-popup>
                        <q-item-section>个人主页</q-item-section>
                    </q-item>
                    <q-item clickable v-close-popup>
                        <q-item-section>账户设置</q-item-section>
                    </q-item>
                    <q-separator />
                    <q-item clickable v-close-popup>
                        <q-item-section>退出登录</q-item-section>
                    </q-item>
                </q-list>
            </q-menu>
        </q-btn>
        <q-btn flat round dense :icon="$q.dark.isActive ? 'dark_mode' : 'light_mode'" :ripple="false"
            @click="toggleTheme" />
        <q-btn flat round dense icon="apps" />
    </q-toolbar>

</template>
<script setup lang="ts">
import { useQuasar } from 'quasar'
import { ref } from 'vue'

const search = ref('')

const $q = useQuasar()

const toggleTheme = () => {
    $q.dark.toggle();
}

const emit = defineEmits(['draw'])

</script>
<style lang="scss" scoped>
.body--light {
    .rs-header-bg {
        background: #fff;

        color: black;
    }

}

.body--dark {
    .rs-header-bg {
        background: $dark;
    }
}
</style>
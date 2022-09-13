<template>
    <q-page class="login-page">
        <div class="container full-height">
            <div class="row full-height flex-center">
                <q-card class="col-lg-3 col-md-5 col-sm-8 col-xs-12 q-pa-md">
                    <q-card-section>
                        <router-link to="/" custom v-slot="{ navigate }">
                            <div @click="navigate" class="text-subtitle1 text-bold non-selectable cursor-pointer">红石皮肤站
                            </div>
                        </router-link>
                        <q-tab-panels v-model="panel" animated swipeable>
                            <q-tab-panel class="login-form-panel" name="prelogin">
                                <div class="q-mt-sm">
                                    <div class="text-h6 q-mb-sm non-selectable">登陆</div>
                                    <q-input class="login-form-input" dense v-model="email" label="邮箱"
                                        placeholder="请输入账号邮箱" />
                                    <div class="text-body2 q-mt-lg"><span
                                            class="text-primary cursor-pointer">创建一个新账号</span>
                                    </div>
                                    <div class="text-body2 q-mt-md text-primary cursor-pointer">
                                        忘记密码
                                    </div>
                                    <div class="flex justify-end">
                                        <q-btn color="primary" @click="requestLogin">下一步</q-btn>
                                    </div>
                                </div>
                            </q-tab-panel>

                            <q-tab-panel class="login-form-panel" name="password">
                                <div class="q-mt-sm">
                                    <div class="cursor-pointer q-mb-sm text-subtitle2" @click="panel = 'prelogin'">
                                        <q-icon name="login" class="q-pr-xs"></q-icon>{{ email }}
                                    </div>
                                    <div class="text-h6 q-mb-sm non-selectable">请输入密码</div>
                                    <q-input class="login-form-input" type="password" dense v-model="passowrd"
                                        label="密码" placeholder="输入密码" />

                                    <div style="margin-left: -8px;" class="q-mt-sm">
                                        <q-checkbox size="xs" v-model="remember" label="保持登陆状态" />
                                    </div>
                                    <div class="flex justify-end">
                                        <q-btn color="primary" @click="requestLogin">登陆</q-btn>
                                    </div>
                                </div>
                            </q-tab-panel>
                        </q-tab-panels>

                    </q-card-section>
                    <q-inner-loading :showing="false">
                        <q-spinner-gears size="50px" color="primary" />
                    </q-inner-loading>
                </q-card>
            </div>
        </div>

    </q-page>
</template>
<script lang="ts" setup>
import { RouterLink } from 'vue-router'
import { useMeta } from 'quasar';
import { ref } from 'vue'

useMeta({
    title: '红石账户'
})
const panel = ref('prelogin')

const email = ref('')
const passowrd = ref('')
const remember = ref(false)

const requestLogin = () => {
    // 完成后会向后端发送登陆请求

    panel.value = 'password'
    passowrd.value = ''
}

</script>
<style lang="scss" scoped>
.login-page {
    height: 100vh;

    background-image: url(../../assets/images/home-bg-0.png);
    background-position: center;
    background-size: cover;
    background-repeat: no-repeat;

    overflow: hidden;

    ::-webkit-scrollbar {
        display: none;
    }
}



.login-form {
    &-input {
        width: 100%;
    }

    &-panel {
        padding: 0;
    }
}
</style>
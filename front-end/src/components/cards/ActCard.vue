<template>
    <q-card bordered flat>
        <!--头部是用户头像和昵称-->
        <q-card-section>
            <q-item>
                <q-item-section avatar>
                    <UserAvatar :type="userType ?? 'normal'" src="https://cdn.quasar.dev/img/boy-avatar.png">
                    </UserAvatar>
                </q-item-section>
                <q-item-section>
                    <q-item-label>{{ nick }}</q-item-label>
                    <q-item-label caption>
                        {{ subtitle }}
                    </q-item-label>
                </q-item-section>
                <q-item-section side>
                    <q-btn flat :ripple="false" color="grey" icon="more_horiz">
                        <q-menu auto-close>
                            <q-list style="min-width: 100px">
                                <q-item clickable>
                                    <q-item-section>屏蔽此人</q-item-section>
                                </q-item>
                                <q-separator />
                                <q-item clickable>
                                    <q-item-section>举报</q-item-section>
                                </q-item>
                            </q-list>
                        </q-menu>
                    </q-btn>
                </q-item-section>
            </q-item>
            <q-card-section>
                <slot></slot>
            </q-card-section>
        </q-card-section>
        <q-card-actions align="right">
            <q-btn flat :ripple="false" color="grey" icon="favorite" label="100" />
            <q-btn flat :ripple="false" color="primary" icon="chat_bubble_outline" label="64" />
        </q-card-actions>
    </q-card>
</template>
<script lang="ts" setup>

import UserAvatar from '../UserAvatar.vue'

interface ActCardProp {
    avatar?: string;
    nick?: string;
    userType?: 'normal' | 'official' | 'team';
    subtitle?: string;
}

const props = defineProps<ActCardProp>()

</script>

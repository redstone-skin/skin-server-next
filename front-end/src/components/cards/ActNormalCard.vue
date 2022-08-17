<template>
    <q-card bordered flat>
        <!--头部是用户头像和昵称-->
        <q-card-section>
            <q-item>
                <q-item-section avatar>
                    <q-avatar>
                        <img src="https://cdn.quasar.dev/img/boy-avatar.png">
                        <q-badge floating color="primary">V</q-badge>
                    </q-avatar>
                </q-item-section>
                <q-item-section>
                    <q-item-label>红石皮肤站_Official</q-item-label>
                    <q-item-label caption>
                        发表于 19:19
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
                红石皮肤站Alpha版本正在开发中
                <!--要支持下插图功能-->
                <div class="img-flex">
                    <q-img class="act-img" fit="cover" src="https://placeimg.com/500/300/nature"></q-img>
                </div>
            </q-card-section>
        </q-card-section>
        <q-card-actions align="right">
            <q-btn dense flat :ripple="false" color="grey" icon="favorite" label="100" />
            <q-btn dense flat :ripple="false" color="primary" icon="chat_bubble_outline" label="64" />
        </q-card-actions>
    </q-card>
</template>
<style lang="scss" scoped>
.img-flex {
    display: flex;
    padding-top: 8px;
    flex-wrap: wrap;
    flex-direction: row;


    .act-img {
        width: 30%;
        flex-grow: 1;

    }
}
</style>
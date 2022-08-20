<template>
    <act-card nick="红石皮肤站_Official" subtitle="发表于 19:00">
        红石皮肤站Alpha版本正在开发中
        <!--要支持下插图功能-->
        <div class="img-flex">
            <q-img class="act-img" fit="cover" src="https://placeimg.com/500/300/nature"></q-img>
        </div>
    </act-card>
</template>
<script lang="ts" setup>
import ActCard from './ActCard.vue'


</script>
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
<template>
    <div>
        <!-- 推荐 -->
        <GroupTitle>
            为你推荐
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <SkinGridList></SkinGridList>
        <!-- 最新 -->
        <GroupTitle>
            最新上传
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <SkinGridList></SkinGridList>
        <!-- 收藏 -->
        <GroupTitle>
            最多使用
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <SkinGridList></SkinGridList>
        <!-- 热门 -->
        <GroupTitle>
            披风合集
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <SkinGridList></SkinGridList>
        <GroupTitle>
            高清披风
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <SkinGridList></SkinGridList>

        <GroupTitle>
            包含鞘翅
            <template v-slot:right>
                <q-btn flat color="primary" label="换一换" />
            </template>
        </GroupTitle>
        <ServerGridList></ServerGridList>

        <!-- 底部搜索 -->
        <div class="rs-bottom-search">
            <div style="min-width: 30vw">
                <div class="text-h4 text-center q-mb-sm">更多服务器?在这里搜索</div>
                <!-- 搜索框 -->
                <SearchBox></SearchBox>
            </div>
        </div>
    </div>
</template>
<script lang="ts" setup>
import GroupTitle from 'src/components/GroupTitle.vue';
import ServerGridList from 'src/components/ServerGridList.vue';
import SearchBox from 'src/components/SearchBox.vue';

</script>
<style lang="scss" scoped>
.rs-bottom-search {
    display: flex;
    justify-content: center;
    align-items: center;

    min-height: 20vh;

    margin-top: 32px;
}
</style>
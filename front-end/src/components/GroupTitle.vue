<template>
    <div class="rs-group-warpper">
        <div class="group-title text-h5 q-pl-sm">
            <slot></slot>
        </div>
        <q-space></q-space>
        <div>
            <slot name="right"></slot>
        </div>
    </div>
</template>
<style lang="scss" scoped>
.rs-group-warpper {
    display: flex;
}

.group-title {
    margin: 4px 0;

    user-select: none;
}
</style>
<template>
    <div class="q-pa-lg">
        <q-input dense outlined v-model="kw" placeholder="在这里搜索皮肤，披风，服务器">
            <template v-slot:append>
                <q-icon name="search" class="cursor-pointer" />
            </template>
        </q-input>
    </div>
</template>
<script lang="ts" setup>
import { ref } from 'vue'

const kw = ref('')

</script>
<template>
    <q-dialog ref="dialogRef" @hide="onDialogHide">
        <q-card class="q-dialog-plugin">
            <q-card-section>
                <div class="text-h6">配置引导</div>
            </q-card-section>
            <q-tabs v-model="tab" dense align="left" class="text-grey" active-color="primary" indicator-color="primary"
                narrow-indicator>
                <q-tab name="mod" label="皮肤MOD" />
                <q-tab name="yggdrasil" label="外置登陆" />
            </q-tabs>
            <q-tab-panels v-model="tab" animated>
                <q-tab-panel name="mod">
                    <GuideMod></GuideMod>
                </q-tab-panel>
                <q-tab-panel name="yggdrasil">
                    <GuideYggdrasil></GuideYggdrasil>
                </q-tab-panel>
            </q-tab-panels>
            <q-card-actions align="right">
                <q-btn flat label="关闭" @click="onDialogCancel" />
            </q-card-actions>
        </q-card>
    </q-dialog>
</template>
<script lang="ts" setup>
import { ref } from 'vue'
import { useDialogPluginComponent } from 'quasar'
const { dialogRef, onDialogHide, onDialogOK, onDialogCancel } = useDialogPluginComponent()

import GuideMod from './GuideMod.vue';
import GuideYggdrasil from './GuideYggdrasil.vue';

const tab = ref('mod')


</script>

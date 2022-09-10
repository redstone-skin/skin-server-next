<template>
  <q-stepper v-model="step" vertical flat color="primary" animated>
    <q-step :name="1" title="下载皮肤MOD" icon="settings" :done="step > 1">
      <div>
        <!--CSL 下载-->
        <q-select
          outlined
          dense
          v-model="selectedMC"
          :options="mcVersions"
          label="MC版本"
          style="max-width: 50%"
        />
        <div class="q-mt-md q-gutter-xs">
          <q-btn
            color="secondary"
            label="Forge 版下载"
            :disable="!selectedMC"
          />
          <q-btn color="accent" label="Fabric 版下载" :disable="!selectedMC" />
        </div>
      </div>
      <q-stepper-navigation>
        <q-btn @click="step = 2" color="primary" label="继续" />
        <q-btn
          flat
          @click="step = 3"
          color="primary"
          label="跳过安装引导"
          class="q-ml-sm"
        />
      </q-stepper-navigation>
    </q-step>

    <q-step
      :name="2"
      title="安装皮肤MOD"
      icon="create_new_folder"
      :done="step > 2"
    >
      请将MOD放置到你的MC安装目录的mods文件夹中，并启动客户端。
      <q-stepper-navigation>
        <q-btn @click="step++" color="primary" label="继续" />
        <q-btn
          flat
          @click="step--"
          color="primary"
          label="返回"
          class="q-ml-sm"
        />
      </q-stepper-navigation>
    </q-step>

    <q-step :name="3" title="将皮肤站添加至加载列表" icon="add_comment">
      请点击下方按钮下载此皮肤站的Extralist文件，然后将其放置到
      <pre class="q-d-inline">.minecraft/CustomSkinLoader/ExtraList</pre>
      文件夹中。
      <br />
      启动游戏后即可看到皮肤站的皮肤。

      <q-stepper-navigation>
        <q-btn
          @click="downloadExtraList"
          color="primary"
          label="下载 Extralist 文件"
        />
        <q-btn
          flat
          @click="step--"
          color="primary"
          label="返回"
          class="q-ml-sm"
        />
      </q-stepper-navigation>
    </q-step>
  </q-stepper>
</template>
<script lang="ts" setup>
import { onMounted, ref } from 'vue';
import { csList } from '../http-api/misc';
import fileDownload from 'js-file-download';

const step = ref(1);
const selectedMC = ref(null);

interface CSLDownload {
  name: string;
  forge: string;
  fabric: string;
}

const downloadList = ref<CSLDownload[]>([]);
const mcVersions = ref<string[]>([]);

const downloadExtraList = () => {
  // TODO
  const domain = window.location.host;
  const url = `https://${domain}/csl/`;
  const extraObj = {
    name: 'RedstoneSkin',
    type: 'CustomSkinAPI',
    root: url,
    __comment:
      '红石皮肤站 ExtraList 配置文件，请放入 .minecraft/CustomSkinLoader/ExtraList 文件夹中',
  };

  // 文件下载多了重名，加一个不容易重名的后缀
  const fileName = `RedstoneSkin_${new Date().getTime()}.json`;

  fileDownload(JSON.stringify(extraObj, null, 2), fileName);
};

onMounted(() => {
  csList().then((res) => {
    downloadList.value.length = 0;

    // K-V to V
    for (const key in res.details) {
      mcVersions.value.push(key);
      downloadList.value.push({
        name: key,
        forge: res.details[key].Forge,
        fabric: res.details[key].Fabric,
      });
    }
  });
});
</script>

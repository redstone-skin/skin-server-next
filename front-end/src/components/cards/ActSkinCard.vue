<template>
  <q-card>
    <!--头部是用户头像和昵称-->
    <q-card-section>
      <q-item>
        <q-item-section avatar>
          <q-avatar>
            <img src="https://cdn.quasar.dev/img/boy-avatar.png" />
            <q-badge floating color="primary">V</q-badge>
          </q-avatar>
        </q-item-section>
        <q-item-section>
          <q-item-label>红石皮肤站_Official</q-item-label>
          <q-item-label caption> 发表于 19:19 </q-item-label>
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

      <q-card-section> </q-card-section>
    </q-card-section>
  </q-card>
</template>

import { RouteRecordRaw } from 'vue-router';

const routes: RouteRecordRaw[] = [
  {
    path: '/',
    component: () => import('layouts/NewLayout.vue'),
    children: [
      {
        path: '',
        component: () => import('pages/IndexPage.vue'),
        children: [
          {
            path: '',
            component: () => import('pages/index/SkinPage.vue'),
          },
          {
            path: 'dress',
            component: () => import('pages/index/SkinPage.vue'),
          },
          {
            path: 'cape',
            component: () => import('pages/index/CapePage.vue'),
          },
          {
            path: 'server',
            component: () => import('pages/index/SkinPage.vue'),
          },
        ],
      },
    ],
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue'),
  },
];

export default routes;

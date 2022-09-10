import { ssrMiddleware } from 'quasar/wrappers';
import { createProxyMiddleware } from 'http-proxy-middleware';

export default ssrMiddleware(({ app, resolve, render, serve }) => {
  app.use(
    createProxyMiddleware(['/api', '/csl'], {
      target: 'http://localhost:5000',
      changeOrigin: true,
      ws: true,
      pathRewrite: {
        '^/api': '',
      },
    })
  );
});

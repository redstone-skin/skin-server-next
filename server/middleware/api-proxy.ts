import { eventHandler } from "h3";
import { createProxyEventHandler } from "h3-proxy";

export default defineEventHandler(
  eventHandler(
    createProxyEventHandler({
      target: useRuntimeConfig().public.apiServer,
      pathFilter: ["/api"],
    }),
  ),
);

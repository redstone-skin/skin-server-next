FROM node:16-alpine3.15

WORKDIR /app
COPY . ./front-end
# Build Frontend
RUN cd /app/front-end \
    && npm i \
    && npm run build \
    && cd ./dist/ssr \
    && npm i \
    && cp -r . /app/ssr \
    && rm -rf /app/front-end

ENTRYPOINT ["node","/app/ssr/index.js"]

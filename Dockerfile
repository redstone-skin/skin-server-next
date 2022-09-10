
# Build backend
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-backend
WORKDIR /source

# copy csproj and restore as distinct layers
# copy and publish app and libraries
COPY ./back-end .
RUN dotnet publish -c release -o /app -r linux-x64

# Build frontend

FROM node:16-alpine AS build-frontend
WORKDIR /source

COPY ./front-end .
# Build Frontend
RUN npm i \
    && npm run build \
    && cd ./dist/ssr \
    && npm i 


# Final image
FROM keymetrics/pm2:16-buster
WORKDIR /app

# Copy backend
COPY --from=build-backend ./app ./backend

#Copy frontend
COPY --from=build-frontend /source/dist/ssr ./frontend

COPY ./ecosystem.config.js ./ecosystem.config.js

CMD [ "pm2-runtime", "start", "ecosystem.config.js" ]






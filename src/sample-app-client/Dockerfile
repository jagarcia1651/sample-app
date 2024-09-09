FROM node:20-alpine

WORKDIR /app
EXPOSE 8080

COPY ["src/sample-app-client/", "/app/"]

RUN npm install

CMD [ "npm", "run", "dev" ]

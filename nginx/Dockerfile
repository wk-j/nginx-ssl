FROM nginx
COPY ./nginx.conf /etc/nginx/nginx.conf
COPY ./nginx-ssl.webredirect.org /etc/nginx/sites-available/nginx-ssl.webredirect.org

COPY ./cert/fullchain.pem   /fullchain.pem
COPY ./cert/privkey.pem     /privkey.pem
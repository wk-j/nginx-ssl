## Commands

```bash
brew install letsencrypt
sudo certbot certonly --manual

sudo cp /etc/letsencrypt/live/nginx-ssl.webredirect.org/fullchain.pem nginx/cert
sudo cp /etc/letsencrypt/live/nginx-ssl.webredirect.org/privkey.pem nginx/cert
```

```
IMPORTANT NOTES:
 - Congratulations! Your certificate and chain have been saved at:
   /etc/letsencrypt/live/nginx-ssl.webredirect.org/fullchain.pem
   Your key file has been saved at:
   /etc/letsencrypt/live/nginx-ssl.webredirect.org/privkey.pem
   Your cert will expire on 2019-10-14. To obtain a new or tweaked
   version of this certificate in the future, simply run certbot
   again. To non-interactively renew *all* of your certificates, run
   "certbot renew"
 - If you like Certbot, please consider supporting our work by:

   Donating to ISRG / Let's Encrypt:   https://letsencrypt.org/donate
   Donating to EFF:                    https://eff.org/donate-le
```
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [Route("/.well-known/acme-challenge/aAbtlRGnVqhMvafpTwf5kcoR0gsbnuam-6A7BpAedcA")]
    public class WNController
    {
        public string Get() =>
            "aAbtlRGnVqhMvafpTwf5kcoR0gsbnuam-6A7BpAedcA.c5KlemD5s8BxXA4JIGAc41hDAwwGCYHT_yGueoTRqMo";
    }
}
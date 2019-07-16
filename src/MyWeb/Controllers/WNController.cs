using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    [Route("/.well-known/acme-challenge/BM8IOYUn4P0iSe5csNPl2npacT9zTtXUJhb3BF820rA")]
    public class WNController
    {
        public string Get() =>
            "BM8IOYUn4P0iSe5csNPl2npacT9zTtXUJhb3BF820rA.c5KlemD5s8BxXA4JIGAc41hDAwwGCYHT_yGueoTRqMo";
    }
}
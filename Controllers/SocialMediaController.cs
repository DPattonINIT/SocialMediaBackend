using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialMediaBackend.Services;

namespace SocialMediaBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialMediaController : ControllerBase
    {
        private readonly SocialMediaService _socialMediaService;
        public SocialMediaController(SocialMediaService socialMediaService){
            _socialMediaService = socialMediaService;
        }
[HttpGet]
[Route("stats")]
    }
}
﻿using Microsoft.AspNetCore.Mvc;


namespace provider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExChangeRateController : ControllerBase
    {
        [HttpGet]
        
        public string GetExchangeRate()
        {
            return "OK";
        }
    }
}

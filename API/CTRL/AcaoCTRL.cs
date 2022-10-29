using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.CTRL
{
    [Route("Andressa.API/Acao")]
    [ApiController]
    public class AcaoCTRL
    {
        
        [HttpGet("Get")]
        public string Get()
        {
            return "Olá mundo";
        }
    }
}
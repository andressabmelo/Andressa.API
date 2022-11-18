using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
namespace API.CTRL
{
    [Route("Andressa.API/Acao")]
    [ApiController]
    public class AcaoCTRL
    {
        private IMusicaBLL BLL ;

        public AcaoCTRL(IMusicaBLL bLL){
            BLL = bLL;
        }

        [HttpGet("TocarMusica1")]
        public string TocarMusica1(int numero)
        {
            return BLL.TocarMusica1();
        }
        [HttpGet("TocarMusica2")]
        public string TocarMusica2(int numero)
        {
            return BLL.TocarMusica2();
        }
        [HttpGet("TocarMusica3")]
        public string TocarMusica3(int numero)
        {
            return BLL.TocarMusica3();
        }
        [HttpGet("TocarMusica4")]
        public string TocarMusica4(int numero)
        {
            return BLL.TocarMusica4();
        }
        [HttpPost("EscolherMusica")]
        public string EscolherMusica(int numero)
        {
            if(numero==1){
                return BLL.TocarMusica1();
            }
            else if(numero==2){
                return BLL.TocarMusica2();
            }
            else if(numero==3){
                return BLL.TocarMusica3();
            }
            else {
                return BLL.TocarMusica4();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
namespace BLL
{
    public class LouvorBLL : IMusicaBLL
    {
        public string TocarMusica1(){
            return "E eis que o véu se rasgou, a terra tremeu, algo acontecia entre a terra e o céu";
        }
        public string TocarMusica2(){
            return "Não há ferrolhos, nem portas, que se fechem diante da tua voz";
        }
        public string TocarMusica3(){
            return "Volta logo Jesus, tenho saudades de casa, o céu é o meu lar";
        }
        public string TocarMusica4(){
            return "Os sonhos de Deus jamais vão morrer";
        }
    }
}
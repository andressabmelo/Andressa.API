using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BLL.Interface;

namespace API.CTRL
{
    
     [Route("Andressa.API/Array")]
    [ApiController]
    public class ArrayCTRL
    {
        [HttpGet("ArrayNomes")]
        public string[] ArrayNomes(int numero)
        {
            var retorno= new string[5];
            retorno[0]="Andressa";
            retorno[1]="Margarete";
            retorno[2]="Leonel";
            retorno[3]="Sophia";
            retorno[4]="Maria";
            return retorno;
        }
        [HttpGet("ListarNomes")]
        public List<string> ListarNomes(int numero)
        {
            var retorno= new List <string>();
            retorno.Add("Beti");
            retorno.Add("Andressa");
            retorno.Add("Rodrigo");
            retorno.Add("Mãe");
            return retorno.OrderByDescending(nome => nome).ToList();
        }
        [HttpGet("Potencia")]
        public List<double> Potencia(double numero,double Potencia)
        {
            var retorno= new List <double>();
            for(double i = 1; i <= Potencia; i ++){
                retorno.Add(Math.Pow(numero,i));
            }
            return retorno;
        }
        [HttpGet("bidimensional")]
        public List<int[]> bidimensional(int numero)
        {
            var retorno= new List <int[]>();
            retorno.Add(new int[2]);
            retorno[0][0]=1;
            retorno[0][1]=2;
            retorno.Add(new int[2]);
            retorno[1][0]=3;
            retorno[1][1]=4;
            return retorno;
        }
        [HttpPost("ListaDeNomes")]
        public List<string> ListaDeNomes(string nome)
        {
            var retorno= new List<string>();
            retorno.Add("Andressa");
            retorno.Add("Margarete");
            retorno.Add("Leonel");
            retorno.Add("Sophia");
            retorno.Add("Maria");
            retorno.Add("Jheniffer");
            retorno.Add("Rodrigo");
            retorno.Add("Estéfani");
            retorno.Add("Mateus");
            retorno.Add("Vagner");
            retorno.Add("Nicolas");
            retorno.Add("William");
            retorno.Add("Calu");
            retorno.Add("Cacau");
            retorno.Add("Rei");
            retorno.Add("Branca");
            retorno.Add("Fredy");
            retorno.Add("Beti");
            retorno.Add("Guri");
            retorno.Add("Pandora");
            return retorno.OrderBy(nome => nome).ToList();
        }
    }
}

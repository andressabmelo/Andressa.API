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
        private IArrayBLL BLL;
        public ArrayCTRL(IArrayBLL bll){
            BLL=bll;
        }
        [HttpGet("ArrayNomes")]
        public string[] ArrayNomes(int numero)
        {
            return BLL.Arraynomes();
        }

        

        [HttpGet("ListarNomes")]
        public List<string> ListarNomes(int numero)
        {
            return BLL.Listarnomes();
        }

        

        [HttpGet("Potencia")]
        public List<double> Potencia(double numero,double Potencia)
        {
            return BLL.Potencia(numero, Potencia);
        }

        

        [HttpGet("bidimensional")]
        public List<int[]> bidimensional(int numero)
        {
            return BLL.Bidimensional();
        }

        

        [HttpPost("ListaDeNomes")]
        public List<string> ListaDeNomes(string nome)
        {
            return BLL.Listadenomes(nome);
        }
        [HttpPost("Desafio")]
        public string Desafio(string valor)
        {
            return BLL.Desafio(valor);
        }


        
    }
}

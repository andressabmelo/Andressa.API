using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL
{
    public class ArrayBLL : IArrayBLL
    {
         public string[] Arraynomes()
        {
            var retorno = new string[5];
            retorno[0] = "Andressa";
            retorno[1] = "Margarete";
            retorno[2] = "Leonel";
            retorno[3] = "Sophia";
            retorno[4] = "Maria";
            return retorno;
        }
        public List<string> Listarnomes()
        {
            var retorno = new List<string>();
            retorno.Add("Beti");
            retorno.Add("Andressa");
            retorno.Add("Rodrigo");
            retorno.Add("Mãe");
            return retorno.OrderByDescending(nome => nome).ToList();
        }
        public List<double> Potencia(double numero, double Potencia)
        {
            var retorno = new List<double>();
            for (double i = 1; i <= Potencia; i++)
            {
                retorno.Add(Math.Pow(numero, i));
            }
            return retorno;
        }
        public List<int[]> Bidimensional()
        {
            var retorno = new List<int[]>();
            retorno.Add(new int[2]);
            retorno[0][0] = 1;
            retorno[0][1] = 2;
            retorno.Add(new int[2]);
            retorno[1][0] = 3;
            retorno[1][1] = 4;
            return retorno;
        }
        public List<string> Listadenomes(string nome)
        {
            var retorno = new List<string>();
            retorno.Add(nome);
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
            retorno = retorno.OrderBy(nome => nome).ToList();
            return retorno;
        }
        public string Desafio(string valor){
            var Palavrasemespaco = valor;
            var Totaldeletras = Palavrasemespaco.Length;
            return "Sua palavra tem: " + Totaldeletras + " letras";
        }
    }
}
//stackover flow
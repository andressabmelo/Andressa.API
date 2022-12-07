using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IArrayBLL
    {
        string[] Arraynomes();
        List<string> Listarnomes();
        List<double> Potencia(double numero, double Potencia);
        List<int[]> Bidimensional();
        List<string> Listadenomes(string nome);
        string Desafio(string valor);
    }
}
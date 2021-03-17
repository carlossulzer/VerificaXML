using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerificaXML
{
    public class PastasDOM
    {


        public PastasDOM(int codigo, string nome, string pasta, string existe, string filial)
        {
            CodigoFilial = codigo;
            NomeFilial = nome;
            Pasta = pasta;
            Existe = existe;
            Filial = filial;
        }

        public int CodigoFilial { get; set; }
        public string NomeFilial { get; set; }
        public string Pasta { get; set; }
        public string Existe { get; set; }
        public string Filial { get; set; }
    }
}

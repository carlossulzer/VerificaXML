using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace VerificaXML
{
    class PastasDAO
    {

        public DataSet CarregarPastas()
        {
            DataSet dsPastas;
            StringBuilder sql = new StringBuilder();

            sql.Append(" SELECT ");
            sql.Append("    FILIAL.COD_FILIAL, FILIAL.FIL_RAZAO, PARAM_CONF_NFE.PASTA_DESTINO ");
            sql.Append(" FROM ");
            sql.Append("    PARAM_CONF_NFE ");
            sql.Append("    , FILIAL ");
            sql.Append(" WHERE ");
            sql.Append("    PARAM_CONF_NFE.COD_FILIAL (+) = FILIAL.COD_FILIAL ");
            sql.Append("    and	TO_NUMBER(FIL_CGC) <> 0 ");
            sql.Append(@"    and pasta_destino like '\\192.168.0.4%XML' ");
            sql.Append(" ORDER BY 1 ");

            BancodeDados dados = new BancodeDados();
            dsPastas = dados.MontaDataSet(sql.ToString(), "pastas");



            return dsPastas;
        }

        public List<PastasDOM> CarregarPastasList(string mes, string ano)
        {
            int codigoFilial = 0;
            string filial = string.Empty;
            string nomeFilial = string.Empty;
            string pasta = string.Empty;
            string existe = string.Empty;
            string pasta2 = string.Empty;
            int cont = 0;
            int contBarras = 0;
            bool verdadeiro = true;

            List<PastasDOM> pastasLista = new List<PastasDOM>();

            DataSet pastas = CarregarPastas();

            foreach (DataRow pastaSelecionada in pastas.Tables[0].Rows)
            {
                codigoFilial = Convert.ToInt16(pastaSelecionada[0].ToString());
                nomeFilial = pastaSelecionada[1].ToString().ToUpper();
                pasta = pastaSelecionada[2].ToString().ToUpper();
                filial = Convert.ToInt16(pastaSelecionada[0].ToString()).ToString("00 - ") + pastaSelecionada[1].ToString().ToUpper();

                string[] words = pasta.Split(new string[] { "\\" }, StringSplitOptions.None);


                cont = words.GetLength(0)-1;
                while (cont >= 0 && verdadeiro)
                {
                    if (!words[cont].Trim().Equals(string.Empty))
                    {
                        pasta2 = words[cont];
                        contBarras++;
                        verdadeiro = (contBarras == 3) ? false : true;
                    }
                    cont--;
                }

                pasta = pasta.Substring(0, pasta.LastIndexOf(pasta2) - 1) + "\\" + ano + "\\" + mes + "\\XML";

                if (Directory.Exists(pasta))
                    existe = "Sim";
                else
                    existe = "Não";
                
                pastasLista.Add(new PastasDOM(codigoFilial, nomeFilial, pasta, existe, filial));

            }
            return pastasLista;

        }

    }
}

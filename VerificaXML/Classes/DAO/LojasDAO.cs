using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace VerificaXML
{
    public class LojasDAO
    {

        public DataSet CarregarLojas()
        {
            DataSet dsLojas;
            StringBuilder sql = new StringBuilder();

            sql.Append(" select ");
            sql.Append("    cod_filial");
            sql.Append("    , fil_razao");
            sql.Append(" from ");
            sql.Append("    filial ");
            sql.Append(" where ");
            sql.Append("    fil_cgc <> '00000000000000' ");
            sql.Append(" order by 1 "); 

            BancodeDados dados = new BancodeDados();
            dsLojas = dados.MontaDataSet(sql.ToString(), "filial");

            return dsLojas;
        }


        public void CarregarDropDownLojas(ref CheckedListBox clbxLojas)
        {
            DataSet lojas = CarregarLojas();

            foreach (DataRow lojaSelecionada in lojas.Tables[0].Rows)
            {
                clbxLojas.Items.Add(String.Format(@"{0:00}", lojaSelecionada[0]) + " - " + lojaSelecionada[1].ToString());
            }
        }
    }
}

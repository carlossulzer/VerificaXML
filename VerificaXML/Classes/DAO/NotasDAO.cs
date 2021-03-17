using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace VerificaXML
{
    public class NotasDAO
    {

        public DataSet CarregarNotas(string tipos, string lojas, int mes, int ano)
        {
            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 01);

            DateTime ultimoDiaDoMes = primeiroDiaDoMes.AddMonths(1).AddDays(-1);

            DataSet dsNotas;
            StringBuilder sql = new StringBuilder();

            sql.Append(" select ");
            sql.Append("    to_char(filial.cod_filial, '00')||' - '||filial.fil_razao as filial ");
            sql.Append("    , documento.data_movto as data ");
            sql.Append("    , documento.sr_nota_fiscal as serie ");
            sql.Append("    , documento.no_nota_fiscal as nota ");
            sql.Append("    , upper(pck_restituicao_icms.fcn_tipo_doc(documento.tipo_doc)) as tipo ");
            sql.Append("    , substr(documento.chave_nfe, -44) as chave ");
            sql.Append("    , 'NÃO' as xmlExiste ");
            sql.Append("    , (rownum - 1) as linha");
            sql.Append(" from ");
            sql.Append("    documento, filial ");
            sql.Append(" where ");

            sql.Append(" documento.cod_empresa = filial.cod_empresa ");
            sql.Append(" and documento.cod_filial = filial.cod_filial ");
            sql.Append(" and documento.cod_empresa = 1 "); 

            if (!lojas.Equals(string.Empty))
                sql.Append("     and documento.cod_filial in (" + lojas + ")");

            if (!tipos.Equals(string.Empty))
                sql.Append("     and documento.tipo_doc in (" + tipos + ")");


            sql.Append("     and documento.data_movto >= to_date('" + primeiroDiaDoMes.ToString("yyyy-MM-dd") + "' , 'yyyy-mm-dd')");
            sql.Append("     and documento.data_movto <= to_date('" + ultimoDiaDoMes.ToString("yyyy-MM-dd") + "' , 'yyyy-mm-dd')");
            sql.Append("     and documento.chave_nfe is not null ");
            sql.Append("     and documento.status = 'OK' ");
            sql.Append(" order by filial.cod_filial, documento.data_movto ");

            BancodeDados dados = new BancodeDados();
            dsNotas = dados.MontaDataSet(sql.ToString(), "documento");



            return dsNotas;
        }

    }
}

using System;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace VerificaXML
{
    public class BancodeDados 
    {
        string cString;
        OracleConnection cn;
        OracleCommand cmd;
        OracleDataAdapter da;
        OracleDataReader dr;
        DataSet ds = new DataSet();

        public string TipoBanco
        {
            get 
            {
                return ConfigurationManager.AppSettings["banco"].ToUpper();
            }
        }


        public BancodeDados()
        {
            cString = ConfigurationManager.AppSettings["conexaoOracle"];
        }

        // Gera uma conexão conforme especificado no web.config
        public OracleConnection AbrirConexao()
        {
            if (cn == null)
                cn = new OracleConnection(cString);

            if (cn.State.Equals(ConnectionState.Closed) || (cn.State == ConnectionState.Connecting))
                cn.Open();

            return cn;
        }


        public void FecharConexao()
        {
            if (cn.State.Equals(ConnectionState.Open))
                cn.Close();
        }


        // Criação de todos os objetos de banco para um acesso simples e os interliga
        public void CriarCommand(string sql)
        {
            cn = AbrirConexao();
            cmd = new OracleCommand(sql, cn);
        }

        // Devolve o objeto de conexão armazenado nesta instância
        public OracleConnection conexao
        {
            get 
            { 
                return (cn); 
            }
        }

        // Devolve o objeto command armazenado nesta instância
        public IDbCommand command
        {
            get 
            { 
                return (cmd); 
            }
        }

        // Devolve o objeto adapter armazenado nesta instância
		public DbDataAdapter DataAdapter
        {
            get 
            {
                return ((OracleDataAdapter)da); 
            }
        }

        // Devolve o objeto DataRedaer armazenado nesta instância
        public OracleDataReader DataReader
        {
            get 
            { 
                return (dr); 
            }
        }

        // Cria um DataSet Genérico
        public DataSet MontaDataSet(string sql, string nomedaTabela)
        {
            try
            {
                AbrirConexao();
                da = new OracleDataAdapter(sql, (OracleConnection)cn);
                da.Fill(ds); 
                return ds;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Erro ao tentar obter dados."+e.Message.ToString()); 
            }
        }

		// Cria um DataSet Genérico
		public DataTable MontaDataTable(string sql)
		{
			try
			{
				AbrirConexao();
				DataSet dt = new DataSet();
  			    da = new OracleDataAdapter(sql, (OracleConnection)cn);
    			da.Fill(dt);
				return dt.Tables[0];
			}
			catch (Exception e)
			{
				throw new ApplicationException("Erro ao tentar obter dados."+e.Message.ToString()); 
			}
		}


        public IDataReader MontaDataReader(string Sql)
        {
            CriarCommand(Sql);
            dr = cmd.ExecuteReader();
            return dr;
        }

        private object ObterValor(string sql)
        {
            CriarCommand(sql);
            object retorno = cmd.ExecuteScalar();
            if (retorno == null)
                retorno = String.Empty;

            return retorno;
        }


        public int ObterValorInteiro(string sql)
        {
            return Convert.ToInt32("0" + ObterValor(sql));
        }

        public decimal ObterValorDecimal(string sql)
        {
            return Convert.ToDecimal("0" + ObterValor(sql));
        }

        public string ObterValorString(string sql)
        {
            return ObterValor(sql).ToString();
        }

        public int IncluirRegistro(string sql)
        {
            return ObterValorInteiro(sql);
        }


        public void ExecutarNonQuery(string sql)
        {
			CriarCommand(sql);
            cmd.ExecuteNonQuery();
        }

    }
}
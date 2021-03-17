using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace VerificaXML
{
    public partial class Form1 : Form
    {
        DataSet dsNotas = null;
        public Form1()
        {
            InitializeComponent();
            CarregarTipoNota();
            CarregarLojas();
            CarregarMes();
            CarregarAno();
            ObterPastas();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            LerArquivos();
        }

        private void LerArquivos()
        {
            try
            {
                string chave = string.Empty;
                string arquivoNome = string.Empty;
                string arquivoExtensao = string.Empty;
                string destino = string.Empty;
                string pasta = string.Empty;
                string pastaDestino = string.Empty;
                string supportedExtensions = "*.xml";

                // percorre as lojas selecionada no CheckedListBox
                for (int i = 0; i < clbxLojas.CheckedItems.Count; i++)
                {
                    // obtem o nome da pasta aonde estão os arquivos xml da filial, referente ao mes/ano selecionado
                    pasta = ProcurarPastaGrid(clbxLojas.CheckedItems[i].ToString());

                    // exclui arquivo anteriores existentes na pasta de destino (pasta que será usada para guardar os arquivos xmls encontrados)
                    pastaDestino = pasta + "\\encontrado\\";
                    if (Directory.Exists(pastaDestino))
                    {
                        foreach (string arquivo in Directory.GetFiles(pastaDestino, "*.*", SearchOption.TopDirectoryOnly))
                            File.Delete(arquivo);
                    }
                    else
                    {
                        Directory.CreateDirectory(pastaDestino);
                    }

                    // Carregar arquivos xml existentes na pasta referente ao mês/ano selecionado
                    lbxNotas.Items.Clear();
                    foreach (string arquivo in Directory.GetFiles(pasta, "*.*", SearchOption.TopDirectoryOnly).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                    {
                        lbxNotas.Items.Add(arquivo);
                    }

                    string nome = string.Empty;
                    string item = string.Empty;
                    int contXML = 0;

                    // Percorre os arquivos xml carregados no listbox
                    while ((contXML < lbxNotas.Items.Count)) 
                    {
                        item = lbxNotas.Items[contXML].ToString();
                        XmlDocument soapDocument = new XmlDocument();
                        soapDocument.Load(item);
                        string xml = soapDocument.InnerXml;

                        if (xml.LastIndexOf("Id=\"NFe") > 0)
                        {
                            chave = xml.Substring(xml.LastIndexOf("Id=\"NFe") + 7, 44);

                            if (chave.Equals("32131227340074000123550010001064631001064634"))
                            {
                                MessageBox.Show("Achou a chave");
                            }

                            if (!chave.Equals(string.Empty))
                            {
                                ConsultaChaveGridNota(chave);
                                arquivoNome = Path.GetFileName(item);
                                destino = pastaDestino + arquivoNome;
                                File.Copy(item, destino);
                            }
                        }
                        this.Update();
                        contXML++;
                    } 

                }
            }
            catch (Exception ex)
            {
                //Log.Gravar(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());
            }


        }

       
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCarregarNotas_Click(object sender, EventArgs e)
        {
            FormatarGridView();

            string tipos = SelecionarTiposdeNotas();
            string lojas = SelecionarLojas();
            int mes = ObterMes();
            int ano = (int)nudAno.Value;


            NotasDAO notas = new NotasDAO();
            dsNotas = notas.CarregarNotas(tipos, lojas, mes, ano);
            dgvNotas.DataSource = dsNotas.Tables[0];
        }


        private void FormatarGridView()
        {
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.AllowUserToResizeColumns = false;
            dgvNotas.AllowUserToResizeRows = false;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNotas.AutoGenerateColumns = false;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvNotas.RowHeadersVisible = false;
            //dgvNotas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void CarregarTipoNota()
        {
            clbxTipoNota.Items.AddRange(new object[] { "1 - Venda", 
                                                       "2 - Compra", 
                                                       "3 - Dev.Venda", 
                                                       "4 - Dev.Compra", 
                                                       "5 - Transf. Saída", 
                                                       "6 - Transf. Entrada", 
                                                       "7 - Acerto", 
                                                       "8 - Garantia / Análise" });

        }


        public void CarregarLojas()
        {
            LojasDAO lojasDAO = new LojasDAO();
            lojasDAO.CarregarDropDownLojas(ref clbxLojas);
        }


        public void CarregarAno()
        {
            nudAno.Minimum = 1950;
            nudAno.Maximum = 2050;
            nudAno.Value = DateTime.Now.Year;
        
        }

        public void CarregarMes()
        {
            int mes = DateTime.Now.Month - 1;

            string[] meses = new string[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            cbxMes.Text = meses[mes];
        
        }

        public int ObterMes()
        {
            string[] meses = new string[12] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            return Array.IndexOf(meses, cbxMes.Text) + 1;
        }

        public string SelecionarTiposdeNotas()
        {
            string tipo = string.Empty;
            for (int i = 0; i < clbxTipoNota.CheckedItems.Count; i++)
			    tipo += clbxTipoNota.CheckedItems[i].ToString().Substring(0, 1)+","; 

            if (!tipo.Equals(string.Empty))
                tipo = tipo.Substring(0, tipo.LastIndexOf(","));
            return tipo;        
        }


        public string SelecionarLojas()
        {
            string lojas = string.Empty;
            for (int i = 0; i < clbxLojas.CheckedItems.Count; i++)
            {
                lojas += clbxLojas.CheckedItems[i].ToString().Substring(0, 2) + ",";
            }

            if (!lojas.Equals(string.Empty))
                lojas = lojas.Substring(0, lojas.LastIndexOf(","));

            return lojas;
        }

        public void ObterPastas()
        {
            int mes = ObterMes();
            PastasDAO pastaDAO = new PastasDAO();
            dgvPastas.DataSource = pastaDAO.CarregarPastasList(mes.ToString("00-") + cbxMes.Text, nudAno.Value.ToString());
        }

        public string ProcurarPastaGrid(string filial)
        {
            string pasta = string.Empty;

            for (int Count = 0; Count < dgvPastas.Rows.Count; Count++)
            {

                if (dgvPastas.Rows[Count].Cells["cod_desc_filial"].Value.ToString().Trim().Equals(filial.Trim()))
                {
                    pasta = dgvPastas.Rows[Count].Cells["pasta"].Value.ToString();
                }

            }
            return pasta;
        
        }

        
        public void ConsultaChaveGridNota(string chave)
        {
            int linha = 0;

            DataRow[] foundRows;
            foundRows = dsNotas.Tables[0].Select("chave = '" + chave.Trim() + "'");

            if (foundRows.Length > 0)
            {
                linha = Convert.ToInt32(foundRows[0].ItemArray[7]);
                dgvNotas.Rows[linha].Cells["xmlExiste"].Value = "SIM";
            }
        }

        

    }
}


/*
select data_movto, sr_nota_fiscal, no_nota_fiscal, upper(pck_restituicao_icms.fcn_tipo_doc(tipo_doc)), substr(chave_nfe, -44) 
from documento where cod_empresa =1 and cod_filial = 4 and data_movto = '07-nov-2013' and sr_nota_fiscal = 'E01' and status = 'OK'
*/


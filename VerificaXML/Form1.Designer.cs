namespace VerificaXML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbdXML = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCarregarNotas = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clbxTipoNota = new System.Windows.Forms.CheckedListBox();
            this.lbxNotas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbxLojas = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlExiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPastas = new System.Windows.Forms.DataGridView();
            this.codFilial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFilial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_desc_filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1329, 698);
            this.tabControl1.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCarregarNotas);
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.btnProcessar);
            this.tabPage1.Controls.Add(this.pnlFiltro);
            this.tabPage1.Controls.Add(this.dgvNotas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1321, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCarregarNotas
            // 
            this.btnCarregarNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarNotas.Location = new System.Drawing.Point(461, 627);
            this.btnCarregarNotas.Name = "btnCarregarNotas";
            this.btnCarregarNotas.Size = new System.Drawing.Size(117, 23);
            this.btnCarregarNotas.TabIndex = 55;
            this.btnCarregarNotas.Text = "Carregar Notas";
            this.btnCarregarNotas.UseVisualStyleBackColor = true;
            this.btnCarregarNotas.Click += new System.EventHandler(this.btnCarregarNotas_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(735, 627);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 23);
            this.btnFechar.TabIndex = 51;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(599, 627);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(117, 23);
            this.btnProcessar.TabIndex = 50;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltro.Controls.Add(this.nudAno);
            this.pnlFiltro.Controls.Add(this.cbxMes);
            this.pnlFiltro.Controls.Add(this.label5);
            this.pnlFiltro.Controls.Add(this.clbxTipoNota);
            this.pnlFiltro.Controls.Add(this.lbxNotas);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.clbxLojas);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Location = new System.Drawing.Point(19, 17);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(229, 586);
            this.pnlFiltro.TabIndex = 49;
            // 
            // nudAno
            // 
            this.nudAno.Location = new System.Drawing.Point(40, 34);
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(130, 20);
            this.nudAno.TabIndex = 56;
            // 
            // cbxMes
            // 
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbxMes.Location = new System.Drawing.Point(40, 7);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(130, 21);
            this.cbxMes.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tipo de Nota";
            // 
            // clbxTipoNota
            // 
            this.clbxTipoNota.FormattingEnabled = true;
            this.clbxTipoNota.Location = new System.Drawing.Point(9, 405);
            this.clbxTipoNota.Name = "clbxTipoNota";
            this.clbxTipoNota.Size = new System.Drawing.Size(203, 139);
            this.clbxTipoNota.TabIndex = 52;
            // 
            // lbxNotas
            // 
            this.lbxNotas.FormattingEnabled = true;
            this.lbxNotas.Location = new System.Drawing.Point(146, 385);
            this.lbxNotas.Name = "lbxNotas";
            this.lbxNotas.Size = new System.Drawing.Size(66, 17);
            this.lbxNotas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Lojas";
            // 
            // clbxLojas
            // 
            this.clbxLojas.FormattingEnabled = true;
            this.clbxLojas.Location = new System.Drawing.Point(10, 79);
            this.clbxLojas.Name = "clbxLojas";
            this.clbxLojas.Size = new System.Drawing.Size(203, 304);
            this.clbxLojas.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mês";
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filial,
            this.data,
            this.serie,
            this.nota,
            this.chave,
            this.tipo,
            this.xmlExiste,
            this.linha});
            this.dgvNotas.Location = new System.Drawing.Point(255, 17);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(1041, 583);
            this.dgvNotas.TabIndex = 48;
            // 
            // filial
            // 
            this.filial.DataPropertyName = "filial";
            this.filial.HeaderText = "Filial";
            this.filial.Name = "filial";
            this.filial.Width = 200;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.Width = 80;
            // 
            // serie
            // 
            this.serie.DataPropertyName = "serie";
            this.serie.HeaderText = "Série";
            this.serie.Name = "serie";
            this.serie.Width = 60;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.Width = 60;
            // 
            // chave
            // 
            this.chave.DataPropertyName = "chave";
            this.chave.HeaderText = "Chave";
            this.chave.Name = "chave";
            this.chave.Width = 300;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.Width = 180;
            // 
            // xmlExiste
            // 
            this.xmlExiste.DataPropertyName = "xmlExiste";
            this.xmlExiste.HeaderText = "XML Existe";
            this.xmlExiste.Name = "xmlExiste";
            // 
            // linha
            // 
            this.linha.DataPropertyName = "linha";
            this.linha.HeaderText = "linha";
            this.linha.Name = "linha";
            this.linha.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPastas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1321, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pastas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPastas
            // 
            this.dgvPastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFilial,
            this.NomeFilial,
            this.pasta,
            this.existe,
            this.cod_desc_filial});
            this.dgvPastas.Location = new System.Drawing.Point(9, 18);
            this.dgvPastas.Name = "dgvPastas";
            this.dgvPastas.Size = new System.Drawing.Size(1302, 648);
            this.dgvPastas.TabIndex = 0;
            // 
            // codFilial
            // 
            this.codFilial.DataPropertyName = "CodigoFilial";
            this.codFilial.HeaderText = "Código";
            this.codFilial.Name = "codFilial";
            this.codFilial.Width = 50;
            // 
            // NomeFilial
            // 
            this.NomeFilial.DataPropertyName = "NomeFilial";
            this.NomeFilial.HeaderText = "Nome da Filial";
            this.NomeFilial.Name = "NomeFilial";
            this.NomeFilial.Width = 300;
            // 
            // pasta
            // 
            this.pasta.DataPropertyName = "pasta";
            this.pasta.HeaderText = "Caminho dos arquivos XML da filial";
            this.pasta.Name = "pasta";
            this.pasta.Width = 530;
            // 
            // existe
            // 
            this.existe.DataPropertyName = "existe";
            this.existe.HeaderText = "Pasta Existe";
            this.existe.Name = "existe";
            this.existe.Width = 90;
            // 
            // cod_desc_filial
            // 
            this.cod_desc_filial.DataPropertyName = "filial";
            this.cod_desc_filial.HeaderText = "cod_desc_filial";
            this.cod_desc_filial.Name = "cod_desc_filial";
            this.cod_desc_filial.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 722);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar XML";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdXML;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbxTipoNota;
        private System.Windows.Forms.ListBox lbxNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbxLojas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPastas;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFilial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFilial;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn existe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_desc_filial;
        private System.Windows.Forms.Button btnCarregarNotas;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.DataGridViewTextBoxColumn filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn chave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlExiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn linha;
    }
}


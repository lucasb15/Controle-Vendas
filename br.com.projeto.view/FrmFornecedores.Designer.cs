namespace Controle_Vendas.br.com.projeto.view
{
    partial class FrmFornecedores
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
            panel1 = new Panel();
            label1 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            tabPage2 = new TabPage();
            tabelaFornecedores = new DataGridView();
            btnPesquisar = new Button();
            label16 = new Label();
            txtPesquisa = new TextBox();
            tabPage1 = new TabPage();
            btnBuscar = new Button();
            cbUF = new ComboBox();
            label15 = new Label();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtCidade = new TextBox();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtCEP = new MaskedTextBox();
            label9 = new Label();
            txtCelular = new MaskedTextBox();
            label8 = new Label();
            txtTelefone = new MaskedTextBox();
            label7 = new Label();
            txtCNPJ = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabFornecedores = new TabControl();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFornecedores).BeginInit();
            tabPage1.SuspendLayout();
            tabFornecedores.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 97);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(380, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Fornecedores";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Highlight;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(579, 424);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 45);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Highlight;
            btnExcluir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(465, 424);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 45);
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(351, 424);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 45);
            btnSalvar.TabIndex = 35;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.Highlight;
            btnNovo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(237, 424);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(108, 45);
            btnNovo.TabIndex = 34;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaFornecedores);
            tabPage2.Controls.Add(btnPesquisar);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(txtPesquisa);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(984, 280);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaFornecedores
            // 
            tabelaFornecedores.AllowUserToAddRows = false;
            tabelaFornecedores.AllowUserToDeleteRows = false;
            tabelaFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFornecedores.Location = new Point(9, 54);
            tabelaFornecedores.Name = "tabelaFornecedores";
            tabelaFornecedores.ReadOnly = true;
            tabelaFornecedores.RowHeadersWidth = 51;
            tabelaFornecedores.Size = new Size(967, 200);
            tabelaFornecedores.TabIndex = 33;
            tabelaFornecedores.CellClick += tabelaCliente_CellClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.Highlight;
            btnPesquisar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(461, 6);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(127, 45);
            btnPesquisar.TabIndex = 32;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.Highlight;
            label16.Location = new Point(11, 22);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 1;
            label16.Text = "Nome:";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(75, 17);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(380, 26);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(cbUF);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(txtComplemento);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(txtNumero);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtCelular);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtCNPJ);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 280);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(487, 97);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 31);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbUF
            // 
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbUF.Location = new Point(673, 97);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(66, 28);
            cbUF.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(639, 105);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 28;
            label15.Text = "UF:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(774, 166);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(202, 26);
            txtBairro.TabIndex = 27;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(461, 166);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(246, 26);
            txtComplemento.TabIndex = 25;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(80, 166);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(235, 26);
            txtCidade.TabIndex = 23;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(851, 131);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 26);
            txtNumero.TabIndex = 21;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(430, 131);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(341, 26);
            txtEndereco.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 26);
            txtEmail.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 26);
            txtNome.TabIndex = 5;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(80, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(125, 26);
            txtCodigo.TabIndex = 3;
            txtCodigo.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(716, 172);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 26;
            label14.Text = "Bairro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(340, 172);
            label13.Name = "label13";
            label13.Size = new Size(118, 20);
            label13.TabIndex = 24;
            label13.Text = "Complemento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(9, 172);
            label12.Name = "label12";
            label12.Size = new Size(68, 20);
            label12.TabIndex = 22;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(780, 137);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 20;
            label11.Text = "Número:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(342, 137);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 18;
            label10.Text = "Endereço:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(387, 99);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(86, 26);
            txtCEP.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(342, 105);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 16;
            label9.Text = "CEP:";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(80, 134);
            txtCelular.Mask = "(99) 0 0000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(235, 26);
            txtCelular.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(9, 140);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 14;
            label8.Text = "Celular:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 102);
            txtTelefone.Mask = "(99) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(235, 26);
            txtTelefone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(9, 108);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 12;
            label7.Text = "Telefone:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(552, 38);
            txtCNPJ.Mask = "##.###.###/####-##";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(235, 26);
            txtCNPJ.TabIndex = 9;
            txtCNPJ.MaskInputRejected += txtCNPJ_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(490, 44);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "CNPJ:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(9, 76);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(9, 44);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(9, 12);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // tabFornecedores
            // 
            tabFornecedores.Controls.Add(tabPage1);
            tabFornecedores.Controls.Add(tabPage2);
            tabFornecedores.Location = new Point(0, 105);
            tabFornecedores.Name = "tabFornecedores";
            tabFornecedores.SelectedIndex = 0;
            tabFornecedores.Size = new Size(992, 313);
            tabFornecedores.TabIndex = 2;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 479);
            Controls.Add(btnEditar);
            Controls.Add(tabFornecedores);
            Controls.Add(btnExcluir);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Font = new Font("Century Gothic", 9F);
            Name = "FrmFornecedores";
            Text = "Cadastro de Fornecedores";
            Load += FrmFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFornecedores).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabFornecedores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private TabPage tabPage2;
        private DataGridView tabelaFornecedores;
        private Button btnPesquisar;
        private Label label16;
        private TextBox txtPesquisa;
        private TabPage tabPage1;
        private Button btnBuscar;
        private ComboBox cbUF;
        private Label label15;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private MaskedTextBox txtCEP;
        private Label label9;
        private MaskedTextBox txtCelular;
        private Label label8;
        private MaskedTextBox txtTelefone;
        private Label label7;
        private MaskedTextBox txtCNPJ;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabControl tabFornecedores;
    }
}
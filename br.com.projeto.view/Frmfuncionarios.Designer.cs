namespace Controle_Vendas.br.com.projeto.view
{
    partial class Frmfuncionarios
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
            tabFuncionarios = new TabControl();
            tabPage1 = new TabPage();
            cbNivel = new ComboBox();
            label19 = new Label();
            cbCargo = new ComboBox();
            label18 = new Label();
            txtSenha = new TextBox();
            label17 = new Label();
            btnBuscar = new Button();
            cbUF = new ComboBox();
            label15 = new Label();
            txtBairro = new TextBox();
            label14 = new Label();
            txtComplemento = new TextBox();
            label13 = new Label();
            txtCidade = new TextBox();
            label12 = new Label();
            txtNumero = new TextBox();
            label11 = new Label();
            txtEndereco = new TextBox();
            label10 = new Label();
            txtCEP = new MaskedTextBox();
            label9 = new Label();
            txtCelular = new MaskedTextBox();
            label8 = new Label();
            txtTelefone = new MaskedTextBox();
            label7 = new Label();
            txtCPF = new MaskedTextBox();
            label6 = new Label();
            txtRG = new MaskedTextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            tabelaFuncionario = new DataGridView();
            btnPesquisar = new Button();
            label16 = new Label();
            txtPesquisa = new TextBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            panel1.SuspendLayout();
            tabFuncionarios.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 97);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(355, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            // 
            // tabFuncionarios
            // 
            tabFuncionarios.Controls.Add(tabPage1);
            tabFuncionarios.Controls.Add(tabPage2);
            tabFuncionarios.Location = new Point(4, 103);
            tabFuncionarios.Name = "tabFuncionarios";
            tabFuncionarios.SelectedIndex = 0;
            tabFuncionarios.Size = new Size(992, 313);
            tabFuncionarios.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbNivel);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(cbCargo);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(txtSenha);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(cbUF);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtComplemento);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtNumero);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtCelular);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtRG);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 280);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbNivel
            // 
            cbNivel.FormattingEnabled = true;
            cbNivel.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cbNivel.Location = new Point(639, 209);
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(145, 28);
            cbNivel.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.Highlight;
            label19.Location = new Point(583, 215);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 39;
            label19.Text = "Nivel:";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Gerente", "Vendedor", "Estágiario" });
            cbCargo.Location = new Point(408, 209);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(145, 28);
            cbCargo.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.Highlight;
            label18.Location = new Point(342, 218);
            label18.Name = "label18";
            label18.Size = new Size(60, 20);
            label18.TabIndex = 37;
            label18.Text = "Cargo:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(80, 209);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(235, 26);
            txtSenha.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.Highlight;
            label17.Location = new Point(9, 215);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 35;
            label17.Text = "Senha:";
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
            // txtComplemento
            // 
            txtComplemento.Location = new Point(461, 166);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(246, 26);
            txtComplemento.TabIndex = 25;
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
            // txtCidade
            // 
            txtCidade.Location = new Point(80, 166);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(235, 26);
            txtCidade.TabIndex = 23;
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
            // txtNumero
            // 
            txtNumero.Location = new Point(851, 131);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 26);
            txtNumero.TabIndex = 21;
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
            // txtEndereco
            // 
            txtEndereco.Location = new Point(430, 131);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(341, 26);
            txtEndereco.TabIndex = 19;
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
            // txtCPF
            // 
            txtCPF.Location = new Point(551, 67);
            txtCPF.Mask = "###.###.###-##";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(235, 26);
            txtCPF.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(490, 76);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 10;
            label6.Text = "CPF:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(551, 38);
            txtRG.Mask = "##.###.###-##";
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(235, 26);
            txtRG.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(490, 44);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 8;
            label5.Text = "RG:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(382, 26);
            txtEmail.TabIndex = 7;
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
            // txtNome
            // 
            txtNome.Location = new Point(80, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 26);
            txtNome.TabIndex = 5;
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
            // txtCodigo
            // 
            txtCodigo.Location = new Point(80, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(125, 26);
            txtCodigo.TabIndex = 3;
            txtCodigo.TabStop = false;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaFuncionario);
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
            // tabelaFuncionario
            // 
            tabelaFuncionario.AllowUserToAddRows = false;
            tabelaFuncionario.AllowUserToDeleteRows = false;
            tabelaFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaFuncionario.Location = new Point(9, 54);
            tabelaFuncionario.Name = "tabelaFuncionario";
            tabelaFuncionario.ReadOnly = true;
            tabelaFuncionario.RowHeadersWidth = 51;
            tabelaFuncionario.Size = new Size(967, 200);
            tabelaFuncionario.TabIndex = 33;
            tabelaFuncionario.CellClick += tabelaFuncionario_CellClick;
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
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Highlight;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(583, 432);
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
            btnExcluir.Location = new Point(469, 432);
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
            btnSalvar.Location = new Point(355, 432);
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
            btnNovo.Location = new Point(241, 432);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(108, 45);
            btnNovo.TabIndex = 34;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // Frmfuncionarios
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 489);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(tabFuncionarios);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F);
            Name = "Frmfuncionarios";
            Text = "Cadastro de Funcionários";
            Load += Frmfuncionarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabFuncionarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaFuncionario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabFuncionarios;
        private TabPage tabPage1;
        private Button btnBuscar;
        private ComboBox cbUF;
        private Label label15;
        private TextBox txtBairro;
        private Label label14;
        private TextBox txtComplemento;
        private Label label13;
        private TextBox txtCidade;
        private Label label12;
        private TextBox txtNumero;
        private Label label11;
        private TextBox txtEndereco;
        private Label label10;
        private MaskedTextBox txtCEP;
        private Label label9;
        private MaskedTextBox txtCelular;
        private Label label8;
        private MaskedTextBox txtTelefone;
        private Label label7;
        private MaskedTextBox txtCPF;
        private Label label6;
        private MaskedTextBox txtRG;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private TabPage tabPage2;
        private DataGridView tabelaFuncionario;
        private Button btnPesquisar;
        private Label label16;
        private TextBox txtPesquisa;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private ComboBox cbNivel;
        private Label label19;
        private ComboBox cbCargo;
        private Label label18;
        private TextBox txtSenha;
        private Label label17;
    }
}
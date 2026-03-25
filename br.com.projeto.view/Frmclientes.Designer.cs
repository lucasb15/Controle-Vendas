
namespace Controle_Vendas.br.com.projeto.view
{
    partial class Frmclientes
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
            tabClientes = new TabControl();
            tabPage1 = new TabPage();
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
            tabelaCliente = new DataGridView();
            btnPesquisar = new Button();
            label16 = new Label();
            txtPesquisa = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            tabClientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(305, 34);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // tabClientes
            // 
            tabClientes.Controls.Add(tabPage1);
            tabClientes.Controls.Add(tabPage2);
            tabClientes.Location = new Point(0, 103);
            tabClientes.Name = "tabClientes";
            tabClientes.SelectedIndex = 0;
            tabClientes.Size = new Size(992, 313);
            tabClientes.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            tabPage1.Click += tabPage1_Click;
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
            label15.Location = new Point(636, 102);
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
            label14.Location = new Point(713, 169);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 26;
            label14.Text = "Bairro:";
            label14.Click += label14_Click;
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
            label13.Location = new Point(337, 169);
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
            label12.Location = new Point(6, 169);
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
            label11.Location = new Point(777, 134);
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
            label10.Location = new Point(339, 134);
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
            label9.Location = new Point(339, 102);
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
            label8.Location = new Point(6, 137);
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
            label7.Location = new Point(6, 105);
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
            label6.Location = new Point(487, 73);
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
            label5.Location = new Point(487, 41);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 8;
            label5.Text = "RG:";
            label5.Click += label5_Click;
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
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "E-mail:";
            label4.Click += label4_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 26);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            label3.Click += label3_Click;
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
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabelaCliente);
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
            tabPage2.Click += tabPage2_Click;
            // 
            // tabelaCliente
            // 
            tabelaCliente.AllowUserToAddRows = false;
            tabelaCliente.AllowUserToDeleteRows = false;
            tabelaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCliente.Location = new Point(9, 54);
            tabelaCliente.Name = "tabelaCliente";
            tabelaCliente.ReadOnly = true;
            tabelaCliente.RowHeadersWidth = 51;
            tabelaCliente.Size = new Size(967, 200);
            tabelaCliente.TabIndex = 33;
            tabelaCliente.CellClick += tabelaCliente_CellClick;
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
            label16.Location = new Point(8, 19);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 1;
            label16.Text = "Nome:";
            label16.TextAlign = ContentAlignment.TopCenter;
            label16.Click += label16_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(75, 17);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(380, 26);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.KeyPress += txtPesquisa_KeyPress;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.Highlight;
            btnNovo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(221, 422);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(108, 45);
            btnNovo.TabIndex = 30;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += button1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.Highlight;
            btnSalvar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(335, 422);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 45);
            btnSalvar.TabIndex = 31;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Highlight;
            btnExcluir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(449, 422);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 45);
            btnExcluir.TabIndex = 32;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Highlight;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(563, 422);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 45);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // Frmclientes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 479);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(tabClientes);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frmclientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += Frmclientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabClientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).EndInit();
            ResumeLayout(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabClientes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtCEP;
        private Label label9;
        private MaskedTextBox txtCelular;
        private Label label8;
        private MaskedTextBox txtTelefone;
        private Label label7;
        private MaskedTextBox txtCPF;
        private Label label6;
        private MaskedTextBox txtRG;
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
        private ComboBox cbUF;
        private Label label15;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtPesquisa;
        private Label label16;
        private DataGridView tabelaCliente;
        private Button btnPesquisar;
        private Button btnBuscar;
    }
}
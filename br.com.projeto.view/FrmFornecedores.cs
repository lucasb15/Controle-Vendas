using Controle_Vendas.br.com.projeto.dao;
using Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Vendas.br.com.projeto.view
{
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCEP.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";

                System.Net.WebClient web = new System.Net.WebClient();
                string resultado = web.DownloadString(xml);
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.LoadXml(resultado);
                txtEndereco.Text = xmlDoc.GetElementsByTagName("logradouro")[0].InnerText;
                txtBairro.Text = xmlDoc.GetElementsByTagName("bairro")[0].InnerText;
                txtCidade.Text = xmlDoc.GetElementsByTagName("localidade")[0].InnerText;
                cbUF.Text = xmlDoc.GetElementsByTagName("uf")[0].InnerText;
            }
            catch (Exception error)
            {
                MessageBox.Show("Endereço não encontrado, escreva manualmente");
                throw;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helpers.LimparTela(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.Nome = txtNome.Text;
            obj.CNPJ = txtCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbUF.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.AddFornecedor(obj);

            tabelaFornecedores.DataSource = dao.ListarFornecedores();

            Helpers.LimparTela(this);
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = tabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = tabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtCEP.Text = tabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = tabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            cbUF.Text = tabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabFornecedores.SelectedTab = tabPage1;
        }

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedores.DataSource = dao.ListarFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Fornecedor obj = new Fornecedor();

            obj.Codigo = int.Parse(txtCodigo.Text);
            dao.ExcluirFornecedor(obj);

            tabelaFornecedores.DataSource = dao.ListarFornecedores();
            Helpers.LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.Nome = txtNome.Text;
            obj.CNPJ = txtCNPJ.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Cep = txtCEP.Text;
            obj.Endereco = txtEndereco.Text;
            obj.Numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = cbUF.Text;
            obj.Codigo = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedor(obj);

            tabelaFornecedores.DataSource = dao.ListarFornecedores();
            Helpers.LimparTela(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedores.DataSource = dao.ListarFornecedorPorNome(nome);

            if (tabelaFornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado com esse nome!");
                tabelaFornecedores.DataSource = dao.ListarFornecedores();
            }

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            FornecedorDAO dao = new FornecedorDAO();

            if (!string.IsNullOrEmpty(nome))
            {
                tabelaFornecedores.DataSource = dao.ListarFornecedorPorNome(nome);
            }
            else
            {
                tabelaFornecedores.DataSource = dao.ListarFornecedores();
            }
        }
    }
}

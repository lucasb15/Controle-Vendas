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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Nome = txtNome.Text;
            obj.RG = txtRG.Text;
            obj.CPF = txtCPF.Text;
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
            obj.Cargo = cbCargo.Text;
            obj.Senha = txtSenha.Text;
            obj.NivelAcesso = cbNivel.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AddFuncionario(obj);
            MessageBox.Show("Funcionário cadastrado com sucesso!");

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

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.ListarFuncionarios(tabelaFuncionario);
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRG.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCEP.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUF.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionarios.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(obj);

            tabelaFuncionario.DataSource = dao.ListarFuncionarios(tabelaFuncionario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Nome = txtNome.Text;
            obj.RG = txtRG.Text;
            obj.CPF = txtCPF.Text;
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
            obj.Cargo = cbCargo.Text;
            obj.Senha = txtSenha.Text;
            obj.NivelAcesso = cbNivel.Text;
            obj.Codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.ListarFuncionarios(tabelaFuncionario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            if (!string.IsNullOrEmpty(nome))
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                tabelaFuncionario.DataSource = dao.BuscarFuncionariosPorNome(nome);
            }
            else
            {
                MessageBox.Show("Digite um nome para pesquisar.");
                Frmfuncionarios_Load(sender, e); // Recarrega a lista completa
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            FuncionarioDAO dao = new FuncionarioDAO();

            if (!string.IsNullOrEmpty(nome))
            {
                tabelaFuncionario.DataSource = dao.ListarFuncionariosPorNome(nome);
            }
            else
            {
                tabelaFuncionario.DataSource = dao.ListarFuncionarios(tabelaFuncionario);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helpers.LimparTela(this);
        }
    }
}

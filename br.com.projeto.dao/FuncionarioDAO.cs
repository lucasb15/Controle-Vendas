using Controle_Vendas.br.com.projeto.conexao;
using Controle_Vendas.br.com.projeto.model;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Controle_Vendas.br.com.projeto.dao;

public class FuncionarioDAO
{
    #region Cadastrar Funcionario
    public void AddFuncionario(Funcionario obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, telefone, celular, cep, endereco, numero,
                                                          complemento, bairro, cidade, estado, senha, cargo, nivel_acesso) 
                               VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado,@senha, @cargo, @nivel_acesso)";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", obj.Nome);
                executaCMD.Parameters.AddWithValue("@rg", obj.RG);
                executaCMD.Parameters.AddWithValue("@cpf", obj.CPF);
                executaCMD.Parameters.AddWithValue("@email", obj.Email);
                executaCMD.Parameters.AddWithValue("@telefone", obj.Telefone);
                executaCMD.Parameters.AddWithValue("@celular", obj.Celular);
                executaCMD.Parameters.AddWithValue("@cep", obj.Cep);
                executaCMD.Parameters.AddWithValue("@endereco", obj.Endereco);
                executaCMD.Parameters.AddWithValue("@numero", obj.Numero);
                executaCMD.Parameters.AddWithValue("@complemento", obj.Complemento);
                executaCMD.Parameters.AddWithValue("@bairro", obj.Bairro);
                executaCMD.Parameters.AddWithValue("@cidade", obj.Cidade);
                executaCMD.Parameters.AddWithValue("@estado", obj.Estado);
                executaCMD.Parameters.AddWithValue("@senha", obj.Senha);
                executaCMD.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaCMD.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);

                conexao.Open();
                executaCMD.ExecuteNonQuery();

            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Alterar Funcionario
    public void AlterarFuncionario(Funcionario obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"UPDATE tb_funcionarios SET nome = @nome, rg = @rg, cpf = @cpf, email = @email, telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, numero = @numero,
                               complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, senha = @senha, cargo = @cargo, nivel_acesso = @nivel_acesso
                               WHERE id = @id";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", obj.Nome);
                executaCMD.Parameters.AddWithValue("@rg", obj.RG);
                executaCMD.Parameters.AddWithValue("@cpf", obj.CPF);
                executaCMD.Parameters.AddWithValue("@email", obj.Email);
                executaCMD.Parameters.AddWithValue("@telefone", obj.Telefone);
                executaCMD.Parameters.AddWithValue("@celular", obj.Celular);
                executaCMD.Parameters.AddWithValue("@cep", obj.Cep);
                executaCMD.Parameters.AddWithValue("@endereco", obj.Endereco);
                executaCMD.Parameters.AddWithValue("@numero", obj.Numero);
                executaCMD.Parameters.AddWithValue("@complemento", obj.Complemento);
                executaCMD.Parameters.AddWithValue("@bairro", obj.Bairro);
                executaCMD.Parameters.AddWithValue("@cidade", obj.Cidade);
                executaCMD.Parameters.AddWithValue("@estado", obj.Estado);
                executaCMD.Parameters.AddWithValue("@senha", obj.Senha);
                executaCMD.Parameters.AddWithValue("@cargo", obj.Cargo);
                executaCMD.Parameters.AddWithValue("@nivel_acesso", obj.NivelAcesso);
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                int linhasAfetadas = executaCMD.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário foi alterado.");
                }
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Excluir Funcionario
    public void ExcluirFuncionario(Funcionario obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"DELETE FROM tb_funcionarios
                               WHERE id = @id";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                int linhasAfetadas = executaCMD.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Funcionário deletado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário foi deletado.");
                }
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Listar Funcionarios
    public DataTable ListarFuncionarios(DataGridView dataGridView)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                SqlDataAdapter da = new SqlDataAdapter(executaCMD);
                da.Fill(tabelaFuncionario);
                return tabelaFuncionario;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Buscar Funcionarios por nome
    public DataTable BuscarFuncionariosPorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios WHERE nome = @nome";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", Nome);
                SqlDataAdapter da = new SqlDataAdapter(executaCMD);
                da.Fill(tabelaFuncionario);
                return tabelaFuncionario;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Listar Funcionarios por nome LIKE
    public DataTable ListarFuncionariosPorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios WHERE nome LIKE @nome";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", "%" + Nome + "%");
                SqlDataAdapter da = new SqlDataAdapter(executaCMD);
                da.Fill(tabelaFuncionario);
                return tabelaFuncionario;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion
}

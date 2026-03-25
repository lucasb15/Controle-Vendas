using Controle_Vendas.br.com.projeto.conexao;
using Controle_Vendas.br.com.projeto.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Vendas.br.com.projeto.dao;

public class FornecedorDAO
{
    #region Cadastrar Fornecedor
    public void AddFornecedor(Fornecedor obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                // Criando o comando SQL para inserir um novo cliente
                string sql = @"INSERT INTO tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                        VALUES (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";


                // Criando o objeto SqlCommand para executar o comando SQL
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", obj.Nome);
                executaCMD.Parameters.AddWithValue("@cnpj", obj.CNPJ);
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

                // Abrindo a conexão, executando o comando e fechando a conexão
                conexao.Open();
                executaCMD.ExecuteNonQuery();


                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Listar Fornecedores
    public DataTable ListarFornecedores()
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"SELECT * FROM tb_fornecedores";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);

                conexao.Open();
                SqlDataReader reader = executaCMD.ExecuteReader();

                tabelaFornecedor.Load(reader);
                return tabelaFornecedor;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);

            throw;
        }
    }
    #endregion

    #region Buscar Fornecedor por Nome
    public DataTable BuscarFornecedorPorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"SELECT * FROM tb_fornecedores WHERE nome = @Nome";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@Nome", Nome);

                conexao.Open();
                SqlDataReader reader = executaCMD.ExecuteReader();

                tabelaFornecedor.Load(reader);
                return tabelaFornecedor;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);

            throw;
        }
    }
    #endregion

    #region Alterar Fornecedor
    public void AlterarFornecedor(Fornecedor obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"UPDATE tb_fornecedores SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id = @id";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", obj.Nome);
                executaCMD.Parameters.AddWithValue("@cnpj", obj.CNPJ);
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
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                executaCMD.ExecuteNonQuery();
                MessageBox.Show("Fornecedor alterado com sucesso!");
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Excluir Fornecedor
    public void ExcluirFornecedor(Fornecedor obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"DELETE FROM tb_fornecedores WHERE id = @id";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);
                conexao.Open();
                executaCMD.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Listar Fornecedor por nome LIKE
    public DataTable ListarFornecedorPorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "SELECT * FROM tb_fornecedores WHERE nome LIKE @nome";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome", "%" + Nome + "%");
                SqlDataAdapter da = new SqlDataAdapter(executaCMD);
                da.Fill(tabelaFornecedor);
                return tabelaFornecedor;
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
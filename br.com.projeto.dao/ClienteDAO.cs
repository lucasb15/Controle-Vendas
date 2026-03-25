using Controle_Vendas.br.com.projeto.conexao;
using Controle_Vendas.br.com.projeto.model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Controle_Vendas.br.com.projeto.dao;

public class ClienteDAO
{
    #region Cadastrar Cliente
    public void AddCliente(Cliente obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                // Criando o comando SQL para inserir um novo cliente
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                        VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";


                // Criando o objeto SqlCommand para executar o comando SQL
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

                // Abrindo a conexão, executando o comando e fechando a conexão
                conexao.Open();
                executaCMD.ExecuteNonQuery();


                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Listar Clientes
    public DataTable ListarClientes()
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaCliente = new DataTable();
                string sql = @"SELECT * FROM tb_clientes";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);

                conexao.Open();
                SqlDataReader reader = executaCMD.ExecuteReader();

                tabelaCliente.Load(reader);
                return tabelaCliente;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);

            throw;
        }
    }
    #endregion

    #region Buscar Clientes por Nome
    public DataTable BuscarClientePorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaCliente = new DataTable();
                string sql = @"SELECT * FROM tb_clientes WHERE nome = @Nome";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@Nome", Nome);

                conexao.Open();
                SqlDataReader reader = executaCMD.ExecuteReader();

                tabelaCliente.Load(reader);
                return tabelaCliente;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);

            throw;
        }
    }
    #endregion

    #region Listar Clientes por Nome
    public DataTable ListarClientePorNome(string Nome)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                DataTable tabelaCliente = new DataTable();
                string sql = @"SELECT * FROM tb_clientes WHERE nome LIKE @Nome";

                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@Nome", Nome);

                conexao.Open();
                SqlDataReader reader = executaCMD.ExecuteReader();

                tabelaCliente.Load(reader);
                return tabelaCliente;
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);

            throw;
        }
    }
    #endregion

    #region Alterar Cliente
    public void AlterarCliente(Cliente obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"UPDATE tb_clientes SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id = @id";
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
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);

                conexao.Open();
                executaCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso!");
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Aconteceu um erro: " + erro.Message);
            throw;
        }
    }
    #endregion

    #region Excluir Cliente
    public void ExcluirCliente(Cliente obj)
    {
        try
        {
            using (SqlConnection conexao = new ConnectionFactory().GetConnection())
            {
                string sql = @"DELETE FROM tb_clientes WHERE id = @id";
                SqlCommand executaCMD = new SqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@id", obj.Codigo);
                conexao.Open();
                executaCMD.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso!");
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

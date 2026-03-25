using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Vendas.br.com.projeto.model;

public class Funcionario : Cliente
{
    public string Cargo { get; set; }
    public string Senha { get; set; }
    public string NivelAcesso { get; set; }
}

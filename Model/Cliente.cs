using System.ComponentModel.DataAnnotations;

namespace atividadeAvaliativaModulo6.Model
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
    }
}
namespace SistemaContratos.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Data_criacao { get; set; }
        public string Data_exclusao { get; set; }

        // Construtor de usuarios
        public UsuariosModel(int id, int cpf, string nome, string email, string dataCriacao, string dataExclusao)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            Data_criacao = dataCriacao;
            Data_exclusao = dataExclusao;
        }
    }
}

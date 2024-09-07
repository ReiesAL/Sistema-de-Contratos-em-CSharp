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
    }
}

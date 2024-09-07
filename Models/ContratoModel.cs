namespace SistemaContratos.Models
{
    public class ContratoModel
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public int Contrato { get; set; }
        public string Nome { get; set; }
        public string Produto { get; set; }
        public float Valor { get; set; }
        public string Vencimento { get; set; }
        public string Data_inclusao { get; set; }
        public string Usuario_cpf { get; set; }
    }
}

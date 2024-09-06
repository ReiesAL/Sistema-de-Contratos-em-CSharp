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

        // Construtor de contratos
        public ContratoModel(int id, int cpf, int contrato, string nome, string produto, float valor, string vencimento, string dataInclusao, string usuarioCpf)
        {
            Id = id;
            Cpf = cpf;
            Contrato = contrato;
            Nome = nome;
            Produto = produto;
            Valor = valor;
            Vencimento = vencimento;
            Data_inclusao = dataInclusao;
            Usuario_cpf = usuarioCpf;
        }

    }
}

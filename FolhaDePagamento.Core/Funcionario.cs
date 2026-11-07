namespace FolhaDePagamento.Core
{

    
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        private decimal _salarioBase;


        public decimal SalarioBase => _salarioBase;


        public Funcionario(string nome, decimal salarioBase)
        {

            if (salarioBase < 0)
            {
                throw new ArgumentException("O salário base não pode ser negativo.");
            }

            _salarioBase = salarioBase;
            Nome = nome;
        }

        public abstract decimal CalcularSalario();
    }
}
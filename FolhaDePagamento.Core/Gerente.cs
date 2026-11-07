namespace FolhaDePagamento.Core
{

    public class Gerente : Funcionario
    {

        public Gerente(string nome, decimal salarioBase) : base(nome, salarioBase)
        {
      
        }

      
        public override decimal CalcularSalario()
        {
   
            decimal bonus = SalarioBase * 0.20m;

            return SalarioBase + bonus;
        }
    }
}
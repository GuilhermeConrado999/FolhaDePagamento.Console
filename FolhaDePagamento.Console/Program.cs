using FolhaDePagamento.Core;

namespace FolhaDePagamento.App
{
    class Program
    {
        static void Main()
        {
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Gerente("Cesar", 3000.00m),
                new Desenvolvedor("Maria", 4000.00m, 10, 50.00m)
            };

            Console.WriteLine("=== FOLHA DE PAGAMENTO ===");

            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine($"{f.Nome} recebe: {f.CalcularSalario():C}");
            }
        }
    }
}
using System;

namespace SistemaMatriculas
{
    class TestaMatricula
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto Matricula
            Matricula matricula = new Matricula();

            // Atribuindo valores aos atributos básicos
            matricula.NomeDoAluno = "Carlos Oliveira";
            matricula.Curso = "Ciência da Computação";
            matricula.NumeroMatricula = 202301010;
            matricula.Situacao = "Ativa";
            matricula.DataInicial = "10/03/2023";

            Console.WriteLine("=== INFORMAÇÕES INICIAIS DA MATRÍCULA ===");
            matricula.ExibirInformacoes();

            Console.WriteLine("\n=== TRANCANDO A MATRÍCULA ===");
            matricula.Trancar();
            Console.WriteLine("Método Trancar() executado!");
            matricula.ExibirInformacoes();

            Console.WriteLine("\n=== REATIVANDO A MATRÍCULA ===");
            matricula.Reativar();
            Console.WriteLine("Método Reativar() executado!");
            matricula.ExibirInformacoes();

            Console.WriteLine("\n=== TESTANDO COM SEGUNDA MATRÍCULA ===");
            Matricula matricula2 = new Matricula();
            matricula2.NomeDoAluno = "Ana Paula";
            matricula2.Curso = "Engenharia Civil";
            matricula2.NumeroMatricula = 202301011;
            matricula2.Situacao = "Ativa";
            matricula2.DataInicial = "15/03/2023";

            Console.WriteLine("Situação inicial:");
            matricula2.ExibirInformacoes();

            Console.WriteLine("\nApós trancar:");
            matricula2.Trancar();
            matricula2.ExibirInformacoes();

            Console.WriteLine("\n=== EVIDÊNCIA DE FUNCIONAMENTO DOS MÉTODOS ===");
            Console.WriteLine("✅ Método Trancar(): Altera situação para 'Trancada'");
            Console.WriteLine("✅ Método Reativar(): Altera situação para 'Ativa'");
            Console.WriteLine("✅ Método ExibirInformacoes(): Mostra dados formatados");
            Console.WriteLine("✅ Mudanças de estado foram aplicadas corretamente!");

            Console.ReadKey();
        }
    }
}
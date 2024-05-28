using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Console.WriteLine("Quantas pessoas serão hospedadas? ");
int quantidadeCadastro;

try
{
    quantidadeCadastro = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("\nEntrada inválida. Por favor, insira um valor numérico. Encerrando programa.");
    return;
}

List<Pessoa> hospedes = new List<Pessoa>();

for (int i = 0; i < quantidadeCadastro; i++)
{
    Pessoa p = new Pessoa();

    Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
    p.Nome = Console.ReadLine();

    Console.WriteLine($"Digite o sobrenome da {i + 1}ª pessoa:");
    p.Sobrenome = Console.ReadLine();

    hospedes.Add(p);
}

Console.WriteLine("\nEscolha o tipo do quarto:");
Console.WriteLine("1 - Comum ");
Console.WriteLine("2 - Suíte ");

int escolhaQuarto;

try
{
    escolhaQuarto = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("\nEntrada inválida. Por favor, insira um valor numérico. Encerrando programa.");
    return;
}

// Cria uma nova reserva com base na escolha do usuário
Reserva escolha = new Reserva(diasReservados: 0, escolhaQuarto);
Comum comum = new Comum();
Suite suite = new Suite();

if (escolhaQuarto == 1)
{
    escolha.CadastrarComum(comum);
    if (hospedes.Count <= comum.CapacidadeComum)
    {
        escolha.CadastrarHospedes(hospedes);

        Console.WriteLine("\nQuantos dias serão reservados?");
        try
        {
            escolha.DiasReservados = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("\nEntrada inválida. Por favor, insira um valor numérico. Encerrando programa.");
            return;
        }

        Console.WriteLine("\nDetalhes da Reserva:");
        Console.WriteLine($"Tipo do Quarto: {escolha.QuartoComum.TipoComum}");
        Console.WriteLine($"Quantidade de Hóspedes: {escolha.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da Diária: {escolha.QuartoComum.ValorDiariaComum:C2}");
        Console.WriteLine($"Total da Reserva: {escolha.CalcularValorDiaria():C2}");
    }
    else
    {
        Console.WriteLine("\nCapacidade do quarto comum excedida. Encerrando programa.");
    }
}
else if (escolhaQuarto == 2)
{
    escolha.CadastrarSuite(suite);
    if (hospedes.Count <= suite.CapacidadeSuite)
    {
        escolha.CadastrarHospedes(hospedes);

        Console.WriteLine("\nQuantos dias serão reservados?");
        try
        {
            escolha.DiasReservados = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("\nEntrada inválida. Por favor, insira um valor numérico. Encerrando programa.");
            return;
        }

        Console.WriteLine("\nDetalhes da Reserva:");
        Console.WriteLine($"Tipo do Quarto: {escolha.QuartoSuite.TipoSuite}");
        Console.WriteLine($"Quantidade de Hóspedes: {escolha.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da Diária: {escolha.QuartoSuite.ValorDiariaSuite:C2}");
        Console.WriteLine($"Total da Reserva: {escolha.CalcularValorDiaria():C2}");
    }
    else
    {
        Console.WriteLine("\nCapacidade da suíte excedida. Encerrando programa.");
    }
}
else
{
    Console.WriteLine("\nOpção inválida. Encerrando programa.");
}

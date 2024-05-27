using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Console.WriteLine("Quantas pessoas serão hospedadas? ");
int quantidadeCadastro = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>();

for (int i = 0; i < quantidadeCadastro; i++)
{
    Pessoa p = new Pessoa();

    Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
    p.Nome = Console.ReadLine();

    Console.WriteLine($"Digite o sobrenome da {i + 1}ª pessoa:");
    p.Sobrenome = Console.ReadLine();

    hospedes.Add(p); // Adiciona o hóspede à lista
}

Console.WriteLine("\nEscolha o tipo do quarto:");
Console.WriteLine("1 - Comum ");
Console.WriteLine("2 - Suíte ");

int escolhaQuarto = int.Parse(Console.ReadLine()); // Captura a escolha do usuário

// Cria uma nova reserva com base na escolha do usuário
Reserva escolha = new Reserva(diasReservados: 0, escolhaQuarto);

if (escolhaQuarto == 1)
{
    // Cria o quarto comum
    Comum comum = new Comum(tipoComum: "Padrão", capacidadeComum: 1, valorDiariaComum: 99);

    // Captura a quantidade de dias da reserva
    Console.WriteLine("\nQuantos dias serão reservados?");
    escolha.DiasReservados = int.Parse(Console.ReadLine());

    escolha.CadastrarComum(comum);
    escolha.CadastrarHospedes(hospedes);
}
else if (escolhaQuarto == 2)
{
    // Cria a suíte
    Suite suite = new Suite(tipoSuite: "Premium", capacidadeSuite: 2, valorDiariaSuite: 189);

    // Captura a quantidade de dias da reserva
    Console.WriteLine("\nQuantos dias serão reservados?");
    escolha.DiasReservados = int.Parse(Console.ReadLine());

    escolha.CadastrarSuite(suite);
    escolha.CadastrarHospedes(hospedes);
}
else
{
    Console.WriteLine("Opção inválida. Encerrando programa.");
    return; // Encerra o programa se a escolha do quarto for inválida
}

// Exibe as informações da reserva
Console.WriteLine("\nDetalhes da Reserva:");
Console.WriteLine($"Tipo do Quarto: {(escolhaQuarto == 1 ? escolha.QuartoComum.TipoComum : escolha.QuartoSuite.TipoSuite)}");
Console.WriteLine($"Quantidade de Hóspedes: {escolha.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {escolha.CalcularValorDiaria() / 2 :C2}");
Console.WriteLine($"Total da Reserva: {escolha.CalcularValorDiaria():C2}");

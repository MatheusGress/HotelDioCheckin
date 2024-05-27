using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Pessoa quantidade = new Pessoa();

Console.WriteLine("Quantas pessoas serão hospedadas? ");
quantidade.QuantidadeCadastro = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>();

for (int i = 0; i < quantidade.QuantidadeCadastro; i++)
{
    Pessoa p = new Pessoa();

    Console.WriteLine("Digite seu primeiro nome: ");
    p.Nome = Console.ReadLine();

    Console.WriteLine("Digite seu sobrenome: ");
    p.Sobrenome = Console.ReadLine();

}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
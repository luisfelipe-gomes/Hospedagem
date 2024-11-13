using System.Text;
using Projeto_Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Criando os modelos de hóspedes e cadastrando na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Luis", sobrenome: "Gomes");
Pessoa p2 = new Pessoa(nome: "Leticia", sobrenome: "Krausse");

hospedes.Add(p1);
hospedes.Add(p2);

// Criando a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 100);

// Criando uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibindo a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Quantidade de dias: {reserva.obterQtdDias()}");
Console.WriteLine($"Valor Diaria: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor Total: {reserva.CalcularValorTotal()}");


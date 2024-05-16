using DesafioProjetoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilha_Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");
            Pessoa p3 = new Pessoa(nome: "Hospede 3");

            hospedes.Add(p1);
            hospedes.Add(p2);
            hospedes.Add(p3);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            Console.ReadKey();
        }
    }
}

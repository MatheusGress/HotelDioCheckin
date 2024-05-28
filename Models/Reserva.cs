using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int EscolhaQuarto { get; }
        public List<Pessoa> Hospedes { get; private set; }
        public Suite QuartoSuite { get; private set; }
        public Comum QuartoComum { get; private set; }
        public int DiasReservados { get; set; }
        public bool CapacidadeExcedida { get; private set; }

        public Reserva(int diasReservados, int escolhaQuarto)
        {
            DiasReservados = diasReservados;
            EscolhaQuarto = escolhaQuarto;
            CapacidadeExcedida = true;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (EscolhaQuarto == 1 && QuartoComum != null && hospedes.Count <= QuartoComum.CapacidadeComum)
            {
                Hospedes = hospedes;
            }
            else if (EscolhaQuarto == 2 && QuartoSuite != null && hospedes.Count <= QuartoSuite.CapacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                CapacidadeExcedida = false;
                Console.WriteLine("Capacidade excedida ou quarto não selecionado.");
            }
        }

        public void CadastrarComum(Comum comum)
        {
            QuartoComum = comum;
        }

        public void CadastrarSuite(Suite suite)
        {
            QuartoSuite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = 0;

            if (EscolhaQuarto == 1 && QuartoComum != null)
            {
                valorDiaria = DiasReservados * QuartoComum.ValorDiariaComum;
            }
            else if (EscolhaQuarto == 2 && QuartoSuite != null)
            {
                valorDiaria = DiasReservados * QuartoSuite.ValorDiariaSuite;
            }
            else
            {
                Console.WriteLine("Quarto não selecionado.");
            }

            if (DiasReservados >= 10)
            {
                valorDiaria *= 0.9m; 
            }

            return valorDiaria;
        }
    }
}

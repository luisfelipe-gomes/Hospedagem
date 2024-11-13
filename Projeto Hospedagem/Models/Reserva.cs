using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hospedagem.Models
{
    internal class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O numero de hóspedes é maior que a capacidade da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorTotal()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor * 0.1M;
            }

            return valor;
        }

        public decimal CalcularValorDiaria()
        {
            return Suite.ValorDiaria;
        }

        public int obterQtdDias()
        { 
            return DiasReservados;
        }


    }
}

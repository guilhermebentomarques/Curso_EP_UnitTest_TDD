using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Domain.Conta_Corrente.Interface
{
    public interface IContaCorrenteRepository
    {
        ContaCorrente ObterContaPorNumero(string numeroConta);
        void Atualizar(ContaCorrente contaCorrente);
    }
}

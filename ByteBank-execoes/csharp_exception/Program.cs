﻿using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

try
{
    ContaCorrente conta1 = new ContaCorrente(283, "1234-X");
    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());

    conta1.Sacar(50);
    Console.WriteLine(conta1.GetSaldo());

}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo Insufuciente!");
    Console.WriteLine(ex.Message);
}
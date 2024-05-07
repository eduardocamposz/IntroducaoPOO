using ExemploAula;

Conta conta1 = new Conta(123456);
Conta conta2 = new Conta(654321, 10000);

Console.WriteLine($"Conta 1 {conta1.Numero}");
Console.WriteLine($"Conta 2: {conta2.Numero} saldo: {conta2.Saldo} ");
Conta objConta = new Conta(100);

objConta.Creditar(150.27M);
objConta.Debitar(200.27M);

// decimal meuSaldo = objConta.Extrato();
// Console.WriteLine(meuSaldo);

// CONTA CORRENTE:
ContaCorrente cc = new ContaCorrente(100, 50);

cc.Creditar(100);
cc.Debitar(240);

Console.WriteLine(cc.Extrato()); 
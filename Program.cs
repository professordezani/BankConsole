Conta objConta = new Conta(100);

objConta.Creditar(150.27M);
objConta.Debitar(200.27M);

decimal meuSaldo = objConta.Extrato();

Console.WriteLine(meuSaldo);
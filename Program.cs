// classes abstratas não podem ser instanciadas.
// Conta objConta = new Conta(100);

// objConta.Creditar(150.27M);
// objConta.Debitar(200.27M);

// decimal meuSaldo = objConta.Extrato();
// Console.WriteLine(meuSaldo);

// CONTA CORRENTE:
Conta cc = new ContaCorrente(100, 50);

cc.Creditar(100);
cc.Debitar(240);

Console.WriteLine(cc.Extrato()); 


// CONTA POUPANÇA:
Conta cp = new ContaPoupanca(100);
cp.Creditar(100);

decimal rendimento = ((ContaPoupanca)cp).Render();

cp.Creditar(rendimento); // execute a cada mês

Console.WriteLine(cp.Extrato());




List<Conta> contas = new List<Conta>();
contas.Add(cc);
contas.Add(cp);
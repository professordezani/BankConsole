// // classes abstratas não podem ser instanciadas.
// // Conta objConta = new Conta(100);

// // objConta.Creditar(150.27M);
// // objConta.Debitar(200.27M);

// // decimal meuSaldo = objConta.Extrato();
// // Console.WriteLine(meuSaldo);

// // CONTA CORRENTE:
// Conta cc = new ContaCorrente(100, 50);

// cc.Creditar(100);
// cc.Debitar(240);

// Console.WriteLine(cc.Extrato()); 


// // CONTA POUPANÇA:
// Conta cp = new ContaPoupanca(100);
// cp.Creditar(100);

// decimal rendimento = ((ContaPoupanca)cp).Render();

// cp.Creditar(rendimento); // execute a cada mês

// Console.WriteLine(cp.Extrato());




// List<Conta> contas = new List<Conta>();
// contas.Add(cc);
// contas.Add(cp);




Cliente cliente = new Cliente("Fulano Xavier");

ContaCorrente cc = new ContaCorrente(1000, 100);
ContaPoupanca cp = new ContaPoupanca(500);

cliente.AddConta(cc);
cliente.AddConta(cp);

foreach(Conta conta in cliente.GetContas()) {
    string tipo = "";
    decimal limite = 0;

    if(conta is ContaCorrente) {
        tipo = "Conta Corrente";
        cc = (ContaCorrente)conta;
        limite = cc.GetLimite();
    }
    else {
        tipo = "Conta Poupança";
        // cc = conta as ContaCorrente;
    }

    Console.WriteLine($"{tipo}: {conta.Extrato()}, limite: {limite}");
}
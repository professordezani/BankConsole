public class ContaCorrente : Conta {

    // atributo:
    decimal limite;

    public ContaCorrente(decimal limite) : base() {
        this.limite = limite;
    }

    public ContaCorrente(decimal saldo, decimal limite): base(saldo) {
        this.limite = limite;
    }

    public override void Debitar(decimal valor) {
        if(valor <= saldo + limite) 
            saldo -= valor;
    }

}
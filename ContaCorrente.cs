public class ContaCorrente : Conta {

    // atributo:
    private decimal limite;

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

    public decimal GetLimite() {
        return limite;
    }

}
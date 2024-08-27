public abstract class Conta {
    // atributos:
    protected decimal saldo;

    // construtor:
    public Conta() {}

    // construtor:
    public Conta(decimal saldoInicial) {
        saldo = saldoInicial;
    }

    // métodos:
    public decimal Extrato() {
        return saldo;
    }

    public virtual void Debitar(decimal valor) {
        if(valor <= saldo)
            saldo -= valor;
    }

    public void Creditar(decimal valor) {
        saldo += valor;
    }
}
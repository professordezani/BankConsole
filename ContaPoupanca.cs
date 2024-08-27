public class ContaPoupanca : Conta, IRendimento
{
    public ContaPoupanca(decimal saldo) : base(saldo) {}

    public decimal Render() {
        return saldo * 0.005M;
    }
}
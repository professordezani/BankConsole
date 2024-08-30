public class Cliente
{
    private string nome;
    private List<Conta> contas;

    public Cliente(string nome)
    {
        this.nome = nome;
        this.contas = new List<Conta>();
    }

    public string GetNome() {
        return this.nome;
    }

    public List<Conta> GetContas() {
        return this.contas;
    }

    public void AddConta(Conta conta) {
        this.contas.Add(conta);
    }
}
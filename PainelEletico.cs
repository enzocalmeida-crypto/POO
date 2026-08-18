public class PainelEletrico
{
    private string _cor;
    private string _marca;
    private int _disjuntores;

    public PainelEletrico(string cor, string marca, int disjuntores)
    {
        _cor = cor;
        _marca = marca;
        _disjuntores = disjuntores;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getMarca()
    {
        return _marca;
    }

    public void setMarca(string marca)
    {
        this._marca = marca;
    }

    public int getDisjuntores()
    {
        return _disjuntores;
    }

    public void setDisjuntores(int disjuntores)
    {
        this._disjuntores = disjuntores;
    }

    public void ligar()
    {
        Console.WriteLine("ligando painel...");
    }

    public void desligar()
    {
        Console.WriteLine("desligando painel...");
    }

    public void Executar()
    {
        Console.WriteLine("--Painel Elétrico--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Disjuntores: {_disjuntores}");
    }
}
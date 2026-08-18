public class Fusca
{
    private string _cor;
    private string _marca;
    private int _ano;

    public Fusca(string cor, string marca, int ano)
    {
        _cor = cor;
        _marca = marca;
        _ano = ano;
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

    public int getAno()
    {
        return _ano;
    }

    public void setAno(int ano)
    {
        this._ano = ano;
    }

    public void ligar()
    {
        Console.WriteLine("ligando...");
    }

    public void buzinar()
    {
        Console.WriteLine("buzinando...");
    }

    public void Executar()
{
    Console.WriteLine("--Fusca--");
    Console.WriteLine($"Cor: {_cor}");
    Console.WriteLine($"Marca: {_marca}");
    Console.WriteLine($"Ano: {_ano}");
}
}
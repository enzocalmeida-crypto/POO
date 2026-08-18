public class Violao
{
    private string _cor;
    private string _marca;
    private int _cordas;

    public Violao(string cor, string marca, int cordas)
    {
        _cor = cor;
        _marca = marca;
        _cordas = cordas;
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

    public int getCordas()
    {
        return _cordas;
    }

    public void setCordas(int cordas)
    {
        this._cordas = cordas;
    }

    public void tocar()
    {
        Console.WriteLine("tocando...");
    }

    public void afinar()
    {
        Console.WriteLine("afinando...");
    }

    public void Executar()
    {
        Console.WriteLine("--Violão--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Cordas: {_cordas}");
    }
}
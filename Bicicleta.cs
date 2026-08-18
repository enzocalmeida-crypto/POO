public class Bicicleta
{
    private string _cor;
    private string _marca;
    private int _marchas;

    public Bicicleta(string cor, string marca, int marchas)
    {
        _cor = cor;
        _marca = marca;
        _marchas = marchas;
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

    public int getMarchas()
    {
        return _marchas;
    }

    public void setMarchas(int marchas)
    {
        this._marchas = marchas;
    }

    public void pedalar()
    {
        Console.WriteLine("pedalando...");
    }

    public void frear()
    {
        Console.WriteLine("freando...");
    }

    public void Executar()
    {
        Console.WriteLine("--Bicicleta--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Marchas: {_marchas}");
    }
}
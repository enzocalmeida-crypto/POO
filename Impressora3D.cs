public class Impressora3D
{
    private string _cor;
    private string _marca;
    private int _temperatura;

    public Impressora3D(string cor, string marca, int temperatura)
    {
        _cor = cor;
        _marca = marca;
        _temperatura = temperatura;
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

    public int getTemperatura()
    {
        return _temperatura;
    }

    public void setTemperatura(int temperatura)
    {
        this._temperatura = temperatura;
    }

    public void imprimir()
    {
        Console.WriteLine("imprimindo...");
    }

    public void aquecer()
    {
        Console.WriteLine("aquecendo...");
    }

    public void Executar()
    {
        Console.WriteLine("--Impressora 3D--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Temperatura: {_temperatura}");
    }
}
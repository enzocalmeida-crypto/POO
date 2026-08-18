public class Extintor
{
    private string _cor;
    private string _tipo;
    private int _peso;

    public Extintor(string cor, string tipo, int peso)
    {
        _cor = cor;
        _tipo = tipo;
        _peso = peso;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getTipo()
    {
        return _tipo;
    }

    public void setTipo(string tipo)
    {
        this._tipo = tipo;
    }

    public int getPeso()
    {
        return _peso;
    }

    public void setPeso(int peso)
    {
        this._peso = peso;
    }

    public void apagarFogo()
    {
        Console.WriteLine("apagando fogo...");
    }

    public void verificar()
    {
        Console.WriteLine("verificando...");
    }

    public void Executar()
    {
        Console.WriteLine("--Extintor--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Tipo: {_tipo}");
        Console.WriteLine($"Peso: {_peso}");
    }

}
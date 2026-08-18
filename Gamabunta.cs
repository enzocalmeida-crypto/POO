public class Gamabunta
{
    private string _cor;
    private string _especie;
    private int _tamanho;

    public Gamabunta(string cor, string especie, int tamanho)
    {
        _cor = cor;
        _especie = especie;
        _tamanho = tamanho;
    }

    public string getCor()
    {
        return _cor;
    }

    public void setCor(string cor)
    {
        this._cor = cor;
    }

    public string getEspecie()
    {
        return _especie;
    }

    public void setEspecie(string especie)
    {
        this._especie = especie;
    }

    public int getTamanho()
    {
        return _tamanho;
    }

    public void setTamanho(int tamanho)
    {
        this._tamanho = tamanho;
    }

    public void pular()
    {
        Console.WriteLine("Gamabunta está pulando...");
    }

    public void atacar()
    {
        Console.WriteLine("Gamabunta está atacando...");
    }

    public void Executar()
    {
        Console.WriteLine("--Gamabunta--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Espécie: {_especie}");
        Console.WriteLine($"Tamanho: {_tamanho}");
    }
}
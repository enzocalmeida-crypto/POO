public class ChaveDeFenda
{
    private string _cor;
    private string _marca;
    private int _tamanho;

    public ChaveDeFenda(string cor, string marca, int tamanho)
    {
        _cor = cor;
        _marca = marca;
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

    public string getMarca()
    {
        return _marca;
    }

    public void setMarca(string marca)
    {
        this._marca = marca;
    }

    public int getTamanho()
    {
        return _tamanho;
    }

    public void setTamanho(int tamanho)
    {
        this._tamanho = tamanho;
    }

    public void apertar()
    {
        Console.WriteLine("apertando parafuso...");
    }

    public void soltar()
    {
        Console.WriteLine("soltando parafuso...");
    }

    public void Executar()
    {
        Console.WriteLine("--Chave de Fenda--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Tamanho: {_tamanho}");
    }
}
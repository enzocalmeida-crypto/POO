public class ChapeuDoSlash
{
    private string _cor;
    private string _material;
    private int _tamanho;

    public ChapeuDoSlash(string cor, string material, int tamanho)
    {
        _cor = cor;
        _material = material;
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

    public string getMaterial()
    {
        return _material;
    }

    public void setMaterial(string material)
    {
        this._material = material;
    }

    public int getTamanho()
    {
        return _tamanho;
    }

    public void setTamanho(int tamanho)
    {
        this._tamanho = tamanho;
    }

    public void vestir()
    {
        Console.WriteLine("vestindo o chapéu...");
    }

    public void retirar()
    {
        Console.WriteLine("retirando o chapéu...");
    }

    public void Executar()
    {
        Console.WriteLine("--Chapéu do Slash--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Material: {_material}");
        Console.WriteLine($"Tamanho: {_tamanho}");
    }
}
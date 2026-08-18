public class EspadaDoMihawk
{
    private string _cor;
    private string _material;
    private int _tamanho;

    public EspadaDoMihawk(string cor, string material, int tamanho)
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

    public void atacar()
    {
        Console.WriteLine("atacando com a espada...");
    }

    public void guardar()
    {
        Console.WriteLine("guardando a espada...");
    }
}
public class Notebook
{
    private string _cor;
    private string _marca;
    private int _memoria;

    public Notebook(string cor, string marca, int memoria)
    {
        _cor = cor;
        _marca = marca;
        _memoria = memoria;
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

    public int getMemoria()
    {
        return _memoria;
    }

    public void setMemoria(int memoria)
    {
        this._memoria = memoria;
    }

    public void ligar()
    {
        Console.WriteLine("ligando...");
    }

    public void desligar()
    {
        Console.WriteLine("desligando...");
    }

    public void Executar()
    {
       Console.WriteLine("--Notebook--");
       Console.WriteLine($"Cor: {_cor}");
       Console.WriteLine($"Marca: {_marca}");
       Console.WriteLine($"Memória: {_memoria} GB");
    }
}
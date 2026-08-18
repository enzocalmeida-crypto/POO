public class PainelSolar
{
    private string _cor;
    private string _marca;
    private int _potencia;

    public PainelSolar(string cor, string marca, int potencia)
    {
        _cor = cor;
        _marca = marca;
        _potencia = potencia;
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

    public int getPotencia()
    {
        return _potencia;
    }

    public void setPotencia(int potencia)
    {
        this._potencia = potencia;
    }

    public void captarLuz()
    {
        Console.WriteLine("captando luz...");
    }

    public void gerarEnergia()
    {
        Console.WriteLine("gerando energia...");
    }

    public void Executar()
    {
        Console.WriteLine("--Painel Solar--");
        Console.WriteLine($"Cor: {_cor}");
        Console.WriteLine($"Marca: {_marca}");
        Console.WriteLine($"Potência: {_potencia}");
    }
}
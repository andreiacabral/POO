using System;

public class Guitarra
{

    private string numeroSerie, fabricante, modelo, tipo, madeira;
    private double preco;

    //Cria��o do contrutor da classe Guitarra
    public Guitarra(
            string numeroSerie, string fabricante,
            string modelo, string tipo,
            string madeira, double preco)
    {
        this.numeroSerie = numeroSerie;
        this.fabricante = fabricante;
        this.modelo = modelo;
        this.tipo = tipo;
        this.madeira = madeira;
        this.preco = preco;
    }
    public string getNumeroSerie()
    {
        return numeroSerie;
    }
    public void setNumeroSerie(string numeroSerie)
    {
        this.numeroSerie = numeroSerie;
    }
    public string getFabricante()
    {
        return fabricante;
    }
    public void setFabricante(string fabricante)
    {
        this.fabricante = fabricante;
    }
    public string getModelo()
    {
        return modelo;
    }
    public string getTipo()
    {
        return tipo;
    }
    public void setTipo(string tipo)
    {
        this.tipo = tipo;
    }
    public string getMadeira()
    {
        return madeira;
    }
    public void setMadeira(string madeira)
    {
        this.madeira = madeira;
    }
    public double getPreco()
    {
        return preco;
    }
    public void setPreco(double preco)
    {
        this.preco = preco;
    }

    //O m�todo main ()  � o m�todo principal da classe
    public static void main(string[] args)
    {
        //instanciamoss um objeto chamado "minhaGuitarra" que ser� do tipo "Guitarra"
        //Os valores passados s�o usados pelo construtor da classe para criar o objeto
        Guitarra minhaGuitarra = new Guitarra("01020304", "Fender", "Telecaster", "El�trica", "Mogno", 1500);
        //testando os dados da classe, imprimindo a sa�da simples no terminal
        Console.WriteLine("N�mero de S�rie: " + (minhaGuitarra.getNumeroSerie()));
        Console.WriteLine("Madeira: " + (minhaGuitarra.getMadeira()));
        Console.WriteLine("Pre�o: " + (minhaGuitarra.getPreco()));
        Console.WriteLine("Tipo: " + (minhaGuitarra.getTipo()));
        Console.WriteLine("Fabricante: " + (minhaGuitarra.getFabricante()));
        Console.WriteLine("Modelo: " + (minhaGuitarra.getModelo()));
    }
}
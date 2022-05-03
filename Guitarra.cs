using System;

public class Guitarra
{

    private string numeroSerie, fabricante, modelo, tipo, madeira;
    private double preco;

    //Criação do contrutor da classe Guitarra
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

    //O método main ()  é o método principal da classe
    public static void main(string[] args)
    {
        //instanciamoss um objeto chamado "minhaGuitarra" que será do tipo "Guitarra"
        //Os valores passados são usados pelo construtor da classe para criar o objeto
        Guitarra minhaGuitarra = new Guitarra("01020304", "Fender", "Telecaster", "Elétrica", "Mogno", 1500);
        //testando os dados da classe, imprimindo a saída simples no terminal
        Console.WriteLine("Número de Série: " + (minhaGuitarra.getNumeroSerie()));
        Console.WriteLine("Madeira: " + (minhaGuitarra.getMadeira()));
        Console.WriteLine("Preço: " + (minhaGuitarra.getPreco()));
        Console.WriteLine("Tipo: " + (minhaGuitarra.getTipo()));
        Console.WriteLine("Fabricante: " + (minhaGuitarra.getFabricante()));
        Console.WriteLine("Modelo: " + (minhaGuitarra.getModelo()));
    }
}
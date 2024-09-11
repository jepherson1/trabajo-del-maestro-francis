using System;
using System.Collections.Generic;

// Clase abstracta Shape
public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    protected Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalcularSuperficie();
}

// Subclase Triangulo
public class Triangulo : Shape
{
    public Triangulo(double ancho, double alto) : base(ancho, alto) { }

    public override double CalcularSuperficie()
    {
        return (Ancho * Alto) / 2;
    }
}

// Subclase Rectangulo
public class Rectangulo : Shape
{
    public Rectangulo(double ancho, double alto) : base(ancho, alto) { }

    public override double CalcularSuperficie()
    {
        return Ancho * Alto;
    }
}

// Subclase Circulo
public class Circulo : Shape
{
    public Circulo(double radio) : base(radio, radio) { }

    public override double CalcularSuperficie()
    {
        return Math.PI * Math.Pow(Ancho, 2); // Ancho es el radio
    }
}

// Programa principal para demostrar el uso
public class Program
{
    public static void Main()
    {
        // Crear diferentes formas
        List<Shape> formas = new List<Shape>
        {
            new Triangulo(10, 5),
            new Rectangulo(4, 6),
            new Circulo(3)
        };

        // Calcular áreas
        foreach (Shape forma in formas)
        {
            Console.WriteLine($"Área de {forma.GetType().Name}: {forma.CalcularSuperficie()}");
        }
    }
}

// jepherson de leon diaz

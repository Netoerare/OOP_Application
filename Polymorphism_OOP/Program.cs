using System;

abstract class Shape
{
    public abstract double CalculateArea();
}
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Triangle : Shape
{
    public double Base { get ; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Base * Height /2;
    }
}


class Program 
{ 
    
    static void Main()
    {
        
        Shape[] shape = new Shape[]
        {
            new Rectangle { Length = 10, Width = 5},
            new Circle { Radius = 10 },
            new Triangle { Base = 10, Height = 7 },
            
        };
        foreach (var shapes in shape)
        {
            Console.WriteLine("Area: " + shapes.CalculateArea());
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Shapes
{
public class Shape3D
{
    public string Name { get ; set;}
    public List<double> Dimensions { get; set; }

    public Shape3D(string name, List<double> dimensions){
        Name = name;
        Dimensions = dimensions;
    }

   public void Dump()
        {
            Console.WriteLine("----- Shape Dump -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Dimensions: " + (Dimensions.Count > 0 ? string.Join(", ", Dimensions) : "None"));
            Console.WriteLine("----------------------");
        }
}

public class ShapeContainer
{
   // list to store shapes
    private List<Shape3D> shapes;

    // initilizing constructor
    public ShapeContainer()
    {
        shapes = new List<Shape3D>();
    }

    // method that adds shape
    public void Create(Shape3D shape)
    {
        if (shape == null)
            throw new ArgumentNullException(nameof(shape), "Shape cannot be null");

        shapes.Add(shape);
    }

    // gets and retrieves the shape at specified index
    public Shape3D Get(int index)
    {
        if (index < 0 || index >= shapes.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");

        return shapes[index];
    }

    // deletes shape from specified index
    public void Delete(int index)
    {
        if(index < 0 || index >= shapes.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");

        shapes.RemoveAt(index);
    }
    public void CreateNullShapeThrowsArgumentNullException()
    {
        var container = new ShapeContainer();
        Assert.Throws<ArgumentNullException>(() => container.Create(null));
    }
}
}
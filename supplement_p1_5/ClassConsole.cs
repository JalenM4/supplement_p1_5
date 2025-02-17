using System;
using System.Collections.Generic;
using Shapes;

namespace ShareConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeContainer container = new ShapeContainer();
            Console.WriteLine("Shape RELP, type 'help' for commands");

            while (true)
            {
                Console.Write("/n Enter Command: ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                    continue;
                
                if (input == "exit")
                {
                    Console.WriteLine("goodbye");
                    break;
                }
                else if (input == "help")
                {
                    Console.WriteLine("\nAvailable commands:");
                    Console.WriteLine("  create - Create a new shape");
                    Console.WriteLine("  get    - Retrieve a shape by index");
                    Console.WriteLine("  delete - Delete a shape by index");
                    Console.WriteLine("  exit   - Exit the application");
                }
                else if (input == "create")
                {
                    try{
                        // gets shape name
                        Console.Write("Enter shape name: ");
                        string name = Console.ReadLine();

                        // gets dimension as a sperated list
                        Console.Write("Enter dimensions seperated by spaces (ex., 1.5 2.0 2.5): ");
                        string dimInput = Console.ReadLine();
                        string[] dimsParts = dimInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        List<double> dimensions = new List<double>();
                        foreach (string part in dimsParts)
                        {
                            if (double.TryParse(part, out double value))
                                dimensions.Add(value);
                            else
                                Console.WriteLine($"Invalid dimension'{part}' ignored. ");
                        }
                        // creating shape and dump beofre the addition
                        Shape3D newShape = new Shape3D(name, dimensions);
                        newShape.Dump();
                        container.Create(newShape);
                        Console.WriteLine("Shape created and added to the container");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error creating shape: " + ex.Message);
                    }
                }
                else if (input == "get")
                {
                    try{
                        Console.Write("Enter index of shape to retrieve: ");
                        string indexInput = Console.ReadLine();
                        if (int.TryParse(indexInput, out int index))
                        {
                            Shape3D shape = container.Get(index);
                            shape.Dump();
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving shape: " + ex.Message);
                    }
                    }
                    else if (input == "delete"){
                        try
                    {
                        Console.Write("Enter index of shape to delete: ");
                        string indexInput = Console.ReadLine();
                        if (int.TryParse(indexInput, out int index))
                        {
                            container.Delete(index);
                            Console.WriteLine("Shape deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deleting shape: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command. Type 'help' for the list of commands.");
                }
            
            }
        }
    }
}
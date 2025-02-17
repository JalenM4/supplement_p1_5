using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace supplement_p1_5;

public class Class1
{
    /// <summary>
    /// Created shape class for shapes to pull measurements from and
    /// to refer from
    /// </summary>
    public abstract class Shape3D
    {
        /// <summary>
        ///  abstract funtion that finds the volume of a given shape 
        ///  and returns it as a double
        /// </summary>
        /// <returns> returns a value equaling the volume of random 
        /// generated shape</returns>
        public abstract double GetVolume();
        /// <summary>
        /// abstract funtion that finds the surface area of a given shape 
        ///  and returns it as a double
        /// </summary>
        /// <returns>returns a value giving the surface area of random 
        /// generated shape</returns>
        public abstract double GetSurfaceArea();
        /// <summary>
        /// abstract function that returns values as a string returning
        /// the good values
        /// </summary>
        /// <returns> a astring value giving information on created shape 3</returns>
        public abstract string Dump();
    }
    /// <summary>
    /// Cube class that takes side measurements and validates after
    /// inheriting from the shape3d class
    /// </summary>
    public class Cube : Shape3D
    {
        private double side; 
        public double Side{
            get => side;
            set{
                Validate(value);
                side = value;
;            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="side"> side is a variable of the length 
        /// of one side on the created cube</param>
        public Cube(double side)
        {
            Side = side;
        }

        private void Validate(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side length must be greater than 0.");
            }
        }
        public override double GetVolume()
        {
            return Math.Pow(Side, 3);
        }

        public override double GetSurfaceArea()
        {
            return Math.Pow(Side, 2);
        }

        public override string Dump()
        {
            return $"Cube: Side={Side}, SurfaceArea={GetSurfaceArea()}, Volume={GetVolume}";
        }
    }
    /// <summary>
    /// created sphere class inheriting from shape3d providing a radius
    /// and height value to be passed through volume and surface area
    /// </summary>
    public class Sphere : Shape3D
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                Validate(value);
                radius = value;
            }
        }
        public Sphere(double radius)
        {
            Radius = radius;
        }
        private void Validate(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0.");
            }
        }
        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        public override double GetSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
        public override string Dump()
        {
            return $"Sphere: Radius={Radius}, SurfaceArea={GetSurfaceArea()},Volume={GetVolume()}";
        }
    }
    /// <summary>
    /// Cylinder clalss that inherits from shape3D and has two main variable
    /// radius and height, they both pass through the volume and surface area
    /// function to be checked and validated
    /// </summary>
    public class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public double Radius 
        {
            get => radius;
            set
            {
                Validate(value, Height);
                radius = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                Validate(Radius, value);
                height = value;
            }
        }
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
        private void Validate(double radius, double height)
        {
            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentException("Radius and height must be greater than 0");
            }
        }
        public override double GetVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * Height;
        }
        public override double GetSurfaceArea()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }
        public override string Dump()
        {
            return $"Cylinder : Radius={Radius}, Height={Height}, SurfaceArea={GetSurfaceArea()}, Volume={GetVolume()}";
        }
    }
    /// <summary>
    /// last function that writes values and 'contructs'
    /// the shapes after taking the final values from inherited classes
    /// </summary>
    public class buildShape
    {
        public static void Main(string[] args)
        {
            try{
                Cube myCube = new Cube(5);
                Console.WriteLine(myCube.Dump());

                Sphere mySphere = new Sphere(3);
                Console.WriteLine(myCube.Dump());

                Cylinder myCylinder = new Cylinder(2, 7);
                Console.WriteLine(myCylinder.Dump());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}

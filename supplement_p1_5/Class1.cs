using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace supplement_p1_5;

public class Class1
{
    public abstract class Shape3D
    {
        public abstract double GetVolume();
        public abstract double GetSurfaceArea();
        public abstract string Dump();
    }
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
            return 2 * Math.PI * Radius * Radius * (Radius + Height);
        }
        public override string Dump()
        {
            return $"Cylinder : Radius={Radius}, Height={Height}, SurfaceArea={GetSurfaceArea()}, Volume={GetVolume()}";
        }
    }

}

using System.Net.Http.Headers;

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
        public override do
    }

}

using System;
using Xunit;
using supplement_p1_5;

namespace supplement_p1_5.Tests;

public class UnitTest1
{
    public class CubeTests{
    
    [Fact]
    public void CubeCalculatesVolumeAndSurfaceAreaCorrectly()
    {
        double side = 5;
        var cube = new Class1.Cube(side);
        double expectedVolume = Math.Pow(side, 3);
        double expectedSurfaceArea = Math.Pow(side, 2);

        double actualVolume = cube.GetVolume();
        double actualSurfaceArea = cube.GetSurfaceArea();

        Assert.Equal(expectedVolume, actualVolume);
        Assert.Equal(expectedSurfaceArea, actualSurfaceArea);
    }

    [Fact]
    public void CubeIsInvalidSideThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Class1.Cube(0));
    }
    }

    public class SphereTests
    {
        [Fact]
        public void SphereCalculatesVolumeAndSurfaceAreaCorrectly()
        {
            double radius = 3;
            var sphere = new Class1.Sphere(radius);
            double expectedVolume = (4.0/3.0) * Math.PI * Math.Pow(radius, 3);
            double expectedSurfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

            double actualVolume = sphere.GetVolume();
            double actualSurfaceArea = sphere.GetSurfaceArea();

            Assert.Equal(expectedVolume, actualVolume, 4);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4);
        }
        [Fact]
        public void SphereInvalidRadiusThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Class1.Sphere(-1));
        }
    }

    public class CylinderTests
    {
        [Fact]
        public void CylinderCalculatesVolumeAndSurfaceAreaCorrectly()
        {
            double radius = 2;
            double height = 7;
            var cylinder = new Class1.Cylinder(radius, height);
            double expectedVolume = Math.PI * Math.Pow(radius, 2) * height;
            double expectedSurfaceArea = 2 * Math.PI * Math.Pow(radius, 2) * (radius + height);

            double actualVolume = cylinder.GetVolume();
            double actualSurfaceArea = cylinder.GetSurfaceArea();

            Assert.Equal(expectedVolume, actualVolume, 4);
            Assert.Equal(expectedSurfaceArea, actualSurfaceArea, 4);
        }
        [Fact]
        public void CylinderInvalidDimensionsThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Class1.Cylinder(0, 7));
        }
    }
}

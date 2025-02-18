using System;
using System.Collections.Generic;
using Xunit;
using Shapes;

namespace Shapetests
{
    public class ShapeContainerTests
    {
        [Fact]
        public void CreateShapeAddsShapeToContainer()
        {
            //Arrange
            var container = new ShapeContainer();
            var shape = new Shape3D("Cube", new List<double> {3.0, 3.0, 3.0 });

            container.Create(shape);
            var retrievedShape = container.Get(0);

            // Assert shapees
            Assert.NotNull(retrievedShape);
            Assert.Equal("Cube", retrievedShape.Name);
            Assert.Equal(new List<double> {3.0, 3.0, 3.0}, retrievedShape.Dimensions);
        }
        [Fact]
        public void GetShapeInvalidIndexThrwosArgumentOutOfRangeException()
        {
            var container = new ShapeContainer();

            Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0));
        }
        [Fact]
        public void DeleteShapeRemovesShapeFromContainer()
        {
            var container = new ShapeContainer();
            var shape = new Shape3D("Sphere", new List<double> { 5.0 });
            container.Create(shape);

            container.Delete(0);

            Assert.Throws<ArgumentOutOfRangeException>(() => container.Get(0));
        }
        [Fact]
        public void CreatesNullShapeAndThrowsArgumentNullException()
        {
            var container = new ShapeContainer();

            Assert.Throws<ArgumentNullException>(() => container.Create(null));
        }
    }
}
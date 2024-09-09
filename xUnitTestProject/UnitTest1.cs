using ShapeArea;
namespace xUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CircleAreaTest()
        {
            IShape circle = ShapeFactory.CreateCircle(5);
            double area = circle.CalculateArea();
            Assert.Equal(Math.PI * 25, area, precision: 10);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            double area = triangle.CalculateArea();
            Assert.Equal(6, area, precision: 10);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 5);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void NotRightTriangleTest()
        {
            var triangle = (Triangle)ShapeFactory.CreateTriangle(5, 5, 5);
            bool isRightTriangle = triangle.IsRightTriangle();
            Assert.False(isRightTriangle);
        }
    }
}
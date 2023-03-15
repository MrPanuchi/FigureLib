namespace FigureLibTests
{
    public class TriangleTest
    {
        [Fact]
        public void CreateTriangleWithValidParams()
        {
            Triangle triangle = new Triangle(new double[] { 1, 2, 2.5 });
        }
        [Theory]
        [InlineData(new double[] { 1, 2, 3, 4 })]
        [InlineData(new double[] { -1, 2, 3 })]
        [InlineData(new double[] { 1, -2, 3 })]
        [InlineData(new double[] { 1, 2, -3 })]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 1, 2 })]
        public void CreateTriangleWithInvalidParams(double[] doubles)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(doubles));
        }
        [Fact]
        public void RightTriangle()
        {
            var triangle = new Triangle(new double[] { 5, 12, 13 });
            Assert.True(triangle.IsRightTriangle());
        }
        [Fact]
        public void NotRightTriangle()
        {
            var triangle = new Triangle(new double[] { 5, 12, 14 });
            Assert.False(triangle.IsRightTriangle());
        }
        [Fact]
        public void RightTriangleArea()
        {
            Triangle triangle = new Triangle(new double[] { 1, 2, 2 });
            Assert.Equal(0.968, Math.Round(triangle.GetArea(), 3));
        }
    }
}
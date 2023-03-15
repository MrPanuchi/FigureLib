namespace FigureLibTests
{
    public class ExplicitTest
    {
        [Fact]
        public void TriangleToSafeTriangle()
        {
            Triangle a = new Triangle(new double[] { 1, 2, 2.5 });
            SafeTriangle b = (SafeTriangle)a;
            Assert.True(true);
        }
        [Fact]
        public void SafeTriangleToTriangle()
        {
            SafeTriangle a = new SafeTriangle(new double[] { 1, 2, 2.5 });
            Triangle b = (Triangle)a;
            Assert.True(true);
        }
        [Fact]
        public void CircleToSafeCircle()
        {
            Circle a = new Circle(1);
            SafeCircle b = (SafeCircle)a;
            Assert.True(true);
        }
        [Fact]
        public void SafeCircleToCircle()
        {
            SafeCircle a = new SafeCircle(1);
            Circle b = (Circle)a;
            Assert.True(true);
        }
    }
}

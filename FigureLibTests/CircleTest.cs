namespace FigureLibTests
{
    public class CircleTest
    {
        [Fact]
        public void CreateCircleWithValidParams()
        {
            Circle circle = new Circle(1.1);
        }
        [Fact]
        public void CreateCircleWithInvalidParams()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1.1));
        }
        [Fact]
        public void CreateCircleWithArea1()
        {
            Circle circle = new Circle(0.564);
            Assert.Equal(1, Math.Round(circle.GetArea()));
        }
    }
}

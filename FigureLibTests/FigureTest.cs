namespace FigureLibTests
{
    public class FigureTest
    {
        [Fact]
        public void FigureArea()
        {
            Figure[] figures = new Figure[]
            {
                new Circle(1),
                new Triangle(new double[] { 1, 2, 2 })
            };
            double[] rightAnswer = new double[] { 3.1416, 0.9682 };
            double[] calculatedAnswers = new double[figures.Length];
            for (int i = 0; i < figures.Length; i++)
            {
                calculatedAnswers[i] = Math.Round(figures[i].GetArea(), 4);
            }
            Assert.Equal(rightAnswer, calculatedAnswers);
        }
    }
}

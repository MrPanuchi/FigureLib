using FigureLib.Interfaces;

namespace FigureLib
{
    public abstract class Figure : IArea, IPerimeter
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}

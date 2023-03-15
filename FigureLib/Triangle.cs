using FigureLib.Base;
using FigureLib.Safe;

namespace FigureLib
{
    public class Triangle : BaseTriangle
    {
        public Triangle(double[] sides) : base(sides) { }

        public static explicit operator SafeTriangle(Triangle obj)
        {
            return new SafeTriangle(obj.Sides);
        }
    }
}

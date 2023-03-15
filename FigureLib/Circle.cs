using FigureLib.Base;
using FigureLib.Safe;

namespace FigureLib
{
    public class Circle : BaseCircle
    {
        public Circle(double radius) : base(radius) { }

        public static explicit operator SafeCircle(Circle obj)
        {
            return new SafeCircle(obj.Radius);
        }
    }
}

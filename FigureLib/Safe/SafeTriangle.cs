using FigureLib.Base;
using System.Threading;

namespace FigureLib.Safe
{
    public class SafeTriangle : BaseTriangle
    {
        private ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

        public SafeTriangle(double[] sides) : base(sides) { }

        public override double[] Sides
        {
            get
            {
                _lock.EnterReadLock();
                _lock.ExitReadLock();
                return base.Sides;
            }
            set
            {
                _lock.EnterWriteLock();
                base.Sides = value;
                _lock.ExitWriteLock();
            }
        }

        public static explicit operator Triangle(SafeTriangle obj)
        {
            return new Triangle(obj.Sides);
        }
    }
}

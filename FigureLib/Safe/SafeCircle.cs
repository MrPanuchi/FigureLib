using FigureLib.Base;
using System.Threading;

namespace FigureLib.Safe
{
    public class SafeCircle : BaseCircle
    {
        private ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

        public SafeCircle(double radius) : base(radius) { }

        public override double Radius
        {
            get
            {
                _lock.EnterReadLock();
                _lock.ExitReadLock();
                return base.Radius;
            }
            set
            {
                _lock.EnterWriteLock();
                base.Radius = value;
                _lock.ExitWriteLock();
            }
        }

        public static explicit operator Circle(SafeCircle obj)
        {
            return new Circle(obj.Radius);
        }
    }
}

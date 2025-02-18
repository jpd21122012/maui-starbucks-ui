using CassavaRoots.Enums;

namespace CassavaRoots.Events
{
    public class HoverStatusChangedEventArgs : EventArgs
    {
        public HoverStatusChangedEventArgs()
        {

        }
        internal HoverStatusChangedEventArgs(HoverStatus status)
        {
            State = status;
        }
        public HoverStatus State { get; }
    }
}

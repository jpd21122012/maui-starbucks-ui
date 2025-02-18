using CassavaRoots.Enums;

namespace CassavaRoots.Events
{
    public class TouchStatusChangedEventArgs : EventArgs
    {
        public TouchStatusChangedEventArgs()
        {

        }
        internal TouchStatusChangedEventArgs(TouchStatus status)
        {
            Status = status;
        }

        public TouchStatus Status { get; }
    }
}

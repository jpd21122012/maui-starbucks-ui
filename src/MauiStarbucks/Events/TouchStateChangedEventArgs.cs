using CassavaRoots.Enums;

namespace CassavaRoots.Events
{
    public class TouchStateChangedEventArgs : EventArgs
    {
        public TouchStateChangedEventArgs()
        {

        }
        internal TouchStateChangedEventArgs(TouchState state)
        {
            State = state;
        }

        public TouchState State { get; }
    }
}

using CassavaRoots.Enums;


namespace CassavaRoots.Events
{
    public class HoverStateChangedEventArgs : EventArgs
    {
        public HoverStateChangedEventArgs(HoverState state = HoverState.Normal)
        {
            State = state;
        }

        public HoverState State { get; }
    }
}

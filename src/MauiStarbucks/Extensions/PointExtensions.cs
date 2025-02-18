namespace CassavaRoots.Extensions
{
    public static class PointExtensions
    {
        public static double DistanceTo(this Point from, Point to)
        {
            var result = Math.Sqrt(Math.Pow((from.X - to.X), 2) + Math.Pow((from.Y - to.Y), 2));
            return result;
        }
    }
}

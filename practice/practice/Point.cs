namespace practice
{ 
    partial class Program
    {
        public class Point
        {
            public int x;
            public int y;

            public Point(int x , int y)
            {
                this.x = x;
                this.y = y;
            }

            public void move (int X , int Y)
            {
                this.x = X;
                this.y = Y;
            }

            public void move (Point newLocation)
            {
                this.x = newLocation.x;
                this.y = newLocation.y;
            }
        }
    }
}

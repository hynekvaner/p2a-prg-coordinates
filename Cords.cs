using System;
namespace Coord { 
public class Cords : IEquatable<Cords>, IComparable<Cords> 
{
    public Cords(int x, int y)
    {
        X = x;
        Y = y;
    }
​
    public int X { get; set; }
    public int Y { get; set; }

    public int IsFurtherX( Cords other)
    {
        if (other.X > X)
        {
            return other.X - X;
        }else 
            return X - other.X;
    }
    public int IsFurtherY(Cords other)
    {
        if (other.Y > Y)
        {
            return other.Y - Y;
        }
        else
            return Y - other.Y;
    }

    public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
    public double Magnitude { get { return (X * X + Y * Y); } }


}

public class Program 
{
    Coord c1 = new Coord(10, 10);
    Coord c2 = new Coord(10, 10);
​
    Console.WriteLine(c1 == c2);
    Console.WriteLine(c2.Equals(c2));

}
}
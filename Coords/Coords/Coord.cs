using System;
using System.Drawing;

    public class Cords : IEquatable<Cords>, IComparable<Cords>
    {
        public Cords(int x, int y)
        {
            X = x;
            Y = y;
        }
    public int X { get; set; }
    public int Y { get; set; }
        public int IsFurtherX(Cords other)
        {
            if (other.X > X)
            {
                return other.X - X;
            }
            else
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

        public bool Equals(Cords? other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Cords? other)
        {
            throw new NotImplementedException();
        }

        public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
        public double Magnitude { get { return (X * X + Y * Y); } }
    }
 

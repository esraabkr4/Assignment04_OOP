using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_OOP
{
    internal class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {
            
        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Point3D(int X, int Y) :this(X,Y,0)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point3D(int X):this(X,0,0) 
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public static bool operator == (Point3D p1,Point3D p2)
            {
            if (p1 != null && p2 != null)
            {
                if (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z)
                    return true;
            }
            return false ;
            }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            if (p1 != null && p2 != null)
            {
                if (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z)
                    return false;
            }
            return true;
        }
        public int CompareTo(object? obj)
        {
            if (obj is not null)
            {
                
                Point3D p = obj as Point3D;
                int x = X.CompareTo(p.X);
                if (x == 0)
                {
                    int y= Y.CompareTo(p.Y);
                    if (y == 0)
                        return Z.CompareTo(p.Z);
                    else
                        return y;
                }else
                    return x;
            }
            return -1;

        }

        public object Clone()
        {
            return new Point3D() { X=this.X,Y=this.Y,Z=this.Z};
        }
    }
}

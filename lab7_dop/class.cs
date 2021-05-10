using System;

namespace lab7_dop
{
    class Point
    {
        public Point()
        {
        }

        protected double x, y;

        public double pointX
        {
            get { return x; }
            set
            {
                if (value > 0) x = value;
            }
        }

        public double pointY
        {
            get { return y; }
            set
            {
                if (value > 0) y = value;
            }
        }
    }

    abstract class Circle : Point
    {
        public Circle()
        {
        }

        public Circle(double X, double Y)
        {
            x = X;
            y = Y;
        }

        protected double radius;

        public double Rad
        {
            get { return radius; }
            set
            {
                if (value > 0) radius = value;
            }
        }
        

        public double square()
        {
            return Math.PI * radius * radius;
        }
    }

    abstract class Arc : Circle
    {
        public Arc()
        {
        }

        public Arc(double X, double Y, double R, double G) : base(X, Y)
        {
            gradus = G;
        }
        protected double gradus;
        public double Grad
        {
            get { return gradus; }
            set
            {
                if (value > 0) gradus = value;
            }
        }
        
        public abstract double lenght();
        public abstract double perimetr();
        public abstract double square();
    }

    class Segment : Arc
    {
        public Segment()
        {
        }

        public Segment(double X, double Y, double R, int G) : base(X, Y, R, G)
        {
        }

        private double gradRad() {
            return (Math.PI * gradus / 180);
        }
        public override double lenght()
        {
            return radius * gradRad();
        }

        public override double perimetr()
        {
            return lenght() + 2*radius*Math.Sin(gradRad()/2);
        }

        public override double square()
        {
            return (radius*radius/2)*(gradRad()-Math.Sin(gradRad()));
        }
    }
}
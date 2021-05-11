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

        public abstract double lenght();
    }

    class Arc : Circle
    {
        public Arc()
        {
        }

        public Arc(double X, double Y) : base(X, Y)
        {
            
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

        public double Rad
        {
            get { return radius; }
            set
            {
                if (value > 0) radius = value;
            }
        }

        private double gradRad()
        {
            return (Math.PI * gradus / 180);
        }

        public override double lenght()
        {
            return radius * gradRad();
        }
    }

    class Segment : Arc
    {
        public Segment()
        {
        }

        public Segment(double X, double Y) : base(X, Y)
        {
        }

        private double gradRad()
        {
            return (Math.PI * gradus / 180);
        }

        public override double lenght()
        {
            return radius * gradRad();
        }

        public double perimetr()
        {
            return lenght() + 2 * radius * Math.Sin(gradRad() / 2);
        }

        public double square()
        {
            return (radius * radius / 2) * (gradRad() - Math.Sin(gradRad()));
        }
    }
}
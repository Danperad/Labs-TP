using System;

namespace lab8
{
    class Point : IPoint
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

    class Circle : Point, ICircle
    {
        public Circle()
        {
        }

        public Circle(double X, double Y, double R)
        {
            x = X;
            y = Y;
            radius = R;
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

        public double lenght()
        {
            return 2 * Math.PI * radius;
        }

        public double square()
        {
            return Math.PI * radius * radius;
        }
    }

    class Arc : Circle, IArc
    {
        public Arc()
        {
        }

        public Arc(double X, double Y, double R, double G) : base(X, Y, R)
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

        private double gradRad()
        {
            return (Math.PI * gradus / 180);
        }

        public double lenght()
        {
            return radius * gradRad();
        }
    }

    class Segment : Arc, ISegment
    {
        public Segment()
        {
        }

        public Segment(double X, double Y, double R, int G) : base(X, Y, R, G)
        {
        }

        private double gradRad()
        {
            return (Math.PI * gradus / 180);
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
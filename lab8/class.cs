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

    class Circle : IPoint, ICircle
    {
        public Circle()
        {
        }

        protected double x, y;
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

    class Arc : IPoint, IArc
    {
        public Arc()
        {
        }

        protected double gradus;
        protected double radius;
        protected double x, y;

        public double Rad
        {
            get { return radius; }
            set
            {
                if (value > 0) radius = value;
            }
        }

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

    class Segment : IPoint, IArc, ISegment
    {
        public Segment()
        {
        }

        protected double gradus;
        protected double radius;
        protected double x, y;

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

        public double Rad
        {
            get { return radius; }
            set
            {
                if (value > 0) radius = value;
            }
        }

        public double Grad
        {
            get { return gradus; }
            set
            {
                if (value > 0) gradus = value;
            }
        }

        public double lenght()
        {
            return radius * gradRad();
        }
    }
}
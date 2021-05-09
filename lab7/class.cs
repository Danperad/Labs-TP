using System;

namespace lab7_8
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

        public abstract double volume();
        public abstract double squareFull();

        public double square()
        {
            return Math.PI * radius * radius;
        }
    }

    class Scope : Circle
    {
        public Scope()
        {
        }

        public Scope(double X, double Y, double R) : base(X, Y)
        {
            radius = R;
        }

        public override double volume()
        {
            return square() * radius * (4 / 3.0);
        }

        public override double squareFull()
        {
            return square() * 4;
        }
    }

    class Cone : Circle
    {
        public Cone()
        {
        }

        public Cone(double X, double Y, double R) : base(X, Y)
        {
            radius = R;
        }

        double height;

        public double Hei
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
            }
        }

        double squareSide()
        {
            return Math.PI * radius * Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
        }

        public override double volume()
        {
            return square() * height * (1.0 / 3);
        }

        public override double squareFull()
        {
            return square() + squareSide();
        }
    }

    class Snowman
    {
        public Snowman()
        {
        }

        Cone bucket = new Cone();

        public Cone Bucket
        {
            get => bucket;
            set => bucket = value;
        }

        Scope head = new Scope();

        public Scope Head
        {
            get => head;
            set { head = value; }
        }

        Scope average_body = new Scope();

        public Scope Average_body
        {
            get { return average_body; }
            set { average_body = value; }
        }

        Scope lower_body = new Scope();

        public Scope Lower_body
        {
            get { return lower_body; }
            set { lower_body = value; }
        }

        public double squareFull => bucket.squareFull() + head.squareFull() + average_body.squareFull() +
                                    lower_body.squareFull();

        public double volume()
        {
            return bucket.volume() + head.volume() + average_body.volume() + lower_body.volume();
        }
    }
}
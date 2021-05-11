namespace lab8
{
    interface IPoint
    {
        double pointX { get; set; }

        double pointY { get; set; }
    }

    public interface ICircle
    {
        double Rad { get; set; }
        double lenght();
        double square();
    }
    public interface IArc
    {
        double Rad { get; set; }
        double Grad { get; set; }
        double lenght();
    }
    public interface ISegment
    {
        double perimetr();
        double square();
    }
}
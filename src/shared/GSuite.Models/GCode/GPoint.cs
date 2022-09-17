namespace GSuite.Models.GCode;

public record GPoint
{
    public GPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

    #region Properties
    public double X { get; init; }
    public double Y { get; init; }
    #endregion

    #region Methods
    public GPoint3D To3D(double z) => new(X, Y, z);
    public virtual double ModuleSquared() => X * X + Y * Y;
    public virtual double Module() => Math.Sqrt(ModuleSquared());
    public virtual GPoint AddPoint(GPoint other) =>
        new(X + other.X, Y + other.Y);
    public virtual GPoint SubPoint(GPoint other) =>
        new(X - other.X, Y - other.Y);
    public virtual GPoint Scale(double factor) =>
        new(X * factor, Y * factor);
    #endregion

    #region Operators
    public static GPoint operator +(GPoint a, GPoint b) =>
        a.AddPoint(b);

    public static GPoint operator -(GPoint a, GPoint b) =>
        a.SubPoint(b);

    public static GPoint operator *(GPoint a, double factor) =>
        a.Scale(factor);

    #endregion
}


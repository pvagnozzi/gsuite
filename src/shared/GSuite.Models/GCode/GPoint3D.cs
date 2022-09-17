namespace GSuite.Models.GCode;

public record GPoint3D : GPoint
{
    public GPoint3D(double x, double y, double z) :
        base(x, y) => Z = z;

    public double Z { get; init; }

    #region Methods
    public GPoint ToGPoint() => new(X, Y);
    public override double ModuleSquared() => base.ModuleSquared() + Z * Z;
    #endregion

    #region Operators
    public static GPoint3D operator +(GPoint3D a, GPoint3D b) =>
        new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static GPoint3D operator -(GPoint3D a, GPoint3D b) =>
        new(a.X - b.X, a.Y - b.Y, a.Z + b.Z);
    public static GPoint3D operator *(GPoint3D a, double factor) =>
        new(a.X * factor, a.Y * factor, a.Z * factor);
    #endregion
}


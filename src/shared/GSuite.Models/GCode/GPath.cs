using System.Diagnostics.Contracts;

namespace GSuite.Models.GCode;

public record GPath
{
    public GPath(IEnumerable<GPoint> points)
    {
        Contract.Requires(points is not null);
        Contract.Requires(points!.Any());
        Points = points!.ToList();
    }
    
    public IList<GPoint> Points { get; init; }
}




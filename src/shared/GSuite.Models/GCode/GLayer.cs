using System.Diagnostics.Contracts;

namespace GSuite.Models.GCode;

public class GLayer
{
    public GLayer(IEnumerable<GPath> paths, double z)
    {
        Contract.Requires(paths is not null);
        Contract.Requires(paths!.Any());
        Contract.Requires(z >= 0);
        Paths = paths!.ToList();
    }

    public IList<GPath> Paths { get; init; }

    public double Z { get; init; }
}


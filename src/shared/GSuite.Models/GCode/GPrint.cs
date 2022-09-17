using System.Diagnostics.Contracts;

namespace GSuite.Models.GCode;

public record GPrint
{
    public GPrint(IEnumerable<GLayer> layers, bool ascending = true)
    {
        Contract.Requires(layers is not null);
        Contract.Requires(layers!.Any());
        Layers = (ascending ? layers!.OrderBy(x => x.Z) : layers!.OrderByDescending(x => x.Z)).ToList();
    }

    public IList<GLayer> Layers { get; init; }
}

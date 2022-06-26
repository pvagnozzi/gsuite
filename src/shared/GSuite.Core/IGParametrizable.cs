namespace GSuite.Core;

/// <summary>
/// Interface for object with parameters.
/// </summary>
public interface IGParametrizable
{
    /// <summary>
    /// Gets the parameters list.
    /// </summary>
    IList<GParameter> Parameters { get; }
}
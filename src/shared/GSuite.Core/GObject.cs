namespace GSuite.Core;

/// <summary>
/// GSuite base object
/// </summary>
public class GObject
{
    /// <summary>
    /// Initializes a new instance of GObject,.
    /// </summary>
    /// <param name="name">Object name</param>
    /// <param name="description">Object description</param>
    public GObject(string name = "", string description = "")
    {
        Name = name;
        Description = description;
    }

    #region Properties

    /// <summary>
    /// Gets or sets the object name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the object description.
    /// </summary>
    public string Description { get; set; }

    #endregion
}
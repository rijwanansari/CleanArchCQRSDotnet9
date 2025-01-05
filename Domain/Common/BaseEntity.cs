using System.Diagnostics;

namespace Domain.Common;

/// <summary>
/// Represents the base entity with a generic Id property.
/// </summary>
[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
public abstract class BaseEntity<T>
{
    public required virtual T Id { get; set; }

    private string GetDebuggerDisplay()
    {
        return ToString() ?? string.Empty;
    }
}

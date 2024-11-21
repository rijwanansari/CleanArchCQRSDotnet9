namespace Domain.Common;

public abstract class AuditableWithBaseEntity<T> : BaseEntity<T>
{
    public bool IsDeleted { get; set; } = false;
    public DateTime Created { get; set; }
    public string Author { get; set; } = string.Empty;
    public DateTime Modified { get; set; }
    public string Editor { get; set; } = string.Empty;
}

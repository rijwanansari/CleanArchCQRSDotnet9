using System;

namespace Domain.Aggregates.UserAggregate;

public interface IUserProfileRepository
{
    Task<IEnumerable<UserProfile>> GetUnmarriedUsersAsync(CancellationToken cancellationToken = default);

}

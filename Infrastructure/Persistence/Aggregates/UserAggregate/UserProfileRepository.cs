using System;
using Domain.Aggregates.UserAggregate;

namespace Infrastructure.Persistence.Aggregates.UserAggregate;

public class UserProfileRepository : IUserProfileRepository
{
    private readonly EFRepository<UserProfile> _userProfileRepository;

    public UserProfileRepository(EFRepository<UserProfile> userProfileRepository)
    {
        _userProfileRepository = userProfileRepository;
    }

    /// <summary>
    /// Retrieves a list of user profiles where the users are not married.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of unmarried user profiles.</returns>
    public async Task<IEnumerable<UserProfile>> GetUnmarriedUsersAsync(CancellationToken cancellationToken = default)
    {
        return await _userProfileRepository.GetAsync(x => !x.IsMarried, cancellationToken);
    }

}

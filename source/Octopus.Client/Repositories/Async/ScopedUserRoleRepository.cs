using Octopus.Client.Model;

namespace Octopus.Client.Repositories.Async
{
    public interface IScopedUserRoleRepository :
        ICreate<ScopedUserRoleResource>,
        IModify<ScopedUserRoleResource>,
        IDelete<ScopedUserRoleResource>,
        IGet<ScopedUserRoleResource>,
        ICanLimitToSpaces<IScopedUserRoleRepository>
    {
    }

    class ScopedUserRoleRepository : MixedScopeBaseRepository<ScopedUserRoleResource>, IScopedUserRoleRepository
    {
        public ScopedUserRoleRepository(IOctopusAsyncClient client)
            : base(client, "ScopedUserRoles")
        {
        }

        public IScopedUserRoleRepository LimitTo(bool includeGlobal, params string[] spaceIds)
        {
            var repository = new ScopedUserRoleRepository(Client);
            repository.SetupParameters(includeGlobal, spaceIds);
            return repository;
        }
    }
}

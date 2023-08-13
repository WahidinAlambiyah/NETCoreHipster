using NETCoreHipster.Infrastructure.Data;
using NETCoreHipster.Domain.Entities;
using NETCoreHipster.Test.Setup;

namespace NETCoreHipster.Test;

public static class Fixme
{
    public static User ReloadUser<TEntryPoint>(AppWebApplicationFactory<TEntryPoint> factory, User user)
        where TEntryPoint : class, IStartup, new()
    {
        var applicationDatabaseContext = factory.GetRequiredService<ApplicationDatabaseContext>();
        applicationDatabaseContext.Entry(user).Reload();
        return user;
    }
}

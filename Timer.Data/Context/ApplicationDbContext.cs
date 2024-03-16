using Timer.Core.Settings;

namespace Timer.Data.Context;

public class ApplicationDbContext : BaseDbContext
{
  public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
    {
    }
}

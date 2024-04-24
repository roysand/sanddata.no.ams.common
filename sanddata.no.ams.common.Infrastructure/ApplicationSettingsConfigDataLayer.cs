using System.Reflection;
using sanddata.no.ams.common.Infrastructure.Interface;

namespace sanddata.no.ams.common.Infrastructure;

public class ApplicationSettingsConfigDataLayer : IApplicationSettingsConfigDataLayer
{
    private readonly string ConfigParentKey = "ApplicationSettings";

    private readonly IConfigDataLayer _configDataLayer;

    public ApplicationSettingsConfigDataLayer(IConfigDataLayer configDataLayer)
    {
        _configDataLayer = configDataLayer;
    }
    public string DbConnectionString()
    {
        return _configDataLayer.GetConfigValue<string>($"{ConfigParentKey}:{MethodBase.GetCurrentMethod()!.Name}");

    }
}
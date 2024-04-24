using Microsoft.Extensions.Configuration;
using sanddata.no.ams.common.Application.Interfaces;
using sanddata.no.ams.common.Domain.Common.Exceptions;

namespace sanddata.no.ams.common.Infrastructure.Config;

public class Config : IConfig
{
    private readonly IConfiguration _configuration;
    public IApplicationSettingsConfig ApplicationSettingsConfig { get; }

    public Config(IConfiguration configuration)
    {
        _configuration = configuration;
        
        ApplicationSettingsConfig = new ApplicationSettingsConfig(this);
    }
    
    public T GetConfigValue<T>(string configKey, bool mustExist = true)
    {
        try
        {
            var configValue = _configuration.GetValue<T>(configKey);
            if (EqualityComparer<T>.Default.Equals(configValue, default(T)))
            {
                throw new ConfigException($"Config value '{configKey}' is missing");    
            }
            
            return configValue!;
        }
        catch (Exception)
        {
            throw new ConfigException($"Config value '{configKey}' is missing");
        }
    }
}
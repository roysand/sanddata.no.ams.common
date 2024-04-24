using Microsoft.Extensions.Configuration;
using sanddata.no.ams.common.Domain.Common.Exceptions;
using sanddata.no.ams.common.Infrastructure.Interface;

namespace sanddata.no.ams.common.Infrastructure;

public class ConfigDataLayer : IConfigDataLayer
{
    private readonly IConfiguration _configuration;
    public IApplicationSettingsConfigDataLayer ApplicationSettingsConfigDataLayer { get; }

    public ConfigDataLayer(IConfiguration configuration)
    {
        _configuration = configuration;
        
        ApplicationSettingsConfigDataLayer = new ApplicationSettingsConfigDataLayer(this);
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
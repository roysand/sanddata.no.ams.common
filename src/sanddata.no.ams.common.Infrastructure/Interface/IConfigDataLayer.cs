namespace sanddata.no.ams.common.Infrastructure.Interface;

public interface IConfigDataLayer
{
    T GetConfigValue<T>(string configKey, bool mustExist = true);
    IApplicationSettingsConfigDataLayer ApplicationSettingsConfigDataLayer { get;  }    
}
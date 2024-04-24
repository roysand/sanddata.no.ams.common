namespace sanddata.no.ams.common.Application.Interfaces;

public interface IConfig
{
    T GetConfigValue<T>(string configKey, bool mustExist = true);
    IApplicationSettingsConfig ApplicationSettingsConfig { get;  }    
}
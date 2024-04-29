namespace sanddata.no.ams.common.Application.Interfaces;

public interface IApplicationSettingsConfig
{
    string DbConnectionString();
    bool EnableSensitiveDataLogging();
}
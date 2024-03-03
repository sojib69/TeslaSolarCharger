﻿using TeslaSolarCharger.Shared.Dtos.RestValueConfiguration;

namespace TeslaSolarCharger.Services.Services.Contracts;

public interface IRestValueExecutionService
{
    /// <summary>
    /// Get result for each configuration ID
    /// </summary>
    /// <param name="config">Rest Value configuration</param>
    /// <param name="headers">Headers for REST request</param>
    /// <param name="resultConfigurations">Configurations to extract the values</param>
    /// <returns>Dictionary with with resultConfiguration as key and resulting value as Value</returns>
    /// <exception cref="InvalidOperationException">Throw if request results in not success status code</exception>
    Task<Dictionary<int, decimal>> GetResult(DtoRestValueConfiguration config,
        List<DtoRestValueConfigurationHeader> headers,
        List<DtoRestValueResultConfiguration> resultConfigurations);
}

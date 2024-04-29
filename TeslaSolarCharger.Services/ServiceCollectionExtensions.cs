﻿using Microsoft.Extensions.DependencyInjection;
using TeslaSolarCharger.Services.Services;
using TeslaSolarCharger.Services.Services.Modbus;
using TeslaSolarCharger.Services.Services.Modbus.Contracts;
using TeslaSolarCharger.Services.Services.Rest;
using TeslaSolarCharger.Services.Services.Rest.Contracts;

namespace TeslaSolarCharger.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServicesDependencies(this IServiceCollection services) =>
            services
                .AddTransient<IRestValueConfigurationService, RestValueConfigurationService>()
                .AddTransient<IRestValueExecutionService, RestValueExecutionService>()
                .AddSingleton<IModbusClientHandlingService, ModbusClientHandlingService>()
                .AddTransient<IModbusTcpClient, CustomModbusTcpClient>()
                .AddTransient<IModbusValueConfigurationService, ModbusValueConfigurationService>()
                .AddTransient<IModbusValueExecutionService, ModbusValueExecutionService>()
            ;
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MssqlTools;
using static North.ToolsInformation;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights()
    .AddScoped<MssqlTools.Tools>()
    .AddScoped<ISqlConnectionFactory,SqlConnectionFactory>();

builder.EnableMcpToolMetadata();

builder
    .ConfigureMcpTool(CreateTableToolName)
    .WithProperty(CreateTableSQLPropertyName, CreateTableSQLPropertyType, CreateTableSQLPropertyDescription);
builder
    .ConfigureMcpTool(DescribeTableDescription)
    .WithProperty(DescribeTableNamePropertyName, DescribeTableNamePropertyType, DescribeTableNamePropertyDescription);

builder
    .ConfigureMcpTool(DropTableToolName)
    .WithProperty(DropTablePropertyName, DropTablePropertyType, DropTablePropertyDescription);

builder
    .ConfigureMcpTool(InsertDataToolName)
    .WithProperty(InsertSQLPropertyName, InsertSQLPropertyType, InsertSQLPropertyDescription);

builder
    .ConfigureMcpTool(ReadDataToolName)
    .WithProperty(ReadSQLPropertyName,ReadSQLPropertyType, ReadSQLPropertyDescription);

builder
    .ConfigureMcpTool(UpdateDataToolName)
    .WithProperty(UpdateSQLPropertyName, UpdateSQLPropertyType, UpdateSQLPropertyDescription);


builder
    .ConfigureMcpTool(ListTablesToolName);


builder.Build().Run();

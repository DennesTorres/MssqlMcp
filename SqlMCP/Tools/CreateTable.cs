// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;
using static North.ToolsInformation;


namespace SqlMCP.Tools;

public partial class Tools
{
    [Function("CreateTable")]
    public async Task<DbOperationResult> CreateTable(
    [McpToolTrigger(CreateTableToolName, CreateTableDescription)]
        ToolInvocationContext context,
      [McpToolProperty(CreateTableSQLPropertyName, CreateTableSQLPropertyType, CreateTableSQLPropertyDescription)]
        string sql)
    {
        return await tools.CreateTable(sql);
    }
}

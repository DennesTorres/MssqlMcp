// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;
using static North.ToolsInformation;


namespace SqlMCP.Tools;

public partial class Tools
{
    [Function("InsertData")]
    public async Task<DbOperationResult> InsertData(
        [McpToolTrigger(InsertDataToolName, InsertDataDescription)]
        ToolInvocationContext context,
        [McpToolProperty(InsertSQLPropertyName, InsertSQLPropertyType, 
                InsertSQLPropertyDescription)]
        string sql)
    {
        return await tools.InsertData(sql);
    }
}

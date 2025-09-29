// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;

using MssqlTools;

namespace SqlMCP.Tools;
using static North.ToolsInformation;


public partial class Tools
{
    [Function("UpdateData")]
    public async Task<DbOperationResult> UpdateData(
        [McpToolTrigger(UpdateDataToolName, UpdateDataDescription)]
        ToolInvocationContext context,
        [McpToolProperty(UpdateSQLPropertyName, UpdateSQLPropertyType, 
                UpdateSQLPropertyDescription)]
        string sql)
    {
        return await tools.UpdateData(sql);
    }
}


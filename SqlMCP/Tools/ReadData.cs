// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;
using static North.ToolsInformation;

namespace SqlMCP.Tools;
public partial class Tools
{
    [Function("ReadData")]
    public async Task<DbOperationResult> ReadData(
        [McpToolTrigger(ReadDataToolName, ReadDataDescription)]
        ToolInvocationContext context,
        [McpToolProperty(ReadSQLPropertyName, ReadSQLPropertyType, 
                ReadSQLPropertyDescription)]
        string sql)
    {
        return await tools.ReadData(sql);
    }
}

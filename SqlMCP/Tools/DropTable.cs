// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.


using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;
using static North.ToolsInformation;

namespace SqlMCP.Tools;

public partial class Tools
{
    [Function("DropTable")]
    public async Task<DbOperationResult> DropTable(
        [McpToolTrigger(DropTableToolName, DropTableDescription)]
        ToolInvocationContext context,
        [McpToolProperty(DropTablePropertyName, DropTablePropertyType, 
                DropTablePropertyDescription)]
        string sql)
    {
        return await tools.DropTable(sql);
    }
}

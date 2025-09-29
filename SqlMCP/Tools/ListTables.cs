// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;
using static North.ToolsInformation;


namespace SqlMCP.Tools;

public partial class Tools
{
    [Function("ListTables")]
    public async Task<DbOperationResult> ListTables(
        [McpToolTrigger(ListTablesToolName, ListTablesDescription)]
        ToolInvocationContext context)
    {
        return await tools.ListTables(); 
    }
}

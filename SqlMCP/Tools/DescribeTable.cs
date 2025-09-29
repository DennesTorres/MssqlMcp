// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Mcp;
using MssqlTools;

namespace SqlMCP.Tools;
using static North.ToolsInformation;

public partial class Tools
{
    [Function("DescribeTable")]
    public async Task<DbOperationResult> DescribeTable(
        [McpToolTrigger(DescribeTableToolName, DescribeTableDescription)]
        ToolInvocationContext context,
        [McpToolProperty(DescribeTableNamePropertyName, DescribeTableNamePropertyType,
                DescribeTableNamePropertyDescription)]
        string name)
    {
        return await tools.DescribeTable(name);
    }
}

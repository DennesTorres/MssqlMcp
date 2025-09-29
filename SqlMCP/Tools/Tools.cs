// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using Microsoft.Extensions.Logging;
using MssqlTools;

namespace SqlMCP.Tools;

// Register this class as a tool container
public partial class Tools(ISqlConnectionFactory connectionFactory, MssqlTools.Tools toolsinput,
                        ILogger<Tools> logger)
{
    private readonly ISqlConnectionFactory _connectionFactory = connectionFactory;
    private readonly ILogger<Tools> _logger = logger;
    private readonly MssqlTools.Tools tools=toolsinput;


}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.


using Microsoft.Extensions.Logging;

namespace MssqlTools;

public partial class Tools
{
    public async Task<DbOperationResult> CreateTable(string sql)
    {
        var conn = await _connectionFactory.GetOpenConnectionAsync();
        try
        {
            using (conn)
            {
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
                _ = await cmd.ExecuteNonQueryAsync();
                return new DbOperationResult(success: true);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "CreateTable failed: {Message}", ex.Message);
            return new DbOperationResult(success: false, error: ex.Message);
        }
    }
}

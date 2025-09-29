
# Mssql SQL MCP Server (.NET 8)

This project is a .NET 8 console application implementing a Model Context Protocol (MCP) server for MSSQL Databases using the official [MCP C# SDK](https://github.com/modelcontextprotocol/csharp-sdk).

## Features

- Provide connection string via environment variable `CONNECTION_STRING`.
- **MCP Tools Implemented**:
  - ListTables: List all tables in the database.
  - DescribeTable: Get schema/details for a table.
  - CreateTable: Create new tables.
  - DropTable: Drop existing tables.
  - InsertData: Insert data into tables.
  - ReadData: Read/query data from tables.
  - UpdateData: Update values in tables.
- **Logging**: Console logging using Microsoft.Extensions.Logging.
- **Unit Tests**: xUnit-based unit tests for all major components.

## Getting Started

### Prerequisites

- Access to a SQL Server or Azure SQL Database

### Setup

1. **Build ***

This server is an Azure function. It needs to be deployed to Azure as an Azure function.

You need to configure the variable CONNECTION_STRING with your SQL Server or Azure SQL connectionstring

You need to link the function to application insights in order to access logs for troubleshooting when needed.

**Run the MCP Server**

You can use MCP Inspector or APIFY to test the function as an MCP Server.

Check the exceptions or traces log analytics table for any exception message.

# Troubleshooting

The function logs to log Analytics. When deploying the function, it needs to be linked to an application insights.


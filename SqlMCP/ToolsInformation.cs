namespace North;
internal sealed class ToolsInformation
{
    public const string CreateTableToolName = "create_table";
    public const string CreateTableDescription =
        "Creates a new table in the SQL Database. Expects a valid CREATE TABLE SQL statement as input.";
    public const string CreateTableSQLPropertyName = "createtablesql";
    public const string CreateTableSQLPropertyDescription = "Creates a new table in the SQL Database. Expects a valid CREATE TABLE SQL statement as input.";
    public const string CreateTableSQLPropertyType = "string";


    public const string UpdateDataToolName = "update_data";
    public const string UpdateDataDescription =
        "Creates a new table in the SQL Database. Expects a valid CREATE TABLE SQL statement as input.";
    public const string UpdateSQLPropertyName = "updatesql";
    public const string UpdateSQLPropertyDescription = "UPDATE SQL statement";
    public const string UpdateSQLPropertyType = "string";

    public const string ReadDataToolName = "read_data";
    public const string ReadDataDescription =
        "Creates a new table in the SQL Database. Expects a valid CREATE TABLE SQL statement as input.";
    public const string ReadSQLPropertyName = "readsql";
    public const string ReadSQLPropertyDescription = "SQL query to execute";
    public const string ReadSQLPropertyType = "string";

    public const string InsertDataToolName = "insert_data";
    public const string InsertDataDescription =
        "Insert data in a table in the SQL Database. Expects a valid INSERT SQL statement as input.";
    public const string InsertSQLPropertyName = "insertsql";
    public const string InsertSQLPropertyDescription = "INSERT SQL statement";
    public const string InsertSQLPropertyType = "string";

    public const string DropTableToolName = "drop_table";
    public const string DropTableDescription =
        "Drops a table in the SQL Database. Expects a valid DROP TABLE SQL statement as input.";
    public const string DropTablePropertyName = "droptable";
    public const string DropTablePropertyDescription = "DROP TABLE SQL statement";
    public const string DropTablePropertyType = "string";

    public const string DescribeTableToolName = "describe_table";
    public const string DescribeTableDescription =
        "Returns table schema";
    public const string DescribeTableNamePropertyName = "describetable";
    public const string DescribeTableNamePropertyDescription = "Name of table";
    public const string DescribeTableNamePropertyType = "string";

    public const string ListTablesToolName = "list_tables";
    public const string ListTablesDescription =
        "Returns a list with all the tables in the database";
}


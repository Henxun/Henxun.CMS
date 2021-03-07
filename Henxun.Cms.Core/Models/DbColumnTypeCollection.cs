using System;
using System.Collections.Generic;
using System.Text;

namespace Henxun.Cms.Core.Models
{
    public class DbColumnTypeCollection
    {
        public static IList<DbColumnDataType> DbColumnDataTypes => new List<DbColumnDataType>()
        {
            #region SqlServer，https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings

            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "bigint", CSharpType = "Int64"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "binary,image,varbinary(max),rowversion,timestamp,varbinary", CSharpType = "Byte[]"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "bit", CSharpType = "Boolean"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "char,nchar,text,ntext,varchar,nvarchar", CSharpType = "String"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "date,datetime,datetime2,smalldatetime", CSharpType ="DateTime"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "datetimeoffset", CSharpType ="DateTimeOffset"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "decimal,money,numeric,smallmoney", CSharpType ="Decimal"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "float", CSharpType ="Double"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "int", CSharpType ="Int32"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "real", CSharpType ="Single"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "smallint", CSharpType ="Int16"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "sql_variant", CSharpType ="Object"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "time", CSharpType ="TimeSpan"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "tinyint", CSharpType ="Byte"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.SqlServer, ColumnTypes = "uniqueidentifier", CSharpType ="Guid"},

            #endregion

            #region PostgreSQL，http://www.npgsql.org/doc/types/basic.html

            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "boolean,bit(1)", CSharpType ="Boolean"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "smallint", CSharpType ="short"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "integer", CSharpType ="int"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "bigint", CSharpType ="long"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "real", CSharpType ="float"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "double precision", CSharpType ="Double"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "numeric,money", CSharpType ="decimal"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "text,character,character varying,citext,json,jsonb,xml,name", CSharpType ="String"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "point", CSharpType ="NpgsqlTypes.NpgsqlPoint"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "lseg", CSharpType ="NpgsqlTypes.NpgsqlLSeg"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "path", CSharpType ="NpgsqlTypes.NpgsqlPath"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "polygon", CSharpType ="NpgsqlTypes.NpgsqlPolygon"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "line", CSharpType ="NpgsqlTypes.NpgsqlLine"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "circle", CSharpType ="NpgsqlTypes.NpgsqlCircle"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "box", CSharpType ="NpgsqlTypes.NpgsqlBox"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "bit(n),bit varying", CSharpType ="BitArray"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "hstore", CSharpType ="IDictionary<string, string>"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "uuid", CSharpType ="Guid"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "cidr", CSharpType ="ValueTuple<IPAddress, int>"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "inet", CSharpType ="IPAddress"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "macaddr", CSharpType ="PhysicalAddress"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "tsquery", CSharpType ="NpgsqlTypes.NpgsqlTsQuery"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "tsvector", CSharpType ="NpgsqlTypes.NpgsqlTsVector"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "date,timestamp,timestamp with time zone,timestamp without time zone", CSharpType ="DateTime"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "interval,time", CSharpType ="TimeSpan"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "time with time zone", CSharpType ="DateTimeOffset"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "bytea", CSharpType ="Byte[]"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "oid,xid,cid", CSharpType ="uint"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "oidvector", CSharpType ="uint[]"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "char", CSharpType ="char"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "geometry", CSharpType ="NpgsqlTypes.PostgisGeometry"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.PostgreSQL, ColumnTypes = "record", CSharpType ="object[]"},

            #endregion

            #region MySQL，https://www.devart.com/dotconnect/mysql/docs/DataTypeMapping.html

            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "bool,boolean,bit(1),tinyint(1)", CSharpType ="Boolean"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "tinyint", CSharpType ="SByte"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "tinyint unsigned", CSharpType ="Byte"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "smallint, year", CSharpType ="Int16"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "int, integer, smallint unsigned, mediumint", CSharpType ="Int32"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "bigint, int unsigned, integer unsigned, bit", CSharpType ="Int64"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "float", CSharpType ="Single"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "double, real", CSharpType ="Double"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "decimal, numeric, dec, fixed, bigint unsigned, float unsigned, double unsigned, serial", CSharpType ="Decimal"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "date, timestamp, datetime", CSharpType ="DateTime"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "datetimeoffset", CSharpType ="DateTimeOffset"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "time", CSharpType ="TimeSpan"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "char, varchar, tinytext, text, mediumtext, longtext, set, enum, nchar, national char, nvarchar, national varchar, character varying", CSharpType ="String"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "binary, varbinary, tinyblob, blob, mediumblob, longblob, char byte", CSharpType ="Byte[]"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "geometry", CSharpType ="System.Data.Spatial.DbGeometry"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.MySQL, ColumnTypes = "geometry", CSharpType ="System.Data.Spatial.DbGeography"},

            #endregion

            #region Oracle, https://docs.oracle.com/cd/E14435_01/win.111/e10927/featUDTs.htm#CJABAEDD

            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "BFILE,BLOB,RAW,LONG RAW", CSharpType ="Byte[]"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "CHAR, NCHAR, VARCHAR2, CLOB, NCLOB,NVARCHAR2,REF,XMLTYPE,ROWID,LONG", CSharpType ="String"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "BINARY FLOAT,BINARY DOUBLE", CSharpType ="System.Byte"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "INTERVAL YEAR TO MONTH", CSharpType ="Int32"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "FLOAT,INTEGER,NUMBER", CSharpType ="Decimal"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "DATE, TIMESTAMP, TIMESTAMP WITH LOCAL TIME ZONE,TIMESTAMP WITH TIME ZONE", CSharpType ="DateTime"},
            new DbColumnDataType(){ DataBaseType = DataBaseType.Oracle, ColumnTypes = "INTERVAL DAY TO SECOND", CSharpType ="TimeSpan"},

            #endregion
        };
    }
}

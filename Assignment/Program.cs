using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using static Azure.Core.HttpHeader;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            // EF Core Overview
            /// Entity Framework Core(EF Core) is an ORM (Object Relational Mapper).
            /// It allows you to work with a database using C# classes instead of writing SQL queries directly.
            /// Benefits:
            /// LINQ Queries instead of raw SQL. 
            /// Migrations to manage schema changes.
            /// 

            // ADO.NET vs Dapper vs EF Core
            /// ADO.NET:
            /// Low - level → you must write SQL manually.
            /// Gives full control but is verbose and hard to maintain.
            /// Dapper:
            /// A lightweight Micro ORM.
            /// Faster than EF Core.
            /// You still write SQL, but it maps results to objects automatically.
            /// EF Core:
            /// A full ORM.
            /// Works directly with C# classes (no SQL needed most of the time).
            /// Slightly slower than Dapper, but much more productive.

            //DbContext 
            /// The bridge between your code and the database.
            /// It contains:
            /// DbSet < TEntity > → represents a table.
            /// OnModelCreating → for custom configurations, throuth Override OnConfiguring 

            // Types of Mapping
            /// 1.By Convention
            /// EF Core automatically infers rules based on names.
            /// 2.By Data Annotation
            /// Use attributes to configure properties explicitly.
            /// 

            // Migrations
            /// Migrations let you manage database schema changes like version control.
            /// Key commands:
            /// add - migration InitialCreate
            /// update - database
            /// remove - migration

            #endregion

        }
    }
}

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace BHDemo.Data
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public class BHDemoDbContext : System.Data.Entity.DbContext, IBHDemoDbContext
    {
        public System.Data.Entity.DbSet<Reason> Reasons { get; set; } // Reasons
        public System.Data.Entity.DbSet<User> Users { get; set; } // Users

        static BHDemoDbContext()
        {
            System.Data.Entity.Database.SetInitializer<BHDemoDbContext>(null);
        }

        public BHDemoDbContext()
            : base("Name=BHDemo")
        {
        }

        public BHDemoDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public BHDemoDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public BHDemoDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public BHDemoDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        public BHDemoDbContext(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ReasonConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new UserConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>

using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;

namespace SalesAppBackend.Module.BusinessObjects {
	public class SalesAppBackendContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(SalesAppBackendDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(SalesAppBackendContextInitializer))]
	public class SalesAppBackendDbContext : DbContext {
		public SalesAppBackendDbContext(String connectionString)
			: base(connectionString) {
		}
		public SalesAppBackendDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public SalesAppBackendDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	}
}
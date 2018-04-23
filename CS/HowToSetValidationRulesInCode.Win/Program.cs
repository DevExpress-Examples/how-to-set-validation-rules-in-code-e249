using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace HowToSetValidationRulesInCode.Win {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			HowToSetValidationRulesInCodeWindowsFormsApplication application = new HowToSetValidationRulesInCodeWindowsFormsApplication();
			if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
				application.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
			}
			try {
    DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register();
    				application.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString;
				application.Setup();
				application.Start();
			}
			catch(Exception e) {
				application.HandleException(e);
			}
		}
	}
}

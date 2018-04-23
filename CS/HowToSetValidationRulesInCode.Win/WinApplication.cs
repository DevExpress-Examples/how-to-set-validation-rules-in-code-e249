using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace HowToSetValidationRulesInCode.Win {
	public partial class HowToSetValidationRulesInCodeWindowsFormsApplication : WinApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
		public HowToSetValidationRulesInCodeWindowsFormsApplication() {
			InitializeComponent();
		}

		private void HowToSetValidationRulesInCodeWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
        	e.Updater.Update();
			e.Handled = true;
		}
	}
}

Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace HowToSetValidationRulesInCode.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim webApplication As New HowToSetValidationRulesInCodeWindowsFormsApplication()
            Try
                DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register()
                webApplication.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString
                webApplication.Setup()
                webApplication.Start()
            Catch e As Exception
                webApplication.HandleException(e)
            End Try
        End Sub
    End Class
End Namespace

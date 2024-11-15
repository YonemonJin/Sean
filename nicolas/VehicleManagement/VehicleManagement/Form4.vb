Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Form3.Show()
        Dim report As New ReportDocument
        report.Load("C:\Users\SANDBOX-15\Documents\nicolas\VehicleManagement\VehicleManagement\CrystalReport1.rpt")
        Form3.CrystalReportViewer1.ReportSource = report
        Form3.CrystalReportViewer1.Refresh()
    End Sub
End Class
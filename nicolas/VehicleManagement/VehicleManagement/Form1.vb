Imports MySql.Data.MySqlClient
Public Class Form1
    Dim query As String
    Dim tableinfo As DataTable 'hold record from sql'
    Dim da As MySqlDataAdapter 'handle sql query'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call databaseconnect procedure'
        databaseConnect()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            query = "SELECT * FROM vehicleinfo"
            'send sql query to server'
            da = New MySqlDataAdapter(query, datacon)
            tableinfo = New DataTable
            'Fill in the table'
            da.Fill(tableinfo)
            'displayrecord'

            datarecord.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill
            datarecord.DataSource = tableinfo
            datacon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

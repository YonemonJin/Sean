Imports MySql.Data.MySqlClient
Public Class Form2
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim model, plateno, type As String
    Dim query As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaseConnect()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        model = txtmodel.Text
        type = txttype.Text
        plateno = txtplate.Text
        query = "INSERT INTO vehicleinfo(vType, " &
            "plateNo, vModel) VALUE('" &
            type & "','" & plateno & "','" &
            model & "')"
        If type <> "" And model <> "" And
                plateno <> "" Then
            Try
                With cmd
                    .Connection = datacon
                    .CommandText = query
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("save successful!")
                        txtmodel.Clear()
                        txttype.Clear()
                        txtplate.Clear()
                    Else
                        MsgBox("Failed to insert Record.")
                    End If
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Fill in the info")
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class
Imports MySql.Data.MySqlClient

Module Module1
    'declare variables'
    Public datacon As New MySqlConnection
    Dim server As String = "127.0.0.1"
    Dim dbasename As String = "cs2dbase"
    Dim username As String = "root"
    Dim passwd As String = "password" 'depends on server'
    'create a connection of a subprocedure'
    Public Sub databaseConnect()
        'check if connection exists'
        If Not datacon Is Nothing Then
            'establish connection'
            datacon.ConnectionString = "server=" &
            server & ";user id=" & username &
            ";password=" & passwd & ";database=" & dbasename & ""
            Try
                'open connection'
                datacon.Open()
                MsgBox("database connected!")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

End Module

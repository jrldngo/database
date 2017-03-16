Imports System.Data
Imports System.Data.OleDb

Module mdlConnection
    Dim conStr As String = My.Settings.CDB111_CBD_BUNDANGConnectionString

    Public Function Execute(ByVal command As String) As DataTable
        Try
            Dim cn As New OleDbConnection(conStr)
            Dim da As New OleDbDataAdapter(command, cn)
            Dim cb As New OleDbCommandBuilder(da)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return Nothing
        End Try

    End Function
End Module

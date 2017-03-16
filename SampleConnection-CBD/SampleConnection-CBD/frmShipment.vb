Imports System.Data.OleDb
Public Class frmShipment

    Public Sub RefreshForm()
        Dim ds As New DataSet
        Dim myCon As New OleDbConnection
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT CaptainName FROM Captain", myCon)
        da.Fill(ds, "Captain")
        Dim viewSub As New 

    End Sub

    Private Sub frmShipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub
End Class
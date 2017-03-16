Public Class frmCaptain

    Private Sub RefreshForm()
        Dim dt As DataTable
        dt = Execute("Select * from captain")
        'dt = Execute("SELECT CaptainName, CaptainID " & _
        '           "FROM Captain " & _
        '          "WHERE CaptainName = 'Lj'")
        dgvOutput.DataSource = dt
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = Execute("SELECT CaptainName, CaptainID " & _
                     "FROM Captain " & _
                     "WHERE CaptainName LIKE '%" & txtSearch.Text & "%'")
        dgvOutput.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Execute("INSERT INTO Captain VALUES " & _
                "('" & txtCaptainID.Text & "', '" & txtCaptainName.Text & "')")
        RefreshForm()
    End Sub

    Private Sub dgvOutput_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOutput.CellClick
        txtCaptainID.Text = dgvOutput.SelectedRows(0).Cells(0).Value
        txtCaptainName.Text = dgvOutput.SelectedRows(0).Cells(1).Value
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Execute("UPDATE Captain SET CaptainID = '" & txtCaptainID.Text & "', CaptainName = '" & txtCaptainName.Text & "' WHERE CaptainID = '" & dgvOutput.SelectedRows(0).Cells(0).Value & "'")
        RefreshForm()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Execute("DELETE FROM Captain WHERE CaptainID = '" & dgvOutput.SelectedRows(0).Cells(0).Value & "'")
        RefreshForm()
    End Sub


End Class

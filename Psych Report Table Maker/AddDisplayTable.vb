Public Class AddDisplayTable
    Public Title As String
    Public TableName As String
    Public FirstColumn As String
    Public Score As Boolean
    Public Percentile As Boolean
    Public Range As Boolean
    Public Cancel As Boolean = True
    Public Note As String
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtTableName.Text = "" Then
            MsgBox("Table title is required.")
            txtTableName.Focus()
            Exit Sub
        Else
            Title = txtTableTitle.Text
            TableName = txtTableName.Text
            FirstColumn = txtFirstColumn.Text
            Score = cbxScore.Checked
            Percentile = cbxPercentile.Checked
            Range = cbxRange.Checked
            Note = txtNote.Text
            Cancel = False
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
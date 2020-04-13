Public Class AddRangeLabel

    Public RangeLabel As String
    Public LowerBound As Double?
    Public UpperBound As Double?
    Public ScoreTypeID As Integer
    Public Cancel As Boolean = True
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtRangeLabel.Text = "" Then
            MsgBox("Range label is required.")
            txtRangeLabel.Focus()
        Else
            Cancel = False
            RangeLabel = txtRangeLabel.Text
            If txtUpperBound.Text = "" Then
                UpperBound = Nothing
            Else
                UpperBound = CDbl(txtUpperBound.Text)
            End If
            If txtLowerBound.Text = "" Then
                LowerBound = Nothing
            Else
                LowerBound = CDbl(txtLowerBound.Text)
            End If
            ScoreTypeID = CType(CType(ScoreTypeBindingSource.Current, DataRowView).Row, tmDataSet.ScoreTypeRow).ScoreTypeID
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub AddRangeLabel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ScoreTypeTableAdapter.Fill(Me.tmDataSet.ScoreType)
        If ScoreTypeID = 0 Then
            ScoreTypeBindingSource.Position = 0
        Else
            ScoreTypeBindingSource.Position = ScoreTypeBindingSource.Find("ScoreTypeID", ScoreTypeID)
        End If
    End Sub

    Private Sub txtLowerBound_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLowerBound.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "-"c Or e.KeyChar = "."c Then
        Else
            e.KeyChar = CChar(Char.ConvertFromUtf32(0))
        End If
    End Sub

End Class
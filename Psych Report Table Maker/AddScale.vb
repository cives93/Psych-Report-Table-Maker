Public Class AddScale
    Public intScoreType As Integer
    Public strScaleName As String
    Public Cancel As Boolean = True
    Public intLevel As Integer
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtScale.Text = "" Then
            MsgBox("Scale name is required")
            txtScale.Focus()
        Else
            strScaleName = txtScale.Text
            If ScoreTypeBindingSource.Position = -1 Then
                MsgBox("Select a score type")
            Else
                intScoreType = CType(CType(ScoreTypeBindingSource.Current, DataRowView).Row, tmDataSet.ScoreTypeRow).ScoreTypeID
                Cancel = False
                intLevel = lstLevel.SelectedIndex
                My.Settings.LastScoreType = intScoreType
                My.Settings.LastScaleType = intLevel
                My.Settings.Save()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub AddScale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ScoreTypeTableAdapter.Fill(Me.tmDataSet.ScoreType)
        Dim pdc As System.ComponentModel.PropertyDescriptorCollection = ScoreTypeBindingSource.CurrencyManager.GetItemProperties()
        Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("ScoreTypeID", True)
        ScoreTypeBindingSource.Position = ScoreTypeBindingSource.Find(prop, My.Settings.LastScoreType)
        lstLevel.SelectedIndex = My.Settings.LastScaleType
    End Sub
End Class
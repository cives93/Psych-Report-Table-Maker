Public Class AddBattery
    Public BatteryName As String
    Public Abbreviation As String
    Public Cancel As Boolean = True
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtBatteryName.Text = "" Then
            MsgBox("Last Name is required")
            txtBatteryName.Focus()
        Else
            BatteryName = txtBatteryName.Text
            Abbreviation = txtAbbreviation.Text
            Cancel = False
            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
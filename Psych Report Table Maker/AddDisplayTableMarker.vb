Public Class AddDisplayTableMarker
    Public MarkerMeaning As String
    Public MarkerSymbol As String
    Public Cancel As Boolean = True
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtMarkerSymbol.Text = "" Then
            MsgBox("A marker symbol is required.")
            txtMarkerSymbol.Focus()
            Exit Sub
        Else
            MarkerSymbol = txtMarkerSymbol.Text
            MarkerMeaning = txtMarkerMeaning.Text
            Cancel = False
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddDisplayTableMarker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtMarkerMeaning.Focus()
    End Sub
End Class
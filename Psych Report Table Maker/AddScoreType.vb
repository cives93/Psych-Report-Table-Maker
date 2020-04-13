Public Class AddScoreType
    Public Cancel As Boolean = True
    Public Mean As Double?
    Public SD As Double?
    Public ScoreTypeName As String
    Public StandardScore As Boolean = True
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtScoreType.Text = "" Then
            MsgBox("Score Type is required")
            txtScoreType.Focus()
        Else
            If txtMean.Text = "" And lstStandardScore.SelectedIndex = 0 Then
                MsgBox("A mean is required")
                txtMean.Focus()
            Else
                If txtSD.Text = "" And lstStandardScore.SelectedIndex = 0 Then
                    MsgBox("A standard deviation is required")
                    txtSD.Focus()
                Else
                    If lstStandardScore.SelectedIndex = 0 Then
                        Mean = CDbl(txtMean.Text)
                        SD = CDbl(txtSD.Text)
                    Else
                        Mean = Nothing
                        SD = Nothing
                    End If
                    StandardScore = lstStandardScore.SelectedIndex = 0
                    Cancel = False
                    ScoreTypeName = txtScoreType.Text
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtSD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSD.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            e.KeyChar = CChar(Char.ConvertFromUtf32(0))
        End If
    End Sub

    Private Sub txtMean_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMean.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
        Else
            e.KeyChar = CChar(Char.ConvertFromUtf32(0))
        End If
    End Sub


    Private Sub lstStandardScore_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstStandardScore.SelectedIndexChanged
        If lstStandardScore.SelectedIndex = 0 Then
            txtMean.Enabled = True
            txtSD.Enabled = True
        Else
            txtMean.Enabled = False
            txtMean.Text = ""
            txtSD.Enabled = False
            txtSD.Text = ""
        End If
    End Sub

    Private Sub AddScoreType_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstStandardScore.SelectedIndex = 0
    End Sub
End Class
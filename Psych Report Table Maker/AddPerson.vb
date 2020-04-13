Public Class AddPerson
    Public LastName As String
    Public FirstName As String
    Public Age As Integer
    Public Cancel As Boolean = True
    Public ClientID As String
    Public Birthdate As Date
    Public Sex As Integer
    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If txtLastName.Text = "" Then
            MsgBox("Last Name is required")
            txtLastName.Focus()
            Exit Sub
        Else
            LastName = txtLastName.Text
        End If
        FirstName = txtFirstName.Text
        Birthdate = dtpBirthdate.Value
        ClientID = txtClientID.Text
        Sex = lstSex.SelectedIndex
        Cancel = False
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddPerson_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpBirthdate.Value = Today
        lstSex.SelectedIndex = 0
        txtFirstName.Focus()
    End Sub


End Class
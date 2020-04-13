Public Class SelectDisplayTables
    Public blnCancel As Boolean

    Private Sub SelectDisplayTables_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DisplayTableTableAdapter.Update(tmDataSet.DisplayTable)
    End Sub
    Private Sub SelectDisplayTables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisplayTableTableAdapter.Fill(tmDataSet.DisplayTable)
        ' DisplayTableBindingSource.Sort = "Include DESC, DisplayTableDisplay, OrderID"
        DisplayTableBindingSource.MoveFirst()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        blnCancel = True
        Me.Close()
    End Sub

    Private Sub btnUpDisplayItem_Click(sender As System.Object, e As System.EventArgs) Handles btnUpDisplayItem.Click
        If DisplayTableBindingSource.Position > 0 Then
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            Dim intTemp As Integer = dt.OrderID
            DisplayTableBindingSource.MovePrevious()
            Dim udt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            dt.OrderID = udt.OrderID
            udt.OrderID = intTemp
            intTemp = dt.DisplayTableID
            DisplayTableBindingSource.Sort = "Include DESC, OrderID"
            DisplayTableBindingSource.Position = DisplayTableBindingSource.Find("DisplayTableID", intTemp)
        End If

    End Sub

    Private Sub btnDownDisplayItem_Click(sender As System.Object, e As System.EventArgs) Handles btnDownDisplayItem.Click
        If DisplayTableBindingSource.Position <> -1 Then
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            Dim intTemp As Integer = dt.OrderID
            DisplayTableBindingSource.MoveNext()
            Dim udt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            dt.OrderID = udt.OrderID
            udt.OrderID = intTemp
            intTemp = dt.DisplayTableID
            DisplayTableBindingSource.Sort = "Include DESC, OrderID"
            DisplayTableBindingSource.Position = DisplayTableBindingSource.Find("DisplayTableID", intTemp)
        End If
    End Sub

    Private Sub btnOkay_Click(sender As System.Object, e As System.EventArgs) Handles btnOkay.Click
        blnCancel = False
        Me.Close()
    End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
    '    If CheckBox1.Checked Then
    '        'DisplayTableBindingSource.Filter = "Include = True"
    '        DisplayTableBindingSource.Sort = "Include DESC, OrderID"
    '    Else
    '        DisplayTableBindingSource.Filter = ""
    '        DisplayTableBindingSource.Sort = "DisplayTableName"
    '    End If

    'End Sub

    Private Sub btnExclude_Click(sender As Object, e As EventArgs) Handles btnExclude.Click
        If DisplayTableBindingSource.Position <> -1 Then
            If dgvIncludeTable.SelectedRows.Count = 0 Then
                Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
                dt.Include = False
                'DisplayTableBindingSource.Sort = "Include DESC, OrderID"
                'ExcludeTableBindingSource.Sort = "DisplayTableDisplay, OrderID"
                DisplayTableBindingSource.MoveFirst()
                ExcludeTableBindingSource.Position = ExcludeTableBindingSource.Find("DisplayTableID", dt.DisplayTableID)
            Else
                For Each r As DataGridViewRow In dgvIncludeTable.SelectedRows
                    Dim dtr As tmDataSet.DisplayTableRow = CType(CType(r.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableRow)
                    dtr.Include = False
                Next
                DisplayTableBindingSource.MoveFirst()
            End If





        End If
    End Sub

    Private Sub btnInclude_Click(sender As Object, e As EventArgs) Handles btnInclude.Click
        If ExcludeTableBindingSource.Position <> -1 Then
            If dvgExcludeTable.SelectedRows.Count = 0 Then
                Dim dt As tmDataSet.DisplayTableRow = CType(CType(ExcludeTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
                dt.Include = True

                'ExcludeTableBindingSource.Sort = "Include DESC, DisplayTableDisplay, OrderID"
                ExcludeTableBindingSource.MovePrevious()
                DisplayTableBindingSource.Position = DisplayTableBindingSource.Find("DisplayTableID", dt.DisplayTableID)
            Else
                For Each r As DataGridViewRow In dvgExcludeTable.SelectedRows
                    Dim dtr As tmDataSet.DisplayTableRow = CType(CType(r.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableRow)
                    dtr.Include = True
                Next
                ExcludeTableBindingSource.MoveFirst()
            End If
        End If

    End Sub
End Class


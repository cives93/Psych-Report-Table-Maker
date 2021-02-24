Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Drawing.Text
Imports MathNet.Numerics.Distributions
Imports System.IO
Imports System.Xml

Public Class TableMaker
    Dim blnClosing As Boolean
    Dim LastDate As Date = Date.Today
    Dim blnUpdating As Boolean

    Private Sub TableMaker_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        blnClosing = True
        SaveData()
        My.Settings.LastFont = cbxFont.SelectedItem.ToString
        My.Settings.Save()
    End Sub

    Private Sub TableMaker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayTableBindingSource.Filter = "Hide = " & False
        Me.ReportItemTableAdapter.Fill(Me.tmDataSet.ReportItem)
        Me.ReportTableAdapter.Fill(Me.tmDataSet.Report)
        Dim ff As New InstalledFontCollection
        For Each f As System.Drawing.FontFamily In ff.Families
            If f.IsStyleAvailable(FontStyle.Regular) And f.IsStyleAvailable(FontStyle.Bold) And f.IsStyleAvailable(FontStyle.Italic) Then
                cbxFont.Items.Add(f.Name)
            End If
        Next
        Dim st As tmDataSet.ScaleTypeRow
        st = tmDataSet.ScaleType.NewScaleTypeRow()
        st.ScaleTypeID = 0
        st.ScaleTypeName = "Scale"
        tmDataSet.ScaleType.AddScaleTypeRow(st)
        st = tmDataSet.ScaleType.NewScaleTypeRow()
        st.ScaleTypeID = 1
        st.ScaleTypeName = "Subscale"
        tmDataSet.ScaleType.AddScaleTypeRow(st)

        Dim sex As tmDataSet.SexRow
        sex = tmDataSet.Sex.NewSexRow
        sex.SexID = 0
        sex.Sex = "Male"
        tmDataSet.Sex.AddSexRow(sex)
        sex = tmDataSet.Sex.NewSexRow
        sex.SexID = 1
        sex.Sex = "Female"
        tmDataSet.Sex.AddSexRow(sex)

        cbxFont.SelectedIndex = cbxFont.Items.IndexOf(My.Settings.LastFont)
        BatteryBindingSource.Filter = "HideBattery = " & False
        DisplayTableBindingSource.Sort = "DisplayTableName"
        BatteryDataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        ScaleDataGridView.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        ScoreTypeDataGridView.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        RangeLabelDataGridView.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        DisplayTableItemDataGridView.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.RangeTableAdapter.Fill(Me.tmDataSet.Range)
        Me.RangeLabelTableAdapter.Fill(Me.tmDataSet.RangeLabel)
        RangeLabelBindingSource.Sort = "LowerBound DESC"
        Me.ScoreTypeTableAdapter.Fill(Me.tmDataSet.ScoreType)
        Me.BatteryTableAdapter.Fill(Me.tmDataSet.Battery)
        Me.ScaleTableAdapter.Fill(Me.tmDataSet.Scale)
        Me.PersonTableAdapter.Fill(Me.tmDataSet.Person)
        Me.PersonBatteryTableAdapter.Fill(Me.tmDataSet.PersonBattery)
        Me.PersonBatteryAdministrationTableAdapter.Fill(Me.tmDataSet.PersonBatteryAdministration)
        Me.PersonBatteryScaleTableAdapter.Fill(Me.tmDataSet.PersonBatteryScale)
        Me.DisplayTableTableAdapter.Fill(Me.tmDataSet.DisplayTable)
        Me.DisplayTableItemTableAdapter.Fill(Me.tmDataSet.DisplayTableItem)
        Me.DisplayTableMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableMarker)
        Me.DisplayTableItemMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableItemMarker)
        FormatDisplayItem()
        AdminList()
        FormatPersonBatteryScale()

    End Sub

    Private Sub btnAddPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPerson.Click
        Dim p As New AddPerson
        p.ShowDialog(Me)
        If p.Cancel = False Then
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = PersonTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            PersonTableAdapter.Insert(p.FirstName, p.LastName, p.ClientID, p.Birthdate, p.Sex)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            blnUpdating = True
            PersonTableAdapter.Fill(tmDataSet.Person)
            'PersonBindingSource.MoveLast()
            blnUpdating = False
            PersonBindingSource.Position = PersonBindingSource.Find("PersonID", id)
        End If
    End Sub

    Private Sub btnDeletePerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePerson.Click
        If PersonBindingSource.Position <> -1 Then
            Dim p As tmDataSet.PersonRow
            p = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow)
            Dim pID As Integer = p.PersonID
            Dim strName As String
            If p.IsFirstNameNull Then
                strName = ""
            Else
                strName = p.FirstName
            End If
            If p.IsLastNameNull Then
                strName = strName
            Else
                If strName = "" Then
                    strName = p.LastName
                Else
                    strName &= " " & p.LastName
                End If
            End If

            If strName = "" Then
                strName = "this person"
            End If

            If strName.EndsWith("s") Then
                strName &= "'"
            Else
                strName &= "'s"
            End If

            If MsgBox("Delete " & strName & " data?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
                blnUpdating = True
                SaveData()
                For Each pbs As tmDataSet.PersonBatteryScaleRow In (From pbsr In tmDataSet.PersonBatteryScale Where pbsr.PersonBatteryRow.PersonID = pID)
                    pbs.Delete()
                Next
                For Each pba As tmDataSet.PersonBatteryAdministrationRow In (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonBatteryRow.PersonID = pID)
                    pba.Delete()
                Next
                For Each pb As tmDataSet.PersonBatteryRow In (From pbr In tmDataSet.PersonBattery Where pbr.PersonID = pID)
                    pb.Delete()
                Next
                SaveData()
                p = tmDataSet.Person.FindByPersonID(pID)
                p.Delete()
                PersonTableAdapter.Update(tmDataSet.Person)
                blnUpdating = False
                If tmDataSet.Person.Rows.Count > 0 Then
                    PersonBindingSource.Position = 0
                Else
                    PersonBindingSource.Position = -1
                End If
                Me.Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Sub SaveData()
        Me.Validate()
        Dim BindingSourcesQuery = From bindingsources In Me.components.Components
              Where (TypeOf bindingsources Is Windows.Forms.BindingSource)
              Select bindingsources

        For Each bindingSource As Windows.Forms.BindingSource In BindingSourcesQuery
            bindingSource.EndEdit()
        Next
        TableAdapterManager.UpdateAll(Me.tmDataSet)
    End Sub

    Private Sub btnAddTestGiven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTestGiven.Click
        If PersonBindingSource.Position <> -1 And BatteryBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            SaveData()
            Dim p As tmDataSet.PersonRow
            p = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow)
            Dim b As tmDataSet.BatteryRow
            b = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            Dim pb As tmDataSet.PersonBatteryRow
            pb = tmDataSet.PersonBattery.NewPersonBatteryRow
            Dim bID, pID As Integer
            bID = b.BatteryID
            pID = p.PersonID
            pb.BatteryID = bID
            pb.PersonID = pID

            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = PersonBatteryTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            PersonBatteryTableAdapter.Insert(b.BatteryID, p.PersonID, LastDate)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.PersonBatteryTableAdapter.ClearBeforeFill = False
            Me.PersonBatteryTableAdapter.FillBy(Me.tmDataSet.PersonBattery, id)
            Me.PersonBatteryTableAdapter.ClearBeforeFill = True
            'Me.tmDataSet.PersonBattery.AddPersonBatteryRow(pb)
            'PersonBatteryTableAdapter.Update(Me.tmDataSet.PersonBattery)
            'PersonBatteryBindingSource.EndEdit()
            Dim pbsr As tmDataSet.PersonBatteryScaleRow
            Dim pba As tmDataSet.PersonBatteryAdministrationRow
            Dim intPBCount As Integer = (From pbr As tmDataSet.PersonBatteryRow In tmDataSet.PersonBattery Where pbr.BatteryID = bID And pbr.PersonID = pID).Count
            If intPBCount < 2 Then
                pba = Me.tmDataSet.PersonBatteryAdministration.NewPersonBatteryAdministrationRow
                With pba
                    .BatteryID = bID
                    .PersonBatteryID = id
                    .PersonID = pID
                End With
                Me.tmDataSet.PersonBatteryAdministration.AddPersonBatteryAdministrationRow(pba)
                SaveData()
                PersonBatteryAdministrationTableAdapter.Fill(tmDataSet.PersonBatteryAdministration)
            Else
                pba = (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonID = pID And pbar.BatteryID = bID).ToArray(0)
                pba.PersonBatteryID = id
            End If
            'Stores start time in variable "StartTime"
            'Prints execution time in the debug window
            For Each s As tmDataSet.ScaleRow In (From sr In tmDataSet.Scale Where sr.BatteryID = bID Order By sr.OrderID)
                pbsr = tmDataSet.PersonBatteryScale.NewPersonBatteryScaleRow
                With pbsr
                    .PersonBatteryID = id
                    .ScaleID = s.ScaleID
                End With
                tmDataSet.PersonBatteryScale.AddPersonBatteryScaleRow(pbsr)
                'PersonBatteryScaleTableAdapter.Insert(id, s.ScaleID, Nothing)
            Next
            'Dim start As Integer = My.Computer.Clock.LocalTime.Millisecond
            SaveData()
            For Each pbsr In (From pbs In tmDataSet.PersonBatteryScale Where pbs.PersonBatteryID = id)
                pbsr.Delete()
            Next
            tmDataSet.PersonBatteryScale.AcceptChanges()
            'PersonBatteryScaleTableAdapter.Update(tmDataSet.PersonBatteryScale)
            PersonBatteryScaleTableAdapter.ClearBeforeFill = False
            PersonBatteryScaleTableAdapter.FillBy(Me.tmDataSet.PersonBatteryScale, id)
            PersonBatteryScaleTableAdapter.ClearBeforeFill = True

            'Dim endtime As Integer = My.Computer.Clock.LocalTime.Millisecond
            'Dim elapsed As Integer = endtime - start
            'Debug.Print("Execution time in seconds: " & elapsed)
            FormatPersonBatteryScale()
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = PersonBatteryBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("PersonBatteryID", True)
            blnUpdating = False
            PersonBatteryBindingSource.Position = PersonBatteryBindingSource.Find(prop, id)
            PersonBatteryScaleDataGridView.Focus()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnDeleteTestGiven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteTestGiven.Click
        If PersonBatteryBindingSource.Position <> -1 Then
            blnUpdating = True
            SaveData()
            Dim pb As tmDataSet.PersonBatteryRow = CType(CType(PersonBatteryBindingSource.Current, DataRowView).Row, tmDataSet.PersonBatteryRow)
            Dim pbID As Integer = pb.PersonBatteryID
            Dim pbs() As tmDataSet.PersonBatteryScaleRow = (From pbsr In Me.tmDataSet.PersonBatteryScale Where pbsr.PersonBatteryID = pbID).ToArray
            For Each pbsr As tmDataSet.PersonBatteryScaleRow In pbs
                pbsr.Delete()
            Next

            pb = tmDataSet.PersonBattery.FindByPersonBatteryID(pbID)
            Dim pba As tmDataSet.PersonBatteryAdministrationRow = (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonID = pb.PersonID And pbar.BatteryID = pb.BatteryID).ToArray(0)
            Dim Checkpb() As tmDataSet.PersonBatteryRow = (From pbr As tmDataSet.PersonBatteryRow In tmDataSet.PersonBattery Where pbr.PersonID = pb.PersonID And pbr.BatteryID = pb.BatteryID And pbr.PersonBatteryID <> pbID).ToArray
            If Checkpb.Length = 0 Then
                pba.Delete()
            Else
                pba.PersonBatteryID = Checkpb(0).PersonBatteryID
            End If
            pb.Delete()
            SaveData()
            blnUpdating = False

        End If
    End Sub

    Private Sub btnAddBattery_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBattery.Click
        Dim ab As New AddBattery
        ab.ShowDialog(Me)

        If ab.Cancel = False Then
            blnUpdating = True

            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = BatteryTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            BatteryTableAdapter.Insert(ab.BatteryName, False, ab.Abbreviation)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.BatteryTableAdapter.ClearBeforeFill = False
            Me.BatteryTableAdapter.FillBy(Me.tmDataSet.Battery, id)
            Me.BatteryTableAdapter.ClearBeforeFill = True
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = BatteryBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("BatteryID", True)
            BatteryBindingSource.Sort = "BatteryName"
            blnUpdating = False
            BatteryBindingSource.Position = BatteryBindingSource.Find(prop, id)
        End If
    End Sub

    Private Sub btnDeleteBattery_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteBattery.Click
        If BatteryBindingSource.Position <> -1 Then
            blnUpdating = True
            SaveData()
            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            Dim bID As Integer = b.BatteryID
            Dim pbs() As tmDataSet.PersonBatteryRow = (From pb As tmDataSet.PersonBatteryRow In Me.tmDataSet.PersonBattery Where pb.BatteryID = bID).ToArray
            Dim lstDT As New List(Of tmDataSet.DisplayTableRow)
            If pbs.Count = 0 Then
                Dim ss() As tmDataSet.ScaleRow = (From sr In Me.tmDataSet.Scale Where sr.BatteryID = bID).ToArray
                For Each sr As tmDataSet.ScaleRow In ss
                    Dim sID As Integer = sr.ScaleID
                    Dim dt() As tmDataSet.DisplayTableRow = (From dti As tmDataSet.DisplayTableItemRow In Me.tmDataSet.DisplayTableItem Where dti.ScaleID = sID Select dti.DisplayTableRow Distinct).ToArray
                    For Each dtr As tmDataSet.DisplayTableRow In dt
                        lstDT.Add(dtr)
                    Next
                Next
                Dim sdt() As String = (From dtr As tmDataSet.DisplayTableRow In lstDT Select dtr.DisplayTableName Distinct).ToArray
                If sdt.Count > 0 Then
                    Dim sDisplay As String = ""
                    For Each s As String In sdt
                        sDisplay &= vbCrLf & s
                    Next
                    MsgBox("This battery (" & b.BatteryName & ") cannot be deleted until the scales from this battery have been deleted from the following display tables:" & sDisplay)
                Else
                    For Each sr As tmDataSet.ScaleRow In ss
                        sr.Delete()
                    Next
                    b = tmDataSet.Battery.FindByBatteryID(bID)
                    b.Delete()
                    SaveData()
                End If
            Else
                Dim Names As String = ""
                For Each pbsr In pbs
                    Dim sLastName, sFirstName As String
                    If pbsr.PersonRow.IsLastNameNull Then
                        sLastName = ""
                    Else
                        sLastName = pbsr.PersonRow.LastName
                    End If
                    If pbsr.PersonRow.IsFirstNameNull Then
                        sFirstName = ""
                    Else
                        sFirstName = pbsr.PersonRow.FirstName
                    End If
                    Names &= vbCrLf & sFirstName & " " & sLastName
                Next
                MsgBox("This battery (" & b.BatteryName & ") cannot be deleted until scores from this battery have been deleted from the following individuals' profiles:" & Names)
            End If
            blnUpdating = False
        End If
    End Sub

    Private Sub btnAddScale_Click(sender As System.Object, e As System.EventArgs) Handles btnAddScale.Click
        If BatteryBindingSource.Position <> -1 Then
            Dim nScale As New AddScale
            nScale.ShowDialog(Me)
            If nScale.Cancel = False Then
                Me.Cursor = Cursors.WaitCursor
                blnUpdating = True
                SaveData()
                Dim b As tmDataSet.BatteryRow
                b = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
                Dim bID As Integer
                bID = b.BatteryID
                Dim cmd As New SqlServerCe.SqlCeCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = ScaleTableAdapter.Connection
                cmd.CommandText = "SELECT @@identity"
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                ScaleTableAdapter.Insert(nScale.strScaleName, bID, nScale.intLevel, 0, nScale.intScoreType)
                Dim id As Integer = CInt(cmd.ExecuteScalar())
                cmd.Connection.Close()
                Me.ScaleTableAdapter.ClearBeforeFill = False
                Me.ScaleTableAdapter.FillBy(Me.tmDataSet.Scale, id)
                Me.ScaleTableAdapter.ClearBeforeFill = True
                Dim pdc As System.ComponentModel.PropertyDescriptorCollection = ScaleBindingSource.CurrencyManager.GetItemProperties()
                Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("ScaleID", True)
                ScaleBindingSource.Position = ScaleBindingSource.Find(prop, id)
                Dim s As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
                s.OrderID = s.ScaleID
                blnUpdating = False
                Me.Cursor = Cursors.Default
            End If

        End If

    End Sub


    Private Sub btnDeleteScale_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteScale.Click
        If ScaleBindingSource.Position <> -1 Then
            blnUpdating = True
            SaveData()
            Dim s As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            Dim bID As Integer = b.BatteryID
            Dim sID As Integer = s.ScaleID
            Dim pbs() As tmDataSet.PersonBatteryScaleRow = (From pbsr As tmDataSet.PersonBatteryScaleRow In Me.tmDataSet.PersonBatteryScale Where pbsr.ScaleID = sID).ToArray
            Dim lstDT As New List(Of tmDataSet.DisplayTableRow)
            If pbs.Count = 0 Then
                Dim dt() As tmDataSet.DisplayTableRow = (From dti As tmDataSet.DisplayTableItemRow In Me.tmDataSet.DisplayTableItem Where dti.ScaleID = sID Select dti.DisplayTableRow Distinct).ToArray
                For Each dtr As tmDataSet.DisplayTableRow In dt
                    lstDT.Add(dtr)
                Next
                Dim sdt() As String = (From dtr As tmDataSet.DisplayTableRow In lstDT Select dtr.DisplayTableName Distinct).ToArray
                If sdt.Count > 0 Then
                    Dim sDisplay As String = ""
                    For Each sd As String In sdt
                        sDisplay &= vbCrLf & sd
                    Next
                    MsgBox("This battery (" & b.BatteryName & ") cannot be deleted until the following scales from this battery have been deleted from the following display tables:" & sDisplay)
                Else
                    s.Delete()
                    SaveData()
                End If
            Else
                Dim Names As String = ""
                Dim p() As tmDataSet.PersonRow = (From pbsr As tmDataSet.PersonBatteryScaleRow In pbs Select pbsr.PersonBatteryRow.PersonRow Distinct).ToArray
                For Each pr In p
                    Dim sLastName, sFirstName As String
                    If pr.IsLastNameNull Then
                        sLastName = ""
                    Else
                        sLastName = pr.LastName
                    End If
                    If pr.IsFirstNameNull Then
                        sFirstName = ""
                    Else
                        sFirstName = pr.FirstName
                    End If
                    Names &= vbCrLf & sFirstName & " " & sLastName
                Next
                MsgBox("This scale (" & s.ScaleName & ") cannot be deleted until scores from this scale have been deleted from the following individuals' profiles:" & Names)
            End If
            blnUpdating = False

        End If

    End Sub

    Private Sub btnUpScale_Click(sender As System.Object, e As System.EventArgs) Handles btnUpScale.Click
        If ScaleBindingSource.Position > 0 Then
            'Dim GridRow As Integer = 2000000
            ''Dim LowestScale As tmDataSet.ScaleRow
            'Dim nSelected As Integer = ScaleDataGridView.SelectedRows.Count
            'Dim SelectedScales(nSelected - 1) As tmDataSet.ScaleRow
            'For i As Integer = 0 To nSelected - 1
            '    If GridRow > ScaleDataGridView.SelectedRows(i).Index Then GridRow = ScaleDataGridView.SelectedRows(i).Index
            '    If ScaleDataGridView.SelectedRows(i).DataBoundItem IsNot Nothing Then
            '        SelectedScales(i) = CType(CType(ScaleDataGridView.SelectedRows(i).DataBoundItem, DataRowView).Row, tmDataSet.ScaleRow)
            '    End If
            'Next
            'Dim LowestID As Integer = (From s In SelectedScales Select s.OrderID).Min
            'Dim HighestID As Integer = (From s In SelectedScales Select s.OrderID).Max
            'Dim pdc = ScaleBindingSource.CurrencyManager.GetItemProperties()

            'Dim LowPositionID As Integer = ScaleBindingSource.Find(pdc("OrderID"), LowestID)
            'Dim HighPositionID As Integer = ScaleBindingSource.Find(pdc("OrderID"), LowestID)
            'If LowPositionID > 0 Then
            '    Dim sp As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Item(LowPositionID - 1), DataRowView).Row, tmDataSet.ScaleRow)
            '    Dim OrderedScales As tmDataSet.ScaleRow() = (From ss In SelectedScales Select ss Order By ss.OrderID).ToArray
            '    For i As Integer = 0 To OrderedScales.Count - 1
            '        If sp.OrderID > OrderedScales(i).OrderID Then
            '            Dim tempID = OrderedScales(i).OrderID
            '            OrderedScales(i).OrderID = sp.OrderID
            '            sp.OrderID = tempID
            '        End If
            '    Next
            '    ScaleBindingSource.Sort = "OrderID"
            '    For i As Integer = GridRow - 1 To GridRow + nSelected - 2
            '        ScaleDataGridView.Rows(i).Selected = True
            '    Next
            '    ScaleDataGridView.Rows(GridRow + nSelected - 1).Selected = False
            'End If


            'For Each si As DataGridViewRow In ScaleDataGridView.SelectedRows
            '    Dim sr As tmDataSet.ScaleRow

            '    If si.DataBoundItem IsNot Nothing Then
            '        sr = CType(CType(si.DataBoundItem, DataRowView).Row, tmDataSet.ScaleRow)

            '        If LowestID = 0 Or sr.OrderID < LowestID Then
            '            LowestID = sr.OrderID
            '            LowestScale = sr
            '        End If
            '    End If
            'Next
            Dim s1 As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
            ScaleBindingSource.MovePrevious()
            Dim s2 As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
            Dim temp As Integer = s1.OrderID
            s1.OrderID = s2.OrderID
            s2.OrderID = temp
            ScaleBindingSource.Sort = "OrderID"
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = ScaleBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("ScaleID", True)
            ScaleBindingSource.Position = ScaleBindingSource.Find(prop, s1.ScaleID)
        End If
    End Sub

    Private Sub btnDownScale_Click(sender As System.Object, e As System.EventArgs) Handles btnDownScale.Click
        If ScaleBindingSource.Position <> -1 Then
            Dim s1 As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
            Dim intScaleCount As Integer = (From s In Me.tmDataSet.Scale Where s.BatteryID = s1.BatteryID).Count
            If ScaleBindingSource.Position < intScaleCount - 1 Then
                ScaleBindingSource.MoveNext()
                Dim s2 As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
                Dim temp As Integer = s1.OrderID
                s1.OrderID = s2.OrderID
                s2.OrderID = temp
                ScaleBindingSource.Sort = "OrderID"
                Dim pdc As System.ComponentModel.PropertyDescriptorCollection = ScaleBindingSource.CurrencyManager.GetItemProperties()
                Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("ScaleID", True)
                ScaleBindingSource.Position = ScaleBindingSource.Find(prop, s1.ScaleID)
            End If
        End If
    End Sub

    Private Sub btnAddScoreType_Click(sender As System.Object, e As System.EventArgs) Handles btnAddScoreType.Click
        Dim ast As New AddScoreType
        ast.ShowDialog(Me)
        If ast.Cancel = False Then
            Me.Cursor = Cursors.WaitCursor
            SaveData()
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = ScoreTypeTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            ScoreTypeTableAdapter.Insert(ast.ScoreTypeName, ast.Mean, ast.SD, ast.StandardScore)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.ScoreTypeTableAdapter.Fill(Me.tmDataSet.ScoreType)
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = ScoreTypeBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("ScoreTypeID", True)
            ScoreTypeBindingSource.Position = ScoreTypeBindingSource.Find(prop, id)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnDeleteScoreType_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteScoreType.Click
        If ScoreTypeBindingSource.Position <> -1 Then
            Dim st As tmDataSet.ScoreTypeRow = CType(CType(ScoreTypeBindingSource.Current, DataRowView).Row, tmDataSet.ScoreTypeRow)
            If st.ScoreTypeID > 10 Then
                Dim b() As String = (From s In tmDataSet.Scale Where s.ScoreTypeID = st.ScoreTypeID Select s.BatteryRow.BatteryName Distinct).ToArray
                Dim bNames As String = ""
                For Each sb In b
                    bNames &= vbCrLf & sb
                Next
                If b.Count > 0 Then
                    MsgBox("This score type cannot be deleted because scales in the following batteries use this score type:" & bNames & vbCrLf & "Change the score types for those scales or delete them.")
                Else
                    SaveData()
                    st.Delete()
                    SaveData()
                    ScoreTypeTableAdapter.Fill(tmDataSet.ScoreType)
                End If
            Else
                MsgBox("The " & st.ScoreTypeName & " score type cannot be deleted.")
            End If
        End If

    End Sub


    Private Sub ScoreTypeBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles ScoreTypeBindingSource.CurrentChanged
        If ScoreTypeBindingSource.Position <> -1 Then
            Dim st As tmDataSet.ScoreTypeRow = CType(CType(ScoreTypeBindingSource.Current, DataRowView).Row, tmDataSet.ScoreTypeRow)
            DataGridViewTextBoxColumn8.ReadOnly = st.ScoreTypeID < 11
            DataGridViewTextBoxColumn9.ReadOnly = st.ScoreTypeID < 11
            DataGridViewTextBoxColumn10.ReadOnly = st.ScoreTypeID < 11
            StandardScore.ReadOnly = st.ScoreTypeID < 11
            RangeLabelBindingSource.Filter = "ScoreTypeID = " & st.ScoreTypeID
        Else
            RangeLabelBindingSource.Filter = ""
        End If
    End Sub


    Private Sub btnAddDisplayTable_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDisplayTable.Click
        Dim adt As New AddDisplayTable
        If BatteryBindingSource.Position <> -1 Then
            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            If b.IsBatteryNameNull = False Then
                If b.BatteryName <> "" Then
                    adt.txtTableTitle.Text = b.BatteryName
                End If
                If b.IsAbbreviationNull = False Then
                    If b.Abbreviation <> "" Then
                        adt.txtTableTitle.Text &= " (" & b.Abbreviation & ")"
                    End If
                End If
            End If
            If b.IsAbbreviationNull = False Then
                If b.Abbreviation <> "" Then
                    adt.txtTableName.Text = b.Abbreviation
                End If
            End If
            Dim st() As tmDataSet.ScoreTypeRow = (From scr In tmDataSet.Scale Where scr.BatteryID = b.BatteryID Select scr.ScoreTypeRow Distinct).ToArray
            Dim sNote As String = ""
            For Each s In st
                If s.StandardScore Then
                    sNote &= s.ScoreTypeName.Substring(0, 1) & s.ScoreTypeName.ToLower.Substring(1) & "s have a mean of " & s.Mean & " and a standard deviation of " & s.SD & ". "
                End If
            Next
            adt.txtNote.Text = sNote
        End If
        adt.ShowDialog(Me)
        If adt.Cancel = False Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            SaveData()
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = DisplayTableTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            DisplayTableTableAdapter.Insert(adt.TableName, 1, adt.FirstColumn, adt.Score, adt.Percentile, adt.Range, adt.Title, adt.Note, 1, False, 0, False)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.DisplayTableTableAdapter.Fill(Me.tmDataSet.DisplayTable)
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableID", True)
            blnUpdating = False

            DisplayTableBindingSource.Position = DisplayTableBindingSource.Find(prop, id)
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            dt.OrderID = dt.DisplayTableID
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnDeleteDisplayTable_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteDisplayTable.Click
        If DisplayTableBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            SaveData()
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            For Each dtim As tmDataSet.DisplayTableItemMarkerRow In (From dtimr In tmDataSet.DisplayTableItemMarker Where dtimr.DisplayTableItemRow.DisplayTableID = dt.DisplayTableID).ToArray
                dtim.Delete()
            Next
            For Each dti As tmDataSet.DisplayTableItemRow In (From dtir As tmDataSet.DisplayTableItemRow In Me.tmDataSet.DisplayTableItem Where dtir.DisplayTableID = dt.DisplayTableID).ToArray
                dti.Delete()
            Next
            For Each dtm As tmDataSet.DisplayTableMarkerRow In (From dtmr In Me.tmDataSet.DisplayTableMarker Where dtmr.DisplayTableID = dt.DisplayTableID).ToArray
                dtm.Delete()
            Next
            dt.Delete()
            SaveData()
            blnUpdating = False
            FormatDisplayItem()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnAddDisplayMarker_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDisplayMarker.Click
        If DisplayTableBindingSource.Position <> -1 Then
            Dim adtm As New AddDisplayTableMarker
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            Dim intMarkerCount As Integer = (From dtmr In tmDataSet.DisplayTableMarker Where dtmr.DisplayTableID = dt.DisplayTableID).Count
            Dim sMarker(4) As String
            sMarker(0) = "*"
            sMarker(1) = "†"
            sMarker(2) = "‡"
            sMarker(3) = "§"
            sMarker(4) = "**"
            If intMarkerCount > 4 Then intMarkerCount = 0
            adtm.txtMarkerSymbol.Text = sMarker(intMarkerCount)
            adtm.txtMarkerMeaning.Text = ""
            adtm.ShowDialog(Me)
            If adtm.Cancel = False Then
                Me.Cursor = Cursors.WaitCursor
                blnUpdating = True
                SaveData()
                Dim cmd As New SqlServerCe.SqlCeCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = DisplayTableMarkerTableAdapter.Connection
                cmd.CommandText = "SELECT @@identity"
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                DisplayTableMarkerTableAdapter.Insert(dt.DisplayTableID, adtm.MarkerMeaning, adtm.MarkerSymbol)
                Dim id As Integer = CInt(cmd.ExecuteScalar())
                cmd.Connection.Close()
                Me.DisplayTableMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableMarker)
                Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableMarkerBindingSource.CurrencyManager.GetItemProperties()
                Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableMarkerID", True)
                blnUpdating = False
                DisplayTableMarkerBindingSource.Position = DisplayTableMarkerBindingSource.Find(prop, id)
                FormatDisplayItem()
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub btnDeleteDisplayMarker_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteDisplayMarker.Click
        If DisplayTableMarkerBindingSource.Position <> -1 Then
            blnUpdating = True
            Dim dtm As tmDataSet.DisplayTableMarkerRow = CType(CType(DisplayTableMarkerBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableMarkerRow)
            For Each dtim In (From dtimr In Me.tmDataSet.DisplayTableItemMarker Where dtimr.DisplayTableMarkerID = dtm.DisplayTableMarkerID).ToArray
                dtim.Delete()
            Next
            dtm.Delete()
            SaveData()
            Me.DisplayTableMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableMarker)
            Me.DisplayTableItemMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableItemMarker)
            blnUpdating = False
            FormatDisplayItem()
        End If
    End Sub
    Private Sub btnAddAllDisplayItems_Click(sender As Object, e As System.EventArgs) Handles btnAddAllDisplayItems.Click
        If DisplayTableBindingSource.Position <> -1 And ScaleBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            SaveData()
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)

            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            For Each sc In (From scr In tmDataSet.Scale Where scr.BatteryID = b.BatteryID Order By scr.OrderID).ToArray
                Dim intLevel As Integer
                If sc.IsLevelNull Then intLevel = 0 Else intLevel = sc.Level
                Dim dti As tmDataSet.DisplayTableItemRow = Me.tmDataSet.DisplayTableItem.NewDisplayTableItemRow
                With dti
                    .Bold = sc.Level = 0
                    .AllCaps = False
                    .DisplayTableID = dt.DisplayTableID
                    .OrderID = 0
                    .Italic = False
                    .Level = sc.Level
                    .Size = 12
                    .ScaleID = sc.ScaleID
                    .Abbreviation = False
                End With
                Me.tmDataSet.DisplayTableItem.AddDisplayTableItemRow(dti)
            Next
            Me.DisplayTableItemTableAdapter.Update(Me.tmDataSet.DisplayTableItem)
            Me.DisplayTableItemTableAdapter.Fill(Me.tmDataSet.DisplayTableItem)
            For Each dti In (From dtir In tmDataSet.DisplayTableItem Where dtir.OrderID = 0).ToArray
                dti.OrderID = dti.DisplayTableItemID
            Next
            DisplayTableItemBindingSource.Sort = "OrderID"
            blnUpdating = False
            FormatDisplayItem()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnAddDisplayTableItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddDisplayTableItem.Click
        If DisplayTableBindingSource.Position <> -1 And ScaleBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            Dim InsertAfterID As Integer = 0
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            Dim sc As tmDataSet.ScaleRow = CType(CType(ScaleBindingSource.Current, DataRowView).Row, tmDataSet.ScaleRow)
            Dim idti As tmDataSet.DisplayTableItemRow = Nothing
            If DisplayTableItemBindingSource.Position <> -1 Then
                idti = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            End If
            SaveData()
            Dim intLevel As Integer
            If sc.IsLevelNull Then intLevel = 0 Else intLevel = sc.Level
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = DisplayTableItemTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            If idti Is Nothing Then
                DisplayTableItemTableAdapter.Insert(dt.DisplayTableID, 12, False, False, False, intLevel, sc.ScaleID, Nothing, False, False, False, "white")
            Else
                InsertAfterID = idti.OrderID
                DisplayTableItemTableAdapter.Insert(dt.DisplayTableID, idti.Size, idti.Italic, idti.Bold, idti.AllCaps, idti.Level, sc.ScaleID, Nothing, idti.Abbreviation, idti.BorderAbove, idti.BorderBelow, idti.FillColor)
            End If

            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.DisplayTableItemTableAdapter.ClearBeforeFill = False
            Me.DisplayTableItemTableAdapter.FillBy(Me.tmDataSet.DisplayTableItem, id)
            Me.DisplayTableItemTableAdapter.ClearBeforeFill = True
            Dim dti As tmDataSet.DisplayTableItemRow = Me.tmDataSet.DisplayTableItem.FindByDisplayTableItemID(id)
            dti.OrderID = id
            If InsertAfterID > 0 Then
                Dim blnExit As Boolean
                Do
                    Dim TempID As Integer = dti.OrderID
                    Dim mdti() As tmDataSet.DisplayTableItemRow = (From dtir In Me.tmDataSet.DisplayTableItem Where (dtir.OrderID < TempID And dtir.OrderID > InsertAfterID And dtir.DisplayTableID = dt.DisplayTableID) Select dtir Order By dtir.OrderID Descending).ToArray
                    If mdti.Length > 0 Then
                        dti.OrderID = mdti(0).OrderID
                        mdti(0).OrderID = TempID
                    End If
                    blnExit = mdti.Length = 0
                Loop Until blnExit
            End If
            DisplayTableItemBindingSource.Sort = "OrderID"
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableItemBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableItemID", True)
            DisplayTableItemBindingSource.Position = DisplayTableItemBindingSource.Find(prop, id)
            blnUpdating = False
            ScaleBindingSource.MoveNext()
            FormatDisplay()
            FormatDisplayItem()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnDeleteDisplayTableItem_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteDisplayTableItem.Click
        If DisplayTableItemBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            blnUpdating = True
            SaveData()
            Dim dti As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            Dim dtiID As Integer = dti.DisplayTableItemID
            For Each dtim As tmDataSet.DisplayTableItemMarkerRow In (From dtimr In Me.tmDataSet.DisplayTableItemMarker Where dtimr.DisplayTableItemID = dtiID).ToArray
                dtim.Delete()
            Next
            dti.Delete()
            SaveData()
            blnUpdating = False
            FormatDisplay()
            FormatDisplayItem()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnMarkItem_Click(sender As System.Object, e As System.EventArgs) Handles btnMarkItem.Click
        If DisplayTableItemBindingSource.Position <> -1 And DisplayTableMarkerBindingSource.Position <> -1 Then
            blnUpdating = True
            Dim dti As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            Dim dtm As tmDataSet.DisplayTableMarkerRow = CType(CType(DisplayTableMarkerBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableMarkerRow)
            SaveData()
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = DisplayTableItemMarkerTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            DisplayTableItemMarkerTableAdapter.Insert(dti.DisplayTableItemID, dtm.DisplayTableMarkerID)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.DisplayTableItemMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableItemMarker)
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableItemMarkerBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableItemMarkerID", True)
            blnUpdating = False
            DisplayTableItemMarkerBindingSource.Position = DisplayTableItemMarkerBindingSource.Find(prop, id)
            FormatDisplayItem()
        End If
    End Sub

    Private Sub btnUnmarkItem_Click(sender As System.Object, e As System.EventArgs) Handles btnUnmarkItem.Click
        If DisplayTableItemMarkerBindingSource.Position <> -1 Then
            blnUpdating = True
            Dim dtim As tmDataSet.DisplayTableItemMarkerRow = CType(CType(DisplayTableItemMarkerBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemMarkerRow)
            SaveData()
            dtim.Delete()
            SaveData()
            Me.DisplayTableItemMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableItemMarker)
            blnUpdating = False
            FormatDisplayItem()
        End If
    End Sub

    Private Sub cbxHide_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxHide.CheckedChanged
        If cbxHide.Checked Then
            BatteryBindingSource.Filter = "HideBattery = " & True
        Else
            BatteryBindingSource.Filter = "HideBattery = " & False
        End If
    End Sub

    Private Sub FormatDisplayItem()
        Dim blnDisplayItemScore As Boolean = False
        If DisplayTableItemDataGridView.Rows.Count > 0 And blnUpdating = False Then
            Me.Validate()
            DisplayTableItemBindingSource.EndEdit()
            DisplayTableBindingSource.EndEdit()
            Dim dtr As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            Dim p As tmDataSet.PersonRow
            If PersonBatteryBindingSource.Position <> -1 Then
                p = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow)
            Else
                p = Nothing
            End If

            For Each dr As DataGridViewRow In Me.DisplayTableItemDataGridView.Rows
                dr.Cells("RangeColumn").Value = ""
                dr.Cells("PercentileColumn").Value = ""
                dr.Cells("RangeColumn").Value = ""
                If dr.DataBoundItem IsNot Nothing Then
                    Dim dti As tmDataSet.DisplayTableItemRow = CType(CType(dr.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                    If dti.Italic Then
                        If dti.Bold Then
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableItemDataGridView.DefaultCellStyle.Font.FontFamily, CSng(dti.Size), FontStyle.Italic Or FontStyle.Bold)
                        Else
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableItemDataGridView.DefaultCellStyle.Font.FontFamily, CSng(dti.Size), FontStyle.Italic)
                        End If
                    Else
                        If dti.Bold Then
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableItemDataGridView.DefaultCellStyle.Font.FontFamily, CSng(dti.Size), FontStyle.Bold)
                        Else
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableItemDataGridView.DefaultCellStyle.Font.FontFamily, CSng(dti.Size), FontStyle.Regular)
                        End If
                    End If
                    If dti.IsBorderAboveNull Then
                        dti.BorderAbove = False
                    End If

                    If dti.IsBorderBelowNull Then
                        dti.BorderBelow = False
                    End If

                    If dti.IsScaleNameNull = False Then
                        If dti.AllCaps Then
                            dr.Cells("Marker").Value = dti.ScaleName.ToUpper
                        Else
                            dr.Cells("Marker").Value = dti.ScaleName
                        End If
                        If dti.Abbreviation Then
                            If dti.ScaleRow.BatteryRow.IsAbbreviationNull = False Then
                                dr.Cells("Marker").Value = dr.Cells("Marker").Value.ToString & " (" & dti.ScaleRow.BatteryRow.Abbreviation & ")"
                            Else
                                dr.Cells("Marker").Value = dr.Cells("Marker").Value.ToString & " (" & dti.ScaleRow.BatteryRow.BatteryName & ")"
                            End If
                        End If
                    Else
                        dr.Cells("Marker").Value = ""
                    End If
                    For Each dtmi In (From dtmir In tmDataSet.DisplayTableItemMarker Where dtmir.DisplayTableItemID = dti.DisplayTableItemID Order By dtmir.DisplayTableItemMarkerID).ToArray
                        If dr.Cells("Marker").Value Is Nothing Then
                            dr.Cells("Marker").Value = dtmi.DisplayTableMarkerRow.MarkerSymbol
                        Else
                            dr.Cells("Marker").Value = dr.Cells("Marker").Value.ToString & dtmi.DisplayTableMarkerRow.MarkerSymbol
                        End If
                    Next
                    If p IsNot Nothing Then
                        Dim pbs() As tmDataSet.PersonBatteryScaleRow = CType(tmDataSet.PersonBatteryScale.Select("PersonID = " & p.PersonID & " AND ScaleID = " & dti.ScaleID), tmDataSet.PersonBatteryScaleRow())
                        If pbs.Length > 0 Then
                            Dim pba As tmDataSet.PersonBatteryAdministrationRow = (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonID = p.PersonID And pbar.BatteryID = pbs(0).PersonBatteryRow.BatteryID).FirstOrDefault
                            Dim pbsr As tmDataSet.PersonBatteryScaleRow = (From pbsi In pbs Where pbsi.PersonBatteryID = pba.PersonBatteryID).FirstOrDefault
                            If pbsr.IsScoreNull = False Then
                                dr.Cells("DisplayItemScore").Value = pbsr.Score
                                Dim st As tmDataSet.ScoreTypeRow = dti.ScaleRow.ScoreTypeRow

                                Dim r As tmDataSet.RangeRow = dtr.RangeRow
                                Dim rl() As tmDataSet.RangeLabelRow = (From rlr In tmDataSet.RangeLabel Where rlr.RangeID = r.RangeID And rlr.ScoreTypeID = st.ScoreTypeID And rlr.IsLowerBoundNull = False Order By rlr.LowerBound Descending Select rlr).ToArray
                                Dim rLowest() As tmDataSet.RangeLabelRow = (From rlr In tmDataSet.RangeLabel Where rlr.RangeID = r.RangeID And rlr.ScoreTypeID = st.ScoreTypeID And rlr.IsLowerBoundNull = True Select rlr).ToArray

                                If rLowest.Length > 0 Then
                                    dr.Cells("RangeColumn").Value = rLowest(0).RangeLabel
                                End If
                                For Each rlr In rl
                                    If pbsr.Score >= rlr.LowerBound Then
                                        dr.Cells("RangeColumn").Value = rlr.RangeLabel
                                        Exit For
                                    End If
                                Next
                                Dim norm As New Normal
                                If st.StandardScore Then
                                    dr.Cells("PercentileColumn").Value = PercentRounder(norm.CumulativeDistribution((pbsr.Score - st.Mean) / st.SD))
                                End If

                                Select Case dti.ScaleRow.ScoreTypeID
                                    Case 7 'Percentile
                                        dr.Cells("PercentileColumn").Value = pbsr.Score
                                        dr.Cells("DisplayItemScore").Value = ""
                                    Case 10 'Cumulative Percentile
                                        dr.Cells("PercentileColumn").Value = pbsr.Score
                                        dr.Cells("DisplayItemScore").Value = ""
                                End Select

                            End If
                        End If
                    End If
                End If
            Next
        End If
        DisplayItemScore.Visible = ScoreCheckBox.Checked
        PercentileColumn.Visible = PercentileCheckBox.Checked
        RangeColumn.Visible = RangeCheckBox.Checked
        If BatteryBindingSource.Position = -1 Then
            FilteredPersonBatteryBindingSource.Filter = "PersonBatteryID < 0"
        Else
            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            FilteredPersonBatteryBindingSource.Filter = "BatteryID = " & b.BatteryID
        End If

    End Sub

    Private Function PercentRounder(ByVal d As Double, Optional ByVal Odds As Boolean = False) As String
        Dim f As Double = 0
        If d > 0.9905 Then f = 1 - d
        If d < 0.0095 Then f = d
        Dim MaxDigits As Integer = 14
        If f = 0 Then
            Return CStr(System.Math.Round(d, 2) * 100) & If(Odds, "%", "")
        Else
            Dim remainder As Double = f
            Dim intDigits As Integer = 1


            Do
                intDigits += 1
            Loop Until (remainder * System.Math.Pow(10, intDigits) >= 1) Or (intDigits > MaxDigits)
            If intDigits > MaxDigits Then
                remainder = System.Math.Round(remainder, intDigits)
                intDigits = 1
                Do
                    intDigits += 1
                Loop Until (remainder * System.Math.Pow(10, intDigits) >= 1) Or (intDigits > MaxDigits)
            End If
            If Odds And d < 0.5 Then
                Return CStr(System.Math.Round(d, intDigits) * 10 ^ intDigits) & " in " & (10 ^ intDigits).ToString("N0")
            Else
                Return CStr(System.Math.Round(d, intDigits) * 100)
            End If

        End If

    End Function

    Private Sub btnAddRangeLabel_Click(sender As System.Object, e As System.EventArgs) Handles btnAddRangeLabel.Click
        If ScoreTypeBindingSource.Position <> -1 And RangeBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            SaveData()
            Dim r As tmDataSet.RangeRow = CType(CType(RangeBindingSource.Current, DataRowView).Row, tmDataSet.RangeRow)
            Dim sc As tmDataSet.ScoreTypeRow = CType(CType(ScoreTypeBindingSource.Current, DataRowView).Row, tmDataSet.ScoreTypeRow)
            Dim arl As New AddRangeLabel
            arl.ScoreTypeID = sc.ScoreTypeID
            arl.ShowDialog(Me)
            If arl.Cancel = False Then
                Dim cmd As New SqlServerCe.SqlCeCommand
                cmd.CommandType = CommandType.Text
                cmd.Connection = RangeLabelTableAdapter.Connection
                cmd.CommandText = "SELECT @@identity"
                If cmd.Connection.State <> ConnectionState.Open Then
                    cmd.Connection.Open()
                End If
                RangeLabelTableAdapter.Insert(arl.RangeLabel, r.RangeID, arl.ScoreTypeID, arl.LowerBound, arl.UpperBound)
                Dim id As Integer = CInt(cmd.ExecuteScalar())
                cmd.Connection.Close()
                Me.RangeLabelTableAdapter.Fill(Me.tmDataSet.RangeLabel)
                ScoreTypeBindingSource.Position = ScoreTypeBindingSource.Find("ScoreTypeID", arl.ScoreTypeID)
                Dim pdc As System.ComponentModel.PropertyDescriptorCollection = RangeLabelBindingSource.CurrencyManager.GetItemProperties()
                Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("RangeLabelID", True)
                RangeLabelBindingSource.Position = RangeLabelBindingSource.Find(prop, id)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub btnDeleteRange_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteRange.Click
        If RangeBindingSource.Position <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            SaveData()
            Dim r As tmDataSet.RangeRow = CType(CType(RangeBindingSource.Current, DataRowView).Row, tmDataSet.RangeRow)
            Dim rID As Integer = r.RangeID
            If rID = 1 Then
                MsgBox("This range cannot be deleted. However, it can be renamed and edited to any system desired.")
            Else
                Dim dt() As String = (From dtr In tmDataSet.DisplayTable Where dtr.RangeID = r.RangeID Select dtr.DisplayTableName).ToArray
                If dt.Count = 0 Then
                    For Each rl As tmDataSet.RangeLabelRow In (From rlr In Me.tmDataSet.RangeLabel Where rlr.RangeID = rID).ToArray
                        rl.Delete()
                    Next
                    r.Delete()
                    SaveData()
                    Me.RangeLabelTableAdapter.Fill(Me.tmDataSet.RangeLabel)
                    Me.RangeTableAdapter.Fill(Me.tmDataSet.Range)
                Else
                    Dim dtNames As String = ""
                    For Each s In dt
                        dtNames &= vbCrLf & s
                    Next
                    MsgBox("This range cannot be deleted yet because it is being used in the following tables:" & dtNames)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnAddRange_Click(sender As System.Object, e As System.EventArgs) Handles btnAddRange.Click
        Dim sRange As String = InputBox("Name of range", "Add range", "")
        If sRange <> "" Then
            Me.Cursor = Cursors.WaitCursor
            SaveData()
            Dim cmd As New SqlServerCe.SqlCeCommand
            cmd.CommandType = CommandType.Text
            cmd.Connection = RangeTableAdapter.Connection
            cmd.CommandText = "SELECT @@identity"
            If cmd.Connection.State <> ConnectionState.Open Then
                cmd.Connection.Open()
            End If
            RangeTableAdapter.Insert(sRange)
            Dim id As Integer = CInt(cmd.ExecuteScalar())
            cmd.Connection.Close()
            Me.RangeTableAdapter.Fill(Me.tmDataSet.Range)
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = RangeBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("RangeID", True)
            RangeBindingSource.Position = RangeBindingSource.Find(prop, id)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BoldCheckBox_Enter(sender As Object, e As System.EventArgs) Handles BoldCheckBox.Enter
        AddHandler BoldCheckBox.CheckStateChanged, AddressOf BoldCheckBox_CheckedChanged
    End Sub

    Private Sub BoldCheckBox_Leave(sender As Object, e As System.EventArgs) Handles BoldCheckBox.Leave
        RemoveHandler BoldCheckBox.CheckStateChanged, AddressOf BoldCheckBox_CheckedChanged
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs)
        For Each dtir As DataGridViewRow In DisplayTableItemDataGridView.SelectedRows
            Dim dti As tmDataSet.DisplayTableItemRow
            If dtir.DataBoundItem IsNot Nothing Then
                dti = CType(CType(dtir.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                dti.Bold = BoldCheckBox.Checked
            End If
        Next
        FormatDisplayItem()
        DisplayTableItemDataGridView.Focus()
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs)
        For Each dtir As DataGridViewRow In DisplayTableItemDataGridView.SelectedRows
            Dim dti As tmDataSet.DisplayTableItemRow
            If dtir.DataBoundItem IsNot Nothing Then
                dti = CType(CType(dtir.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                dti.Italic = ItalicCheckBox.Checked
            End If
        Next


        FormatDisplayItem()
        DisplayTableItemDataGridView.Focus()
    End Sub

    Private Sub LevelListBox_Click(sender As Object, e As System.EventArgs) Handles LevelListBox.Click
        DisplayTableItemBindingSource.EndEdit()
        DisplayTableItemDataGridView.Focus()
    End Sub

    Private Sub LevelListBox_Enter(sender As Object, e As System.EventArgs) Handles LevelListBox.Enter
        AddHandler LevelListBox.SelectedIndexChanged, AddressOf LevelListBox_SelectedIndexChanged
    End Sub

    Private Sub LevelListBox_Leave(sender As Object, e As System.EventArgs) Handles LevelListBox.Leave
        RemoveHandler LevelListBox.SelectedIndexChanged, AddressOf LevelListBox_SelectedIndexChanged
    End Sub

    Private Sub LevelListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If DisplayTableItemBindingSource.Position <> -1 Then
            For Each dtir As DataGridViewRow In DisplayTableItemDataGridView.SelectedRows
                Dim dti As tmDataSet.DisplayTableItemRow
                If dtir.DataBoundItem IsNot Nothing Then
                    dti = CType(CType(dtir.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                    dti.Level = LevelListBox.SelectedIndex
                End If
            Next
            DisplayTableItemBindingSource.EndEdit()
            DisplayTableItemDataGridView.EndEdit()
            FormatDisplayItem()
            DisplayTableItemDataGridView.Focus()
        End If
    End Sub

    Private Sub ItalicCheckBox_Enter(sender As Object, e As System.EventArgs) Handles ItalicCheckBox.Enter
        AddHandler ItalicCheckBox.CheckStateChanged, AddressOf ItalicCheckBox_CheckedChanged
    End Sub

    Private Sub ItalicCheckBox_Leave(sender As Object, e As System.EventArgs) Handles ItalicCheckBox.Leave
        RemoveHandler ItalicCheckBox.CheckStateChanged, AddressOf ItalicCheckBox_CheckedChanged
    End Sub

    Private Sub cbxFont_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFont.SelectedIndexChanged
        DisplayTableItemDataGridView.Font = New System.Drawing.Font(cbxFont.SelectedItem.ToString, 12)
        FormatDisplayItem()
    End Sub

    Private Sub tcTableMaker_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tcTableMaker.SelectedIndexChanged
        If tcTableMaker.SelectedTab.Name = tpTable.Name Then
            FormatDisplay()
            FormatDisplayItem()
        End If
        cbxHide.Checked = False
    End Sub

    Private Sub DisplayTableBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles DisplayTableBindingSource.CurrentChanged
        If DisplayTableBindingSource.Position = -1 And blnUpdating = False Then
            DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
        Else
            If DisplayTableBindingSource.Current IsNot Nothing Then
                Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
                If dt.IsFirstColumnHeaderNull Then
                    DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
                Else
                    If dt.FirstColumnHeader = "" Then
                        DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
                    Else
                        DisplayTableItemDataGridView.Columns(0).HeaderText = dt.FirstColumnHeader
                    End If
                End If
                FormatDisplayItem()
            End If
        End If
    End Sub

    Private Sub btnUpDisplayItem_Click(sender As System.Object, e As System.EventArgs) Handles btnUpDisplayItem.Click
        If DisplayTableItemBindingSource.Position > 0 Then
            Dim s1 As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            DisplayTableItemBindingSource.MovePrevious()
            Dim s2 As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            Dim temp As Integer = s1.OrderID
            s1.OrderID = s2.OrderID
            s2.OrderID = temp
            DisplayTableItemBindingSource.Sort = "OrderID"
            Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableItemBindingSource.CurrencyManager.GetItemProperties()
            Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableItemID", True)
            DisplayTableItemBindingSource.Position = DisplayTableItemBindingSource.Find(prop, s1.DisplayTableItemID)
            FormatDisplayItem()
        End If
    End Sub

    Private Sub btnDownDisplayItem_Click(sender As System.Object, e As System.EventArgs) Handles btnDownDisplayItem.Click
        If DisplayTableItemBindingSource.Position <> -1 Then
            Dim s1 As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
            Dim intDisplayTableItemCount As Integer = (From s In Me.tmDataSet.DisplayTableItem Where s.DisplayTableID = s1.DisplayTableID).Count
            If DisplayTableItemBindingSource.Position < intDisplayTableItemCount - 1 Then
                DisplayTableItemBindingSource.MoveNext()
                Dim s2 As tmDataSet.DisplayTableItemRow = CType(CType(DisplayTableItemBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                Dim temp As Integer = s1.OrderID
                s1.OrderID = s2.OrderID
                s2.OrderID = temp
                DisplayTableItemBindingSource.Sort = "OrderID"
                Dim pdc As System.ComponentModel.PropertyDescriptorCollection = DisplayTableItemBindingSource.CurrencyManager.GetItemProperties()
                Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("DisplayTableItemID", True)
                DisplayTableItemBindingSource.Position = DisplayTableItemBindingSource.Find(prop, s1.DisplayTableItemID)
                FormatDisplayItem()
            End If
        End If
    End Sub

    Private Sub DisplayTableBindingSource_PositionChanged(sender As Object, e As System.EventArgs) Handles DisplayTableBindingSource.PositionChanged
        If DisplayTableBindingSource.Position = -1 Then
            DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
        Else
            Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
            If dt.IsFirstColumnHeaderNull Then
                DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
            Else
                If dt.FirstColumnHeader = "" Then
                    DisplayTableItemDataGridView.Columns(0).HeaderText = "Scale"
                Else
                    DisplayTableItemDataGridView.Columns(0).HeaderText = dt.FirstColumnHeader
                End If
            End If
            FormatDisplayItem()
        End If
    End Sub

    Private Sub cbxAllCaps_CheckedChanged(sender As System.Object, e As System.EventArgs)
        For Each dtir As DataGridViewRow In DisplayTableItemDataGridView.SelectedRows
            Dim dti As tmDataSet.DisplayTableItemRow
            If dtir.DataBoundItem IsNot Nothing Then
                dti = CType(CType(dtir.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                dti.AllCaps = cbxAllCaps.Checked
            End If
        Next
        FormatDisplayItem()
        DisplayTableItemDataGridView.Focus()
    End Sub

    Private Sub cbxAbbreviation_CheckedChanged(sender As System.Object, e As System.EventArgs)
        For Each dtir As DataGridViewRow In DisplayTableItemDataGridView.SelectedRows
            Dim dti As tmDataSet.DisplayTableItemRow
            If dtir.DataBoundItem IsNot Nothing Then
                dti = CType(CType(dtir.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableItemRow)
                dti.Abbreviation = cbxAbbreviation.Checked
            End If
        Next
        FormatDisplayItem()
        DisplayTableItemDataGridView.Focus()
    End Sub
    Private Sub cbxAbbreviation_Enter(sender As Object, e As System.EventArgs) Handles cbxAbbreviation.Enter
        AddHandler CType(sender, System.Windows.Forms.CheckBox).CheckStateChanged, AddressOf cbxAbbreviation_CheckedChanged
    End Sub

    Private Sub cbxAbbreviation_Leave(sender As Object, e As System.EventArgs) Handles cbxAbbreviation.Leave
        RemoveHandler CType(sender, System.Windows.Forms.CheckBox).CheckStateChanged, AddressOf cbxAbbreviation_CheckedChanged
    End Sub

    Private Sub cbxAllCaps_Enter(sender As Object, e As System.EventArgs) Handles cbxAllCaps.Enter
        AddHandler CType(sender, System.Windows.Forms.CheckBox).CheckStateChanged, AddressOf cbxAllCaps_CheckedChanged
    End Sub

    Private Sub cbxAllCaps_Leave(sender As Object, e As System.EventArgs) Handles cbxAllCaps.Leave
        RemoveHandler CType(sender, System.Windows.Forms.CheckBox).CheckStateChanged, AddressOf cbxAllCaps_CheckedChanged
    End Sub

    Private Sub FullNameComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FullNameComboBox.SelectedIndexChanged
        If blnClosing = False And tpTable Is tcTableMaker.SelectedTab Then
            FormatDisplay()
            FormatDisplayItem()
        End If

    End Sub

    Private Sub FormatDisplay()
        If DisplayTableDataGridView.Rows.Count > 0 And blnUpdating = False Then
            Me.Validate()
            DisplayTableBindingSource.EndEdit()
            For Each dtr In tmDataSet.DisplayTable
                dtr.Include = False
            Next
            Dim p As tmDataSet.PersonRow
            If PersonBindingSource.Position <> -1 Then
                p = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow)
            Else
                p = Nothing
            End If
            For Each dr As DataGridViewRow In Me.DisplayTableDataGridView.Rows
                If p Is Nothing Then
                    dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableDataGridView.DefaultCellStyle.Font, FontStyle.Regular)
                Else
                    If dr.DataBoundItem IsNot Nothing Then
                        Dim dt As tmDataSet.DisplayTableRow = CType(CType(dr.DataBoundItem, DataRowView).Row, tmDataSet.DisplayTableRow)
                        Dim sc() As tmDataSet.ScaleRow = (From dtir In Me.tmDataSet.DisplayTableItem Where dt.DisplayTableID = dtir.DisplayTableID Select dtir.ScaleRow Distinct).ToArray
                        Dim blnBold As Boolean = False
                        For Each s In sc
                            Dim sID As Integer = s.ScaleID
                            Dim ScoreSum As Double = (From pbsr In tmDataSet.PersonBatteryScale Where pbsr.PersonID = p.PersonID And pbsr.ScaleID = sID And pbsr.IsScoreNull = False Select pbsr.Score).Sum
                            If ScoreSum > 0 Then
                                blnBold = True
                                dt.Include = True
                            End If
                        Next
                        If blnBold Then
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableDataGridView.DefaultCellStyle.Font, FontStyle.Bold)
                        Else
                            dr.DefaultCellStyle.Font = New System.Drawing.Font(DisplayTableDataGridView.DefaultCellStyle.Font, FontStyle.Regular)
                        End If
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub ScoreCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs)
        FormatDisplayItem()
    End Sub

    Private Sub ScoreCheckBox_Enter(sender As Object, e As System.EventArgs) Handles ScoreCheckBox.Enter, PercentileCheckBox.Enter, RangeCheckBox.Enter
        AddHandler CType(sender, Windows.Forms.CheckBox).CheckStateChanged, AddressOf ScoreCheckBox_CheckedChanged
    End Sub

    Private Sub ScoreCheckBox_Leave(sender As Object, e As System.EventArgs) Handles ScoreCheckBox.Leave, PercentileCheckBox.Leave, RangeCheckBox.Leave
        RemoveHandler CType(sender, Windows.Forms.CheckBox).CheckStateChanged, AddressOf ScoreCheckBox_CheckedChanged
    End Sub

    Private Sub RangeNameComboBox_Enter(sender As Object, e As System.EventArgs) Handles RangeNameComboBox.Enter
        AddHandler RangeNameComboBox.SelectedValueChanged, AddressOf RangeNameComboBox_SelectedIndexChanged
    End Sub

    Private Sub RangeNameComboBox_Leave(sender As Object, e As System.EventArgs) Handles RangeNameComboBox.Leave
        RemoveHandler RangeNameComboBox.SelectedValueChanged, AddressOf RangeNameComboBox_SelectedIndexChanged
    End Sub

    Private Sub RangeNameComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        RangeBindingSource.EndEdit()
        FormatDisplayItem()
    End Sub

    Private Function MarkerToHTML(ByVal strM As String) As String

        Dim nM As String = ""
        For Each s As String In strM
            nM &= "&#" & Char.ConvertToUtf32(s, 0) & ";"
        Next
        Return nM
    End Function

    Private Sub btnMakeTable_Click(sender As System.Object, e As System.EventArgs) Handles btnMakeTable.Click
        'If DisplayTableBindingSource.Position <> -1 And DisplayTableItemBindingSource.Position <> -1 Then

        '    Try
        '        Me.Cursor = Cursors.WaitCursor

        '        DisplayTableBindingSource.EndEdit()
        '        DisplayTableItemBindingSource.EndEdit()

        '        Dim intFontSize As Integer = 12
        '        Dim intColumnCount As Integer = 1
        '        Dim dt As tmDataSet.DisplayTableRow = CType(CType(DisplayTableBindingSource.Current, DataRowView).Row, tmDataSet.DisplayTableRow)
        '        Dim dti As tmDataSet.DisplayTableItemRow() = (From tmi In tmDataSet.DisplayTableItem Where tmi.DisplayTableID = dt.DisplayTableID Order By tmi.OrderID Select tmi).ToArray
        '        If ScoreCheckBox.Checked Then intColumnCount += 1
        '        If PercentileCheckBox.Checked Then intColumnCount += 1
        '        If RangeCheckBox.Checked Then intColumnCount += 1
        '        'Dim rm As tmDataSet.RangeRow = CType(CType(RangeBindingSource.Current, DataRowView).Row, tmDataSet.RangeRow)
        '        'Dim rmis As tmDataSet.RangeLabelRow() = (From rmi In tmDataSet.RangeLabel Where rmi.RangeID = rm.RangeID Order By rmi.LowerBound Descending Select rmi).ToArray
        '        Dim Rowcount As Integer = DisplayTableItemDataGridView.RowCount
        '        'Dim strRowStyle() = {"no", "bb", "it", "bi"}
        '        Dim r As Integer
        '        Dim sb As New System.Text.StringBuilder
        '        sb.Append("<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.0 Strict//EN" & Chr(34)).AppendLine()
        '        sb.Append("http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" & Chr(34) & ">").AppendLine()
        '        sb.Append("<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & " lang=" & Chr(34) & "en" & Chr(34) & " xml:lang=" & Chr(34) & "en" & Chr(34) & ">").AppendLine()
        '        sb.Append("<head>").AppendLine()
        '        'sb.Append("<style type=" & Chr(34) & "text/css" & Chr(34) & ">").AppendLine()
        '        'sb.Append("table {border:1px solid #000; border-bottom:none;border-left:none;border-right:none;border-top:none;border-collapse:collapse;font-family:" & Chr(34) & "Times New Roman" & Chr(34) & ",serif; font-size:100%; width:100%;}").AppendLine()
        '        'sb.Append("td,th{border:1px solid #000; border-collapse:collapse; padding:5px;}").AppendLine()
        '        'sb.Append("#cs{width:50.62%; text-align:left; }").AppendLine()
        '        'sb.Append("#ss{width:9.16%; text-align:center}").AppendLine()
        '        'sb.Append("#pr{width:17.64%; text-align:center}").AppendLine()
        '        'sb.Append("#rl{width:22.58%; text-align:center}").AppendLine()
        '        'sb.Append("caption{background:white; font-size:100%; padding:5px; text-align:left;}").AppendLine()
        '        'sb.Append("thead th{text-align:left}").AppendLine()
        '        'sb.Append("tbody th{text-align:left;}").AppendLine()
        '        'sb.Append("tfoot td{text-align:left;border-bottom:none;border-left:none;border-right:none;border-top:none;}").AppendLine()
        '        'sb.Append("tbody tr.it td{ font-style:italic;}").AppendLine()
        '        'sb.Append("tbody tr.bb td{ font-weight:bold;}").AppendLine()
        '        'sb.Append("tbody tr.no td{ font-style:normal;}").AppendLine()
        '        'sb.Append("tbody tr.bi td{ font-style:italic;font-weight:bold;}").AppendLine()
        '        'sb.Append("</style>").AppendLine()
        '        sb.Append("<meta content=" & Chr(34) & "text/html" & Chr(34) & "; charset=ISO-8859-1 http-equiv=" & Chr(34) & "Content-Type" & Chr(34) & ">").AppendLine()
        '        sb.Append("<title>" & dt.DisplayTableName & "</title>").AppendLine()
        '        sb.Append("</head>").AppendLine()
        '        sb.Append("<body style = " & Chr(34) & "font-family: " & cbxFont.SelectedItem.ToString & Chr(34) & ";text-align:left;text-indent:0in>").AppendLine()
        '        sb.Append("<b>" & dt.DisplayTableTitle & "</b><br>").AppendLine()
        '        sb.Append("<table style = " & Chr(34) & "font-family: " & cbxFont.SelectedItem.ToString & Chr(34) & ";border-style: none none none solid; border-color:black black black black; border-width: 0pt 0pt 1pt 0pt; padding: 4pt; width: 6.5in; border-collapse: collapse;text-align:center;vertical-align:center;" & Chr(34) & " summary=" & Chr(34) & "Test Scores" & Chr(34) & ">").AppendLine()
        '        sb.Append("<thead> <tr>").AppendLine()
        '        sb.Append("<th style=" & Chr(34) & "width:50.62%; text-align:left;vertical-align:center;border-style:none none solid none;border-color: black black black black; border-width: 0pt 0pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & " scope=" & Chr(34) & "col" & Chr(34) & ">" & If(dt.IsFirstColumnHeaderNull, "Composite/Subtest", dt.FirstColumnHeader) & "</th>").AppendLine()
        '        If ScoreCheckBox.Checked Then
        '            sb.Append("<th style=" & Chr(34) & "width:9.16%; text-align:center;vertical-align:center;border-style:none none solid none;border-color: black black black black; border-width: 0pt 0pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & " scope=" & Chr(34) & "col" & Chr(34) & ">Score</th>").AppendLine()
        '        End If
        '        If PercentileCheckBox.Checked Then
        '            sb.Append("<th style=" & Chr(34) & "width:17.64%; text-align:center;vertical-align:center;border-style:none none solid none;border-color: black black black black; border-width: 0pt 0pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & " scope=" & Chr(34) & "col" & Chr(34) & ">Percentile</th>").AppendLine()
        '        End If

        '        If RangeCheckBox.Checked Then
        '            sb.Append("<th style=" & Chr(34) & "width:22.58%; text-align:center;vertical-align:center;border-style:none none solid none;border-color: black black black black; border-width: 0pt 0pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & " scope=" & Chr(34) & "col" & Chr(34) & ">Range</th>").AppendLine()
        '        End If
        '        sb.Append("</tr>").AppendLine()
        '        sb.Append("</thead>").AppendLine()
        '        sb.Append("<tbody>").AppendLine()


        '        Dim dtm() As tmDataSet.DisplayTableMarkerRow = (From dtmr In tmDataSet.DisplayTableMarker Where dtmr.DisplayTableID = dt.DisplayTableID).ToArray
        '        For r = 2 To Rowcount + 1
        '            Dim strIndent As String = ""
        '            If dti(r - 2).IsLevelNull = False Then
        '                For j As Integer = 0 To dti(r - 2).Level
        '                    strIndent &= "&nbsp;&nbsp;"
        '                Next
        '            End If
        '            Dim strMarker As String = ""
        '            Dim dtmi() As tmDataSet.DisplayTableItemMarkerRow = (From dtmir In tmDataSet.DisplayTableItemMarker Where dtmir.DisplayTableItemID = dti(r - 2).DisplayTableItemID).ToArray
        '            For Each dtmir In dtmi
        '                If dtmir.DisplayTableMarkerRow.IsMarkerSymbolNull = False Then
        '                    strMarker &= MarkerToHTML(dtmir.DisplayTableMarkerRow.MarkerSymbol)
        '                End If
        '            Next


        '            Dim strScaleName As String
        '            If dti(r - 2).ScaleRow.IsScaleNameNull Then
        '                strScaleName = ""
        '            Else
        '                strScaleName = dti(r - 2).ScaleRow.ScaleName
        '                If dti(r - 2).AllCaps Then strScaleName = strScaleName.ToUpper()
        '            End If

        '            intFontSize = CInt(100 * dti(r - 2).Size / 12)

        '            sb.Append("<tr style=" & Chr(34) & "vertical-align:center;font-style:" & If(dti(r - 2).Italic, "italic", "normal") & "; font-weight:" & If(dti(r - 2).Bold, "bold", "normal") & ";font-size:" & intFontSize & "%;" & Chr(34) & ">").AppendLine()
        '            sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid solid; border-color: black black black black; border-width: 0pt 1pt 1pt 1pt; padding: 4pt; border-collapse: collapse;text-align:left;" & Chr(34) & ">" & strIndent & strScaleName & strMarker & "</td>").AppendLine()
        '            If ScoreCheckBox.Checked Then
        '                If DisplayTableItemDataGridView.Rows(r - 2).Cells("DisplayItemScore").FormattedValue IsNot "" Then
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & ">" & DisplayTableItemDataGridView.Rows(r - 2).Cells("DisplayItemScore").Value.ToString & "</td>").AppendLine()
        '                Else
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & "></td>").AppendLine()

        '                End If
        '            End If
        '            If PercentileCheckBox.Checked Then
        '                If DisplayTableItemDataGridView.Rows(r - 2).Cells("PercentileColumn").FormattedValue IsNot "" Then
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & ">" & DisplayTableItemDataGridView.Rows(r - 2).Cells("PercentileColumn").Value.ToString & "</td>").AppendLine()
        '                Else
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & "></td>").AppendLine()
        '                End If

        '            End If
        '            If RangeCheckBox.Checked Then
        '                If DisplayTableItemDataGridView.Rows(r - 2).Cells("RangeColumn").FormattedValue IsNot "" Then
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & ">" & DisplayTableItemDataGridView.Rows(r - 2).Cells("RangeColumn").Value.ToString & "</td>").AppendLine()
        '                Else
        '                    sb.Append("<td style=" & Chr(34) & "vertical-align:center;border-style: none solid solid none; border-color: black black black black; border-width: 0pt 1pt 1pt 0pt; padding: 4pt; border-collapse: collapse;" & Chr(34) & "></td>").AppendLine()
        '                End If
        '            End If
        '            sb.Append("</tr>").AppendLine()
        '        Next

        '        sb.Append("</tbody>").AppendLine()
        '        sb.Append("</table>").AppendLine()
        '        If dt.IsNoteNull = False Then
        '            sb.Append("<i>Note</i>: " & dt.Note).AppendLine()
        '        End If

        '        For Each dtmr In dtm
        '            If (dtmr.IsMarkerSymbolNull = False) And (dtmr.IsMarkerMeaningNull = False) Then
        '                sb.Append("<br>").AppendLine()
        '                sb.Append(MarkerToHTML(dtmr.MarkerSymbol) & " " & dtmr.MarkerMeaning).AppendLine()
        '            End If
        '        Next

        '        sb.Append("</body>").AppendLine()
        '        sb.Append("</html>").AppendLine()

        '        Dim fs As New System.IO.FileStream(Application.LocalUserAppDataPath & "\NewTable.doc", FileMode.Create, FileAccess.Write)
        '        'declaring a FileStream and creating a word document file named file with
        '        'access mode of writing
        '        Dim s As New StreamWriter(fs)
        '        'creating a new StreamWriter and passing the filestream object fs as argument
        '        s.BaseStream.Seek(0, SeekOrigin.End)
        '        'the seek method is used to move the cursor to next position to avoid text to be
        '        'overwritten
        '        Dim sbfile As String = sb.ToString
        '        s.WriteLine(sb.ToString)
        '        s.Close()
        '        fs.Close()
        '        'Process.Start(Application.LocalUserAppDataPath & "\NewTable.doc")
        '    Catch ex As Exception
        '        Console.WriteLine(ex.Message)
        '    End Try
        'End If

        'Me.Cursor = Cursors.Default
        WordTable()


        FormatDisplayItem()
    End Sub

    Private Sub WordTable()
        If DisplayTableBindingSource.Position <> -1 And DisplayTableItemBindingSource.Position <> -1 Then
            DisplayTableBindingSource.EndEdit()
            DisplayTableItemBindingSource.EndEdit()
            FormatDisplay()
            SaveData()
            Dim sdt As New SelectDisplayTables With {.blnCancel = True}
            sdt.ShowDialog(Me)
            If sdt.blnCancel = False Then
                Dim blnOmit As Boolean = sdt.cbxOmit.Checked


                Dim intFontSize As Integer = 12
                Dim intColumnCount As Integer = 1
                If ScoreCheckBox.Checked Then intColumnCount += 1
                If PercentileCheckBox.Checked Then intColumnCount += 1
                If RangeCheckBox.Checked Then intColumnCount += 1
                If My.Settings.LastSaveLocation = "" Then
                    My.Settings.LastSaveLocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                    My.Settings.Save()
                End If
                Dim strFileName As String = "TableMaker Data.docx"
                If File.Exists(My.Settings.LastSaveLocation & "\" & strFileName) Then
                    Dim i As Integer = 2
                    Do
                        strFileName = "TableMaker Data" & " " & i & ".docx"
                        i += 1
                    Loop Until File.Exists(My.Settings.LastSaveLocation & "\" & strFileName) = False
                End If
                FormatDisplayItem()
                Dim fds As New SaveFileDialog With {.InitialDirectory = My.Settings.LastSaveLocation, .Filter = "Word Document (.docx)|*.docx", .AddExtension = True, .Title = "Save Word File", .FileName = strFileName}
                If fds.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim fn() As String = fds.FileName.Split("\"c)
                    Dim strLastSave As String = ""
                    For i = 0 To fn.Length - 2
                        If i = 0 Then
                            strLastSave &= fn(i)
                        Else
                            strLastSave &= "\" & fn(i)
                        End If
                    Next
                    My.Settings.LastSaveLocation = strLastSave
                    My.Settings.Save()

                    If FileInUse(fds.FileName) Then
                        MsgBox("This file is in use by another program. Try saving with a different name.")
                    Else
                        If File.Exists(fds.FileName) Then
                            File.Delete(fds.FileName)
                        End If
                        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(fds.FileName, WordprocessingDocumentType.Document)
                            Dim strParagraphStyle As String = "b0i0fs12Ind0JL"
                            ' Add a main document part. 
                            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
                            ' Create the document structure and add some text.
                            mainPart.Document = New Document()
                            Dim sdp As StyleDefinitionsPart = mainPart.AddNewPart(Of StyleDefinitionsPart)()
                            sdp.Styles = New Styles With _
                                               {.DocDefaults = New DocDefaults With _
                                                               {.ParagraphPropertiesDefault = New ParagraphPropertiesDefault With _
                                                                                              {.ParagraphPropertiesBaseStyle = New ParagraphPropertiesBaseStyle With _
                                                                                               {.PageBreakBefore = New PageBreakBefore() With {.Val = False}, _
                                                                                                .Justification = New Justification With {.Val = JustificationValues.Left}, _
                                                                                                .SpacingBetweenLines = New SpacingBetweenLines With {.After = CType(0, StringValue), _
                                                                                                                                                     .Before = CType(0, StringValue), _
                                                                                                                                                       .Line = CType(240, StringValue), _
                                                                                                                                                       .LineRule = LineSpacingRuleValues.Auto}}}}}


                            mainPart.StyleDefinitionsPart.Styles.DocDefaults.RunPropertiesDefault = New RunPropertiesDefault With {.RunPropertiesBaseStyle = New RunPropertiesBaseStyle With {.FontSize = New FontSize With {.Val = "24"}, .RunFonts = New RunFonts With {.Ascii = cbxFont.SelectedItem.ToString}}}
                            'Run Properties of Normal
                            Dim NormalRun As New RunProperties With {.RunFonts = New RunFonts With {.Ascii = cbxFont.SelectedItem.ToString},
                                                                     .FontSize = New FontSize With {.Val = "22"}
                                                                    }
                            'Normal Style
                            Dim NormalStyle As New Style With {.StyleId = "Normal",
                                                               .StyleName = New StyleName With {.Val = "Normal"},
                                                               .Type = StyleValues.Paragraph
                                }

                            NormalStyle.Append(NormalRun)
                            sdp.Styles.Append(NormalStyle)
                            sdp.Styles.Save()

                            'Run Properties of Heading 1
                            Dim Heading1Run As New RunProperties With {.FontSize = New FontSize With {.Val = "28"},
                                                                       .Bold = New Bold}


                            'Heading 1 Style
                            Dim Heading1Style As New Style With {.StyleId = "Heading1",
                                                                 .StyleName = New StyleName With {.Val = "Heading 1"},
                                                                 .BasedOn = New BasedOn With {.Val = "Normal"},
                                                                 .PrimaryStyle = New PrimaryStyle With {.Val = OnOffOnlyValues.On},
                                                                 .LinkedStyle = New LinkedStyle With {.Val = "Heading1Char"},
                                                                 .Type = StyleValues.Paragraph,
                                                                 .NextParagraphStyle = New NextParagraphStyle With {.Val = "Normal"}
                                                                                            }


                            'Heading1Char
                            Dim Heading1CharRun As New RunProperties With {.FontSize = New FontSize With {.Val = "28"},
                                                                       .Bold = New Bold}
                            Dim Heading1CharStyle As New Style With {.StyleId = "Heading1Char",
                                                                     .StyleName = New StyleName With {.Val = "Heading 1 Char"},
                                                                     .Type = StyleValues.Character,
                                                                     .BasedOn = New BasedOn With {.Val = "Normal"},
                                                                     .LinkedStyle = New LinkedStyle With {.Val = "Heading1"}
                                                                    }
                            Heading1Style.Append(Heading1Run)
                            sdp.Styles.Append(Heading1Style)
                            Heading1CharStyle.Append(Heading1CharRun)
                            sdp.Styles.Append(Heading1CharStyle)
                            sdp.Styles.Save()

                            'Run Properties of Table Title
                            Dim tTitleRun As New RunProperties With {.Bold = New Bold,
                                                               .RunFonts = New RunFonts With {.Ascii = cbxFont.SelectedItem.ToString},
                                                               .FontSize = New FontSize With {.Val = "28"}
                                                              }



                            'Table Title Style
                            Dim tTitle As New Style With {.StyleId = "TableTitle",
                                                          .StyleName = New StyleName With {.Val = "Table Title"},
                                                          .BasedOn = New BasedOn With {.Val = "Heading1"},
                                                          .UnhideWhenUsed = New UnhideWhenUsed With {.Val = OnOffOnlyValues.On},
                                                          .LinkedStyle = New LinkedStyle With {.Val = "Heading1Char"},
                                                          .UIPriority = New UIPriority With {.Val = 9},
                                                          .SemiHidden = New SemiHidden With {.Val = OnOffOnlyValues.Off},
                                                          .PrimaryStyle = New PrimaryStyle With {.Val = OnOffOnlyValues.On}
                                                         }

                            tTitle.Append(tTitleRun)
                            sdp.Styles.Append(tTitle)
                            sdp.Styles.Save()

                            Dim TableNoteRun As New RunProperties With {.RunFonts = New RunFonts With {.Ascii = cbxFont.SelectedItem.ToString},
                                                                       .FontSize = New FontSize With {.Val = "20"}
                                                                      }
                            Dim TableNoteStyle As New Style With {.StyleId = "TableNote",
                                                                  .StyleName = New StyleName With {.Val = "Table Note"},
                                                                  .BasedOn = New BasedOn With {.Val = "Normal"},
                                                                  .UnhideWhenUsed = New UnhideWhenUsed With {.Val = OnOffOnlyValues.On},
                                                                  .UIPriority = New UIPriority With {.Val = 9},
                                                                  .SemiHidden = New SemiHidden With {.Val = OnOffOnlyValues.Off},
                                                                  .PrimaryStyle = New PrimaryStyle With {.Val = OnOffOnlyValues.On}
                                                                 }
                            TableNoteStyle.Append(TableNoteRun)
                            sdp.Styles.Append(TableNoteStyle)
                            sdp.Styles.Save()



                            Dim body As Body = mainPart.Document.AppendChild(New Body())

                            Dim DocTitlePara As New Paragraph
                            Dim DocTitleParaProp As New ParagraphProperties
                            DocTitleParaProp.ParagraphStyleId = New ParagraphStyleId With {.Val = "Heading1"}
                            DocTitlePara.Append(DocTitleParaProp)
                            Dim DocTitleText As New Text("Appendix: Test Scores")
                            Dim DocTitleRun As New Run
                            DocTitleRun.Append(DocTitleText)
                            DocTitlePara.Append(DocTitleRun)
                            body.Append(DocTitlePara)
                            If sdt.blnCancel = False Then
                                Dim intTableID() As Integer = (From dtr In sdt.tmDataSet.DisplayTable Where dtr.Include = True Order By dtr.OrderID Select dtr.DisplayTableID).ToArray
                                For Each i As Integer In intTableID
                                    Dim dt As tmDataSet.DisplayTableRow = tmDataSet.DisplayTable.FindByDisplayTableID(i)
                                    Dim dti As tmDataSet.DisplayTableItemRow() = (From tmi In tmDataSet.DisplayTableItem Where tmi.DisplayTableID = dt.DisplayTableID Order By tmi.OrderID Select tmi).ToArray
                                    DisplayTableBindingSource.Position = DisplayTableBindingSource.Find("DisplayTableID", i)
                                    FormatDisplayItem()
                                    Dim p1 As Paragraph = body.AppendChild(New Paragraph)
                                    Dim r1 As Run = p1.AppendChild(New Run)
                                    Dim b1 As Break = r1.AppendChild(New Break With {.Type = BreakValues.Page})


                                    If dt.IsDisplayTableTitleNull = False Then
                                        'Dim para As Paragraph = body.AppendChild(New Paragraph())
                                        'If Array.IndexOf(intTableID, i) > 0 Then
                                        '    'Dim pp As ParagraphProperties = para.AppendChild(New ParagraphProperties)
                                        '    'Dim pbb As PageBreakBefore = pp.AppendChild(New PageBreakBefore With {.Val = True})
                                        '    Dim pp As ParagraphProperties = para.AppendChild(New ParagraphProperties With {.ParagraphStyleId = New ParagraphStyleId With {.Val = "TableTitle"}})
                                        'End If
                                        'Dim run As Run = para.AppendChild(New Run())
                                        'Dim runprop As RunProperties = New RunProperties(New RunFonts With {.Ascii = CStr(cbxFont.SelectedItem)})
                                        'Dim b As New Bold
                                        'runprop.Append(b)
                                        'run.Append(runprop)
                                        'run.AppendChild(New Text(dt.DisplayTableTitle))

                                        Dim TableTitlePara As New Paragraph
                                        Dim TableTitleParaProp As New ParagraphProperties
                                        TableTitleParaProp.ParagraphStyleId = New ParagraphStyleId With {.Val = "TableTitle"}
                                        TableTitlePara.Append(TableTitleParaProp)
                                        Dim TableTitleText As New Text(dt.DisplayTableTitle)
                                        Dim TableTitleRun As New Run
                                        TableTitleRun.Append(TableTitleText)
                                        TableTitlePara.Append(TableTitleRun)
                                        body.Append(TableTitlePara)
                                    End If
                                    Dim t As New Table()
                                    ' Create a TableProperties object and specify its border information.

                                    Dim tblprop As New TableProperties With {.TableBorders = New TableBorders( _
                                                                                  New TopBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Single), .Size = 8}, _
                                                                                  New BottomBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Single), .Size = 8}, _
                                                                                  New LeftBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Nil), .Size = 8}, _
                                                                                  New RightBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Nil), .Size = 8}, _
                                                                                  New InsideHorizontalBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Nil), .Size = 8}, _
                                                                                  New InsideVerticalBorder With {.Val = New EnumValue(Of BorderValues)(BorderValues.Nil), .Size = 8}), _
                                                                             .TableWidth = New TableWidth With {.Width = "5000"}}



                                    tblprop.TableCellMarginDefault = New TableCellMarginDefault With {.BottomMargin = New BottomMargin With {.Width = CType(60, StringValue), .Type = TableWidthUnitValues.Dxa}, _
                                                                                      .TopMargin = New TopMargin With {.Width = CType(60, StringValue), .Type = TableWidthUnitValues.Dxa}, _
                                                                                      .TableCellLeftMargin = New TableCellLeftMargin With {.Width = 60, .Type = TableWidthValues.Dxa}, _
                                                                                      .TableCellRightMargin = New TableCellRightMargin With {.Width = 60, .Type = TableWidthValues.Dxa}}
                                    tblprop.TableWidth = New TableWidth With {.Width = CType(9602, StringValue), .Type = TableWidthUnitValues.Dxa}
                                    ' Append the TableProperties object to the empty table.
                                    t.AppendChild(Of TableProperties)(tblprop)
                                    Dim tg As TableGrid = New TableGrid
                                    Dim tgcScale As GridColumn = New GridColumn With {.Width = CType(5502, StringValue)}
                                    tg.Append(tgcScale)
                                    If dt.Score Then
                                        Dim tgcScore As GridColumn = New GridColumn With {.Width = CType(894, StringValue)}
                                        tg.Append(tgcScore)
                                    End If
                                    If dt.Percentile Then
                                        Dim tgcPercentile As GridColumn = New GridColumn With {.Width = CType(1346, StringValue)}
                                        tg.Append(tgcPercentile)
                                    End If
                                    If dt.Range Then
                                        Dim tgcRange As GridColumn = New GridColumn With {.Width = CType(1860, StringValue)}
                                        tg.Append(tgcRange)
                                    End If
                                    t.Append(tg)
                                    Dim tr As New TableRow
                                    tr.TableRowProperties = New TableRowProperties
                                    tr.TableRowProperties.Append(New TableHeader With {.Val = OnOffOnlyValues.On})
                                    ' Create a cell.
                                    Dim tc1 As New TableCell
                                    tc1.TableCellProperties = New TableCellProperties With _
                                                              {.TableCellBorders = New TableCellBorders With _
                                                                                   {.TopBorder = New TopBorder With {.Val = BorderValues.Single}, _
                                                                                    .BottomBorder = New BottomBorder With {.Val = BorderValues.Single}}}
                                    Dim p As New Paragraph
                                    ApplyStyleToParagraph(wordDocument, "b1i0fs12Ind0JL", "b1i0fs12Ind0JL", p, True, False, 12, 0, JustificationValues.Left)
                                    Dim r As New Run
                                    Dim tx As New Text
                                    If dt.IsFirstColumnHeaderNull Then
                                        tx.Text = "Scale"
                                    Else
                                        tx.Text = dt.FirstColumnHeader
                                    End If
                                    r.Append(tx)
                                    p.Append(r)
                                    tc1.Append(p)
                                    tr.Append(tc1)
                                    If dt.Score Then
                                        tc1 = New TableCell
                                        tc1.TableCellProperties = New TableCellProperties With _
                                                              {.TableCellBorders = New TableCellBorders With _
                                                                                   {.TopBorder = New TopBorder With {.Val = BorderValues.Single}, _
                                                                                    .BottomBorder = New BottomBorder With {.Val = BorderValues.Single}}}

                                        p = New Paragraph
                                        ApplyStyleToParagraph(wordDocument, "b1i0fs12Ind0JC", "b1i0fs12Ind0JC", p, True, False, 12, 0, JustificationValues.Center)
                                        r = New Run
                                        tx = New Text("Score")
                                        r.Append(tx)
                                        p.Append(r)
                                        tc1.Append(p)
                                        tr.Append(tc1)
                                    End If
                                    If dt.Percentile Then
                                        tc1 = New TableCell
                                        tc1.TableCellProperties = New TableCellProperties With _
                                                              {.TableCellBorders = New TableCellBorders With _
                                                                                   {.TopBorder = New TopBorder With {.Val = BorderValues.Single}, _
                                                                                    .BottomBorder = New BottomBorder With {.Val = BorderValues.Single}}}

                                        p = New Paragraph
                                        ApplyStyleToParagraph(wordDocument, "b1i0fs12Ind0JC", "b1i0fs12Ind0JC", p, True, False, 12, 0, JustificationValues.Center)
                                        r = New Run
                                        tx = New Text("Percentile")
                                        r.Append(tx)
                                        p.Append(r)
                                        tc1.Append(p)
                                        tr.Append(tc1)
                                    End If
                                    If dt.Range Then
                                        tc1 = New TableCell
                                        tc1.TableCellProperties = New TableCellProperties With _
                                                              {.TableCellBorders = New TableCellBorders With _
                                                                                   {.TopBorder = New TopBorder With {.Val = BorderValues.Single}, _
                                                                                    .BottomBorder = New BottomBorder With {.Val = BorderValues.Single}}}

                                        p = New Paragraph
                                        ApplyStyleToParagraph(wordDocument, "b1i0fs12Ind0JC", "b1i0fs12Ind0JC", p, True, False, 12, 0, JustificationValues.Center)
                                        r = New Run
                                        tx = New Text("Range")
                                        r.Append(tx)
                                        p.Append(r)
                                        tc1.Append(p)
                                        tr.Append(tc1)
                                    End If
                                    ' Append the table row to the table.
                                    t.Append(tr)
                                    Dim rowIndex As Integer = 0
                                    For Each dtir In dti
                                        Dim dgvr As DataGridViewRow = DisplayTableItemDataGridView.Rows(rowIndex)
                                        tr = New TableRow
                                        tc1 = New TableCell
                                        Dim bborder As DocumentFormat.OpenXml.EnumValue(Of DocumentFormat.OpenXml.Wordprocessing.BorderValues)
                                        Dim tborder As DocumentFormat.OpenXml.EnumValue(Of DocumentFormat.OpenXml.Wordprocessing.BorderValues)
                                        If dtir.BorderBelow Then
                                            bborder = BorderValues.Single

                                        Else
                                            bborder = BorderValues.Nil

                                        End If

                                        If dtir.BorderAbove Then
                                            tborder = BorderValues.Single
                                        Else
                                            tborder = BorderValues.Nil
                                        End If

                                        tc1.TableCellProperties = New TableCellProperties With _
                                              {.TableCellBorders = New TableCellBorders With _
                                                                   {.TopBorder = New TopBorder With {.Val = tborder}, _
                                                                    .BottomBorder = New BottomBorder With {.Val = bborder}}}


                                        p = New Paragraph
                                        strParagraphStyle = "b"
                                        If dtir.Bold Then
                                            strParagraphStyle &= "1"
                                        Else
                                            strParagraphStyle &= "0"
                                        End If
                                        If dtir.Italic Then
                                            strParagraphStyle &= "i1"
                                        Else
                                            strParagraphStyle &= "i0"
                                        End If
                                        If dtir.IsSizeNull Then
                                            strParagraphStyle &= "fs12"
                                        Else
                                            strParagraphStyle &= "fs" & dtir.Size.ToString
                                        End If
                                        ApplyStyleToParagraph(wordDocument, strParagraphStyle & "Ind" & dtir.Level & "JL", strParagraphStyle & "Ind" & dtir.Level & "JL", p, dtir.Bold, dtir.Italic, dtir.Size, dtir.Level, JustificationValues.Left)
                                        r = New Run
                                        tx = New Text(dgvr.Cells("Marker").FormattedValue.ToString)
                                        r.Append(tx)
                                        p.Append(r)
                                        tc1.Append(p)
                                        tr.Append(tc1)
                                        If dt.Score Then
                                            tc1 = New TableCell
                                            tc1.TableCellProperties = New TableCellProperties With _
                                              {.TableCellBorders = New TableCellBorders With _
                                                                   {.TopBorder = New TopBorder With {.Val = tborder}, _
                                                                    .BottomBorder = New BottomBorder With {.Val = bborder}}}
                                            p = New Paragraph
                                            ApplyStyleToParagraph(wordDocument, strParagraphStyle & "Ind0JC", strParagraphStyle & "Ind0JC", p, dtir.Bold, dtir.Italic, dtir.Size, 0, JustificationValues.Center)
                                            r = New Run
                                            tx = New Text(dgvr.Cells("DisplayItemScore").FormattedValue.ToString)
                                            r.Append(tx)
                                            p.Append(r)
                                            tc1.Append(p)
                                            tr.Append(tc1)
                                        End If
                                        If dt.Percentile Then
                                            tc1 = New TableCell
                                            tc1.TableCellProperties = New TableCellProperties With _
                                              {.TableCellBorders = New TableCellBorders With _
                                                                   {.TopBorder = New TopBorder With {.Val = tborder}, _
                                                                    .BottomBorder = New BottomBorder With {.Val = bborder}}}
                                            p = New Paragraph
                                            ApplyStyleToParagraph(wordDocument, strParagraphStyle & "Ind0JC", strParagraphStyle & "Ind0JC", p, dtir.Bold, dtir.Italic, dtir.Size, 0, JustificationValues.Center)
                                            r = New Run
                                            tx = New Text(dgvr.Cells("PercentileColumn").FormattedValue.ToString)
                                            r.Append(tx)
                                            p.Append(r)
                                            tc1.Append(p)
                                            tr.Append(tc1)
                                        End If
                                        If dt.Range Then
                                            tc1 = New TableCell
                                            tc1.TableCellProperties = New TableCellProperties With _
                                              {.TableCellBorders = New TableCellBorders With _
                                                                   {.TopBorder = New TopBorder With {.Val = tborder}, _
                                                                    .BottomBorder = New BottomBorder With {.Val = bborder}}}
                                            p = New Paragraph
                                            ApplyStyleToParagraph(wordDocument, strParagraphStyle & "Ind0JC", strParagraphStyle & "Ind0JC", p, dtir.Bold, dtir.Italic, dtir.Size, 0, JustificationValues.Center)
                                            r = New Run
                                            tx = New Text(dgvr.Cells("RangeColumn").FormattedValue.ToString)
                                            r.Append(tx)
                                            p.Append(r)
                                            tc1.Append(p)
                                            tr.Append(tc1)
                                        End If
                                        If blnOmit And dtir.ScaleRow.ScoreTypeRow.ScoreTypeID <> 9 Then
                                            Dim pr As tmDataSet.PersonRow
                                            If PersonBatteryBindingSource.Position <> -1 Then
                                                pr = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow)
                                            Else
                                                pr = Nothing
                                            End If
                                            If pr IsNot Nothing Then
                                                Dim pbs() As tmDataSet.PersonBatteryScaleRow = CType(tmDataSet.PersonBatteryScale.Select("PersonID = " & pr.PersonID & " AND ScaleID = " & dtir.ScaleID), tmDataSet.PersonBatteryScaleRow())
                                                If pbs.Length > 0 Then
                                                    Dim pba As tmDataSet.PersonBatteryAdministrationRow = (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonID = pr.PersonID And pbar.BatteryID = pbs(0).PersonBatteryRow.BatteryID).FirstOrDefault
                                                    Dim pbsr As tmDataSet.PersonBatteryScaleRow = (From pbsi In pbs Where pbsi.PersonBatteryID = pba.PersonBatteryID).FirstOrDefault
                                                    If pbsr.IsScoreNull = False Then
                                                        t.Append(tr)
                                                    End If
                                                End If
                                            End If
                                        Else
                                            t.Append(tr)
                                        End If
                                        rowIndex += 1
                                    Next

                                    ' Append the table to the document.
                                    mainPart.Document.Body.Append(t)
                                    If dt.IsNoteNull = False Then
                                        If dt.Note <> "" Then
                                            Dim noteP As Paragraph = New Paragraph
                                            Dim TableNoteParaProp As New ParagraphProperties
                                            TableNoteParaProp.ParagraphStyleId = New ParagraphStyleId With {.Val = "TableNote"}
                                            noteP.Append(TableNoteParaProp)
                                            Dim noteRun As Run = New Run With {.RunProperties = New RunProperties With {.Italic = New Italic}}

                                            Dim noteText As Text = New Text("Note")
                                            noteRun.Append(noteText)
                                            noteP.Append(noteRun)
                                            noteRun = New Run
                                            noteText = New Text(": " & dt.Note)
                                            noteRun.Append(noteText)
                                            noteP.Append(noteRun)
                                            mainPart.Document.Body.Append(noteP)
                                        End If
                                    End If
                                    Dim dtm() As tmDataSet.DisplayTableMarkerRow = (From dtmr In tmDataSet.DisplayTableMarker Where dtmr.DisplayTableID = dt.DisplayTableID).ToArray

                                    For Each dtmr In dtm
                                        If (dtmr.IsMarkerSymbolNull = False) And (dtmr.IsMarkerMeaningNull = False) Then
                                            Dim MarkerP As Paragraph = New Paragraph
                                            Dim MarkerPProp As New ParagraphProperties
                                            MarkerPProp.ParagraphStyleId = New ParagraphStyleId With {.Val = "TableNote"}
                                            MarkerP.Append(MarkerPProp)
                                            Dim MarkerRun As Run = New Run
                                            Dim MarkerText As Text = New Text(dtmr.MarkerSymbol & " " & dtmr.MarkerMeaning)
                                            MarkerRun.Append(MarkerText)
                                            MarkerP.Append(MarkerRun)
                                            mainPart.Document.Body.Append(MarkerP)
                                        End If
                                    Next
                                Next
                            End If
                            mainPart.Document.Save()
                            If File.Exists(fds.FileName) Then
                                Process.Start(fds.FileName)
                            End If
                        End Using
                    End If
                End If
            End If
        End If
    End Sub
    ' Apply a style to a paragraph.
    Public Sub ApplyStyleToParagraph(ByVal doc As WordprocessingDocument,
        ByVal styleid As String, ByVal stylename As String, ByVal p As Paragraph, ByVal blnBold As Boolean, ByVal blnItalic As Boolean, ByVal intFontSize As Integer, ByVal intIndent As Integer, Just As JustificationValues)

        ' If the paragraph has no ParagraphProperties object, create one.
        If p.Elements(Of ParagraphProperties)().Count() = 0 Then
            p.PrependChild(Of ParagraphProperties)(New ParagraphProperties)
        End If

        ' Get the paragraph properties element of the paragraph.
        Dim pPr As ParagraphProperties = p.Elements(Of ParagraphProperties)().First()

        ' Get the Styles part for this document.
        Dim part As StyleDefinitionsPart = doc.MainDocumentPart.StyleDefinitionsPart

        ' If the Styles part does not exist, add it and then add the style.
        If part Is Nothing Then
            part = AddStylesPartToPackage(doc)
            AddNewStyle(part, styleid, stylename, blnBold, blnItalic, intFontSize, intIndent, Just)
        Else
            ' If the style is not in the document, add it.
            If IsStyleIdInDocument(doc, styleid) <> True Then
                ' No match on styleid, so let's try style name.
                Dim styleidFromName As String =
                    GetStyleIdFromStyleName(doc, stylename)
                If styleidFromName Is Nothing Then
                    AddNewStyle(part, styleid, stylename, blnBold, blnItalic, intFontSize, intIndent, Just)
                Else
                    styleid = styleidFromName
                End If
            End If
        End If

        ' Set the style of the paragraph.
        pPr.ParagraphStyleId = New ParagraphStyleId With {.Val = styleid}
    End Sub
    ' Return true if the style id is in the document, false otherwise.
    Public Function IsStyleIdInDocument(ByVal doc As WordprocessingDocument,
                                        ByVal styleid As String) As Boolean
        ' Get access to the Styles element for this document.
        Dim s As Styles = doc.MainDocumentPart.StyleDefinitionsPart.Styles

        ' Check that there are styles and how many.
        Dim n As Integer = s.Elements(Of Style)().Count()
        If n = 0 Then
            Return False
        End If

        ' Look for a match on styleid.
        Dim style As Style = s.Elements(Of Style)().
            Where(Function(st) (st.StyleId = styleid) AndAlso
                      (st.Type.Value = StyleValues.Paragraph)).
            FirstOrDefault()
        If style Is Nothing Then
            Return False
        End If

        Return True
    End Function

    ' Return styleid that matches the styleName, or null when there's no match.
    Public Function GetStyleIdFromStyleName(ByVal doc As WordprocessingDocument,
                                            ByVal styleName As String) As String
        Dim stylePart As StyleDefinitionsPart = doc.MainDocumentPart.StyleDefinitionsPart
        Dim styleId As String = stylePart.Styles.Descendants(Of StyleName)().
            Where(Function(s) s.Val.Value.Equals(styleName) AndAlso
                      ((CType(s.Parent, Style)).Type.Value = StyleValues.Paragraph)).
            Select(Function(n) (CType(n.Parent, Style)).StyleId).
            FirstOrDefault()
        Return styleId
    End Function

    ' Create a new style with the specified styleid and stylename and add it to the specified
    ' style definitions part.
    Public Sub AddNewStyle(ByVal styleDefinitionsPart As StyleDefinitionsPart,
                            ByVal styleid As String, ByVal stylename As String, ByVal blnBold As Boolean, ByVal blnItalic As Boolean, ByVal intFontsize As Integer, ByVal intIndent As Integer, ByVal Just As JustificationValues)
        ' Get access to the root element of the styles part.
        Dim styles As Styles = styleDefinitionsPart.Styles

        ' Create a new paragraph style and specify some of the properties.
        Dim style As New Style With {.Type = StyleValues.Paragraph,
                                     .StyleId = styleid,
                                     .CustomStyle = True}
        Dim styleName1 As New StyleName With {.Val = stylename}
        Dim basedOn1 As New BasedOn With {.Val = "Normal"}
        Dim nextParagraphStyle1 As New NextParagraphStyle With {.Val = "Normal"}
        style.Append(styleName1)
        style.Append(basedOn1)
        style.Append(nextParagraphStyle1)

        ' Create the StyleRunProperties object and specify some of the run properties.
        Dim styleRunProperties1 As New StyleRunProperties
        'Dim font1 As New RunFonts With {.Ascii = cbxFont.SelectedItem.ToString}
        ' Specify a point size.
        Dim fontSize1 As New FontSize With {.Val = (intFontsize * 2).ToString}
        If blnBold Then
            styleRunProperties1.Bold = New Bold
        End If
        If blnItalic Then
            styleRunProperties1.Italic = New Italic
        End If

        'styleRunProperties1.Append(font1)
        'styleRunProperties1.Append(fontSize1)

        ' Add the run properties to the style.
        style.Append(styleRunProperties1)
        Dim spp As StyleParagraphProperties = New StyleParagraphProperties With {.Indentation = New Indentation With {.Left = (240 * intIndent).ToString}, .Justification = New Justification With {.Val = Just}}
        style.Append(spp)

        ' Add the style to the styles part.
        styles.Append(style)
    End Sub
    ' Add a StylesDefinitionsPart to the document.  Returns a reference to it.
    Public Function AddStylesPartToPackage(ByVal doc As WordprocessingDocument) _
        As StyleDefinitionsPart
        Dim part As StyleDefinitionsPart
        part = doc.MainDocumentPart.AddNewPart(Of StyleDefinitionsPart)()
        Dim root As New Styles
        root.Save(part)
        Return part
    End Function


    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function

    Private Sub dtpPersonBattery_CloseUp(sender As Object, e As System.EventArgs) Handles dtpPersonBattery.CloseUp
        PersonBatteryBindingSource.EndEdit()
        PersonBatteryDataGridView.RefreshEdit()
        LastDate = dtpPersonBattery.Value
        FormatPersonBatteryScale()
    End Sub

    Private Sub dtpPersonBattery_TextChanged(sender As Object, e As System.EventArgs) Handles dtpPersonBattery.TextChanged
        PersonBatteryBindingSource.EndEdit()
        PersonBatteryDataGridView.RefreshEdit()
        LastDate = dtpPersonBattery.Value
        FormatPersonBatteryScale()
    End Sub

    Private Sub PersonBatteryListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If FilteredPersonBatteryBindingSource.Position <> -1 Then
            Dim pb As tmDataSet.PersonBatteryRow = CType(CType(FilteredPersonBatteryBindingSource.Current, DataRowView).Row, tmDataSet.PersonBatteryRow)
            Dim pba As tmDataSet.PersonBatteryAdministrationRow = (From pbar As tmDataSet.PersonBatteryAdministrationRow In tmDataSet.PersonBatteryAdministration Where pbar.BatteryID = pb.BatteryID And pbar.PersonID = pb.PersonID).FirstOrDefault
            If pba IsNot Nothing Then
                pba.PersonBatteryID = pb.PersonBatteryID
                FormatDisplayItem()
            End If

        End If
    End Sub

    Private Sub PersonBatteryListBox_Enter(sender As Object, e As System.EventArgs) Handles PersonBatteryListBox.Enter
        AddHandler PersonBatteryListBox.SelectedIndexChanged, AddressOf PersonBatteryListBox_SelectedIndexChanged
    End Sub

    Private Sub PersonBatteryListBox_Leave(sender As Object, e As System.EventArgs) Handles PersonBatteryListBox.Leave
        RemoveHandler PersonBatteryListBox.SelectedIndexChanged, AddressOf PersonBatteryListBox_SelectedIndexChanged
    End Sub

    Private Sub BatteryBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BatteryBindingSource.CurrentChanged
        AdminList()
        FormatPersonBatteryScale()
    End Sub

    Private Sub PersonBatteryBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles PersonBatteryBindingSource.CurrentChanged
        PersonBatteryScaleDataGridView.Focus()

    End Sub

    Private Sub AdminList()
        If BatteryBindingSource.Position <> -1 Then
            Dim b As tmDataSet.BatteryRow = CType(CType(BatteryBindingSource.Current, DataRowView).Row, tmDataSet.BatteryRow)
            FilteredPersonBatteryBindingSource.Filter = "BatteryID = " & b.BatteryID
            If PersonBatteryListBox.Items.Count < 2 Then
                scTableScale.Panel2Collapsed = True
            Else
                scTableScale.Panel2Collapsed = False
                If FilteredPersonBatteryBindingSource.Position <> -1 Then
                    Dim pID As Integer = CType(CType(PersonBindingSource.Current, DataRowView).Row, tmDataSet.PersonRow).PersonID
                    Dim pdc As System.ComponentModel.PropertyDescriptorCollection = FilteredPersonBatteryBindingSource.CurrencyManager.GetItemProperties()
                    Dim prop As System.ComponentModel.PropertyDescriptor = pdc.Find("PersonBatteryID", True)
                    FilteredPersonBatteryBindingSource.Position = PersonBatteryBindingSource.Find(prop, (From pbar In tmDataSet.PersonBatteryAdministration Where pbar.PersonID = pID And pbar.BatteryID = b.BatteryID).FirstOrDefault.PersonBatteryID)
                End If
            End If
        End If
    End Sub

    Public Sub FormatPersonBatteryScale()
        If PersonBatteryScaleDataGridView.RowCount > 0 And tcTableMaker.SelectedTab IsNot tpImportExport Then
            For Each drv As DataGridViewRow In PersonBatteryScaleDataGridView.Rows
                Dim dr As tmDataSet.PersonBatteryScaleRow = CType(CType(drv.DataBoundItem, DataRowView).Row, tmDataSet.PersonBatteryScaleRow)
                If dr.ScaleRow.Level = 0 Then
                    drv.DefaultCellStyle.Font = New System.Drawing.Font(PersonBatteryScaleDataGridView.DefaultCellStyle.Font, FontStyle.Bold)
                Else
                    drv.DefaultCellStyle.Font = New System.Drawing.Font(PersonBatteryScaleDataGridView.DefaultCellStyle.Font, FontStyle.Regular)
                End If
                If dr.ScaleRow.ScoreTypeID = 9 Then
                    drv.Cells("DataGridViewTextBoxColumn6").Style.BackColor = System.Drawing.Color.Black
                Else
                    drv.Cells("DataGridViewTextBoxColumn6").Style.BackColor = PersonBatteryScaleDataGridView.DefaultCellStyle.BackColor
                End If
            Next
        End If
    End Sub

    Private Sub PersonBatteryBindingSource_PositionChanged(sender As Object, e As System.EventArgs) Handles PersonBatteryBindingSource.PositionChanged
        FormatPersonBatteryScale()
    End Sub

    Private Sub DisplayTableDataGridView_Sorted(sender As Object, e As System.EventArgs) Handles DisplayTableDataGridView.Sorted
        FormatDisplay()
        FormatDisplayItem()
    End Sub

    Private Sub btnSaveAllData_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveAllData.Click
        If My.Settings.LastSaveLocation = "" Then
            My.Settings.LastSaveLocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            My.Settings.Save()
        End If
        Dim strFileName As String = "TableMaker Data.xml"
        If File.Exists(My.Settings.LastSaveLocation & "\" & strFileName) Then
            Dim i As Integer = 2
            Do
                strFileName = "TableMaker Data" & " " & i & ".xml"
                i += 1
            Loop Until File.Exists(My.Settings.LastSaveLocation & "\" & strFileName) = False
        End If
        FormatDisplayItem()
        Dim fds As New SaveFileDialog With {.InitialDirectory = My.Settings.LastSaveLocation, .Filter = "xml (.xml)|*.xml", .AddExtension = True, .Title = "Export Data", .FileName = strFileName}
        If fds.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fn() As String = fds.FileName.Split("\"c)
            Dim strLastSave As String = ""
            For i = 0 To fn.Length - 2
                If i = 0 Then
                    strLastSave &= fn(i)
                Else
                    strLastSave &= "\" & fn(i)
                End If
            Next
            My.Settings.LastSaveLocation = strLastSave
            My.Settings.Save()
            If MsgBox("Include evaluee data?", MsgBoxStyle.YesNo, "Export Data") = MsgBoxResult.Yes Then
                tmDataSet.WriteXml(fds.FileName)
            Else
                Dim tmXML As XDocument = XDocument.Parse(tmDataSet.GetXml)
                Dim ds As New tmDataSet
                Dim xr As XmlReader = tmXML.CreateReader
                ds.ReadXml(xr)
                ds.PersonBatteryScale.Clear()
                ds.PersonBatteryAdministration.Clear()
                ds.PersonBattery.Clear()
                ds.Person.Clear()

                ds.WriteXml(fds.FileName)
                'tmXML.Save(fds.FileName)
                ds.Dispose()
            End If
            Process.Start(fds.FileName)
        End If
    End Sub

    Private Sub btnImportData_Click(sender As System.Object, e As System.EventArgs) Handles btnImportData.Click

        If MsgBox("Do you wish to clear all data (all person records and all tests and all tables) and import new data from an XML file you have previously exported? It is STRONGLY recommended that you export your data before doing this so that you can revert back to your previous data if needed. Click 'Yes' to proceed. Click 'No' to abort this process.", MsgBoxStyle.YesNo, "Import Data") = MsgBoxResult.Yes Then
            Dim fdo As New OpenFileDialog With {.InitialDirectory = My.Settings.LastSaveLocation, .Filter = "xml (.xml)|*.xml"}
            If fdo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim fn() As String = fdo.FileName.Split("\"c)
                Dim strLastSave As String = ""
                For i = 0 To fn.Length - 2
                    If i = 0 Then
                        strLastSave &= fn(i)
                    Else
                        strLastSave &= "\" & fn(i)
                    End If
                Next
                My.Settings.LastSaveLocation = strLastSave
                My.Settings.Save()
                Dim cmd As New SqlServerCe.SqlCeCommand
                Dim strSQL As String
                For Each t As DataTable In tmDataSet.Tables
                    Dim rs As DataRow() = (From r In t Select r).ToArray
                    For Each r In rs
                        r.Delete()
                    Next

                Next
                SaveData()

                For Each t As DataTable In tmDataSet.Tables
                    If t.PrimaryKey.Length > 0 And t.TableName <> "DisplayTableItemScore" And t.TableName <> "ScaleType" And t.TableName <> "Sex" Then
                        strSQL = "ALTER TABLE " & t.TableName & " ALTER COLUMN " & t.PrimaryKey(0).ColumnName & " IDENTITY (999,1)"
                        Using connection As New SqlServerCe.SqlCeConnection(My.Settings.TableMakerConnectionString)

                            cmd = New SqlServerCe.SqlCeCommand(strSQL, connection)

                            cmd.Connection.Open()

                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                Dim ds As New tmDataSet
                ds.ReadXml(fdo.FileName)
                Dim st As tmDataSet.ScaleTypeRow
                st = tmDataSet.ScaleType.NewScaleTypeRow()
                st.ScaleTypeID = 0
                st.ScaleTypeName = "Scale"
                tmDataSet.ScaleType.AddScaleTypeRow(st)
                st = tmDataSet.ScaleType.NewScaleTypeRow()
                st.ScaleTypeID = 1
                st.ScaleTypeName = "Subscale"
                tmDataSet.ScaleType.AddScaleTypeRow(st)
                IdentityInsert("ScoreType", ds)
                IdentityInsert("Range", ds)
                IdentityInsert("RangeLabel", ds)
                IdentityInsert("Battery", ds)
                IdentityInsert("Scale", ds)
                IdentityInsert("Person", ds)
                IdentityInsert("PersonBattery", ds)
                IdentityInsert("PersonBatteryAdministration", ds)
                IdentityInsert("PersonBatteryScale", ds)
                IdentityInsert("DisplayTable", ds)
                IdentityInsert("DisplayTableItem", ds)
                IdentityInsert("DisplayTableMarker", ds)
                IdentityInsert("DisplayTableItemMarker", ds)

                Me.ScoreTypeTableAdapter.Fill(Me.tmDataSet.ScoreType)
                Me.RangeTableAdapter.Fill(Me.tmDataSet.Range)
                Me.RangeLabelTableAdapter.Fill(Me.tmDataSet.RangeLabel)
                RangeLabelBindingSource.Sort = "LowerBound DESC"
                Me.BatteryTableAdapter.Fill(Me.tmDataSet.Battery)
                Me.ScaleTableAdapter.Fill(Me.tmDataSet.Scale)
                Me.PersonTableAdapter.Fill(Me.tmDataSet.Person)
                Me.PersonBatteryTableAdapter.Fill(Me.tmDataSet.PersonBattery)
                Me.PersonBatteryAdministrationTableAdapter.Fill(Me.tmDataSet.PersonBatteryAdministration)
                Me.PersonBatteryScaleTableAdapter.Fill(Me.tmDataSet.PersonBatteryScale)
                Me.DisplayTableTableAdapter.Fill(Me.tmDataSet.DisplayTable)
                Me.DisplayTableItemTableAdapter.Fill(Me.tmDataSet.DisplayTableItem)
                Me.DisplayTableMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableMarker)
                Me.DisplayTableItemMarkerTableAdapter.Fill(Me.tmDataSet.DisplayTableItemMarker)
                Me.ScaleTableAdapter.Fill(Me.tmDataSet.Scale)

            End If
        End If
    End Sub

    Private Sub IdentityInsert(strTableName As String, ds As tmDataSet)
        Using connection As New SqlServerCe.SqlCeConnection(My.Settings.TableMakerConnectionString)
            Dim cmd As New SqlServerCe.SqlCeCommand
            Dim cmdIdentOn As New SqlServerCe.SqlCeCommand("SET IDENTITY_INSERT " & strTableName & " ON", connection)
            Dim strInsert As String = "INSERT INTO " & strTableName & " ("
            Dim cnt As Integer = 0
            For Each c As DataColumn In tmDataSet.Tables(strTableName).Columns
                cnt += 1
                If c.Expression = "" Then
                    strInsert &= c.ColumnName & ", "
                End If
            Next
            strInsert = strInsert.Substring(0, strInsert.Length - 2) & ") VALUES ("
            cnt = 0
            cmd.Parameters.Clear()
            For Each c As DataColumn In tmDataSet.Tables(strTableName).Columns
                cnt += 1
                If c.Expression = "" Then
                    strInsert &= "@p" & cnt & ", "
                    cmd.Parameters.AddWithValue("@p" & cnt, c.DataType)
                End If
            Next
            strInsert = strInsert.Substring(0, strInsert.Length - 2) & ")"

            cnt = 0
            cmd.CommandText = strInsert
            cmd.Connection = connection
            Dim rcnt As Integer = 0
            If connection.State <> ConnectionState.Open Then connection.Open()
            cmdIdentOn.ExecuteNonQuery()
            For Each r As DataRow In ds.Tables(strTableName).Rows
                rcnt += 1
                cnt = 0
                For Each c As DataColumn In tmDataSet.Tables(strTableName).Columns
                    cnt += 1
                    If c.Expression = "" Then
                        cmd.Parameters("@p" & cnt).Value = r.Item(c.ColumnName)
                    End If
                Next
                cmd.ExecuteNonQuery()
            Next
            cmdIdentOn.CommandText = "SET IDENTITY_INSERT " & strTableName & " OFF"
            cmdIdentOn.ExecuteNonQuery()
        End Using

    End Sub

    Private Sub PersonBindingSource_PositionChanged(sender As Object, e As System.EventArgs) Handles PersonBindingSource.PositionChanged
        FormatPersonBatteryScale()
    End Sub

    Private Sub cbxHiddenTable_CheckedChanged(sender As Object, e As EventArgs) Handles cbxHiddenTable.CheckedChanged
        If cbxHiddenTable.Checked Then
            DisplayTableBindingSource.Filter = "Hide = " & True
        Else
            DisplayTableBindingSource.Filter = "Hide = " & False
        End If
        FormatDisplay()
        FormatDisplayItem()
    End Sub


End Class

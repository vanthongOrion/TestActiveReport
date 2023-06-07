Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document
Imports System.Linq
Imports System.Security.Cryptography

Public Class SectionReport1
    Private myDT As DataTable
    Private asEnum As EnumerableRowCollection
    Private Sub SectionReport1_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
        Me.DataSource = initDT()
    End Sub

    Private Function initDT() As DataTable
        Dim dataTable As New DataTable
        Dim dataColumn1 = New DataColumn("jmemid")
        Dim dataColumn2 = New DataColumn("jname")
        Dim dataColumn3 = New DataColumn("jtel")
        Dim dataColumn4 = New DataColumn("jadr")
        Dim dataColumn5 = New DataColumn("nmemid")
        Dim dataColumn6 = New DataColumn("name")
        Dim dataColumn7 = New DataColumn("ntel")
        Dim dataColumn8 = New DataColumn("nadr")

        dataTable.Columns.Add(dataColumn1)
        dataTable.Columns.Add(dataColumn2)
        dataTable.Columns.Add(dataColumn3)
        dataTable.Columns.Add(dataColumn4)
        dataTable.Columns.Add(dataColumn5)
        dataTable.Columns.Add(dataColumn6)
        dataTable.Columns.Add(dataColumn7)
        dataTable.Columns.Add(dataColumn8)

        Dim rows As DataRow
        rows = dataTable.NewRow

        rows.Item(0) = "1"
        rows.Item(1) = "thong"
        rows.Item(2) = "1234000"
        rows.Item(3) = "tokyo"
        rows.Item(4) = "1234"
        rows.Item(5) = "thuyet"
        rows.Item(6) = "1789"
        rows.Item(7) = "tochigi"

        Dim rows2 = dataTable.NewRow

        rows2.Item(0) = "1"
        rows2.Item(1) = "thong"
        rows2.Item(2) = "1234000"
        rows2.Item(3) = "tokyo"
        rows2.Item(4) = "456"
        rows2.Item(5) = "khoa"
        rows2.Item(6) = "789"
        rows2.Item(7) = "nghean"

        Dim rows3 = dataTable.NewRow

        rows3.Item(0) = "2"
        rows3.Item(1) = "kiet"
        rows3.Item(2) = "999999"
        rows3.Item(3) = "yenthanh"
        rows3.Item(4) = "1"
        rows3.Item(5) = "thong"
        rows3.Item(6) = "1234000"
        rows3.Item(7) = "tokyo"


        dataTable.Rows.Add(rows)
        dataTable.Rows.Add(rows2)
        dataTable.Rows.Add(rows3)
        dataTable.AcceptChanges()

        Return dataTable
    End Function

    Private Sub SectionReport1_FetchData(sender As Object, eArgs As FetchEventArgs) Handles MyBase.FetchData
        'Static count As Integer = 0
        'count += 1

        'If count = 7 Then

        '    eArgs.EOF = True
        '    MessageBox.Show(count)
        '    MessageBox.Show(eArgs.EOF.ToString)

        'Else

        '    eArgs.EOF = False

        'End If

        'If eArgs.EOF = True Then

        '    If count <> 7 Then

        '        eArgs.EOF = False

        '    End If

        'End If


        'MessageBox.Show(eArgs.EOF.ToString)
        'eArgs.EOF = False
        'Fields("jmemid").Value = "1"
        'Fields("jmemname").Value = "2"
        'Fields("nmemid").Value = "3"
        'Fields("NmemName").Value = "Thong"
        'eArgs.EOF = False
        'Dim asEnum = myDT.AsEnumerable().
        '        Select(Function(y) New With {
        '            Key .jMemid = y.Field(Of String)(0),
        '            Key .jName = y.Field(Of String)(1),
        '            Key .jTel = y.Field(Of String)(2),
        '            Key .jAdr = y.Field(Of String)(3),
        '            Key .nMemid = y.Field(Of String)(4),
        '            Key .nMemName = y.Field(Of String)(5),
        '            Key .nTel = y.Field(Of String)(6),
        '            Key .nAdr = y.Field(Of String)(7)})

        'Dim jmemidslist = From x In asEnum
        '                  Select x.jMemid Distinct.ToList
        ''MessageBox.Show(jmemidslist.Count)
        'For i As Integer = 0 To jmemidslist.Count - 1

        '    Dim jmemX = From x In (From a In asEnum
        '                               Where a.jMemid = jmemidslist.Item(i))
        '                    Select x.jMemid, x.jName, x.jAdr, x.jTel Distinct
        '        For Each inner In jmemX

        '            Fields("jmemtel").Value = inner.jTel
        '            Fields("jmemid").Value = inner.jMemid
        '            Fields("jmemAdr").Value = inner.jAdr
        '            Fields("jmemname").Value = inner.jName

        '        Next




        '        Dim nMem = From inner In (
        '                From a In asEnum Where
        '                                     a.jMemid = jmemidslist.Item(i)
        '                ) Select inner.nMemid,
        '                      inner.nMemName,
        '                      inner.nTel,
        '                      inner.nAdr

        '        For Each inner In nMem


        '            Fields("Nmemid").Value = inner.nMemid
        '            Fields("Nmemname").Value = inner.nMemName
        '            Fields("NmemTel").Value = inner.nTel
        '            Fields("NmemAdr").Value = inner.nAdr
        '        'MessageBox.Show(inner.nMemid)
        '    Next

        '    MessageBox.Show("i =" & i)
        '    If i = jmemidslist.Count - 1 Then

        '        eArgs.EOF = True

        '    Else
        '        eArgs.EOF = False
        '    End If

        '    If i = 0 Then
        '        GroupHeader1.NewPage = SectionReportModel.NewPage.After
        '    End If
        'Next

        'For Each jmemidx In jmemidslist

        '    Dim jmem = From x In (From a In asEnum
        '                          Where a.jMemid = jmemidx)
        '               Select x.jTel, x.jName, x.jAdr, x.jMemid Distinct

        '    For Each inner In jmem

        '        Fields("jmemtel").Value = inner.jTel
        '        Fields("jmemid").Value = inner.jMemid
        '        Fields("jmemAdr").Value = inner.jAdr
        '        Fields("jmemname").Value = inner.jName



        '    Next

        '    Dim nMem = From inner In (
        '                From a In asEnum
        '                ) Select inner.nMemid,
        '                      inner.nMemName,
        '                      inner.nTel,
        '                      inner.nAdr

        '    For Each inner In nMem


        '        Fields("Nmemid").Value = inner.nMemid
        '        Fields("Nmemname").Value = inner.nMemName
        '        Fields("NmemTel").Value = inner.nTel
        '        Fields("NmemAdr").Value = inner.nAdr
        '    Next
        'Next

        'Static count As Integer = 0
        'count += 1
        'MessageBox.Show("fetching " & count)
        'MessageBox.Show("arg = " & eArgs.EOF.ToString)
    End Sub

    Private Sub SectionReport1_DataInitialize(sender As Object, e As EventArgs) Handles MyBase.DataInitialize
        Fields.Add("jmemid")
        Fields.Add("jmemname")
        Fields.Add("NmemId")
        Fields.Add("NmemName")
        Fields.Add("NmemTel")
        Fields.Add("NmemAdr")
        Fields.Add("JmemAdr")
        Fields.Add("JmemTel")
        myDT = initDT()

        'asEnum = myDT.AsEnumerable().
        '                Select(Function(y) New With {
        '                    Key .jMemid = y.Field(Of String)(0),
        '                    Key .jName = y.Field(Of String)(1),
        '                    Key .jTel = y.Field(Of String)(2),
        '                    Key .jAdr = y.Field(Of String)(3),
        '                    Key .nMemid = y.Field(Of String)(4),
        '                    Key .nMemName = y.Field(Of String)(5),
        '                    Key .nTel = y.Field(Of String)(6),
        '                    Key .nAdr = y.Field(Of String)(7)})
        '.OrderBy((Function(x) x.jMemid))                    ' can use order by to sort

        ''-- Using query to get jmemid distinct
        'Dim jmemids = From j In asEnum
        '              Select j.jMemid Distinct.ToList

        ''-- Using group by to get jmemid *keyword : First
        'Dim JmemidList = asEnum.GroupBy(Function(x) x.jMemid).
        '            Select(Function(y) y.First.jMemid)


    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format

        Static count As Integer = 0

        count += 1
        'If count = 3 Then

        '    Detail.NewPage = SectionReportModel.NewPage.After

        'End If
        'MessageBox.Show(count)

    End Sub

    Private Sub GroupHeader1_Format(sender As Object, e As EventArgs) Handles GroupHeader1.Format
        Static count As Integer = 0
        count += 1
        'MessageBox.Show(Me.TextBox13.Value.ToString)
        'MessageBox.Show(count)
    End Sub

    Private Sub SectionReport1_PageStart(sender As Object, e As EventArgs) Handles MyBase.PageStart
        'MessageBox.Show("page start")

    End Sub
End Class

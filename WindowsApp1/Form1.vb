Imports GrapeCity.ActiveReports

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = initDT()
        Dim viewer = New Form2
        Dim rpt As New SectionReport1()
        rpt.SetDataTable = dt
        rpt.Run()
        'Dim rpt2 As New SectionReport1
        'rpt2.Run()
        'Dim rpt3 As New SectionReport1
        'rpt3.Run()

        'Dim i As Integer
        'For i = 0 To rpt2.Document.Pages.Count - 1
        '    rpt.Document.Pages.Add(rpt2.Document.Pages(i))
        'Next
        'For i = 0 To rpt3.Document.Pages.Count - 1
        '    rpt.Document.Pages.Add(rpt3.Document.Pages(i))
        'Next

        'rpt.Document.Print(True, True, True)
        viewer.Viewer1.Document = rpt.Document
        viewer.Show()
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

        Dim row4 = dataTable.NewRow

        row4.Item(0) = "2"
        row4.Item(1) = "kiet"
        row4.Item(2) = "999999"
        row4.Item(3) = "yenthanh"
        row4.Item(4) = "1"
        row4.Item(5) = "thong"
        row4.Item(6) = "1234000"
        row4.Item(7) = "tokyo"


        Dim row5 = dataTable.NewRow

        row5.Item(0) = "2"
        row5.Item(1) = "kiet"
        row5.Item(2) = "999999"
        row5.Item(3) = "yenthanh"
        row5.Item(4) = "1"
        row5.Item(5) = "thong"
        row5.Item(6) = "1234000"
        row5.Item(7) = "tokyo"


        Dim row6 = dataTable.NewRow

        row6.Item(0) = "2"
        row6.Item(1) = "kiet"
        row6.Item(2) = "999999"
        row6.Item(3) = "yenthanh"
        row6.Item(4) = "1"
        row6.Item(5) = "thong"
        row6.Item(6) = "1234000"
        row6.Item(7) = "tokyo"

        Dim row7 = dataTable.NewRow

        row7.Item(0) = "2"
        row7.Item(1) = "kiet"
        row7.Item(2) = "999999"
        row7.Item(3) = "yenthanh"
        row7.Item(4) = "1"
        row7.Item(5) = "thong"
        row7.Item(6) = "1234000"
        row7.Item(7) = "tokyo"


        Dim row8 = dataTable.NewRow

        row8.Item(0) = "2"
        row8.Item(1) = "kiet"
        row8.Item(2) = "999999"
        row8.Item(3) = "yenthanh"
        row8.Item(4) = "1"
        row8.Item(5) = "thong"
        row8.Item(6) = "1234000"
        row8.Item(7) = "tokyo"

        Dim row9 = dataTable.NewRow

        row9.Item(0) = "2"
        row9.Item(1) = "kiet"
        row9.Item(2) = "999999"
        row9.Item(3) = "yenthanh"
        row9.Item(4) = "1"
        row9.Item(5) = "thong"
        row9.Item(6) = "1234000"
        row9.Item(7) = "tokyo"



        'dataTable.Rows.Add(rows)
        'dataTable.Rows.Add(rows2)
        'dataTable.Rows.Add(rows3)
        'dataTable.Rows.Add(row4)
        'dataTable.Rows.Add(row5)
        'dataTable.Rows.Add(row6)
        'dataTable.Rows.Add(row7)
        'dataTable.Rows.Add(row8)
        'dataTable.Rows.Add(row9)
        dataTable.AcceptChanges()

        Return dataTable
    End Function

End Class

Imports GrapeCity.ActiveReports

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewer = New Form2
        Dim rpt As New SectionReport1()
        rpt.Run()
        Dim rpt2 As New SectionReport1
        rpt2.Run()
        Dim rpt3 As New SectionReport1
        rpt3.Run()

        Dim i As Integer
        For i = 0 To rpt2.Document.Pages.Count - 1
            rpt.Document.Pages.Add(rpt2.Document.Pages(i))
        Next
        For i = 0 To rpt3.Document.Pages.Count - 1
            rpt.Document.Pages.Add(rpt3.Document.Pages(i))
        Next

        rpt.Document.Print(True, True, True)
        viewer.Viewer1.Document = rpt.Document
        viewer.Show()
    End Sub
End Class

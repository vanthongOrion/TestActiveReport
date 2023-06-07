<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SectionReport1
    Inherits GrapeCity.ActiveReports.SectionReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SectionReport1))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.28125!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox4, Me.TextBox6})
        Me.Detail.Height = 0.1979167!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox3, Me.TextBox5, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16})
        Me.GroupHeader1.DataField = "HdGroup"
        Me.GroupHeader1.Height = 1.084!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.DataField = "Nmemid"
        Me.TextBox1.Height = 0.2!
        Me.TextBox1.Left = 0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Text = "Id"
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 1.0!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.DataField = "NmemName"
        Me.TextBox2.Height = 0.2!
        Me.TextBox2.Left = 1.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Text = "Name"
        Me.TextBox2.Top = 0.00000001490116!
        Me.TextBox2.Width = 1.552!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.DataField = "NmemTel"
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 2.552!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Text = "Tel"
        Me.TextBox4.Top = 0.00000001490116!
        Me.TextBox4.Width = 1.448!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.DataField = "NmemAdr"
        Me.TextBox6.Height = 0.2!
        Me.TextBox6.Left = 4.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Text = "Adr"
        Me.TextBox6.Top = 0.00000001490116!
        Me.TextBox6.Width = 2.0!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Text = "NmemId"
        Me.TextBox7.Top = 0.8840001!
        Me.TextBox7.Width = 1.0!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 1.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Text = "NmemName"
        Me.TextBox8.Top = 0.8840001!
        Me.TextBox8.Width = 1.552!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2!
        Me.TextBox9.Left = 2.552!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Text = "NmemTel"
        Me.TextBox9.Top = 0.8840001!
        Me.TextBox9.Width = 1.448!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2!
        Me.TextBox10.Left = 4.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Text = "NmemAdr"
        Me.TextBox10.Top = 0.8840001!
        Me.TextBox10.Width = 2.0!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2!
        Me.TextBox11.Left = 0.375!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Text = "JmemID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox11.Top = 0.03!
        Me.TextBox11.Width = 1.0!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2!
        Me.TextBox12.Left = 3.333!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Text = "JmemAdr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox12.Top = 0.03!
        Me.TextBox12.Width = 1.0!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2!
        Me.TextBox3.Left = 0.375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Text = "JmemName" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox3.Top = 0.442!
        Me.TextBox3.Width = 1.0!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 3.333!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Text = "JmemTel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox5.Top = 0.442!
        Me.TextBox5.Width = 1.0!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.DataField = "Jmemid"
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 1.375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Text = "Id"
        Me.TextBox13.Top = 0.03!
        Me.TextBox13.Width = 1.625!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.DataField = "JmemName"
        Me.TextBox14.Height = 0.2!
        Me.TextBox14.Left = 1.375!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox14.Top = 0.442!
        Me.TextBox14.Width = 1.594!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.DataField = "Jmemadr"
        Me.TextBox15.Height = 0.2!
        Me.TextBox15.Left = 4.333!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Text = "Adr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox15.Top = 0.03!
        Me.TextBox15.Width = 1.625!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.DataField = "JmemTel"
        Me.TextBox16.Height = 0.2!
        Me.TextBox16.Left = 4.333!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Text = "Tel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox16.Top = 0.442!
        Me.TextBox16.Width = 1.625!
        '
        'SectionReport1
        '
        Me.MasterReport = False
        Me.CompatibilityMode = GrapeCity.ActiveReports.Document.CompatibilityModes.CrossPlatform
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

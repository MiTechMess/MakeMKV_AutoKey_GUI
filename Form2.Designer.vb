<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 21)
        Label1.TabIndex = 0
        Label1.Text = "About this app"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 35)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(607, 403)
        TextBox1.TabIndex = 2
        TextBox1.TabStop = False
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(637, 460)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "MakeMKV AutoKey GUI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class

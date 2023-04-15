<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 15)
        Label1.TabIndex = 0
        Label1.Text = "Created By MiTechMess.com (2023)" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.MakeMKV_AutoKey_GUI_logo
        PictureBox1.Location = New Point(12, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 82)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBox1.Location = New Point(63, 154)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(194, 25)
        TextBox1.TabIndex = 2
        TextBox1.TabStop = False
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(63, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 31)
        Button1.TabIndex = 3
        Button1.Text = "Update MakeMKV Key"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(320, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 216)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "MakeMKV AutoKey GUI"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

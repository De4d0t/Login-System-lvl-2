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
        Me.NsTheme1 = New de4dot_LoginForm_V1._0.NSTheme()
        Me.NsTextBoxUsername = New de4dot_LoginForm_V1._0.NSTextBox()
        Me.NsOnOffBox1 = New de4dot_LoginForm_V1._0.NSOnOffBox()
        Me.NsButton2 = New de4dot_LoginForm_V1._0.NSButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.NsTextBoxSerialCode = New de4dot_LoginForm_V1._0.NSTextBox()
        Me.NsTextBoxTelegramCode = New de4dot_LoginForm_V1._0.NSTextBox()
        Me.NsButton1 = New de4dot_LoginForm_V1._0.NSButton()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New de4dot_LoginForm_V1._0.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsTextBoxUsername)
        Me.NsTheme1.Controls.Add(Me.NsOnOffBox1)
        Me.NsTheme1.Controls.Add(Me.NsButton2)
        Me.NsTheme1.Controls.Add(Me.Label2)
        Me.NsTheme1.Controls.Add(Me.Label99)
        Me.NsTheme1.Controls.Add(Me.NsTextBoxSerialCode)
        Me.NsTheme1.Controls.Add(Me.NsTextBoxTelegramCode)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = False
        Me.NsTheme1.Size = New System.Drawing.Size(365, 201)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Login System V1.2"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsTextBoxUsername
        '
        Me.NsTextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxUsername.Location = New System.Drawing.Point(8, 38)
        Me.NsTextBoxUsername.MaxLength = 32767
        Me.NsTextBoxUsername.Multiline = False
        Me.NsTextBoxUsername.Name = "NsTextBoxUsername"
        Me.NsTextBoxUsername.ReadOnly = False
        Me.NsTextBoxUsername.Size = New System.Drawing.Size(348, 23)
        Me.NsTextBoxUsername.TabIndex = 8
        Me.NsTextBoxUsername.Text = "Username"
        Me.NsTextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxUsername.UseSystemPasswordChar = False
        '
        'NsOnOffBox1
        '
        Me.NsOnOffBox1.Checked = True
        Me.NsOnOffBox1.Location = New System.Drawing.Point(304, 2)
        Me.NsOnOffBox1.MaximumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.MinimumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.Name = "NsOnOffBox1"
        Me.NsOnOffBox1.Size = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.TabIndex = 7
        Me.NsOnOffBox1.Text = "NsOnOffBox1"
        '
        'NsButton2
        '
        Me.NsButton2.Location = New System.Drawing.Point(8, 95)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(348, 23)
        Me.NsButton2.TabIndex = 6
        Me.NsButton2.Text = "Send Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(103, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label99.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label99.Location = New System.Drawing.Point(10, 184)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(87, 12)
        Me.Label99.TabIndex = 4
        Me.Label99.Text = "Code Expires :"
        '
        'NsTextBoxSerialCode
        '
        Me.NsTextBoxSerialCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxSerialCode.Location = New System.Drawing.Point(8, 127)
        Me.NsTextBoxSerialCode.MaxLength = 32767
        Me.NsTextBoxSerialCode.Multiline = False
        Me.NsTextBoxSerialCode.Name = "NsTextBoxSerialCode"
        Me.NsTextBoxSerialCode.ReadOnly = False
        Me.NsTextBoxSerialCode.Size = New System.Drawing.Size(348, 23)
        Me.NsTextBoxSerialCode.TabIndex = 2
        Me.NsTextBoxSerialCode.Text = "Serial Code"
        Me.NsTextBoxSerialCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxSerialCode.UseSystemPasswordChar = False
        '
        'NsTextBoxTelegramCode
        '
        Me.NsTextBoxTelegramCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxTelegramCode.Location = New System.Drawing.Point(8, 66)
        Me.NsTextBoxTelegramCode.MaxLength = 32767
        Me.NsTextBoxTelegramCode.Multiline = False
        Me.NsTextBoxTelegramCode.Name = "NsTextBoxTelegramCode"
        Me.NsTextBoxTelegramCode.ReadOnly = False
        Me.NsTextBoxTelegramCode.Size = New System.Drawing.Size(348, 23)
        Me.NsTextBoxTelegramCode.TabIndex = 1
        Me.NsTextBoxTelegramCode.Text = "Code"
        Me.NsTextBoxTelegramCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxTelegramCode.UseSystemPasswordChar = False
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(8, 156)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(348, 23)
        Me.NsButton1.TabIndex = 0
        Me.NsButton1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 201)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Login System - @de4dot"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents Label2 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents NsTextBoxSerialCode As NSTextBox
    Friend WithEvents NsTextBoxTelegramCode As NSTextBox
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsButton2 As NSButton
    Friend WithEvents NsOnOffBox1 As NSOnOffBox
    Friend WithEvents NsTextBoxUsername As NSTextBox
End Class

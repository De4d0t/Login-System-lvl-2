<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NsTheme1 = New System_Activtion_V1._0.NSTheme()
        Me.NsOnOffBox1 = New System_Activtion_V1._0.NSOnOffBox()
        Me.NsTextBoxNewSerial = New System_Activtion_V1._0.NSTextBox()
        Me.NsTextBoxPass = New System_Activtion_V1._0.NSTextBox()
        Me.NsTextBoxSerial = New System_Activtion_V1._0.NSTextBox()
        Me.NsButton1 = New System_Activtion_V1._0.NSButton()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New System_Activtion_V1._0.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsOnOffBox1)
        Me.NsTheme1.Controls.Add(Me.NsTextBoxNewSerial)
        Me.NsTheme1.Controls.Add(Me.NsTextBoxPass)
        Me.NsTheme1.Controls.Add(Me.NsTextBoxSerial)
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
        Me.NsTheme1.Size = New System.Drawing.Size(364, 165)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Admin Activtion V1.2"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsOnOffBox1
        '
        Me.NsOnOffBox1.Checked = True
        Me.NsOnOffBox1.Location = New System.Drawing.Point(305, 1)
        Me.NsOnOffBox1.MaximumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.MinimumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.Name = "NsOnOffBox1"
        Me.NsOnOffBox1.Size = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.TabIndex = 5
        Me.NsOnOffBox1.Text = "NsOnOffBox1"
        '
        'NsTextBoxNewSerial
        '
        Me.NsTextBoxNewSerial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxNewSerial.Location = New System.Drawing.Point(9, 129)
        Me.NsTextBoxNewSerial.MaxLength = 32767
        Me.NsTextBoxNewSerial.Multiline = False
        Me.NsTextBoxNewSerial.Name = "NsTextBoxNewSerial"
        Me.NsTextBoxNewSerial.ReadOnly = False
        Me.NsTextBoxNewSerial.Size = New System.Drawing.Size(347, 23)
        Me.NsTextBoxNewSerial.TabIndex = 3
        Me.NsTextBoxNewSerial.Text = "Encrypted  Serial"
        Me.NsTextBoxNewSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxNewSerial.UseSystemPasswordChar = False
        '
        'NsTextBoxPass
        '
        Me.NsTextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxPass.Location = New System.Drawing.Point(9, 71)
        Me.NsTextBoxPass.MaxLength = 32767
        Me.NsTextBoxPass.Multiline = False
        Me.NsTextBoxPass.Name = "NsTextBoxPass"
        Me.NsTextBoxPass.ReadOnly = False
        Me.NsTextBoxPass.Size = New System.Drawing.Size(347, 23)
        Me.NsTextBoxPass.TabIndex = 2
        Me.NsTextBoxPass.Text = "Password"
        Me.NsTextBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxPass.UseSystemPasswordChar = False
        '
        'NsTextBoxSerial
        '
        Me.NsTextBoxSerial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NsTextBoxSerial.Location = New System.Drawing.Point(9, 42)
        Me.NsTextBoxSerial.MaxLength = 32767
        Me.NsTextBoxSerial.Multiline = False
        Me.NsTextBoxSerial.Name = "NsTextBoxSerial"
        Me.NsTextBoxSerial.ReadOnly = False
        Me.NsTextBoxSerial.Size = New System.Drawing.Size(347, 23)
        Me.NsTextBoxSerial.TabIndex = 1
        Me.NsTextBoxSerial.Text = "Serial"
        Me.NsTextBoxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NsTextBoxSerial.UseSystemPasswordChar = False
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(9, 100)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(347, 23)
        Me.NsButton1.TabIndex = 0
        Me.NsButton1.Text = "Encrypt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 165)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "System Activtion V1.0 "
        Me.NsTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents NsTextBoxNewSerial As NSTextBox
    Friend WithEvents NsTextBoxPass As NSTextBox
    Friend WithEvents NsTextBoxSerial As NSTextBox
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsOnOffBox1 As NSOnOffBox
End Class

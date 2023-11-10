<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomComboBox
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CmbBoxClients = New System.Windows.Forms.ComboBox()
		Me.BtnNext = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(12, 59)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(500, 42)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Select A Client"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'CmbBoxClients
		'
		Me.CmbBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CmbBoxClients.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.CmbBoxClients.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmbBoxClients.FormattingEnabled = True
		Me.CmbBoxClients.Location = New System.Drawing.Point(12, 104)
		Me.CmbBoxClients.Name = "CmbBoxClients"
		Me.CmbBoxClients.Size = New System.Drawing.Size(500, 29)
		Me.CmbBoxClients.TabIndex = 1
		'
		'BtnNext
		'
		Me.BtnNext.BackColor = System.Drawing.Color.Blue
		Me.BtnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnNext.ForeColor = System.Drawing.Color.White
		Me.BtnNext.Location = New System.Drawing.Point(122, 173)
		Me.BtnNext.Name = "BtnNext"
		Me.BtnNext.Size = New System.Drawing.Size(273, 48)
		Me.BtnNext.TabIndex = 2
		Me.BtnNext.Text = "Next"
		Me.BtnNext.UseVisualStyleBackColor = False
		'
		'CustomComboBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(524, 265)
		Me.Controls.Add(Me.BtnNext)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CmbBoxClients)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "CustomComboBox"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Select Client"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents CmbBoxClients As ComboBox
	Friend WithEvents BtnNext As Button
End Class

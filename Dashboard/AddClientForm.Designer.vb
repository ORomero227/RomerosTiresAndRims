﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClientForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClientForm))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtFirstname = New System.Windows.Forms.TextBox()
		Me.TxtPaternalLastname = New System.Windows.Forms.TextBox()
		Me.TxtMaternalLastname = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.TxtPhysicalAddress = New System.Windows.Forms.TextBox()
		Me.TxtMailingAddress = New System.Windows.Forms.TextBox()
		Me.TxtCity = New System.Windows.Forms.TextBox()
		Me.TxtZipCode = New System.Windows.Forms.TextBox()
		Me.TxtEmail = New System.Windows.Forms.TextBox()
		Me.BirthDatePicker = New System.Windows.Forms.DateTimePicker()
		Me.TxtClientFee = New System.Windows.Forms.TextBox()
		Me.MTxtCellularNumber = New System.Windows.Forms.MaskedTextBox()
		Me.TxtCompanyName = New System.Windows.Forms.TextBox()
		Me.TxtCompanyCity = New System.Windows.Forms.TextBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.BtnAdd = New System.Windows.Forms.Button()
		Me.BtnClear = New System.Windows.Forms.Button()
		Me.BtnClose = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(594, 592)
		Me.Panel1.TabIndex = 5
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.05495!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.94505!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtFirstname, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtPaternalLastname, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtMaternalLastname, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 10)
		Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 11)
		Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 12)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtPhysicalAddress, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtMailingAddress, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtCity, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtZipCode, 1, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtEmail, 1, 8)
		Me.TableLayoutPanel1.Controls.Add(Me.BirthDatePicker, 1, 11)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtClientFee, 1, 12)
		Me.TableLayoutPanel1.Controls.Add(Me.MTxtCellularNumber, 1, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtCompanyName, 1, 9)
		Me.TableLayoutPanel1.Controls.Add(Me.TxtCompanyCity, 1, 10)
		Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 15
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(568, 533)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(249, 35)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Firstname:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtFirstname
		'
		Me.TxtFirstname.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtFirstname.Location = New System.Drawing.Point(258, 3)
		Me.TxtFirstname.Name = "TxtFirstname"
		Me.TxtFirstname.Size = New System.Drawing.Size(307, 28)
		Me.TxtFirstname.TabIndex = 1
		'
		'TxtPaternalLastname
		'
		Me.TxtPaternalLastname.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtPaternalLastname.Location = New System.Drawing.Point(258, 38)
		Me.TxtPaternalLastname.Name = "TxtPaternalLastname"
		Me.TxtPaternalLastname.Size = New System.Drawing.Size(307, 28)
		Me.TxtPaternalLastname.TabIndex = 4
		'
		'TxtMaternalLastname
		'
		Me.TxtMaternalLastname.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtMaternalLastname.Location = New System.Drawing.Point(258, 73)
		Me.TxtMaternalLastname.Name = "TxtMaternalLastname"
		Me.TxtMaternalLastname.Size = New System.Drawing.Size(307, 28)
		Me.TxtMaternalLastname.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Location = New System.Drawing.Point(3, 35)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(249, 35)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Paternal Lastname:"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Location = New System.Drawing.Point(3, 70)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(249, 35)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Maternal Lastname:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label5.Location = New System.Drawing.Point(3, 105)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(249, 35)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Physical Address:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label6.Location = New System.Drawing.Point(3, 140)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(249, 35)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Mailing Address:"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label7.Location = New System.Drawing.Point(3, 175)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(249, 35)
		Me.Label7.TabIndex = 10
		Me.Label7.Text = "City:"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label8.Location = New System.Drawing.Point(3, 210)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(249, 35)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "ZipCode:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label9.Location = New System.Drawing.Point(3, 245)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(249, 35)
		Me.Label9.TabIndex = 12
		Me.Label9.Text = "Cellular Number:"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label10.Location = New System.Drawing.Point(3, 280)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(249, 35)
		Me.Label10.TabIndex = 13
		Me.Label10.Text = "Email:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label11.Location = New System.Drawing.Point(3, 315)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(249, 35)
		Me.Label11.TabIndex = 14
		Me.Label11.Text = "Company Name:"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label12.Location = New System.Drawing.Point(3, 350)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(249, 35)
		Me.Label12.TabIndex = 15
		Me.Label12.Text = "Company City:"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label13.Location = New System.Drawing.Point(3, 385)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(249, 35)
		Me.Label13.TabIndex = 16
		Me.Label13.Text = "Birth Date:"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label14.Location = New System.Drawing.Point(3, 420)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(249, 35)
		Me.Label14.TabIndex = 17
		Me.Label14.Text = "Client Fee:"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtPhysicalAddress
		'
		Me.TxtPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtPhysicalAddress.Location = New System.Drawing.Point(258, 108)
		Me.TxtPhysicalAddress.Name = "TxtPhysicalAddress"
		Me.TxtPhysicalAddress.Size = New System.Drawing.Size(307, 28)
		Me.TxtPhysicalAddress.TabIndex = 19
		'
		'TxtMailingAddress
		'
		Me.TxtMailingAddress.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtMailingAddress.Location = New System.Drawing.Point(258, 143)
		Me.TxtMailingAddress.Name = "TxtMailingAddress"
		Me.TxtMailingAddress.Size = New System.Drawing.Size(307, 28)
		Me.TxtMailingAddress.TabIndex = 20
		'
		'TxtCity
		'
		Me.TxtCity.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtCity.Location = New System.Drawing.Point(258, 178)
		Me.TxtCity.Name = "TxtCity"
		Me.TxtCity.Size = New System.Drawing.Size(307, 28)
		Me.TxtCity.TabIndex = 21
		'
		'TxtZipCode
		'
		Me.TxtZipCode.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtZipCode.Location = New System.Drawing.Point(258, 213)
		Me.TxtZipCode.Name = "TxtZipCode"
		Me.TxtZipCode.Size = New System.Drawing.Size(307, 28)
		Me.TxtZipCode.TabIndex = 22
		'
		'TxtEmail
		'
		Me.TxtEmail.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtEmail.Location = New System.Drawing.Point(258, 283)
		Me.TxtEmail.Name = "TxtEmail"
		Me.TxtEmail.Size = New System.Drawing.Size(307, 28)
		Me.TxtEmail.TabIndex = 24
		'
		'BirthDatePicker
		'
		Me.BirthDatePicker.CustomFormat = ""
		Me.BirthDatePicker.Dock = System.Windows.Forms.DockStyle.Fill
		Me.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.BirthDatePicker.Location = New System.Drawing.Point(258, 388)
		Me.BirthDatePicker.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
		Me.BirthDatePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
		Me.BirthDatePicker.Name = "BirthDatePicker"
		Me.BirthDatePicker.Size = New System.Drawing.Size(307, 28)
		Me.BirthDatePicker.TabIndex = 27
		Me.BirthDatePicker.Value = New Date(2023, 11, 7, 0, 0, 0, 0)
		'
		'TxtClientFee
		'
		Me.TxtClientFee.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtClientFee.Location = New System.Drawing.Point(258, 423)
		Me.TxtClientFee.Name = "TxtClientFee"
		Me.TxtClientFee.Size = New System.Drawing.Size(307, 28)
		Me.TxtClientFee.TabIndex = 28
		'
		'MTxtCellularNumber
		'
		Me.MTxtCellularNumber.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MTxtCellularNumber.Location = New System.Drawing.Point(258, 248)
		Me.MTxtCellularNumber.Mask = "(999) 000-0000"
		Me.MTxtCellularNumber.Name = "MTxtCellularNumber"
		Me.MTxtCellularNumber.Size = New System.Drawing.Size(307, 28)
		Me.MTxtCellularNumber.TabIndex = 23
		'
		'TxtCompanyName
		'
		Me.TxtCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtCompanyName.Location = New System.Drawing.Point(258, 318)
		Me.TxtCompanyName.Name = "TxtCompanyName"
		Me.TxtCompanyName.Size = New System.Drawing.Size(307, 28)
		Me.TxtCompanyName.TabIndex = 25
		'
		'TxtCompanyCity
		'
		Me.TxtCompanyCity.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TxtCompanyCity.Location = New System.Drawing.Point(258, 353)
		Me.TxtCompanyCity.Name = "TxtCompanyCity"
		Me.TxtCompanyCity.Size = New System.Drawing.Size(307, 28)
		Me.TxtCompanyCity.TabIndex = 26
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.BtnAdd)
		Me.Panel2.Controls.Add(Me.BtnClear)
		Me.Panel2.Controls.Add(Me.BtnClose)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel2.Location = New System.Drawing.Point(600, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(356, 592)
		Me.Panel2.TabIndex = 6
		'
		'BtnAdd
		'
		Me.BtnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BtnAdd.BackColor = System.Drawing.Color.Blue
		Me.BtnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnAdd.ForeColor = System.Drawing.Color.White
		Me.BtnAdd.Location = New System.Drawing.Point(55, 167)
		Me.BtnAdd.Name = "BtnAdd"
		Me.BtnAdd.Size = New System.Drawing.Size(273, 48)
		Me.BtnAdd.TabIndex = 1
		Me.BtnAdd.Text = "Add"
		Me.BtnAdd.UseVisualStyleBackColor = False
		'
		'BtnClear
		'
		Me.BtnClear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BtnClear.BackColor = System.Drawing.Color.Red
		Me.BtnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnClear.ForeColor = System.Drawing.Color.White
		Me.BtnClear.Location = New System.Drawing.Point(55, 221)
		Me.BtnClear.Name = "BtnClear"
		Me.BtnClear.Size = New System.Drawing.Size(273, 48)
		Me.BtnClear.TabIndex = 2
		Me.BtnClear.Text = "Clear"
		Me.BtnClear.UseVisualStyleBackColor = False
		'
		'BtnClose
		'
		Me.BtnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnClose.Location = New System.Drawing.Point(55, 275)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(273, 48)
		Me.BtnClose.TabIndex = 3
		Me.BtnClose.Text = "Close"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'AddClientForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(956, 592)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "AddClientForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Adding New Client"
		Me.Panel1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents TxtFirstname As TextBox
	Friend WithEvents TxtPaternalLastname As TextBox
	Friend WithEvents TxtMaternalLastname As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents TxtPhysicalAddress As TextBox
	Friend WithEvents TxtMailingAddress As TextBox
	Friend WithEvents TxtCity As TextBox
	Friend WithEvents TxtZipCode As TextBox
	Friend WithEvents TxtEmail As TextBox
	Friend WithEvents BirthDatePicker As DateTimePicker
	Friend WithEvents TxtClientFee As TextBox
	Friend WithEvents MTxtCellularNumber As MaskedTextBox
	Friend WithEvents Panel2 As Panel
	Friend WithEvents BtnAdd As Button
	Friend WithEvents BtnClear As Button
	Friend WithEvents BtnClose As Button
	Friend WithEvents TxtCompanyName As TextBox
	Friend WithEvents TxtCompanyCity As TextBox
End Class

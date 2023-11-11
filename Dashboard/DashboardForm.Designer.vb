<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.PanelSidebar = New System.Windows.Forms.Panel()
		Me.BtnMyAccount = New System.Windows.Forms.Button()
		Me.BtnDeleteClient = New System.Windows.Forms.Button()
		Me.BtnEditClient = New System.Windows.Forms.Button()
		Me.BtnAddClient = New System.Windows.Forms.Button()
		Me.PanelWelcome = New System.Windows.Forms.Panel()
		Me.LblWelcome = New System.Windows.Forms.Label()
		Me.PanelBanner = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PanelSearchBar = New System.Windows.Forms.Panel()
		Me.BtnExit = New System.Windows.Forms.Button()
		Me.TxtSearchBar = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ClientsGridView = New System.Windows.Forms.DataGridView()
		Me.ClientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PaternalLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MaternalLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PhysicalAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MailingAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Zipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CellularNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompanyCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ClientFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.LblFullName = New System.Windows.Forms.Label()
		Me.LblPhysicalAddress = New System.Windows.Forms.Label()
		Me.LblMailingAddress = New System.Windows.Forms.Label()
		Me.LblCity = New System.Windows.Forms.Label()
		Me.LblZipcode = New System.Windows.Forms.Label()
		Me.LblBirthDate = New System.Windows.Forms.Label()
		Me.LblCellularNumber = New System.Windows.Forms.Label()
		Me.LblEmail = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.LblClientFee = New System.Windows.Forms.Label()
		Me.LblCompanyCity = New System.Windows.Forms.Label()
		Me.LblCompanyName = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.BtnClearGroupBoxes = New System.Windows.Forms.Button()
		Me.BtnPrevious = New System.Windows.Forms.Button()
		Me.BtnNext = New System.Windows.Forms.Button()
		Me.BtnRefresh = New System.Windows.Forms.Button()
		Me.PanelSidebar.SuspendLayout()
		Me.PanelWelcome.SuspendLayout()
		Me.PanelBanner.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelSearchBar.SuspendLayout()
		CType(Me.ClientsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelSidebar
		'
		Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.PanelSidebar.Controls.Add(Me.BtnMyAccount)
		Me.PanelSidebar.Controls.Add(Me.BtnDeleteClient)
		Me.PanelSidebar.Controls.Add(Me.BtnEditClient)
		Me.PanelSidebar.Controls.Add(Me.BtnAddClient)
		Me.PanelSidebar.Controls.Add(Me.PanelWelcome)
		Me.PanelSidebar.Controls.Add(Me.PanelBanner)
		Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
		Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
		Me.PanelSidebar.Name = "PanelSidebar"
		Me.PanelSidebar.Size = New System.Drawing.Size(305, 869)
		Me.PanelSidebar.TabIndex = 0
		'
		'BtnMyAccount
		'
		Me.BtnMyAccount.BackColor = System.Drawing.Color.Transparent
		Me.BtnMyAccount.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.BtnMyAccount.FlatAppearance.BorderSize = 0
		Me.BtnMyAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
		Me.BtnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnMyAccount.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnMyAccount.ForeColor = System.Drawing.Color.White
		Me.BtnMyAccount.Location = New System.Drawing.Point(0, 823)
		Me.BtnMyAccount.Name = "BtnMyAccount"
		Me.BtnMyAccount.Size = New System.Drawing.Size(305, 46)
		Me.BtnMyAccount.TabIndex = 5
		Me.BtnMyAccount.Text = "My Account"
		Me.BtnMyAccount.UseVisualStyleBackColor = False
		'
		'BtnDeleteClient
		'
		Me.BtnDeleteClient.BackColor = System.Drawing.Color.Transparent
		Me.BtnDeleteClient.Dock = System.Windows.Forms.DockStyle.Top
		Me.BtnDeleteClient.FlatAppearance.BorderSize = 0
		Me.BtnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
		Me.BtnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnDeleteClient.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnDeleteClient.ForeColor = System.Drawing.Color.White
		Me.BtnDeleteClient.Location = New System.Drawing.Point(0, 273)
		Me.BtnDeleteClient.Name = "BtnDeleteClient"
		Me.BtnDeleteClient.Size = New System.Drawing.Size(305, 46)
		Me.BtnDeleteClient.TabIndex = 4
		Me.BtnDeleteClient.Text = "Delete Client"
		Me.BtnDeleteClient.UseVisualStyleBackColor = False
		'
		'BtnEditClient
		'
		Me.BtnEditClient.BackColor = System.Drawing.Color.Transparent
		Me.BtnEditClient.Dock = System.Windows.Forms.DockStyle.Top
		Me.BtnEditClient.FlatAppearance.BorderSize = 0
		Me.BtnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
		Me.BtnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnEditClient.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnEditClient.ForeColor = System.Drawing.Color.White
		Me.BtnEditClient.Location = New System.Drawing.Point(0, 227)
		Me.BtnEditClient.Name = "BtnEditClient"
		Me.BtnEditClient.Size = New System.Drawing.Size(305, 46)
		Me.BtnEditClient.TabIndex = 3
		Me.BtnEditClient.Text = "Edit Client"
		Me.BtnEditClient.UseVisualStyleBackColor = False
		'
		'BtnAddClient
		'
		Me.BtnAddClient.BackColor = System.Drawing.Color.Transparent
		Me.BtnAddClient.Dock = System.Windows.Forms.DockStyle.Top
		Me.BtnAddClient.FlatAppearance.BorderSize = 0
		Me.BtnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.BtnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnAddClient.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnAddClient.ForeColor = System.Drawing.Color.White
		Me.BtnAddClient.Location = New System.Drawing.Point(0, 181)
		Me.BtnAddClient.Name = "BtnAddClient"
		Me.BtnAddClient.Size = New System.Drawing.Size(305, 46)
		Me.BtnAddClient.TabIndex = 2
		Me.BtnAddClient.Text = "Add New Client"
		Me.BtnAddClient.UseVisualStyleBackColor = False
		'
		'PanelWelcome
		'
		Me.PanelWelcome.BackColor = System.Drawing.Color.Transparent
		Me.PanelWelcome.Controls.Add(Me.LblWelcome)
		Me.PanelWelcome.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelWelcome.Location = New System.Drawing.Point(0, 73)
		Me.PanelWelcome.Name = "PanelWelcome"
		Me.PanelWelcome.Size = New System.Drawing.Size(305, 108)
		Me.PanelWelcome.TabIndex = 1
		'
		'LblWelcome
		'
		Me.LblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblWelcome.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblWelcome.ForeColor = System.Drawing.Color.White
		Me.LblWelcome.Location = New System.Drawing.Point(0, 0)
		Me.LblWelcome.Name = "LblWelcome"
		Me.LblWelcome.Size = New System.Drawing.Size(305, 108)
		Me.LblWelcome.TabIndex = 0
		Me.LblWelcome.Text = "Welcome Label"
		Me.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PanelBanner
		'
		Me.PanelBanner.Controls.Add(Me.PictureBox1)
		Me.PanelBanner.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelBanner.Location = New System.Drawing.Point(0, 0)
		Me.PanelBanner.Name = "PanelBanner"
		Me.PanelBanner.Size = New System.Drawing.Size(305, 73)
		Me.PanelBanner.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(305, 73)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'PanelSearchBar
		'
		Me.PanelSearchBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.PanelSearchBar.Controls.Add(Me.BtnExit)
		Me.PanelSearchBar.Controls.Add(Me.TxtSearchBar)
		Me.PanelSearchBar.Controls.Add(Me.Label1)
		Me.PanelSearchBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelSearchBar.Location = New System.Drawing.Point(305, 0)
		Me.PanelSearchBar.Name = "PanelSearchBar"
		Me.PanelSearchBar.Size = New System.Drawing.Size(1121, 73)
		Me.PanelSearchBar.TabIndex = 3
		'
		'BtnExit
		'
		Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BtnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BtnExit.BackColor = System.Drawing.Color.Red
		Me.BtnExit.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnExit.ForeColor = System.Drawing.Color.White
		Me.BtnExit.Location = New System.Drawing.Point(966, 18)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(143, 29)
		Me.BtnExit.TabIndex = 5
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.UseVisualStyleBackColor = False
		'
		'TxtSearchBar
		'
		Me.TxtSearchBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TxtSearchBar.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtSearchBar.Location = New System.Drawing.Point(115, 17)
		Me.TxtSearchBar.Name = "TxtSearchBar"
		Me.TxtSearchBar.Size = New System.Drawing.Size(350, 28)
		Me.TxtSearchBar.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(6, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 28)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Search:"
		'
		'ClientsGridView
		'
		Me.ClientsGridView.AllowUserToAddRows = False
		Me.ClientsGridView.AllowUserToDeleteRows = False
		Me.ClientsGridView.AllowUserToResizeColumns = False
		Me.ClientsGridView.AllowUserToResizeRows = False
		Me.ClientsGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ClientsGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
		Me.ClientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.ClientsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
		Me.ClientsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ClientsGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.ClientsGridView.ColumnHeadersHeight = 40
		Me.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.ClientsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientId, Me.FirstName, Me.PaternalLastname, Me.MaternalLastname, Me.PhysicalAddress, Me.MailingAddress, Me.City, Me.Zipcode, Me.BirthDate, Me.CellularNumber, Me.Email, Me.CompanyName, Me.CompanyCity, Me.ClientFee})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.ClientsGridView.DefaultCellStyle = DataGridViewCellStyle2
		Me.ClientsGridView.EnableHeadersVisualStyles = False
		Me.ClientsGridView.GridColor = System.Drawing.Color.SteelBlue
		Me.ClientsGridView.Location = New System.Drawing.Point(323, 79)
		Me.ClientsGridView.Name = "ClientsGridView"
		Me.ClientsGridView.ReadOnly = True
		Me.ClientsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ClientsGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.ClientsGridView.RowHeadersVisible = False
		Me.ClientsGridView.RowHeadersWidth = 51
		Me.ClientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		Me.ClientsGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
		Me.ClientsGridView.RowTemplate.Height = 24
		Me.ClientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.ClientsGridView.Size = New System.Drawing.Size(1091, 391)
		Me.ClientsGridView.TabIndex = 45
		'
		'ClientId
		'
		Me.ClientId.HeaderText = "Client #"
		Me.ClientId.MinimumWidth = 6
		Me.ClientId.Name = "ClientId"
		Me.ClientId.ReadOnly = True
		Me.ClientId.Width = 125
		'
		'FirstName
		'
		Me.FirstName.HeaderText = "Firstname"
		Me.FirstName.MinimumWidth = 6
		Me.FirstName.Name = "FirstName"
		Me.FirstName.ReadOnly = True
		Me.FirstName.Width = 125
		'
		'PaternalLastname
		'
		Me.PaternalLastname.HeaderText = "Paternal Lastname"
		Me.PaternalLastname.MinimumWidth = 6
		Me.PaternalLastname.Name = "PaternalLastname"
		Me.PaternalLastname.ReadOnly = True
		Me.PaternalLastname.Width = 125
		'
		'MaternalLastname
		'
		Me.MaternalLastname.HeaderText = "Maternal Lastname"
		Me.MaternalLastname.MinimumWidth = 6
		Me.MaternalLastname.Name = "MaternalLastname"
		Me.MaternalLastname.ReadOnly = True
		Me.MaternalLastname.Width = 125
		'
		'PhysicalAddress
		'
		Me.PhysicalAddress.HeaderText = "Physical Address"
		Me.PhysicalAddress.MinimumWidth = 6
		Me.PhysicalAddress.Name = "PhysicalAddress"
		Me.PhysicalAddress.ReadOnly = True
		Me.PhysicalAddress.Width = 125
		'
		'MailingAddress
		'
		Me.MailingAddress.HeaderText = "Mailing Address"
		Me.MailingAddress.MinimumWidth = 6
		Me.MailingAddress.Name = "MailingAddress"
		Me.MailingAddress.ReadOnly = True
		Me.MailingAddress.Width = 125
		'
		'City
		'
		Me.City.HeaderText = "City"
		Me.City.MinimumWidth = 6
		Me.City.Name = "City"
		Me.City.ReadOnly = True
		Me.City.Width = 125
		'
		'Zipcode
		'
		Me.Zipcode.HeaderText = "Zipcode"
		Me.Zipcode.MinimumWidth = 6
		Me.Zipcode.Name = "Zipcode"
		Me.Zipcode.ReadOnly = True
		Me.Zipcode.Width = 125
		'
		'BirthDate
		'
		Me.BirthDate.HeaderText = "Birth Date"
		Me.BirthDate.MinimumWidth = 6
		Me.BirthDate.Name = "BirthDate"
		Me.BirthDate.ReadOnly = True
		Me.BirthDate.Width = 125
		'
		'CellularNumber
		'
		Me.CellularNumber.HeaderText = "Cellular Number"
		Me.CellularNumber.MinimumWidth = 6
		Me.CellularNumber.Name = "CellularNumber"
		Me.CellularNumber.ReadOnly = True
		Me.CellularNumber.Width = 125
		'
		'Email
		'
		Me.Email.HeaderText = "Email"
		Me.Email.MinimumWidth = 6
		Me.Email.Name = "Email"
		Me.Email.ReadOnly = True
		Me.Email.Width = 125
		'
		'CompanyName
		'
		Me.CompanyName.HeaderText = "Company Name"
		Me.CompanyName.MinimumWidth = 6
		Me.CompanyName.Name = "CompanyName"
		Me.CompanyName.ReadOnly = True
		Me.CompanyName.Width = 125
		'
		'CompanyCity
		'
		Me.CompanyCity.HeaderText = "Company City"
		Me.CompanyCity.MinimumWidth = 6
		Me.CompanyCity.Name = "CompanyCity"
		Me.CompanyCity.ReadOnly = True
		Me.CompanyCity.Width = 125
		'
		'ClientFee
		'
		Me.ClientFee.HeaderText = "Client Fee"
		Me.ClientFee.MinimumWidth = 6
		Me.ClientFee.Name = "ClientFee"
		Me.ClientFee.ReadOnly = True
		Me.ClientFee.Width = 125
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(324, 476)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(551, 381)
		Me.GroupBox1.TabIndex = 46
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Client Personal Info"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.LblFullName, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.LblPhysicalAddress, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.LblMailingAddress, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.LblCity, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.LblZipcode, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.LblBirthDate, 1, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.LblCellularNumber, 1, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.LblEmail, 1, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 35)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 9
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(526, 338)
		Me.TableLayoutPanel1.TabIndex = 8
		'
		'LblFullName
		'
		Me.LblFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblFullName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblFullName.ForeColor = System.Drawing.Color.White
		Me.LblFullName.Location = New System.Drawing.Point(248, 0)
		Me.LblFullName.Name = "LblFullName"
		Me.LblFullName.Size = New System.Drawing.Size(275, 37)
		Me.LblFullName.TabIndex = 0
		Me.LblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblPhysicalAddress
		'
		Me.LblPhysicalAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblPhysicalAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblPhysicalAddress.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblPhysicalAddress.ForeColor = System.Drawing.Color.White
		Me.LblPhysicalAddress.Location = New System.Drawing.Point(248, 37)
		Me.LblPhysicalAddress.Name = "LblPhysicalAddress"
		Me.LblPhysicalAddress.Size = New System.Drawing.Size(275, 38)
		Me.LblPhysicalAddress.TabIndex = 2
		Me.LblPhysicalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblMailingAddress
		'
		Me.LblMailingAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblMailingAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblMailingAddress.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblMailingAddress.ForeColor = System.Drawing.Color.White
		Me.LblMailingAddress.Location = New System.Drawing.Point(248, 75)
		Me.LblMailingAddress.Name = "LblMailingAddress"
		Me.LblMailingAddress.Size = New System.Drawing.Size(275, 38)
		Me.LblMailingAddress.TabIndex = 3
		Me.LblMailingAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblCity
		'
		Me.LblCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblCity.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblCity.ForeColor = System.Drawing.Color.White
		Me.LblCity.Location = New System.Drawing.Point(248, 113)
		Me.LblCity.Name = "LblCity"
		Me.LblCity.Size = New System.Drawing.Size(275, 38)
		Me.LblCity.TabIndex = 4
		Me.LblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblZipcode
		'
		Me.LblZipcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblZipcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblZipcode.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblZipcode.ForeColor = System.Drawing.Color.White
		Me.LblZipcode.Location = New System.Drawing.Point(248, 151)
		Me.LblZipcode.Name = "LblZipcode"
		Me.LblZipcode.Size = New System.Drawing.Size(275, 38)
		Me.LblZipcode.TabIndex = 5
		Me.LblZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblBirthDate
		'
		Me.LblBirthDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblBirthDate.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblBirthDate.ForeColor = System.Drawing.Color.White
		Me.LblBirthDate.Location = New System.Drawing.Point(248, 189)
		Me.LblBirthDate.Name = "LblBirthDate"
		Me.LblBirthDate.Size = New System.Drawing.Size(275, 37)
		Me.LblBirthDate.TabIndex = 1
		Me.LblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblCellularNumber
		'
		Me.LblCellularNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblCellularNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblCellularNumber.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblCellularNumber.ForeColor = System.Drawing.Color.White
		Me.LblCellularNumber.Location = New System.Drawing.Point(248, 226)
		Me.LblCellularNumber.Name = "LblCellularNumber"
		Me.LblCellularNumber.Size = New System.Drawing.Size(275, 38)
		Me.LblCellularNumber.TabIndex = 6
		Me.LblCellularNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblEmail
		'
		Me.LblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblEmail.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblEmail.ForeColor = System.Drawing.Color.White
		Me.LblEmail.Location = New System.Drawing.Point(248, 264)
		Me.LblEmail.Name = "LblEmail"
		Me.LblEmail.Size = New System.Drawing.Size(275, 38)
		Me.LblEmail.TabIndex = 7
		Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Location = New System.Drawing.Point(3, 37)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(239, 38)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Physical Address"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label6.Location = New System.Drawing.Point(3, 75)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(239, 38)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Mailing Address"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label8.Location = New System.Drawing.Point(3, 113)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(239, 38)
		Me.Label8.TabIndex = 11
		Me.Label8.Text = "City"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label10.Location = New System.Drawing.Point(3, 151)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(239, 38)
		Me.Label10.TabIndex = 12
		Me.Label10.Text = "Zipcode"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label11.Location = New System.Drawing.Point(3, 189)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(239, 37)
		Me.Label11.TabIndex = 13
		Me.Label11.Text = "Birth Date"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label12.Location = New System.Drawing.Point(3, 226)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(239, 38)
		Me.Label12.TabIndex = 14
		Me.Label12.Text = "Cellular Number"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label13.Location = New System.Drawing.Point(3, 264)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(239, 38)
		Me.Label13.TabIndex = 15
		Me.Label13.Text = "Email"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Location = New System.Drawing.Point(3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(239, 37)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Full Name"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
		Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(881, 476)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(533, 261)
		Me.GroupBox2.TabIndex = 47
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Company Info"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.LblClientFee, 1, 7)
		Me.TableLayoutPanel2.Controls.Add(Me.LblCompanyCity, 1, 6)
		Me.TableLayoutPanel2.Controls.Add(Me.LblCompanyName, 1, 5)
		Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 5)
		Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 6)
		Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 7)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 35)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 9
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(508, 220)
		Me.TableLayoutPanel2.TabIndex = 8
		'
		'LblClientFee
		'
		Me.LblClientFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblClientFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblClientFee.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblClientFee.ForeColor = System.Drawing.Color.White
		Me.LblClientFee.Location = New System.Drawing.Point(264, 75)
		Me.LblClientFee.Name = "LblClientFee"
		Me.LblClientFee.Size = New System.Drawing.Size(241, 38)
		Me.LblClientFee.TabIndex = 7
		Me.LblClientFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblCompanyCity
		'
		Me.LblCompanyCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblCompanyCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblCompanyCity.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblCompanyCity.ForeColor = System.Drawing.Color.White
		Me.LblCompanyCity.Location = New System.Drawing.Point(264, 37)
		Me.LblCompanyCity.Name = "LblCompanyCity"
		Me.LblCompanyCity.Size = New System.Drawing.Size(241, 38)
		Me.LblCompanyCity.TabIndex = 6
		Me.LblCompanyCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LblCompanyName
		'
		Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblCompanyName.ForeColor = System.Drawing.Color.White
		Me.LblCompanyName.Location = New System.Drawing.Point(264, 0)
		Me.LblCompanyName.Name = "LblCompanyName"
		Me.LblCompanyName.Size = New System.Drawing.Size(241, 37)
		Me.LblCompanyName.TabIndex = 1
		Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Location = New System.Drawing.Point(3, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(255, 37)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Company Name"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label5.Location = New System.Drawing.Point(3, 37)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(255, 38)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Company City"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label7.Location = New System.Drawing.Point(3, 75)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(255, 38)
		Me.Label7.TabIndex = 10
		Me.Label7.Text = "Fee"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BtnClearGroupBoxes
		'
		Me.BtnClearGroupBoxes.BackColor = System.Drawing.Color.Gold
		Me.BtnClearGroupBoxes.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnClearGroupBoxes.Location = New System.Drawing.Point(881, 743)
		Me.BtnClearGroupBoxes.Name = "BtnClearGroupBoxes"
		Me.BtnClearGroupBoxes.Size = New System.Drawing.Size(258, 57)
		Me.BtnClearGroupBoxes.TabIndex = 9
		Me.BtnClearGroupBoxes.Text = "Clear"
		Me.BtnClearGroupBoxes.UseVisualStyleBackColor = False
		'
		'BtnPrevious
		'
		Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.BtnPrevious.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnPrevious.ForeColor = System.Drawing.Color.White
		Me.BtnPrevious.Location = New System.Drawing.Point(881, 806)
		Me.BtnPrevious.Name = "BtnPrevious"
		Me.BtnPrevious.Size = New System.Drawing.Size(258, 51)
		Me.BtnPrevious.TabIndex = 48
		Me.BtnPrevious.Text = "Previous"
		Me.BtnPrevious.UseVisualStyleBackColor = False
		'
		'BtnNext
		'
		Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.BtnNext.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnNext.ForeColor = System.Drawing.Color.White
		Me.BtnNext.Location = New System.Drawing.Point(1145, 806)
		Me.BtnNext.Name = "BtnNext"
		Me.BtnNext.Size = New System.Drawing.Size(269, 51)
		Me.BtnNext.TabIndex = 49
		Me.BtnNext.Text = "Next"
		Me.BtnNext.UseVisualStyleBackColor = False
		'
		'BtnRefresh
		'
		Me.BtnRefresh.BackColor = System.Drawing.Color.DarkOrange
		Me.BtnRefresh.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnRefresh.Location = New System.Drawing.Point(1145, 743)
		Me.BtnRefresh.Name = "BtnRefresh"
		Me.BtnRefresh.Size = New System.Drawing.Size(269, 57)
		Me.BtnRefresh.TabIndex = 50
		Me.BtnRefresh.Text = "Refresh"
		Me.BtnRefresh.UseVisualStyleBackColor = False
		'
		'DashboardForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(1426, 869)
		Me.Controls.Add(Me.BtnRefresh)
		Me.Controls.Add(Me.BtnNext)
		Me.Controls.Add(Me.BtnPrevious)
		Me.Controls.Add(Me.BtnClearGroupBoxes)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ClientsGridView)
		Me.Controls.Add(Me.PanelSearchBar)
		Me.Controls.Add(Me.PanelSidebar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "DashboardForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DashBoard"
		Me.PanelSidebar.ResumeLayout(False)
		Me.PanelWelcome.ResumeLayout(False)
		Me.PanelBanner.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelSearchBar.ResumeLayout(False)
		Me.PanelSearchBar.PerformLayout()
		CType(Me.ClientsGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanelSidebar As Panel
	Friend WithEvents PanelBanner As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PanelWelcome As Panel
	Friend WithEvents LblWelcome As Label
	Friend WithEvents BtnDeleteClient As Button
	Friend WithEvents BtnEditClient As Button
	Friend WithEvents BtnAddClient As Button
	Friend WithEvents PanelSearchBar As Panel
	Friend WithEvents TxtSearchBar As TextBox
	Friend WithEvents BtnExit As Button
	Friend WithEvents ClientsGridView As DataGridView
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents LblEmail As Label
	Friend WithEvents LblCellularNumber As Label
	Friend WithEvents LblZipcode As Label
	Friend WithEvents LblCity As Label
	Friend WithEvents LblMailingAddress As Label
	Friend WithEvents LblPhysicalAddress As Label
	Friend WithEvents LblBirthDate As Label
	Friend WithEvents LblFullName As Label
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents LblClientFee As Label
	Friend WithEvents LblCompanyCity As Label
	Friend WithEvents LblCompanyName As Label
	Friend WithEvents ClientId As DataGridViewTextBoxColumn
	Friend WithEvents FirstName As DataGridViewTextBoxColumn
	Friend WithEvents PaternalLastname As DataGridViewTextBoxColumn
	Friend WithEvents MaternalLastname As DataGridViewTextBoxColumn
	Friend WithEvents PhysicalAddress As DataGridViewTextBoxColumn
	Friend WithEvents MailingAddress As DataGridViewTextBoxColumn
	Friend WithEvents City As DataGridViewTextBoxColumn
	Friend WithEvents Zipcode As DataGridViewTextBoxColumn
	Friend WithEvents BirthDate As DataGridViewTextBoxColumn
	Friend WithEvents CellularNumber As DataGridViewTextBoxColumn
	Friend WithEvents Email As DataGridViewTextBoxColumn
	Friend WithEvents CompanyName As DataGridViewTextBoxColumn
	Friend WithEvents CompanyCity As DataGridViewTextBoxColumn
	Friend WithEvents ClientFee As DataGridViewTextBoxColumn
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents BtnMyAccount As Button
	Friend WithEvents BtnClearGroupBoxes As Button
	Friend WithEvents BtnPrevious As Button
	Friend WithEvents BtnNext As Button
	Friend WithEvents BtnRefresh As Button
End Class

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
		Me.PanelSidebar = New System.Windows.Forms.Panel()
		Me.BtnExit = New System.Windows.Forms.Button()
		Me.BtnDeleteClient = New System.Windows.Forms.Button()
		Me.BtnEditClient = New System.Windows.Forms.Button()
		Me.BtnAddClient = New System.Windows.Forms.Button()
		Me.PanelWelcome = New System.Windows.Forms.Panel()
		Me.LblWelcome = New System.Windows.Forms.Label()
		Me.PanelBanner = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PanelSearchBar = New System.Windows.Forms.Panel()
		Me.BtnSearch = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.DataGridViewClients = New System.Windows.Forms.DataGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.LblFullName = New System.Windows.Forms.Label()
		Me.PanelSidebar.SuspendLayout()
		Me.PanelWelcome.SuspendLayout()
		Me.PanelBanner.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelSearchBar.SuspendLayout()
		CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelSidebar
		'
		Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.PanelSidebar.Controls.Add(Me.BtnExit)
		Me.PanelSidebar.Controls.Add(Me.BtnDeleteClient)
		Me.PanelSidebar.Controls.Add(Me.BtnEditClient)
		Me.PanelSidebar.Controls.Add(Me.BtnAddClient)
		Me.PanelSidebar.Controls.Add(Me.PanelWelcome)
		Me.PanelSidebar.Controls.Add(Me.PanelBanner)
		Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
		Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
		Me.PanelSidebar.Name = "PanelSidebar"
		Me.PanelSidebar.Size = New System.Drawing.Size(352, 707)
		Me.PanelSidebar.TabIndex = 0
		'
		'BtnExit
		'
		Me.BtnExit.BackColor = System.Drawing.Color.Transparent
		Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.BtnExit.FlatAppearance.BorderSize = 0
		Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
		Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnExit.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnExit.ForeColor = System.Drawing.Color.White
		Me.BtnExit.Location = New System.Drawing.Point(0, 655)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(352, 52)
		Me.BtnExit.TabIndex = 5
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.UseVisualStyleBackColor = False
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
		Me.BtnDeleteClient.Size = New System.Drawing.Size(352, 46)
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
		Me.BtnEditClient.Size = New System.Drawing.Size(352, 46)
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
		Me.BtnAddClient.Size = New System.Drawing.Size(352, 46)
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
		Me.PanelWelcome.Size = New System.Drawing.Size(352, 108)
		Me.PanelWelcome.TabIndex = 1
		'
		'LblWelcome
		'
		Me.LblWelcome.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LblWelcome.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblWelcome.ForeColor = System.Drawing.Color.White
		Me.LblWelcome.Location = New System.Drawing.Point(0, 0)
		Me.LblWelcome.Name = "LblWelcome"
		Me.LblWelcome.Size = New System.Drawing.Size(352, 108)
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
		Me.PanelBanner.Size = New System.Drawing.Size(352, 73)
		Me.PanelBanner.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(352, 73)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'PanelSearchBar
		'
		Me.PanelSearchBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(96, Byte), Integer))
		Me.PanelSearchBar.Controls.Add(Me.BtnSearch)
		Me.PanelSearchBar.Controls.Add(Me.TextBox1)
		Me.PanelSearchBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelSearchBar.Location = New System.Drawing.Point(352, 0)
		Me.PanelSearchBar.Name = "PanelSearchBar"
		Me.PanelSearchBar.Size = New System.Drawing.Size(1140, 73)
		Me.PanelSearchBar.TabIndex = 3
		'
		'BtnSearch
		'
		Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BtnSearch.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnSearch.Location = New System.Drawing.Point(985, 12)
		Me.BtnSearch.Name = "BtnSearch"
		Me.BtnSearch.Size = New System.Drawing.Size(143, 41)
		Me.BtnSearch.TabIndex = 4
		Me.BtnSearch.Text = "Search"
		Me.BtnSearch.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(690, 19)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(289, 28)
		Me.TextBox1.TabIndex = 4
		'
		'DataGridViewClients
		'
		Me.DataGridViewClients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridViewClients.BackgroundColor = System.Drawing.Color.White
		Me.DataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridViewClients.Location = New System.Drawing.Point(365, 79)
		Me.DataGridViewClients.Name = "DataGridViewClients"
		Me.DataGridViewClients.RowHeadersWidth = 51
		Me.DataGridViewClients.RowTemplate.Height = 24
		Me.DataGridViewClients.Size = New System.Drawing.Size(1115, 319)
		Me.DataGridViewClients.TabIndex = 4
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.LblFullName)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(363, 404)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(524, 291)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Client Personal Info"
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(908, 404)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(571, 290)
		Me.GroupBox2.TabIndex = 6
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Client Compay Info"
		'
		'LblFullName
		'
		Me.LblFullName.AutoSize = True
		Me.LblFullName.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblFullName.Location = New System.Drawing.Point(3, 24)
		Me.LblFullName.Name = "LblFullName"
		Me.LblFullName.Size = New System.Drawing.Size(130, 21)
		Me.LblFullName.TabIndex = 0
		Me.LblFullName.Text = "LabelFullName"
		'
		'DashboardForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(1492, 707)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridViewClients)
		Me.Controls.Add(Me.PanelSearchBar)
		Me.Controls.Add(Me.PanelSidebar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "DashboardForm"
		Me.Text = "DashBoard"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.PanelSidebar.ResumeLayout(False)
		Me.PanelWelcome.ResumeLayout(False)
		Me.PanelBanner.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelSearchBar.ResumeLayout(False)
		Me.PanelSearchBar.PerformLayout()
		CType(Me.DataGridViewClients, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
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
	Friend WithEvents BtnExit As Button
	Friend WithEvents PanelSearchBar As Panel
	Friend WithEvents BtnSearch As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridViewClients As DataGridView
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents LblFullName As Label
End Class

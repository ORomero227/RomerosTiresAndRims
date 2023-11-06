<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtUsername = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtPassword = New System.Windows.Forms.TextBox()
		Me.BtnEnter = New System.Windows.Forms.Button()
		Me.CreateAccountLink = New System.Windows.Forms.LinkLabel()
		Me.AboutUsLink = New System.Windows.Forms.LinkLabel()
		Me.BtnClose = New System.Windows.Forms.Button()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.IsSplitterFixed = True
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
		Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1070, 553)
		Me.SplitContainer1.SplitterDistance = 520
		Me.SplitContainer1.TabIndex = 0
		'
		'PictureBox1
		'
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(520, 553)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.81736!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.18264!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(546, 553)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(540, 93)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Login"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.TxtUsername)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.TxtPassword)
		Me.FlowLayoutPanel1.Controls.Add(Me.BtnEnter)
		Me.FlowLayoutPanel1.Controls.Add(Me.CreateAccountLink)
		Me.FlowLayoutPanel1.Controls.Add(Me.AboutUsLink)
		Me.FlowLayoutPanel1.Controls.Add(Me.BtnClose)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 96)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(540, 454)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(3, 40)
		Me.Label2.Margin = New System.Windows.Forms.Padding(3, 40, 3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(537, 23)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Username"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'TxtUsername
		'
		Me.TxtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtUsername.BackColor = System.Drawing.Color.Black
		Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtUsername.ForeColor = System.Drawing.Color.White
		Me.TxtUsername.Location = New System.Drawing.Point(127, 66)
		Me.TxtUsername.Name = "TxtUsername"
		Me.TxtUsername.Size = New System.Drawing.Size(289, 30)
		Me.TxtUsername.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(3, 119)
		Me.Label3.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(537, 23)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Password"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'TxtPassword
		'
		Me.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtPassword.BackColor = System.Drawing.Color.Black
		Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtPassword.ForeColor = System.Drawing.Color.White
		Me.TxtPassword.Location = New System.Drawing.Point(127, 145)
		Me.TxtPassword.Name = "TxtPassword"
		Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TxtPassword.Size = New System.Drawing.Size(289, 30)
		Me.TxtPassword.TabIndex = 2
		'
		'BtnEnter
		'
		Me.BtnEnter.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.BtnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnEnter.Location = New System.Drawing.Point(205, 203)
		Me.BtnEnter.Margin = New System.Windows.Forms.Padding(3, 25, 3, 3)
		Me.BtnEnter.Name = "BtnEnter"
		Me.BtnEnter.Size = New System.Drawing.Size(132, 33)
		Me.BtnEnter.TabIndex = 3
		Me.BtnEnter.Text = "Enter"
		Me.BtnEnter.UseVisualStyleBackColor = True
		'
		'CreateAccountLink
		'
		Me.CreateAccountLink.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.CreateAccountLink.AutoSize = True
		Me.CreateAccountLink.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CreateAccountLink.LinkColor = System.Drawing.Color.Red
		Me.CreateAccountLink.Location = New System.Drawing.Point(205, 279)
		Me.CreateAccountLink.Margin = New System.Windows.Forms.Padding(3, 40, 3, 0)
		Me.CreateAccountLink.Name = "CreateAccountLink"
		Me.CreateAccountLink.Size = New System.Drawing.Size(132, 21)
		Me.CreateAccountLink.TabIndex = 4
		Me.CreateAccountLink.TabStop = True
		Me.CreateAccountLink.Text = "Create Account"
		Me.CreateAccountLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'AboutUsLink
		'
		Me.AboutUsLink.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.AboutUsLink.AutoSize = True
		Me.AboutUsLink.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AboutUsLink.LinkColor = System.Drawing.Color.Red
		Me.AboutUsLink.Location = New System.Drawing.Point(230, 320)
		Me.AboutUsLink.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
		Me.AboutUsLink.Name = "AboutUsLink"
		Me.AboutUsLink.Size = New System.Drawing.Size(83, 21)
		Me.AboutUsLink.TabIndex = 5
		Me.AboutUsLink.TabStop = True
		Me.AboutUsLink.Text = "About Us"
		Me.AboutUsLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'BtnClose
		'
		Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnClose.Location = New System.Drawing.Point(205, 366)
		Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 25, 3, 3)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(132, 33)
		Me.BtnClose.TabIndex = 6
		Me.BtnClose.Text = "Exit"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'LoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(1070, 553)
		Me.Controls.Add(Me.SplitContainer1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "LoginForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtUsername As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TxtPassword As TextBox
	Friend WithEvents BtnEnter As Button
	Friend WithEvents CreateAccountLink As LinkLabel
	Friend WithEvents AboutUsLink As LinkLabel
	Friend WithEvents BtnClose As Button
End Class

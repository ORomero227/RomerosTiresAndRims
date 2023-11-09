'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class DashboardForm

	'Campos
	Private _seller As Seller
	Private _loginForm As LoginForm
	Private _createClientForm As CreateClientForm
	Private _myDatabase As New MyDataBase()
	Private listOfClients As List(Of Client)

	Public Sub New(seller As Seller, loginForm As LoginForm)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_seller = seller
		_loginForm = loginForm
	End Sub

	Public Sub LoadClients()
		'DataGridViewClients.Rows.Clear()

		listOfClients = _myDatabase.GetSellerClients(_seller)

		DataGridViewClients.AutoGenerateColumns = True
		DataGridViewClients.DataSource = listOfClients
	End Sub


	Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_loginForm.Hide()

		Dim completeName As String = _seller.FirstName & " " & _seller.PaternalLastName & " " & _seller.MaternalLastName
		LblWelcome.Text = "Welcome" & vbNewLine & completeName

		LoadClients()
	End Sub


	Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
		Me.Close()

		_loginForm.Show()
	End Sub

	Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
		_createClientForm = New CreateClientForm(_seller, Me)

		_createClientForm.ShowDialog()
	End Sub




End Class

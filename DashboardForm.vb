'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class DashboardForm

	'Campos
	Private _seller As Seller
	Private _loginForm As LoginForm
	Private _createClientForm As AddClientForm
	Private _myDatabase As New MyDataBase()
	Private listOfClients As List(Of Client)

	'Constructor Recibe el vendedor y el form de login
	Public Sub New(seller As Seller, loginForm As LoginForm)
		' This call is required by the designer.
		InitializeComponent()

		_seller = seller
		_loginForm = loginForm
	End Sub

	'Carga el datagridview
	Public Sub LoadClients()
		'Obtiene los clientes del vendedor
		listOfClients = _myDatabase.GetSellerClients(_seller)

		DataGridViewClients.AutoGenerateColumns = True
		DataGridViewClients.DataSource = listOfClients
	End Sub

	'Cuando el form carga
	Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_loginForm.Hide() 'Se esconde el login form

		'Se llena el label de bienvenida con el nombre del vendedor
		Dim completeName As String = _seller.FirstName & " " & _seller.PaternalLastName & " " & _seller.MaternalLastName
		LblWelcome.Text = "Welcome" & vbNewLine & completeName

		LoadClients() 'Se cargan los clientes
	End Sub

	'Boton Para anadir el cliente
	Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
		_createClientForm = New AddClientForm(_seller, Me)
		_createClientForm.ShowDialog()
	End Sub

	'Boton para editar el cliente
	Private Sub BtnEditClient_Click(sender As Object, e As EventArgs) Handles BtnEditClient.Click
		listOfClients = _myDatabase.GetSellerClients(_seller)
		Dim _customListBox As New CustomComboBox(listOfClients, Me, "Update")
		_customListBox.ShowDialog()
	End Sub

	'Boton para salir
	Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
		Me.Close()
		_loginForm.Show()
	End Sub

	'Boton para eliminar el cliente
	Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click
		listOfClients = _myDatabase.GetSellerClients(_seller)
		Dim _customListBox As New CustomComboBox(listOfClients, Me, "Delete")
		_customListBox.ShowDialog()
	End Sub
End Class

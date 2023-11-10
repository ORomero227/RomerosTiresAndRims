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
		DataGridViewClients.Rows.Clear()
		ClearGroupBoxInfo()

		'Obtiene los clientes del vendedor
		listOfClients = _myDatabase.GetSellerClients(_seller)

		For Each client As Client In listOfClients

			DataGridViewClients.Rows.Add(client.ClientId, client.FirstName, client.PaternalLastName, client.MaternalLastName,
										 client.PhysicalAddress, client.MailingAddress, client.City, client.ZipCode,
										 client.BirthDate.ToString("dd/MM/yyyy"), client.CellularNumber, client.Email,
										 client.CompanyName, client.CompanyCity, client.ClientFee.ToString("c2"))
		Next
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

	'Barra de busqueda
	Private Sub TxtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchBar.TextChanged
		DataGridViewClients.Rows.Clear() 'Vacio el datagrid

		'Obtengo los clientes que coincidan con el searchbar
		listOfClients = _myDatabase.SearchClient(TxtSearchBar.Text)

		'Si no coincide vacio el datagrid y cargo todos los clientes del vendedor
		If listOfClients.Count = 0 Then
			DataGridViewClients.Rows.Clear()
			listOfClients = _myDatabase.GetSellerClients(_seller)
		End If

		For Each client As Client In listOfClients
			DataGridViewClients.Rows.Add(
					client.ClientId, client.FirstName, client.PaternalLastName,
					client.MaternalLastName, client.PhysicalAddress,
					client.MailingAddress, client.City, client.ZipCode,
					client.BirthDate.ToString("dd/MM/yyyy"), client.CellularNumber, client.Email,
					client.CompanyName, client.CompanyCity, client.ClientFee.ToString("c2"))
		Next
	End Sub

	'Desactivar con un click en el mainform componentes activos 
	Private Sub DashboardForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
		Me.ActiveControl = Nothing
	End Sub

	'LLenar los group box de informacion
	Private Sub DataGridViewClients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClients.CellClick

		'Se verifica si la fila seleccionada existe
		If e.RowIndex >= 0 Then

			'Se obtiene la fila
			Dim selectedRow As DataGridViewRow = DataGridViewClients.Rows(e.RowIndex)

			'Se asignan los valores de las columnas a las variabless
			Dim fullName As String = $"{selectedRow.Cells("FirstName").Value.ToString()} {selectedRow.Cells("PaternalLastName").Value.ToString()} {selectedRow.Cells("MaternalLastname").Value.ToString()}"
			Dim phyAddress As String = selectedRow.Cells("PhysicalAddress").Value.ToString()
			Dim mailingAddress As String = selectedRow.Cells("MailingAddress").Value.ToString()
			Dim city As String = selectedRow.Cells("City").Value.ToString()
			Dim zipCode As String = selectedRow.Cells("Zipcode").Value.ToString()
			Dim birth As String = selectedRow.Cells("BirthDate").Value.ToString()
			Dim cellNum As String = selectedRow.Cells("CellularNumber").Value.ToString()
			Dim email As String = selectedRow.Cells("Email").Value.ToString()
			Dim companyName As String = selectedRow.Cells("CompanyName").Value.ToString()
			Dim companyCity As String = selectedRow.Cells("CompanyCity").Value.ToString()
			Dim clientFee As Double = CDbl(selectedRow.Cells("ClientFee").Value)

			'GroupBox de client info
			LblFullName.Text = fullName
			LblPhysicalAddress.Text = phyAddress
			LblMailingAddress.Text = mailingAddress
			LblCity.Text = city
			LblZipcode.Text = zipCode
			LblBirthDate.Text = birth
			LblCellularNumber.Text = cellNum
			LblEmail.Text = email

			'GroupBox de client company info
			LblCompanyName.Text = companyName
			LblCompanyCity.Text = companyCity
			LblClientFee.Text = clientFee.ToString("c2")
		End If
	End Sub

	'Vacia los labels de los groupbox
	Public Sub ClearGroupBoxInfo()
		'GroupBox de client info
		LblFullName.Text = ""
		LblPhysicalAddress.Text = ""
		LblMailingAddress.Text = ""
		LblCity.Text = ""
		LblZipcode.Text = ""
		LblBirthDate.Text = ""
		LblCellularNumber.Text = ""
		LblEmail.Text = ""

		'GroupBox de client company info
		LblCompanyName.Text = ""
		LblCompanyCity.Text = ""
		LblClientFee.Text = "$"
	End Sub


End Class

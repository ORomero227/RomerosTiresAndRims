'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims
Public Class EditClientForm

	Private _myDataBase As New MyDataBase()
	Private _dashboard As DashboardForm
	Private _customComboBoxForm As CustomComboBox
	Private _client As Client

	Public Sub New(client As Client, customCmBox As CustomComboBox, dashboard As DashboardForm)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_client = client
		_customComboBoxForm = customCmBox
		_dashboard = dashboard
	End Sub

	'Funciones
	'Funcion para vaciar los textbox
	Public Sub ClearAllTextBoxes()
		TxtFirstname.Clear()
		TxtPaternalLastname.Clear()
		TxtMaternalLastname.Clear()
		TxtPhysicalAddress.Clear()
		TxtMailingAddress.Clear()
		TxtCity.Clear()
		TxtZipCode.Clear()
		TxtCompanyCity.Clear()
		TxtCompanyName.Clear()
		TxtEmail.Clear()
		TxtClientFee.Clear()
		MTxtCellularNumber.Clear()
		BirthDatePicker.Value = Date.Now
	End Sub

	'Funcion para validar los inputs
	Public Function InputsAreInvalid() As Boolean
		Dim validation As New MyValidations()

		'Array que contiene todos los textbox del form
		Dim textboxes() As TextBox = {TxtFirstname, TxtPaternalLastname, TxtMaternalLastname,
									  TxtPhysicalAddress, TxtMailingAddress, TxtCity, TxtZipCode,
									  TxtEmail, TxtClientFee, TxtCompanyName, TxtCompanyCity}
		'Validacion de los textbox
		If validation.AreTextBoxesInvalid(textboxes) Then
			MessageBox.Show("Please, enter all the fields")
			Return True
		End If

		'Validacion si el client fee es un numero valido
		If Not validation.IsADecimalNumber(TxtClientFee) Then
			MessageBox.Show("Please, enter a valid fee")
			Return True
		End If

		Dim maskedTextBox As MaskedTextBox = MTxtCellularNumber
		'Validacion del cellular number
		If validation.IsCellularNumberInvalid(MTxtCellularNumber) Then
			MessageBox.Show("Fill or Verify the cellular phone number.")
			Return True
		End If

		Return False
	End Function

	'Se llena los textbox con la info del cliente
	Private Sub EditClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		_customComboBoxForm.Close()

		TxtFirstname.Text = _client.FirstName
		TxtPaternalLastname.Text = _client.PaternalLastName
		TxtMaternalLastname.Text = _client.MaternalLastName
		TxtPhysicalAddress.Text = _client.PhysicalAddress
		TxtMailingAddress.Text = _client.MailingAddress
		TxtCity.Text = _client.City
		TxtZipCode.Text = _client.ZipCode
		MTxtCellularNumber.Text = _client.CellularNumber
		TxtEmail.Text = _client.Email
		TxtCompanyName.Text = _client.CompanyName
		TxtCompanyCity.Text = _client.CompanyCity
		BirthDatePicker.Text = _client.BirthDate
		TxtClientFee.Text = _client.ClientFee
	End Sub

	'Boton de actualizar
	Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
		Dim areInputsInvalid As Boolean

		areInputsInvalid = InputsAreInvalid()

		'Si los controles no son invalidos
		If Not areInputsInvalid Then
			'Se actualizan los campos del cliente
			_client.FirstName = TxtFirstname.Text
			_client.PaternalLastName = TxtPaternalLastname.Text
			_client.MaternalLastName = TxtMaternalLastname.Text
			_client.PhysicalAddress = TxtPhysicalAddress.Text
			_client.MailingAddress = TxtMailingAddress.Text
			_client.City = TxtCity.Text
			_client.ZipCode = TxtZipCode.Text
			_client.CellularNumber = MTxtCellularNumber.Text
			_client.Email = TxtEmail.Text
			_client.CompanyName = TxtCompanyName.Text
			_client.CompanyCity = TxtCompanyCity.Text
			_client.BirthDate = BirthDatePicker.Text
			_client.ClientFee = TxtClientFee.Text

			Dim isClientInfoUpdated As Boolean = _myDataBase.UpdateClientInfo(_client) 'Actualiza en la base de datos

			If isClientInfoUpdated Then
				MessageBox.Show("Client Info Updated!")
				ClearAllTextBoxes()
				_dashboard.LoadClients()
				Me.Close()
			Else
				MessageBox.Show("An error occurred while trying to update the client info")
			End If
		End If
	End Sub

	'Boton de Salir
	Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
		ClearAllTextBoxes() 'Se vacian los textbox
	End Sub

	'Boton de cerrar el form
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		ClearAllTextBoxes() 'Se vacian los textbox
		Me.Close()
	End Sub
End Class
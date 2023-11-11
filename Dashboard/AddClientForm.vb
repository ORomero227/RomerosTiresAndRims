'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class AddClientForm
	'Campos
	Private _myDataBase As New MyDataBase()
	Private _dashboard As DashboardForm
	Private _seller As Seller
	Private _client As Client

	'Constructor
	Public Sub New(seller As Seller, dashBoard As DashboardForm)
		InitializeComponent()

		'Se inicialisa la base de datos
		_seller = seller
		_dashboard = dashBoard
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

	'Boton de crear
	Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
		'Guarda el resultado de la validacion
		Dim areInputsInvalid As Boolean

		areInputsInvalid = InputsAreInvalid()

		'Si los controles no son invalidos
		If Not areInputsInvalid Then
			'Inicializo el objeto seller
			_client = New Client With
			{
				.FirstName = TxtFirstname.Text,
				.PaternalLastName = TxtPaternalLastname.Text,
				.MaternalLastName = TxtMaternalLastname.Text,
				.PhysicalAddress = TxtPhysicalAddress.Text,
				.MailingAddress = TxtMailingAddress.Text,
				.City = TxtCity.Text,
				.ZipCode = TxtZipCode.Text,
				.BirthDate = BirthDatePicker.Text,
				.CellularNumber = MTxtCellularNumber.Text,
				.Email = TxtEmail.Text,
				.CompanyName = TxtCompanyName.Text,
				.CompanyCity = TxtCompanyCity.Text,
				.ClientFee = CDec(TxtClientFee.Text),
				.SellerId = _seller.SellerId
			}

			'Intenta crear la cuenta
			Dim isAccountCreated As Boolean = _myDataBase.CreateClientAccount(_client, _seller.SellerId)

			If isAccountCreated Then
				MessageBox.Show("Client Added Successfully!")
				ClearAllTextBoxes() 'Se vacian los textbox
				_dashboard.LoadClients() 'Se cargan los clientes 
				Me.Close()
			End If
		End If
	End Sub

	'Boton de reiniciar los textbox
	Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
		ClearAllTextBoxes() 'Se vacian los textbox
	End Sub

	'Boton de cerrar el form
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		ClearAllTextBoxes() 'Se vacian los textbox
		Me.Close()
	End Sub
End Class
'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class CreateSellerAccountForm

	'Campos
	Private _myDataBase As MyDataBase
	Private _seller As Seller

	'Constructor
	Public Sub New(dbContext As MyDataBase)
		InitializeComponent()

		'Se inicialisa la base de datos
		_myDataBase = dbContext
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
		TxtEmail.Clear()
		MTxtCellularNumber.Clear()
		CmbBoxDepartment.Text = "Select Department:"
		CmbBoxSpecialization.Text = "Select Specialization:"
		HiringDatePicker.Value = Date.Now
		TxtUsername.Clear()
		TxtPassword.Clear()
	End Sub

	'Funcion para validar los inputs
	Public Function InputsAreInvalid() As Boolean
		Dim validation As New MyValidations()

		'Array que contiene todos los textbox del form
		Dim textboxes() As TextBox = {TxtFirstname, TxtPaternalLastname, TxtMaternalLastname,
									  TxtPhysicalAddress, TxtMailingAddress, TxtCity, TxtZipCode,
									  TxtEmail, TxtUsername, TxtPassword}
		'Validacion de los textbox
		If validation.AreTextBoxesInvalid(textboxes) Then
			MessageBox.Show("Please, enter all the fields")
			Return True
		End If

		'Array que contiene todos los combobox
		Dim comboboxes() As ComboBox = {CmbBoxDepartment, CmbBoxSpecialization}
		'Validacion de los comboboxes
		If validation.CheckComboBoxSelection(comboboxes) Then
			MessageBox.Show("Verify the department or specialization field.")
			Return True
		End If

		'Validacion del email
		If validation.IsEmailInvalid(TxtEmail) Then
			MessageBox.Show("Please, enter a valid email")
			Return True
		ElseIf _myDataBase.ListOfEmails.Contains(TxtEmail.Text) Then 'Verificar si ya el email esta en uso
			MessageBox.Show("Email already in use. Please use a different email.")
			Return True
		End If

		Dim maskedTextBox As MaskedTextBox = MTxtCellularNumber
		'Validacion del cellular number
		If validation.IsCellularNumberInvalid(MTxtCellularNumber) Then
			MessageBox.Show("Fill or Verify the cellular phone number.")
			Return True
		End If

		'Validacion del username
		If _myDataBase.ListOfUsernames.Contains(TxtUsername.Text) Then
			MessageBox.Show("Username already in use. Please use a different username.")
			Return True
		End If

		Return False
	End Function

	'Boton de crear
	Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
		'Guarda el resultado de la validacion
		Dim areInputsInvalid As Boolean

		areInputsInvalid = InputsAreInvalid()

		'Si los controles no son invalidos
		If Not areInputsInvalid Then
			'Inicializo el objeto seller
			_seller = New Seller With
			{
				.FirstName = TxtFirstname.Text,
				.PaternalLastName = TxtPaternalLastname.Text,
				.MaternalLastName = TxtMaternalLastname.Text,
				.PhysicalAddress = TxtPhysicalAddress.Text,
				.MailingAddress = TxtMailingAddress.Text,
				.City = TxtCity.Text,
				.ZipCode = TxtZipCode.Text,
				.CellularNumber = MTxtCellularNumber.Text,
				.Email = TxtEmail.Text,
				.Department = CmbBoxDepartment.Text,
				.Specialization = CmbBoxSpecialization.Text,
				.HiringDate = HiringDatePicker.Value,
				.UserName = TxtUsername.Text,
				.Password = TxtPassword.Text
			}

			'Intenta crear la cuenta
			Dim isAccountCreated As Boolean = _myDataBase.CreateSellerAccount(_seller)

			If isAccountCreated Then
				MessageBox.Show("Account Created!")
				ClearAllTextBoxes() 'Se vacian los textbox
				Me.Close()
			End If
		End If
	End Sub

	'Boton de reiniciar los textbox
	Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
		ClearAllTextBoxes() 'Se vacian los textbox
	End Sub

	'Boton de cerrar el form
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		ClearAllTextBoxes() 'Se vacian los textbox
		Me.Close()
	End Sub
End Class
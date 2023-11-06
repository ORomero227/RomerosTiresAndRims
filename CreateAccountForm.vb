Public Class CreateAccountForm

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

	'Funcion para validar los textbox 
	Public Function ValidateInputs(textBoxes As TextBox(), comboBoxes As ComboBox(), maskedTextbox As MaskedTextBox) As Boolean

		'Recorro el array que tiene los textBoxes
		For Each box In textBoxes
			If String.IsNullOrEmpty(box.Text.Trim()) Then
				MessageBox.Show("Please, enter all the fields")
				Return True
				Exit For
			End If

			If box.Name = "TxtEmail" And Not box.Text.Contains("@") Then
				MessageBox.Show("Please, enter a valid email")
				Return True
				Exit For
			End If
		Next

		'Recorro el array que tiene los comboBoxes
		For Each combox In comboBoxes
			'Variable para ver si hay un item seleccionado
			Dim isItemSelected As Boolean = False
			'Recorro la lista de items del combobox
			For Each item As Object In combox.Items
				'Si el text es igual al de un item
				If combox.Text = combox.GetItemText(item) Then
					isItemSelected = True
					Exit For
				End If
			Next

			'Si no item seleccionado se marca como un error
			If Not isItemSelected Then
				MessageBox.Show("Verify the department or specialization field")
				Return True
			End If
		Next

		'Validacion del maskedTextBox
		If Not maskedTextbox.MaskCompleted Then
			MessageBox.Show("Fill or Verify the cellular phone number")
			Return True
		End If

		Return False
	End Function


	'Eventos de los botones
	'Boton de crear
	Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

		'Guarda resultado de la validacion
		Dim areFieldInvalids As Boolean

		'Array que contiene todos los textbox del form
		Dim textboxes() As TextBox =
		{
			TxtFirstname, TxtPaternalLastname, TxtMaternalLastname,
			TxtPhysicalAddress, TxtMailingAddress, TxtCity, TxtZipCode,
			TxtEmail, TxtUsername, TxtPassword
		}

		'Array que contiene todos los combobox
		Dim comboboxes() As ComboBox = {CmbBoxDepartment, CmbBoxSpecialization}

		'Se guarda el resultado de la validacion
		areFieldInvalids = ValidateInputs(textboxes, comboboxes, MTxtCellularNumber)

		If areFieldInvalids = False Then
			MessageBox.Show("Account Created")
		End If

	End Sub

	'Boton de reiniciar los textbox
	Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
		ClearAllTextBoxes()
	End Sub

	'Boton de cerrar el form
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

		'Si los textbox tienen datos se borran
		ClearAllTextBoxes()

		Me.Close()
	End Sub

End Class
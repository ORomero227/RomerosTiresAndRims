'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class MyValidations

	'Validacion para verificar los textbox
	Public Function AreTextBoxesInvalid(ParamArray textBoxes As TextBox()) As Boolean
		'Recorre todos los textbox del array
		For Each box In textBoxes

			'Validacion si estan vacios
			If String.IsNullOrEmpty(box.Text.Trim()) Then
				Return True 'Devuelve cierto si hay uno vacio
				Exit For
			End If
		Next

		Return False
	End Function

	'Validacion para verificar el email
	Public Function IsEmailInvalid(emailTextBox As TextBox) As Boolean
		'Si el textbox no contiene @ es invalido
		If Not emailTextBox.Text.Contains("@") Then
			Return True
		End If

		Return False
	End Function

	'Validacion para verificar los combo box
	Public Function CheckComboBoxSelection(ParamArray comboBoxes As ComboBox()) As Boolean
		'Recorre el array que tiene los comboBoxes
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

			'Si no hay un item seleccionado se marca como un error
			If Not isItemSelected Then
				Return True
			End If
		Next

		Return False
	End Function

	'Validacion para verificar el numero de celular
	Public Function IsCellularNumberInvalid(cellularNumMaskedText As MaskedTextBox) As Boolean
		'Si la mascara del textbox no esta completada se asume que esta vacio
		If Not cellularNumMaskedText.MaskCompleted Then
			Return True
		End If

		Return False
	End Function

End Class

'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class LoginForm
	'Campos
	Private _myDatabase As New MyDataBase()
	Private _createAccountForm As CreateSellerAccountForm
	Private _dashBoard As DashboardForm

	'Eventos de botones
	'Boton de iniciar sesion
	Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
		Dim userName As String = TxtUsername.Text.Trim()
		Dim password As String = TxtPassword.Text.Trim()

		'Validacion si estan vacios los campos
		If String.IsNullOrEmpty(userName) Or String.IsNullOrEmpty(password) Then
			MessageBox.Show("Please enter both, username and password")
		End If

		Try
			'Verificar si el vendedor existe
			Dim seller As Seller = _myDatabase.GetSellerByUsername(userName)

			If seller IsNot Nothing AndAlso _myDatabase.ValidatePassword(userName, password) Then
				_dashBoard = New DashboardForm(seller, Me)
				TxtPassword.Clear()
				TxtUsername.Clear()
				_dashBoard.Show()
			Else
				MessageBox.Show("Invalid username or password")
			End If
		Catch ex As Exception
			MessageBox.Show("An error occurred while trying to log in")
		End Try
	End Sub

	'Enlace para crear cuenta
	Private Sub CreateAccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccountLink.LinkClicked
		_createAccountForm = New CreateSellerAccountForm(_myDatabase)

		_createAccountForm.ShowDialog()
	End Sub

	'Enlace para ver el form del about
	Private Sub AboutUsLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutUsLink.LinkClicked
		AboutForm.ShowDialog()
	End Sub

	'Boton para salir
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		Me.Close()
	End Sub

	'Enlace para cambiar el password
	Private Sub ResetPasswordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ResetPasswordLink.LinkClicked
		Dim userName As String
		Dim newPassword As String = ""
		Dim validNewPassword As Boolean
		Dim seller As Seller

		'Se obtiene el username
		userName = InputBox("Enter your username:", "Reset Password")

		If Not String.IsNullOrEmpty(userName.Trim()) Then

			Try
				'Se busca el vendedor
				seller = _myDatabase.GetSellerByUsername(userName)

				'Si se encuentra
				If seller IsNot Nothing Then

					'Validacion del input del new password
					Do Until validNewPassword = True
						'Se obtiene el newPassword
						newPassword = InputBox("Enter the new password:", "Reset Password")
						If String.IsNullOrEmpty(newPassword.Trim()) Then
							MessageBox.Show("Please enter the new password")
						Else
							validNewPassword = True
						End If
					Loop

					'Se verifica si se cambio correctamente
					Dim passwordChanged As Boolean = _myDatabase.ChangePassword(seller, newPassword)
					If passwordChanged Then
						MessageBox.Show("Password Changed Successfully")
					Else
						MessageBox.Show("Error occurred while trying change your password, try again")
					End If
				Else
					MessageBox.Show("Invalid username, try again")
				End If
			Catch ex As Exception
				MessageBox.Show("An error occurred while trying to find your account")
			End Try

		End If

	End Sub



End Class


Public Class LoginForm

	'Campos
	Private _dbContext As New MyDataBase()
	Private _createAccountForm As CreateAccountForm

	'Funciones
	Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	'Eventos de botones
	'Boton de iniciar sesion
	Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click

	End Sub

	'Enlace para crear cuenta
	Private Sub CreateAccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateAccountLink.LinkClicked
		_createAccountForm = New CreateAccountForm(_dbContext)

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
End Class
'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Public Class DashboardForm

	Private _seller As Seller
	Private _loginForm As LoginForm

	Public Sub New(seller As Seller, loginForm As LoginForm)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_seller = seller
		_loginForm = loginForm
	End Sub

	Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim completeName As String = _seller.FirstName & " " & _seller.PaternalLastName & " " & _seller.MaternalLastName

		LblWelcome.Text = "Welcome" & vbNewLine & completeName

		_loginForm.Hide()
	End Sub


	Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
		Me.Close()

		_loginForm.Show()
	End Sub
End Class

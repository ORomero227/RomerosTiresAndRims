'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims
Public Class CustomComboBox

	'Campos
	Dim _listOfClients As List(Of Client)
	Dim _myDatabase As New MyDataBase()
	Dim _dashBoard As DashboardForm
	Dim _customType As String

	'Constructor Recibe el dashboard actual, lista de clientes
	Public Sub New(listOfClients As List(Of Client), dashboard As DashboardForm, type As String)
		' This call is required by the designer.
		InitializeComponent()

		_listOfClients = listOfClients
		_dashBoard = dashboard
		_customType = type
	End Sub

	'Se cargan los clientes al combobox
	Private Sub CustomListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CmbBoxClients.DataSource = _listOfClients
		CmbBoxClients.DisplayMember = "FullName"
		CmbBoxClients.ValueMember = "ClientId"
	End Sub

	'Boton para tomar la decision
	Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
		'Obtengo el cliente
		Dim client As Client = _myDatabase.GetClientById(CmbBoxClients.SelectedValue.ToString())

		If _customType = "Update" Then
			If client IsNot Nothing Then
				Dim editClientForm As New EditClientForm(client, Me, _dashBoard)
				editClientForm.ShowDialog()
			End If
		ElseIf _customType = "Delete" Then

			If MsgBox("Are you sure delete this client", MsgBoxStyle.Question + vbYesNo) = vbYes Then
				Dim isDeleteComplete As Boolean = _myDatabase.DeleteClient(client.ClientId.ToString())
				If isDeleteComplete Then
					MessageBox.Show("Client was deleted successfully")
					_dashBoard.LoadClients()
					Me.Close()
				Else
					MessageBox.Show("An error occurred while trying to delete the client")
				End If
			End If
		Else
			MessageBox.Show("An error ocurred")
		End If
	End Sub
End Class
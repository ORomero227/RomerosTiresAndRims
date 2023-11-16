'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Imports ClosedXML.Excel

Public Class DashboardForm

	'Campos
	Private _seller As Seller
	Private _loginForm As LoginForm
	Private _createClientForm As AddClientForm
	Private _myDatabase As New MyDataBase()
	Private listOfClients As List(Of Client)
	Private _currentRowIndex As Integer = 0
	Private dataTable As New DataTable()

	'Constructor Recibe el vendedor y el form de login
	Public Sub New(seller As Seller, loginForm As LoginForm)
		' This call is required by the designer.
		InitializeComponent()

		_seller = seller
		_loginForm = loginForm
	End Sub

	'Carga el datagridview
	Public Sub LoadClients()
		' Limpiar las filas del DataTable
		dataTable.Rows.Clear()

		'Vacio los labels de los groupbox
		LblFullName.Text = ""
		LblPhysicalAddress.Text = ""
		LblMailingAddress.Text = ""
		LblCity.Text = ""
		LblZipcode.Text = ""
		LblBirthDate.Text = ""
		LblCellularNumber.Text = ""
		LblEmail.Text = ""
		LblCompanyName.Text = ""
		LblCompanyCity.Text = ""
		LblClientFee.Text = "$"

		'Obtiene los clientes del vendedor
		listOfClients = _myDatabase.GetSellerClients(_seller)

		'Agregar las columnas al datatable
		If dataTable.Columns.Count = 0 Then
			dataTable.Columns.Add("Client Id")
			dataTable.Columns.Add("Firstname")
			dataTable.Columns.Add("Paternal	Lastname")
			dataTable.Columns.Add("Maternal Lastname")
			dataTable.Columns.Add("Physical Address")
			dataTable.Columns.Add("Mailing Address")
			dataTable.Columns.Add("City")
			dataTable.Columns.Add("Zipcode")
			dataTable.Columns.Add("Birth Date")
			dataTable.Columns.Add("Cellular Number")
			dataTable.Columns.Add("Email")
			dataTable.Columns.Add("Company Name")
			dataTable.Columns.Add("Company City")
			dataTable.Columns.Add("Client Fee")
		End If

		'Se llena la tabla
		For Each client As Client In listOfClients

			dataTable.Rows.Add(client.ClientId, client.FirstName, client.PaternalLastName, client.MaternalLastName,
										 client.PhysicalAddress, client.MailingAddress, client.City, client.ZipCode,
										 client.BirthDate.ToString("dd/MM/yyyy"), client.CellularNumber, client.Email,
										 client.CompanyName, client.CompanyCity, client.ClientFee.ToString("c2"))
		Next

		'Asigno el datatable al datagrid
		ClientsGridView.DataSource = dataTable
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
		dataTable.Rows.Clear() 'Vacio el datatable

		'Obtengo los clientes que coincidan con el searchbar
		listOfClients = _myDatabase.SearchClient(TxtSearchBar.Text, _seller.SellerId)

		'Si no coincide vacio el datagrid y cargo todos los clientes del vendedor
		If listOfClients.Count = 0 Then
			dataTable.Rows.Clear()
			listOfClients = _myDatabase.GetSellerClients(_seller)
		End If

		'LLeno las filas con los valores del cliente
		For Each client As Client In listOfClients
			dataTable.Rows.Add(
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

	'Obtener la fila actual
	Public Sub ShowCurrentRow(selectedRow As DataGridViewRow)

		'Verifica que haya por lo menos una fila
		If ClientsGridView.Rows.Count > 0 Then
			'Validacion de que la fila este dentro de los limites
			If _currentRowIndex < 0 Then
				_currentRowIndex = 0
			ElseIf _currentRowIndex >= ClientsGridView.Rows.Count Then
				_currentRowIndex = ClientsGridView.Rows.Count - 1
			End If

			'Establece la fila actual como la visible
			ClientsGridView.FirstDisplayedScrollingRowIndex = _currentRowIndex

			'Selecciona la actual y quita de seleccionar las otras
			ClientsGridView.ClearSelection()
			ClientsGridView.Rows(_currentRowIndex).Selected = True

			'Se asignan los valores de las columnas a las variabless
			Dim fullName As String = $"{selectedRow.Cells(1).Value.ToString()} {selectedRow.Cells(2).Value.ToString()} {selectedRow.Cells(3).Value.ToString()}"
			Dim phyAddress As String = selectedRow.Cells("Physical Address").Value.ToString()
			Dim mailingAddress As String = selectedRow.Cells("Mailing Address").Value.ToString()
			Dim city As String = selectedRow.Cells("City").Value.ToString()
			Dim zipCode As String = selectedRow.Cells("Zipcode").Value.ToString()
			Dim birth As String = selectedRow.Cells("Birth Date").Value.ToString()
			Dim cellNum As String = selectedRow.Cells("Cellular Number").Value.ToString()
			Dim email As String = selectedRow.Cells("Email").Value.ToString()
			Dim companyName As String = selectedRow.Cells("Company Name").Value.ToString()
			Dim companyCity As String = selectedRow.Cells("Company City").Value.ToString()
			Dim clientFee As Double = CDbl(selectedRow.Cells("Client Fee").Value)

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

	'Boton clear para borrar los groupbox y el searchbar si esta lleno
	Private Sub BtnClearGroupBoxes_Click(sender As Object, e As EventArgs) Handles BtnClearGroupBoxes.Click
		TxtSearchBar.Clear()

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

	'Boton para regresar la seleccion de la fila en la tabla
	Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
		If _currentRowIndex > 0 Then
			_currentRowIndex -= 1
		End If

		If ClientsGridView.RowCount > 0 Then
			Dim updateRow As DataGridViewRow = ClientsGridView.Rows(_currentRowIndex)

			ShowCurrentRow(updateRow)
		Else
			MessageBox.Show("No clients to view")
		End If
	End Sub

	'Boton para siguiente selecciion de la fila en la tabla
	Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
		If _currentRowIndex < ClientsGridView.Rows.Count - 1 Then
			_currentRowIndex += 1
		End If

		If ClientsGridView.RowCount > 0 Then
			Dim updateRow As DataGridViewRow = ClientsGridView.Rows(_currentRowIndex)

			ShowCurrentRow(updateRow)
		Else
			MessageBox.Show("No clients to view")
		End If
	End Sub

	'Cuando se selecciona una celda por medio de un click
	Private Sub ClientsGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientsGridView.CellClick
		If e.RowIndex >= 0 AndAlso e.RowIndex < ClientsGridView.Rows.Count Then

			_currentRowIndex = e.RowIndex

			Dim selectedRow As DataGridViewRow = ClientsGridView.Rows(e.RowIndex)

			ShowCurrentRow(selectedRow)
		End If
	End Sub

	'Boton para actualizar los groupbox
	Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click

		If ClientsGridView.RowCount > 0 Then
			Dim refreshCurrentRow As DataGridViewRow = ClientsGridView.Rows(_currentRowIndex)
			ShowCurrentRow(refreshCurrentRow)
		Else
			MessageBox.Show("No clients to view")
		End If
	End Sub

	'Boton para exportar a un archivo excel
	Private Sub Btn_ExportExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportExcel.Click
		'Creo un save dialog que guarde documentos xlsx
		Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
			'Muestro el save dialog
			If sfd.ShowDialog() = DialogResult.OK Then
				Try
					'Inicializo un libro de trabajo de Excel
					Using workbook As XLWorkbook = New XLWorkbook()

						'Una tabla temporar que se encarga de guardar los valores del datagrid
						Dim datatable As New DataTable()

						'Paso todas las columnas del data grid al datatable
						For Each col As DataGridViewColumn In ClientsGridView.Columns
							datatable.Columns.Add(col.Name)
						Next

						'Paso todas las filas al datatable
						For Each row As DataGridViewRow In ClientsGridView.Rows
							Dim dataRow As DataRow = datatable.NewRow()
							For Each column As DataGridViewColumn In ClientsGridView.Columns
								dataRow(column.Name) = row.Cells(column.Index).Value
							Next
							datatable.Rows.Add(dataRow)
						Next

						' Agregar el DataTable al libro de trabajo
						Dim worksheet = workbook.Worksheets.Add(datatable, "Clients")

						'Ajusto el ancho de la columna en excel
						worksheet.Columns().AdjustToContents()

						' Guardar el archivo Excel
						workbook.SaveAs(sfd.FileName)

						MessageBox.Show("Successful export to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

					End Using
				Catch ex As Exception
					MessageBox.Show("An error occurred while exporting to Excel:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End If
		End Using
	End Sub
End Class

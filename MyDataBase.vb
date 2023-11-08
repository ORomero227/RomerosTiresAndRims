'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims

Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Security

Public Class MyDataBase
	'Campos
	Private ReadOnly _connectionString As String = "Data Source=OSCARLAPTOP\SQLOSCAR1;Initial Catalog=RomerosTiresAndRimsDB;User Id=sa; Password=oscarpr12"

	Private _seller As Seller

	'Obtiene los emails que ya han sido registrados
	Public ReadOnly Property ListOfEmails As List(Of String)
		Get
			Dim emails As New List(Of String)
			Dim query As String = "SELECT Email FROM tblSellers"

			Using _myConnection As New SqlConnection(_connectionString)

				_myConnection.Open() 'Se abre la conexion

				Try
					'Commando para obtener los emails de la tabla sellers
					Using command As New SqlCommand(query, _myConnection)

						Dim reader As SqlDataReader = command.ExecuteReader()

						'Mientras lee guarda en la lista
						While reader.Read()
							emails.Add(reader("Email").ToString())
						End While

					End Using
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End Using

			Return emails 'Lista con todos los emails
		End Get
	End Property

	'Obtiene los usernames que ya han sido registrados
	Public ReadOnly Property ListOfUsernames As List(Of String)
		Get
			Dim usernames As New List(Of String)
			Dim query As String = "SELECT Username FROM tblSellers"

			Using _myConnection As New SqlConnection(_connectionString)

				_myConnection.Open() 'Se abre la conexion

				Try
					'Commando para obtener los emails de la tabla sellers
					Using command As New SqlCommand(query, _myConnection)

						'Comienza el reader
						Dim reader As SqlDataReader = command.ExecuteReader()

						'Mientras lee guarda en la lista
						While reader.Read()
							usernames.Add(reader("Username").ToString())
						End While
					End Using
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End Using

			Return usernames 'Lista con todos los usernames
		End Get
	End Property

	'Verifica las credenciales
	Public Function ValidatePassword(userName As String, password As String) As Boolean
		Dim query As String = "SELECT Password FROM tblSellers WHERE tblSellers.Username = @Username"

		Using _myConnection As New SqlConnection(_connectionString)

			_myConnection.Open()

			Try
				Using command As New SqlCommand(query, _myConnection)

					command.Parameters.AddWithValue("@Username", userName)

					Dim reader As SqlDataReader = command.ExecuteReader()

					If reader.Read() Then

						Dim storedPassword As String = reader("Password").ToString()

						If storedPassword = password Then
							Return True 'Si el password coincide
						End If

					End If
				End Using
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End Using

		Return False
	End Function

	'Crear cuenta del vendedor
	Public Function CreateSellerAccount(seller As Seller) As Boolean
		Dim query As String = "INSERT INTO tblSellers 
							   (Seller_Id,FirstName,Paternal_LastName,Maternal_LastName,
								Physical_Address,Mailing_Address,City,ZipCode,Cellular_Number,Email,Department,
								Specialization,Hiring_Date,Username,Password)
							   VALUES 
							   (@Seller_Id,@FirstName,@Paternal_LastName,@Maternal_LastName,
								@Physical_Address,@Mailing_Address,@City,@ZipCode,@Cellular_Number,@Email,@Department,
								@Specialization,@Hiring_Date,@Username,@Password)"

		Using _myConnection As New SqlConnection(_connectionString)

			_myConnection.Open()

			Dim transaction As SqlTransaction = _myConnection.BeginTransaction()

			Try
				'Comando para insertar en la tabla tblSellers
				Using command As New SqlCommand(query, _myConnection, transaction)
					'Parametros con valores
					command.Parameters.AddWithValue("@Seller_Id", seller.SellerId)
					command.Parameters.AddWithValue("@FirstName", seller.FirstName)
					command.Parameters.AddWithValue("@Paternal_LastName", seller.PaternalLastName)
					command.Parameters.AddWithValue("@Maternal_LastName", seller.MaternalLastName)
					command.Parameters.AddWithValue("@Physical_Address", seller.PhysicalAddress)
					command.Parameters.AddWithValue("@Mailing_Address", seller.MailingAddress)
					command.Parameters.AddWithValue("@City", seller.City)
					command.Parameters.AddWithValue("@ZipCode", seller.ZipCode)
					command.Parameters.AddWithValue("@Cellular_Number", seller.CellularNumber)
					command.Parameters.AddWithValue("@Email", seller.Email)
					command.Parameters.AddWithValue("@Department", seller.Department)
					command.Parameters.AddWithValue("@Specialization", seller.Specialization)
					command.Parameters.AddWithValue("@Hiring_Date", seller.HiringDate)
					command.Parameters.AddWithValue("@Username", seller.UserName)
					command.Parameters.AddWithValue("@Password", seller.Password)

					command.ExecuteNonQuery()
				End Using

				transaction.Commit()

				Return True
			Catch ex As Exception
				MsgBox(ex.Message)
				transaction.Rollback()
			End Try
		End Using

		Return False
	End Function

	'Obtener el vendedor por el username
	Public Function GetSellerByUsername(userName As String) As Seller
		_seller = Nothing

		Dim query As String = "SELECT * 
							   FROM tblSellers
							   WHERE tblSellers.Username = @Username"

		Using _myConnection As New SqlConnection(_connectionString)

			_myConnection.Open()

			Try
				Using command As New SqlCommand(query, _myConnection)

					command.Parameters.AddWithValue("@Username", userName)

					Dim reader As SqlDataReader = command.ExecuteReader()

					While reader.Read()

						_seller = New Seller With
						{
							.SellerId = reader("Seller_Id"),
							.FirstName = reader("FirstName").ToString(),
							.PaternalLastName = reader("Paternal_LastName").ToString(),
							.MaternalLastName = reader("Maternal_LastName").ToString(),
							.PhysicalAddress = reader("Physical_Address").ToString(),
							.MailingAddress = reader("Mailing_Address").ToString(),
							.City = reader("City").ToString(),
							.ZipCode = reader("ZipCode").ToString(),
							.CellularNumber = reader("Cellular_Number").ToString(),
							.Email = reader("Email").ToString(),
							.Department = reader("Department").ToString(),
							.Specialization = reader("Specialization").ToString(),
							.HiringDate = reader("Hiring_Date").ToString(),
							.UserName = reader("Username").ToString(),
							.Password = reader("Password").ToString()
						}

					End While
				End Using
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End Using

		Return _seller
	End Function

	'Cambiar el password de un vendedor
	Public Function ChangePassword(seller As Seller, newPassword As String) As Boolean

		Dim query As String = "UPDATE tblSellers
							   SET tblSellers.Password = @Password
							   WHERE tblSellers.Seller_Id = @Seller_Id"

		Using _myConnection As New SqlConnection(_connectionString)

			_myConnection.Open()

			Dim transaction As SqlTransaction = _myConnection.BeginTransaction()

			Try
				Using command As New SqlCommand(query, _myConnection, transaction)
					command.Parameters.AddWithValue("@Password", newPassword)
					command.Parameters.AddWithValue("@Seller_Id", seller.SellerId)

					command.ExecuteNonQuery()
				End Using

				transaction.Commit()

				Return True
			Catch ex As Exception
				MsgBox(ex.Message)
				transaction.Rollback()
			End Try
		End Using

		Return False
	End Function



End Class

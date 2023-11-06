Imports System.Data.SqlClient

Public Class MyDataBase
	'Campos
	Private ReadOnly _connectionString As String = "Data Source=OSCARLAPTOP\SQLOSCAR1;Initial Catalog=RomerosTiresAndRimsDB;User Id=sa; Password=oscarpr12"

	'Obtiene los emails que ya han sido registrados
	Public ReadOnly Property ListOfEmails As List(Of String)
		Get
			Dim emails As New List(Of String)
			Dim query As String = "SELECT Email FROM tblSellers"

			Using _myConnection As New SqlConnection(_connectionString)

				'Se abre la conexion
				_myConnection.Open()

				Try
					'Commando para obtener los emails de la tabla sellers
					Using command As New SqlCommand(query, _myConnection)

						'Comienza el reader
						Dim reader As SqlDataReader = command.ExecuteReader()

						'Mientras lee guarda en la lista
						While reader.Read()
							emails.Add(reader("Email").ToString())
						End While
					End Using
				Catch ex As Exception
					MsgBox("Error Occurred")
				Finally
					_myConnection.Close()
				End Try
			End Using
			Return emails
		End Get
	End Property

	'Obtiene los usernames que ya han sido registrados
	Public ReadOnly Property ListOfUsernames As List(Of String)
		Get
			Dim usernames As New List(Of String)
			Dim query As String = "SELECT Username FROM tblSellers"

			Using _myConnection As New SqlConnection(_connectionString)

				'Se abre la conexion
				_myConnection.Open()

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
					MsgBox("Error ocurred")
				Finally
					_myConnection.Close()
				End Try
			End Using
			Return usernames
		End Get
	End Property

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

			'Se abre la conexion
			_myConnection.Open()

			'Se inicia la transaccion
			Using transaction As SqlTransaction = _myConnection.BeginTransaction()

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

					'Confirmar la transaccion
					transaction.Commit()

					'Regresa true si se completo bien
					Return True

				Catch ex As Exception
					'En caso de error se revierte la transaccion
					transaction.Rollback()
					'Mensaje de error
					MsgBox(ex.Message)
					Return False
				Finally
					'Se cierra la conexion
					_myConnection.Close()
				End Try
			End Using
		End Using
	End Function


End Class

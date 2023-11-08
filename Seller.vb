'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims
Public Class Seller

	'Campos
	Private _sellerId As Guid
	Private _firstName As String
	Private _paternalLastName As String
	Private _maternalLastName As String
	Private _physicalAddress As String
	Private _mailingAddress As String
	Private _city As String
	Private _zipCode As String
	Private _cellularNumber As String
	Private _email As String
	Private _department As String
	Private _specialization As String
	Private _hiringDate As Date
	Private _username As String
	Private _password As String

	'Propiedades

	'Seller Id
	Public Property SellerId As Guid
		Get
			Return _sellerId
		End Get
		Set(value As Guid)
			_sellerId = value
		End Set
	End Property

	'Nombre
	Public Property FirstName As String
		Get
			Return _firstName
		End Get
		Set(value As String)
			_firstName = value
		End Set
	End Property

	'Apellido Paterno
	Public Property PaternalLastName As String
		Get
			Return _paternalLastName
		End Get
		Set(value As String)
			_paternalLastName = value
		End Set
	End Property

	'Apellido Materno
	Public Property MaternalLastName As String
		Get
			Return _maternalLastName
		End Get
		Set(value As String)
			_maternalLastName = value
		End Set
	End Property

	'Direccion Fisica
	Public Property PhysicalAddress As String
		Get
			Return _physicalAddress
		End Get
		Set(value As String)
			_physicalAddress = value
		End Set
	End Property

	'Direccion Postal
	Public Property MailingAddress As String
		Get
			Return _mailingAddress
		End Get
		Set(value As String)
			_mailingAddress = value
		End Set
	End Property

	'Ciudad / Pueblo
	Public Property City As String
		Get
			Return _city
		End Get
		Set(value As String)
			_city = value
		End Set
	End Property

	'Zipcode
	Public Property ZipCode As String
		Get
			Return _zipCode
		End Get
		Set(value As String)
			_zipCode = value
		End Set
	End Property

	'Numero de telefono
	Public Property CellularNumber As String
		Get
			Return _cellularNumber
		End Get
		Set(value As String)
			_cellularNumber = value
		End Set
	End Property

	'Email
	Public Property Email As String
		Get
			Return _email
		End Get
		Set(value As String)
			_email = value
		End Set
	End Property

	'Departamento
	Public Property Department As String
		Get
			Return _department
		End Get
		Set(value As String)
			_department = value
		End Set
	End Property

	'Especializacion
	Public Property Specialization As String
		Get
			Return _specialization
		End Get
		Set(value As String)
			_specialization = value
		End Set
	End Property

	'Fecha comienzo a trabajar
	Public Property HiringDate As Date
		Get
			Return _hiringDate
		End Get
		Set(value As Date)
			_hiringDate = value
		End Set
	End Property

	'Username
	Public Property UserName As String
		Get
			Return _username
		End Get
		Set(value As String)
			_username = value
		End Set
	End Property

	'Password
	Public Property Password As String
		Get
			Return _password
		End Get
		Set(value As String)
			_password = value
		End Set
	End Property

	'Constructores

	'Default
	Public Sub New()
		_sellerId = Guid.NewGuid()
		_firstName = "Default"
		_paternalLastName = ""
		_maternalLastName = ""
		_physicalAddress = ""
		_mailingAddress = ""
		_city = ""
		_zipCode = ""
		_cellularNumber = ""
		_email = ""
		_department = ""
		_specialization = ""
		_hiringDate = Date.Now
		_username = ""
		_password = ""
	End Sub

	'Cuando se crea desde el form de create account
	Public Sub New(fName As String, pLastName As String, mLastName As String, userName As String,
				   password As String, pAddres As String, mAddres As String, city As String, zipcode As String,
				   cellNum As String, email As String, dept As String, spec As String, hireDate As Date)

		_sellerId = Guid.NewGuid()
		_firstName = fName
		_paternalLastName = pLastName
		_maternalLastName = mLastName
		_physicalAddress = pAddres
		_mailingAddress = mAddres
		_city = city
		_zipCode = zipcode
		_cellularNumber = cellNum
		_email = email
		_department = dept
		_specialization = spec
		_hiringDate = hireDate
		_username = userName
		_password = password
	End Sub

	'Cuando se crea obteniendo desde una base de datos
	Public Sub New(id As Guid, fName As String, pLastName As String, mLastName As String, userName As String,
				   password As String, pAddres As String, mAddres As String, city As String, zipcode As String,
				   cellNum As String, email As String, dept As String, spec As String, hireDate As Date)

		_sellerId = id
		_firstName = fName
		_paternalLastName = pLastName
		_maternalLastName = mLastName
		_physicalAddress = pAddres
		_mailingAddress = mAddres
		_city = city
		_zipCode = zipcode
		_cellularNumber = cellNum
		_email = email
		_department = dept
		_specialization = spec
		_hiringDate = hireDate
		_username = userName
		_password = password
	End Sub

End Class

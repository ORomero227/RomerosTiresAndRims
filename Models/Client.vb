'Oscar Romero Barbosa
'Y00592812
'Programa: Romero's Tires And Rims
Public Class Client

	'Campos
	Private _clientId As Guid
	Private _firstName As String
	Private _paternalLastName As String
	Private _maternalLastName As String
	Private _physicalAddress As String
	Private _mailingAddress As String
	Private _city As String
	Private _zipCode As String
	Private _birthDate As Date
	Private _cellularNumber As String
	Private _email As String
	Private _companyName As String
	Private _companyCity As String
	Private _clientFee As Double
	Private _sellerId As Guid

	'Propiedades

	'Client Id
	Public Property ClientId As Guid
		Get
			Return _clientId
		End Get
		Set(value As Guid)
			_clientId = value
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

	'Fecha de nacimiento
	Public Property BirthDate As Date
		Get
			Return _birthDate
		End Get
		Set(value As Date)
			_birthDate = value
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

	'Nombre compania
	Public Property CompanyName As String
		Get
			Return _companyName
		End Get
		Set(value As String)
			_companyName = value
		End Set
	End Property

	'Pueblo donde esta la compania
	Public Property CompanyCity As String
		Get
			Return _companyCity
		End Get
		Set(value As String)
			_companyCity = value
		End Set
	End Property

	'Cuota del cliente
	Public Property ClientFee As Double
		Get
			Return _clientFee
		End Get
		Set(value As Double)
			_clientFee = value
		End Set
	End Property

	'Seller Id
	Public Property SellerId As Guid
		Get
			Return _sellerId
		End Get
		Set(value As Guid)
			_sellerId = value
		End Set
	End Property

	'Nombre completo
	Public ReadOnly Property FullName As String
		Get
			Return $"{_firstName} {_paternalLastName} {_maternalLastName}"
		End Get
	End Property


	'Constructores
	'Default
	Public Sub New()
		_clientId = Guid.NewGuid()
		_firstName = "Default"
		_paternalLastName = ""
		_maternalLastName = ""
		_physicalAddress = ""
		_mailingAddress = ""
		_city = ""
		_zipCode = ""
		_birthDate = Date.Now
		_cellularNumber = ""
		_email = ""
		_companyName = ""
		_companyCity = ""
		_clientFee = 0.0
		_sellerId = Guid.NewGuid()
	End Sub

	'Cuando se crea desde el form de add client
	Public Sub New(fName As String, pLastName As String, mLastName As String, pAddres As String, mAddres As String,
				   city As String, zipcode As String, birthDate As Date,
				   cellNum As String, email As String, companyName As String, companyCity As String, clientFee As Double, sellerId As Guid)

		_clientId = Guid.NewGuid()
		_firstName = fName
		_paternalLastName = pLastName
		_maternalLastName = mLastName
		_physicalAddress = pAddres
		_mailingAddress = mAddres
		_city = city
		_zipCode = zipcode
		_birthDate = birthDate
		_cellularNumber = cellNum
		_email = email
		_companyName = companyName
		_companyCity = companyCity
		_clientFee = clientFee
		_sellerId = sellerId
	End Sub

	'Cuando se crea obteniendo desde una base de datos
	Public Sub New(id As Guid, fName As String, pLastName As String, mLastName As String, pAddres As String, mAddres As String,
				   city As String, zipcode As String, birthDate As Date,
				   cellNum As String, email As String, companyName As String, companyCity As String, clietnFee As Double, sellerId As Guid)

		_clientId = id
		_firstName = fName
		_paternalLastName = pLastName
		_maternalLastName = mLastName
		_physicalAddress = pAddres
		_mailingAddress = mAddres
		_city = city
		_zipCode = zipcode
		_birthDate = birthDate
		_cellularNumber = cellNum
		_email = email
		_companyName = companyName
		_companyCity = companyCity
		_clientFee = clietnFee
		_sellerId = sellerId
	End Sub

End Class

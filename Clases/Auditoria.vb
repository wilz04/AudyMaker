Public Class Auditoria

    Private aAuditor As String
    Private aNumero As String
    Private aFecha As Date
    Private aTipo As String

    Private aDirigido As String
    Private aDepartamento As String

    Private aSoluciones As String

    Public Sub New()
        aAuditor = ""
        aNumero = ""
        aFecha = "01/01/2005"
        aTipo = ""

        aDirigido = ""
        aDepartamento = ""

        aSoluciones = ""
    End Sub

    Public Property auditor() As String
        Get
            Return aAuditor
        End Get
        Set(ByVal Value As String)
            aAuditor = Value
        End Set
    End Property

    Public Property numero() As String
        Get
            Return aNumero
        End Get
        Set(ByVal Value As String)
            aNumero = Value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return aFecha
        End Get
        Set(ByVal Value As Date)
            aFecha = Value
        End Set
    End Property

    Public Property tipo() As String
        Get
            Return aTipo
        End Get
        Set(ByVal Value As String)
            aTipo = Value
        End Set
    End Property

    Public Property dirigido() As String
        Get
            Return aDirigido
        End Get
        Set(ByVal Value As String)
            aDirigido = Value
        End Set
    End Property

    Public Property departamento() As String
        Get
            Return aDepartamento
        End Get
        Set(ByVal Value As String)
            aDepartamento = Value
        End Set
    End Property

    Public Property soluciones() As String
        Get
            Return aSoluciones
        End Get
        Set(ByVal Value As String)
            aSoluciones = Value
        End Set
    End Property

End Class

Public Class Especificaciones
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        aDepartamento = ""
        aDirigido = ""

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents gbDirigidoA As System.Windows.Forms.GroupBox
    Friend WithEvents cbPresidente As System.Windows.Forms.CheckBox
    Friend WithEvents cbVicepresidente As System.Windows.Forms.CheckBox
    Friend WithEvents lblCod3 As System.Windows.Forms.Label
    Friend WithEvents lblCod2 As System.Windows.Forms.Label
    Friend WithEvents lblCod1 As System.Windows.Forms.Label
    Friend WithEvents gbDepartamento As System.Windows.Forms.GroupBox
    Friend WithEvents rbGerencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbRecursosH As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdministrativo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSoporteT As System.Windows.Forms.RadioButton
    Friend WithEvents cbAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents rbRelacionesP As System.Windows.Forms.RadioButton
    Friend WithEvents bCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbDirigidoA = New System.Windows.Forms.GroupBox
        Me.lblCod3 = New System.Windows.Forms.Label
        Me.lblCod2 = New System.Windows.Forms.Label
        Me.lblCod1 = New System.Windows.Forms.Label
        Me.cbAdministrador = New System.Windows.Forms.CheckBox
        Me.cbVicepresidente = New System.Windows.Forms.CheckBox
        Me.cbPresidente = New System.Windows.Forms.CheckBox
        Me.gbDepartamento = New System.Windows.Forms.GroupBox
        Me.rbRelacionesP = New System.Windows.Forms.RadioButton
        Me.rbSoporteT = New System.Windows.Forms.RadioButton
        Me.rbAdministrativo = New System.Windows.Forms.RadioButton
        Me.rbRecursosH = New System.Windows.Forms.RadioButton
        Me.rbGerencia = New System.Windows.Forms.RadioButton
        Me.bCerrar = New System.Windows.Forms.Button
        Me.gbDirigidoA.SuspendLayout()
        Me.gbDepartamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDirigidoA
        '
        Me.gbDirigidoA.Controls.Add(Me.lblCod3)
        Me.gbDirigidoA.Controls.Add(Me.lblCod2)
        Me.gbDirigidoA.Controls.Add(Me.lblCod1)
        Me.gbDirigidoA.Controls.Add(Me.cbAdministrador)
        Me.gbDirigidoA.Controls.Add(Me.cbVicepresidente)
        Me.gbDirigidoA.Controls.Add(Me.cbPresidente)
        Me.gbDirigidoA.Location = New System.Drawing.Point(8, 8)
        Me.gbDirigidoA.Name = "gbDirigidoA"
        Me.gbDirigidoA.Size = New System.Drawing.Size(288, 112)
        Me.gbDirigidoA.TabIndex = 2
        Me.gbDirigidoA.TabStop = False
        Me.gbDirigidoA.Text = "Dirigido a:"
        '
        'lblCod3
        '
        Me.lblCod3.Location = New System.Drawing.Point(144, 72)
        Me.lblCod3.Name = "lblCod3"
        Me.lblCod3.Size = New System.Drawing.Size(56, 23)
        Me.lblCod3.TabIndex = 6
        Me.lblCod3.Text = "(cod #03)"
        '
        'lblCod2
        '
        Me.lblCod2.Location = New System.Drawing.Point(144, 48)
        Me.lblCod2.Name = "lblCod2"
        Me.lblCod2.Size = New System.Drawing.Size(56, 23)
        Me.lblCod2.TabIndex = 5
        Me.lblCod2.Text = "(cod #02)"
        '
        'lblCod1
        '
        Me.lblCod1.Location = New System.Drawing.Point(144, 24)
        Me.lblCod1.Name = "lblCod1"
        Me.lblCod1.Size = New System.Drawing.Size(56, 23)
        Me.lblCod1.TabIndex = 4
        Me.lblCod1.Text = "(cod #01)"
        '
        'cbAdministrador
        '
        Me.cbAdministrador.Location = New System.Drawing.Point(8, 72)
        Me.cbAdministrador.Name = "cbAdministrador"
        Me.cbAdministrador.Size = New System.Drawing.Size(136, 24)
        Me.cbAdministrador.TabIndex = 2
        Me.cbAdministrador.Text = "Administrador"
        '
        'cbVicepresidente
        '
        Me.cbVicepresidente.Location = New System.Drawing.Point(8, 48)
        Me.cbVicepresidente.Name = "cbVicepresidente"
        Me.cbVicepresidente.Size = New System.Drawing.Size(136, 24)
        Me.cbVicepresidente.TabIndex = 1
        Me.cbVicepresidente.Text = "Vicepresidente"
        '
        'cbPresidente
        '
        Me.cbPresidente.Location = New System.Drawing.Point(8, 24)
        Me.cbPresidente.Name = "cbPresidente"
        Me.cbPresidente.Size = New System.Drawing.Size(136, 24)
        Me.cbPresidente.TabIndex = 0
        Me.cbPresidente.Text = "Prersidente"
        '
        'gbDepartamento
        '
        Me.gbDepartamento.Controls.Add(Me.rbRelacionesP)
        Me.gbDepartamento.Controls.Add(Me.rbSoporteT)
        Me.gbDepartamento.Controls.Add(Me.rbAdministrativo)
        Me.gbDepartamento.Controls.Add(Me.rbRecursosH)
        Me.gbDepartamento.Controls.Add(Me.rbGerencia)
        Me.gbDepartamento.Location = New System.Drawing.Point(8, 128)
        Me.gbDepartamento.Name = "gbDepartamento"
        Me.gbDepartamento.Size = New System.Drawing.Size(288, 112)
        Me.gbDepartamento.TabIndex = 3
        Me.gbDepartamento.TabStop = False
        Me.gbDepartamento.Text = "Departamento"
        '
        'rbRelacionesP
        '
        Me.rbRelacionesP.Location = New System.Drawing.Point(144, 48)
        Me.rbRelacionesP.Name = "rbRelacionesP"
        Me.rbRelacionesP.Size = New System.Drawing.Size(136, 24)
        Me.rbRelacionesP.TabIndex = 5
        Me.rbRelacionesP.Text = "Relaciones Públicas"
        '
        'rbSoporteT
        '
        Me.rbSoporteT.Location = New System.Drawing.Point(144, 24)
        Me.rbSoporteT.Name = "rbSoporteT"
        Me.rbSoporteT.Size = New System.Drawing.Size(136, 24)
        Me.rbSoporteT.TabIndex = 4
        Me.rbSoporteT.Text = "Soporte Técnico"
        '
        'rbAdministrativo
        '
        Me.rbAdministrativo.Location = New System.Drawing.Point(8, 72)
        Me.rbAdministrativo.Name = "rbAdministrativo"
        Me.rbAdministrativo.Size = New System.Drawing.Size(136, 24)
        Me.rbAdministrativo.TabIndex = 3
        Me.rbAdministrativo.Text = "Administrativo"
        '
        'rbRecursosH
        '
        Me.rbRecursosH.Location = New System.Drawing.Point(8, 48)
        Me.rbRecursosH.Name = "rbRecursosH"
        Me.rbRecursosH.Size = New System.Drawing.Size(136, 24)
        Me.rbRecursosH.TabIndex = 2
        Me.rbRecursosH.Text = "Recursos Humanos"
        '
        'rbGerencia
        '
        Me.rbGerencia.Location = New System.Drawing.Point(8, 24)
        Me.rbGerencia.Name = "rbGerencia"
        Me.rbGerencia.Size = New System.Drawing.Size(136, 24)
        Me.rbGerencia.TabIndex = 0
        Me.rbGerencia.Text = "Gerencia"
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(111, 248)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(84, 24)
        Me.bCerrar.TabIndex = 4
        Me.bCerrar.Text = "Cerrar"
        '
        'Especificaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(306, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.bCerrar)
        Me.Controls.Add(Me.gbDepartamento)
        Me.Controls.Add(Me.gbDirigidoA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Especificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Auditoria / Especificaciones"
        Me.gbDirigidoA.ResumeLayout(False)
        Me.gbDepartamento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private aDepartamento As String
    Private aI As String
    Private aDirigido As String

    Public Property Departamento() As String
        Get
            Return aDepartamento
        End Get
        Set(ByVal Value As String)
            aDepartamento = Value
        End Set
    End Property

    Public Property i() As String
        Get
            Return aI
        End Get
        Set(ByVal Value As String)
            aI = Value
        End Set
    End Property


    Public Property Dirigido() As String
        Get
            Return aDirigido
        End Get
        Set(ByVal Value As String)
            aDirigido = Value
        End Set
    End Property

    Private Sub bCerrarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click
        'Definicion de los atributos "aDepartamento" y "aDirigido"'
        If rbGerencia.Checked Then
            aDepartamento = "Gerencia"
            aI = "1"
        ElseIf rbRecursosH.Checked Then
            aDepartamento = "Recursos Humanos"
            aI = "2"
        ElseIf rbAdministrativo.Checked Then
            aDepartamento = "Administrativo"
            aI = "3"
        ElseIf rbSoporteT.Checked Then
            aDepartamento = "Soporte Técnico"
            aI = "4"
        ElseIf rbRelacionesP.Checked Then
            aDepartamento = "Relaciones Públicas"
            aI = "5"
        End If

        If cbPresidente.Checked Then
            aDirigido += "Presidente, "
        End If
        If cbVicepresidente.Checked Then
            aDirigido += "Vicepresidente, "
        End If
        If cbAdministrador.Checked Then
            aDirigido += "Administrador"
        End If

        If aDepartamento = "" Or aDirigido = "" Then
            MsgBox("Debes llenar todos los espacios", MsgBoxStyle.Exclamation, "AudyMaker")
            aDepartamento = ""
            aDirigido = ""
        Else
            Me.Hide()
        End If
    End Sub

End Class

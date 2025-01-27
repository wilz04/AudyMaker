Public Class Info

    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        aTipo = ""
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
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblOficio As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents rbCalidad As System.Windows.Forms.RadioButton
    Friend WithEvents tbAuditor As System.Windows.Forms.TextBox
    Friend WithEvents tbNumero As System.Windows.Forms.TextBox
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents bCerrar As System.Windows.Forms.Button
    Friend WithEvents rbFinanciera As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblOficio = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.tbAuditor = New System.Windows.Forms.TextBox
        Me.tbNumero = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.bCerrar = New System.Windows.Forms.Button
        Me.gbInfo = New System.Windows.Forms.GroupBox
        Me.gbTipo = New System.Windows.Forms.GroupBox
        Me.rbFinanciera = New System.Windows.Forms.RadioButton
        Me.rbCalidad = New System.Windows.Forms.RadioButton
        Me.gbInfo.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(8, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Auditor:"
        '
        'lblOficio
        '
        Me.lblOficio.Location = New System.Drawing.Point(8, 64)
        Me.lblOficio.Name = "lblOficio"
        Me.lblOficio.TabIndex = 1
        Me.lblOficio.Text = "Numero Oficio:"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(8, 96)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'tbAuditor
        '
        Me.tbAuditor.Location = New System.Drawing.Point(112, 32)
        Me.tbAuditor.Name = "tbAuditor"
        Me.tbAuditor.Size = New System.Drawing.Size(160, 20)
        Me.tbAuditor.TabIndex = 3
        Me.tbAuditor.Text = ""
        '
        'tbNumero
        '
        Me.tbNumero.Location = New System.Drawing.Point(112, 64)
        Me.tbNumero.Name = "tbNumero"
        Me.tbNumero.Size = New System.Drawing.Size(56, 20)
        Me.tbNumero.TabIndex = 4
        Me.tbNumero.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(112, 96)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(208, 248)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.TabIndex = 7
        Me.bCerrar.Text = "Cerrar"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.gbTipo)
        Me.gbInfo.Controls.Add(Me.lblOficio)
        Me.gbInfo.Controls.Add(Me.dtpFecha)
        Me.gbInfo.Controls.Add(Me.lblFecha)
        Me.gbInfo.Controls.Add(Me.tbAuditor)
        Me.gbInfo.Controls.Add(Me.lblNombre)
        Me.gbInfo.Controls.Add(Me.tbNumero)
        Me.gbInfo.Location = New System.Drawing.Point(8, 8)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(280, 232)
        Me.gbInfo.TabIndex = 8
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Informacion principal"
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbFinanciera)
        Me.gbTipo.Controls.Add(Me.rbCalidad)
        Me.gbTipo.Location = New System.Drawing.Point(16, 128)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(248, 96)
        Me.gbTipo.TabIndex = 6
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Tipo de Auditoria"
        '
        'rbFinanciera
        '
        Me.rbFinanciera.Location = New System.Drawing.Point(16, 48)
        Me.rbFinanciera.Name = "rbFinanciera"
        Me.rbFinanciera.Size = New System.Drawing.Size(168, 24)
        Me.rbFinanciera.TabIndex = 10
        Me.rbFinanciera.Text = "Auditoria financiera contable"
        '
        'rbCalidad
        '
        Me.rbCalidad.Location = New System.Drawing.Point(16, 24)
        Me.rbCalidad.Name = "rbCalidad"
        Me.rbCalidad.Size = New System.Drawing.Size(168, 24)
        Me.rbCalidad.TabIndex = 9
        Me.rbCalidad.Text = "Auditoria de calidad"
        '
        'Info
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(298, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.bCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Información básica"
        Me.gbInfo.ResumeLayout(False)
        Me.gbTipo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private aFecha As String
    Private aTipo As String

    Public Property tipo() As String
        Get
            Return aTipo
        End Get
        Set(ByVal Value As String)
            aTipo = Value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            If dtpFecha.Text = "" Then
                Return "01/01/2005"
            Else
                Return dtpFecha.Text
            End If
        End Get
        Set(ByVal Value As Date)
            aFecha = Value
        End Set
    End Property

    Private Sub btnCerrarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click
        If tbAuditor.Text = "" Or tbNumero.Text = "" Or (rbCalidad.Checked = False And rbFinanciera.Checked = False) Then
            MsgBox("Debes llenar todos los espacios", MsgBoxStyle.Exclamation, "AudyMaker")
        Else
            If rbCalidad.Checked Then
                aTipo = "Calidad"
            Else
                aTipo = "Financiera contable"
            End If

            Me.Hide()
        End If
    End Sub

End Class

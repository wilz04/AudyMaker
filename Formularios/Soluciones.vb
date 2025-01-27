Imports Clases

Public Class Soluciones
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents rtbSoluciones As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents lComentario As System.Windows.Forms.Label
    Friend WithEvents bCerrar As System.Windows.Forms.Button
    Friend WithEvents cbAnomalia_1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbAnomalia_2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbAnomalia_3 As System.Windows.Forms.CheckBox
    Friend WithEvents gbAnomalias As System.Windows.Forms.GroupBox
    Friend WithEvents gbSolucion As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.bCerrar = New System.Windows.Forms.Button
        Me.rtbSoluciones = New System.Windows.Forms.RichTextBox
        Me.rtbComentario = New System.Windows.Forms.RichTextBox
        Me.lComentario = New System.Windows.Forms.Label
        Me.cbAnomalia_1 = New System.Windows.Forms.CheckBox
        Me.cbAnomalia_2 = New System.Windows.Forms.CheckBox
        Me.cbAnomalia_3 = New System.Windows.Forms.CheckBox
        Me.gbAnomalias = New System.Windows.Forms.GroupBox
        Me.gbSolucion = New System.Windows.Forms.GroupBox
        Me.gbAnomalias.SuspendLayout()
        Me.gbSolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(120, 368)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(88, 23)
        Me.bCerrar.TabIndex = 7
        Me.bCerrar.Text = "Cerrar"
        '
        'rtbSoluciones
        '
        Me.rtbSoluciones.Location = New System.Drawing.Point(16, 24)
        Me.rtbSoluciones.Name = "rtbSoluciones"
        Me.rtbSoluciones.ReadOnly = True
        Me.rtbSoluciones.Size = New System.Drawing.Size(280, 112)
        Me.rtbSoluciones.TabIndex = 8
        Me.rtbSoluciones.Text = ""
        '
        'rtbComentario
        '
        Me.rtbComentario.Location = New System.Drawing.Point(16, 160)
        Me.rtbComentario.Name = "rtbComentario"
        Me.rtbComentario.Size = New System.Drawing.Size(280, 64)
        Me.rtbComentario.TabIndex = 9
        Me.rtbComentario.Text = ""
        '
        'lComentario
        '
        Me.lComentario.Location = New System.Drawing.Point(16, 144)
        Me.lComentario.Name = "lComentario"
        Me.lComentario.Size = New System.Drawing.Size(100, 16)
        Me.lComentario.TabIndex = 10
        Me.lComentario.Text = "Comentarios:"
        '
        'cbAnomalia_1
        '
        Me.cbAnomalia_1.Location = New System.Drawing.Point(16, 24)
        Me.cbAnomalia_1.Name = "cbAnomalia_1"
        Me.cbAnomalia_1.Size = New System.Drawing.Size(280, 24)
        Me.cbAnomalia_1.TabIndex = 13
        '
        'cbAnomalia_2
        '
        Me.cbAnomalia_2.Location = New System.Drawing.Point(16, 48)
        Me.cbAnomalia_2.Name = "cbAnomalia_2"
        Me.cbAnomalia_2.Size = New System.Drawing.Size(280, 24)
        Me.cbAnomalia_2.TabIndex = 14
        '
        'cbAnomalia_3
        '
        Me.cbAnomalia_3.Location = New System.Drawing.Point(16, 72)
        Me.cbAnomalia_3.Name = "cbAnomalia_3"
        Me.cbAnomalia_3.Size = New System.Drawing.Size(280, 24)
        Me.cbAnomalia_3.TabIndex = 15
        '
        'gbAnomalias
        '
        Me.gbAnomalias.Controls.Add(Me.cbAnomalia_1)
        Me.gbAnomalias.Controls.Add(Me.cbAnomalia_2)
        Me.gbAnomalias.Controls.Add(Me.cbAnomalia_3)
        Me.gbAnomalias.Location = New System.Drawing.Point(8, 8)
        Me.gbAnomalias.Name = "gbAnomalias"
        Me.gbAnomalias.Size = New System.Drawing.Size(312, 104)
        Me.gbAnomalias.TabIndex = 16
        Me.gbAnomalias.TabStop = False
        Me.gbAnomalias.Text = "Anomalias"
        '
        'gbSolucion
        '
        Me.gbSolucion.Controls.Add(Me.rtbSoluciones)
        Me.gbSolucion.Controls.Add(Me.rtbComentario)
        Me.gbSolucion.Controls.Add(Me.lComentario)
        Me.gbSolucion.Location = New System.Drawing.Point(8, 120)
        Me.gbSolucion.Name = "gbSolucion"
        Me.gbSolucion.Size = New System.Drawing.Size(312, 240)
        Me.gbSolucion.TabIndex = 17
        Me.gbSolucion.TabStop = False
        Me.gbSolucion.Text = "Solucion"
        '
        'Soluciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(330, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbSolucion)
        Me.Controls.Add(Me.gbAnomalias)
        Me.Controls.Add(Me.bCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Soluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Auditoria / Soluciones"
        Me.gbAnomalias.ResumeLayout(False)
        Me.gbSolucion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private aTipo As String

    Private newAudyProblemas As New AudyProblemas

    Private Sub bCerrarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click
        Me.Hide()
    End Sub

    Private Sub cbAnomalia_1OnCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnomalia_1.CheckedChanged
        rtbSoluciones.Text += newAudyProblemas.solucion(1, 1) + Chr(10)
        cbAnomalia_1.Enabled = False
    End Sub

    Private Sub cbAnomalia_2OnCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnomalia_2.CheckedChanged
        rtbSoluciones.Text += newAudyProblemas.solucion(1, 2) + Chr(10)
        cbAnomalia_2.Enabled = False
    End Sub

    Private Sub cbAnomalia_3OnCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAnomalia_3.CheckedChanged
        rtbSoluciones.Text += newAudyProblemas.solucion(1, 3) + Chr(10)
        cbAnomalia_3.Enabled = False
    End Sub

End Class

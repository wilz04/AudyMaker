Public Class Reporte
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
    Friend WithEvents rtbReporte As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Reporte))
        Me.rtbReporte = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'rtbReporte
        '
        Me.rtbReporte.BackColor = System.Drawing.Color.White
        Me.rtbReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbReporte.Location = New System.Drawing.Point(0, 0)
        Me.rtbReporte.Name = "rtbReporte"
        Me.rtbReporte.ReadOnly = True
        Me.rtbReporte.Size = New System.Drawing.Size(542, 373)
        Me.rtbReporte.TabIndex = 0
        Me.rtbReporte.Text = ""
        '
        'Reporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 373)
        Me.Controls.Add(Me.rtbReporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reporte"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class

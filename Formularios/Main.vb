Imports Clases

Public Class Main
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
    Friend WithEvents mAuditoria As System.Windows.Forms.MenuItem
    Friend WithEvents miNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents miAbrir As System.Windows.Forms.MenuItem
    Friend WithEvents miGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents miSalir As System.Windows.Forms.MenuItem
    Friend WithEvents mVentanas As System.Windows.Forms.MenuItem
    Friend WithEvents miInfo As System.Windows.Forms.MenuItem
    Friend WithEvents miEspecificacion As System.Windows.Forms.MenuItem
    Friend WithEvents miSolucion As System.Windows.Forms.MenuItem
    Friend WithEvents mOpciones As System.Windows.Forms.MenuItem
    Friend WithEvents miModo As System.Windows.Forms.MenuItem
    Friend WithEvents mAyuda As System.Windows.Forms.MenuItem
    Friend WithEvents miAcerca As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mAuditoria = New System.Windows.Forms.MenuItem
        Me.miNuevo = New System.Windows.Forms.MenuItem
        Me.miAbrir = New System.Windows.Forms.MenuItem
        Me.miGuardar = New System.Windows.Forms.MenuItem
        Me.miSalir = New System.Windows.Forms.MenuItem
        Me.mVentanas = New System.Windows.Forms.MenuItem
        Me.miInfo = New System.Windows.Forms.MenuItem
        Me.miEspecificacion = New System.Windows.Forms.MenuItem
        Me.miSolucion = New System.Windows.Forms.MenuItem
        Me.mOpciones = New System.Windows.Forms.MenuItem
        Me.miModo = New System.Windows.Forms.MenuItem
        Me.mAyuda = New System.Windows.Forms.MenuItem
        Me.miAcerca = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mAuditoria, Me.mVentanas, Me.mOpciones, Me.mAyuda})
        '
        'mAuditoria
        '
        Me.mAuditoria.Index = 0
        Me.mAuditoria.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNuevo, Me.miAbrir, Me.miGuardar, Me.miSalir})
        Me.mAuditoria.Text = "Auditoria"
        '
        'miNuevo
        '
        Me.miNuevo.Index = 0
        Me.miNuevo.Text = "Nuevo"
        '
        'miAbrir
        '
        Me.miAbrir.Index = 1
        Me.miAbrir.Text = "Abrir"
        '
        'miGuardar
        '
        Me.miGuardar.Index = 2
        Me.miGuardar.Text = "Guardar"
        '
        'miSalir
        '
        Me.miSalir.Index = 3
        Me.miSalir.Text = "Salir"
        '
        'mVentanas
        '
        Me.mVentanas.Index = 1
        Me.mVentanas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miInfo, Me.miEspecificacion, Me.miSolucion})
        Me.mVentanas.Text = "Ventanas"
        '
        'miInfo
        '
        Me.miInfo.Index = 0
        Me.miInfo.Text = "Información"
        '
        'miEspecificacion
        '
        Me.miEspecificacion.Index = 1
        Me.miEspecificacion.Text = "Especificaciones"
        '
        'miSolucion
        '
        Me.miSolucion.Index = 2
        Me.miSolucion.Text = "Soluciones"
        '
        'mOpciones
        '
        Me.mOpciones.Index = 2
        Me.mOpciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miModo})
        Me.mOpciones.Text = "Opciones"
        '
        'miModo
        '
        Me.miModo.Index = 0
        Me.miModo.Text = "Modo de edición"
        '
        'mAyuda
        '
        Me.mAyuda.Index = 3
        Me.mAyuda.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAcerca})
        Me.mAyuda.Text = "Ayuda"
        '
        'miAcerca
        '
        Me.miAcerca.Index = 0
        Me.miAcerca.Text = "Acerca de..."
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(792, 553)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AudyMaker"

    End Sub

#End Region

#Region " Declaracion de Atributos "

    Private isLoaded As Boolean

    Private newAuditoria As New Auditoria
    Private newAudyProblemas As New AudyProblemas

    Private newReporte As New Reporte

    Private newInfo As New Info
    Private newEspecificaciones As New Especificaciones
    Private newSoluciones As New Soluciones
#End Region

    Private Sub MainOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoaded = False

        newReporte.MdiParent = Me

        newInfo.MdiParent = Me
        newEspecificaciones.MdiParent = Me
        newSoluciones.MdiParent = Me

        miGuardar.Enabled = False
        mVentanas.Enabled = False
        mOpciones.Enabled = False
    End Sub

#Region " Metodos de opciones de menu "

    Private Sub NuevoOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miNuevo.Click
        newReporte.Show()

        miAbrir.Enabled = False
        miGuardar.Enabled = True
        mVentanas.Enabled = True
        mOpciones.Enabled = True

        miNuevo.Enabled = False
    End Sub

    Private Sub AbrirOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAbrir.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.ShowDialog()

        Try
            newReporte.rtbReporte.LoadFile(openFileDialog.FileName)

            isLoaded = True

            newReporte.rtbReporte.ReadOnly = False
            newReporte.Show()

            miNuevo.Enabled = False
            miAbrir.Enabled = False
            miGuardar.Enabled = True
        Catch exception As Exception
        End Try
    End Sub

    Private Sub miGuardarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miGuardar.Click
        Dim saveFileDialog As New SaveFileDialog
        Dim fileName As String

        saveFileDialog.ShowDialog()
        fileName = saveFileDialog.FileName

        Try
            If fileName.Substring(fileName.Length() - 4, 4) <> ".amd" Then
                fileName += ".amd"
            End If

            newReporte.rtbReporte.SaveFile(fileName)
        Catch exception As Exception
        End Try
    End Sub

    Private Sub SalirOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSalir.Click
        Me.Close()
    End Sub

    Private Sub InfoOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miInfo.Click
        newInfo.Show()
        miInfo.Enabled = False
    End Sub

    Private Sub EspecificacionOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miEspecificacion.Click
        newEspecificaciones.Show()
        miEspecificacion.Enabled = False
    End Sub

    Private Sub SolucionesOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSolucion.Click
        newSoluciones.Show()
        miSolucion.Enabled = False
    End Sub

    Private Sub OpcionesOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miModo.Click
        miModo.Checked = Not miModo.Checked
        newReporte.rtbReporte.ReadOnly = Not newReporte.rtbReporte.ReadOnly
    End Sub

    Private Sub AcercaDeOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAcerca.Click
        MsgBox("Desarrolladores:" & Chr(10) & Chr(10) & "    Jorge Carballo Coto    " & Chr(10) & "    Wilberth Castro Fuentes    " & Chr(10) & "    Jorge Ramírez Barrantes    ", MsgBoxStyle.Information, "AudyMaker")
    End Sub

#End Region

    Private Sub MainOnMdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        If Not newReporte.Visible Then
            Close()
        End If

        'Carga de las propiedades de la clase "newAuditoria"'

        newAuditoria.auditor = newInfo.tbAuditor.Text
        newAuditoria.numero = newInfo.tbNumero.Text
        newAuditoria.fecha = newInfo.fecha
        newAuditoria.tipo = newInfo.tipo

        newAuditoria.dirigido = newEspecificaciones.Dirigido
        newAuditoria.departamento = newEspecificaciones.Departamento

        newAuditoria.soluciones = newSoluciones.rtbSoluciones.Text + Chr(10) + newSoluciones.rtbComentario.Text

        If newInfo.tipo = "calidad" Then
            newReporte.Text = "Reporte / Auditoria de Calidad"
        ElseIf newInfo.tipo = "financiera" Then
            newReporte.Text = "Reporte / Auditoria Financiera Contable"
        End If

        Dim i As Integer = 1
        If newAuditoria.departamento <> "" Then
            If newAuditoria.departamento = "Gerencia" Then
                i = 1
            ElseIf newAuditoria.departamento = "Recursos Humanos" Then
                i = 2
            ElseIf newAuditoria.departamento = "Administrativo" Then
                i = 3
            ElseIf newAuditoria.departamento = "Soporte Técnico" Then
                i = 4
            ElseIf newAuditoria.departamento = "Relaciones Públicas" Then
                i = 5
            End If
        End If

        'Carga del texto de los comboBox de "newSoluciones"'
        newSoluciones.cbAnomalia_1.Text = newAudyProblemas.anomalia(i, 1)
        newSoluciones.cbAnomalia_2.Text = newAudyProblemas.anomalia(i, 2)
        newSoluciones.cbAnomalia_3.Text = newAudyProblemas.anomalia(i, 3)

        If Not isLoaded Then
            'Actualizacion del formulario "newReporte"'
            If newAuditoria.numero <> "" Then
                newReporte.rtbReporte.Text = "Auditoria numero: " + newAuditoria.numero + Chr(10) + Chr(10)
                newReporte.rtbReporte.Text += "Realizada por: " + newAuditoria.auditor + Chr(10) + Chr(10)
                newReporte.rtbReporte.Text += "Fecha de emisión " + newAuditoria.fecha + Chr(10) + Chr(10)
                newReporte.rtbReporte.Text += "De tipo: " + newAuditoria.tipo + Chr(10) + Chr(10)
            Else
                newReporte.rtbReporte.Text = ""
            End If
            If newAuditoria.dirigido <> "" Then
                newReporte.rtbReporte.Text += "Dirigida al " + newAuditoria.dirigido + ":" + Chr(10)
                newReporte.rtbReporte.Text += "El departamento evaluado fué el de " + newAuditoria.departamento + Chr(10)
            End If
            If newAuditoria.soluciones <> "" Then
                newReporte.rtbReporte.Text += "Reporte:" + Chr(10) + newAuditoria.soluciones
            End If
        End If
    End Sub

End Class

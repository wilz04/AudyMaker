Public Class AudyProblemas

    Private anomalias(15) As String
    Private soluciones(15) As String

    Public Sub New()
        'Anomalias:'

        anomalias(1) = "Mala administración"
        anomalias(2) = "Indiciplina"
        anomalias(3) = "Ocultamiento de Información"
        'recursos humanos'
        anomalias(4) = "Mal funcionamiento"
        anomalias(5) = "Indiciplina"
        anomalias(6) = "Trato preferencial"
        'administrativo'
        anomalias(7) = "Mala administración"
        anomalias(8) = "Indiciplina"
        anomalias(9) = "Ocultamiento de Información"
        'Soporte tecnico'
        anomalias(10) = "Mal uso de equipo"
        anomalias(11) = "Indiciplina"
        anomalias(12) = "Perdida de equipo"
        'relaciones publicas'
        anomalias(13) = "Maltrato a los clientes"
        anomalias(14) = "Indiciplina"
        anomalias(15) = "Trato preferencial"

        'Soluciones:'

        'gerencia'
        soluciones(1) = "Se recomienda tomar las medidas pertinentes para lograr una reorganización efectiva y asi mejorar las tareas administrativas de la empresa."
        soluciones(2) = "Revisar que tipo de actos son los que se presentan (llegadas tardias, desobligación con las tareas, mal comportamiento, entre otros) se recomienda una amonestación."
        soluciones(3) = "En este caso dicha falta se tomara como grave, se recomienda una amonestacion severa."
        'recursos humanos'
        soluciones(4) = "Se debe consultar que empleado la realizo, luego revizar en que perjudica a la empresa dicha contratación y tomar las medidas respactivas al empleado."
        soluciones(5) = "Revisar que tipo de actos son los que se presentan (llegadas tardias, desobligación con las tareas, mal comportamiento, entre otros) se recomienda una amonestación."
        soluciones(6) = "Preferiblemente vigilar a los empleados que trabajen en este departamento, ya que ultimamente se dan relaciones no autorizadas entre empleados y clientes, en caso de notar una irregularidad, favor aplicar la sanción correspondiente."
        'administrativo'
        soluciones(7) = "Se recomienda tomar las medidas pertinentes para lograr una reorganización efectiva y asi mejorar las tareas administrativas de la empresa."
        soluciones(8) = "Revisar que tipo de actos son los que se presentan (llegadas tardias, desobligación con las tareas, mal comportamiento, entre otros) se recomienda una amonestación."
        soluciones(9) = "En este caso dicha falta se tomara como grave, se recomienda una amonestacion severa."
        'Soporte tecnico'
        soluciones(10) = "Si se esta utilizando el equipo de la empreza para fines de lucro o personales independientes completamente a la misma, se recomienda una sanción segun el reglamento interno de la empresa."
        soluciones(11) = "Revisar que tipo de actos son los que se presentan (llegadas tardias, desobligación con las tareas, mal comportamiento, entre otros) se recomienda una amonestación."
        soluciones(12) = "En caso de que se note una perdida injustificada del equipo, ya sea informático o de otra índole, se recomienda realizar una investigación exaustiva para dar con el responsable y dar de baja de inmediato"
        'relaciones publicas'
        soluciones(13) = "Si el empleado encargado de este departamnento presenta una actitud pesada (prepotencia) hacia algun cliente, se recomienda dar una amonestación y añadirla a su expediente, con tres faltas de este tipo proceder a despedir"
        soluciones(14) = "Revisar que tipo de actos son los que se presentan (llegadas tardias, desobligación con las tareas, mal comportamiento, entre otros) se recomienda una amonestación."
        soluciones(15) = "Todas las personas (clientes/provedores) deben ser tratados de la misma manera sin preferencia alguna, en este caso se recomienda llamar la atención del empleado que ha incurrido en la falta, con la posibilidad de añadirlo en su expediente"
    End Sub

    Public Property anomalia(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Dim k As Integer
            k = (i - 1) * 3 + j
            Return anomalias(k)
        End Get
        Set(ByVal Value As String)

        End Set
    End Property

    Public Property solucion(ByVal i As Integer, ByVal j As Integer) As String
        Get
            Dim k As Integer
            k = (i - 1) * 3 + j
            Return soluciones(k)
        End Get
        Set(ByVal Value As String)

        End Set
    End Property

End Class

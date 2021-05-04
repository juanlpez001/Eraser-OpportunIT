# OpportunIT-TeamFelipe
Deseo tener un sistema de emparejamiento de mentores y aprendices, donde cada rol se registre (tanto mentores como aprendices) con sus datos básicos y habilidades, para el caso de los mentores conocimientos actuales que pueda enseñar y para los aprendices conocimientos que desean aprender; además permitir realizar el seguimiento de las reuniones diarias donde los aprendices deben definir lo que hicieron en el día, lo que van hacer al siguiente día y que problemas han tenido, en este espacio el mentor asignado puede dejar comentarios respondiendo a las dudas o guiando en el trabajo realizado.
Por otro lado, queremos tener la posibilidad de hacer feedback bidireccional de manera periódica tanto del mentor hacia los aprendices como los aprendices hacia el mentor y asignar un puntaje en una escala de 1 a 5, siendo 5 el puntaje más alto.
Los perfiles de las personas registradas deben tener información básica de contacto, una descripción breve, lista de conocimientos que pueden enseñar y que buscan aprender respectivamente, links de linkedin y github si aplica.
Finalmente deseamos tener reportes de los aprendices con un campo de mentor en caso de que lo tengan asignado o vacío si están en proceso de asignación, reuniones diarias filtradas por aprendiz, usuarios registrados con rol y promedio de calificación de feedback.
Requerimientos
    •	Periodicidad del feedback puede ser parametrizable.
    •	Un mentor puede tener máximo 8 aprendices.
    •	Un aprendiz puede tener máximo un mentor.
    •	Los mentores pueden ver los aprendices libres y registrarlos para hacer mentoría.
    •	Los aprendices pueden solicitar un mentor con los conocimientos que desean aprender.
    •	Las alertas llegan vía email (asignación de mentor, solicitud de mentor, reuniones, etc)
    •	Si un mentor se da de baja en el sistema notificar sobre los aprendices que quedaron libres al administrador para nuevas asignaciones de mentores.
    •	Si un aprendiz se da de baja notificar al administrador y al tutor que tenía asignado.
    •	Las reuniones diarias deben tener estado leído o sin leer para que los mentores puedan gestionarlas.
Reto
    •	Tener un foro de preguntas y respuestas con la posibilidad de compartir código formateado (similar a stackoverflow).
    •	Reuniones dentro del sistema a través de API.
    •	Chat interno.

Prueba hotel excede

Respuestas instrucciones:


1. rta: desarrollo en .netframwrok 4.8 con el fin de agilizar el proceso en las 3 horas dadas.
2. rta: se creo el modelo de datos en SQL SERVER
3. rta: se uso visual studio 2022
4. rta: Se realizo el uso del patron MVC, Model - vista - controlador, es donde la interface de usuario se representa a traves de la vista, la cual se conecta a un modelo de datos por medio de entityframework desde los controladores.

6. rta: Instrucciones de ejecucion de la solucion

1. Dentro de la solucion se encuentra una carpeta con el nombre SQl, donde esta el script de creacion de base de datos
2. La cadena de conexion LLAMADA ModeloHotel se encuentra en el achivo web.config donde va a poder cambiar el servidor sql, usuario y contraseña para conectarse a la base de datos creada con el paso N. 1
3. Para ejecutqr el aplicativo lo puede realizar dentro de visual studio, se uso visual studio 2022, o en caso de que tenga habilitada la caracteristica de IIS:
3.1. crear carpeta para la publicacion del sitio
3.2. crear dentro del IIS un sitio con .netframework 4 o superior, que apunte a la carpeta creada en el punto 3.1
3.3. asignar un puerto al sitio creado
3.4. Abrir el proyecto, darle click derecho a la solucion en la opcion de publish apuntando a la carpeta creada en el punto 3.1.
3.5. para visualizar el sitio debe de en el navegado escribit http:\\localhost:{el puerto asignado en el punto 3.3.}

6.1. Dentro del repositorio encontrara el archivo evidencias.docx donde se colocaran los printscreen del sitio en funcionamiento local.

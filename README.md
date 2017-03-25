# TimeTablingProject
TTP Project


*Analisis de la web app:

	- La app esta dividida en diferentes capas DAL, CORE, Application y WebApplication.
	- Las capas estan ensambladas por dependencias.
	- Las tecnologias a usar han sido, ASP.NET y c# para la programacion.
	- Hemos usado otras librerias javascript con jquery para el manejo de tablas con 
		DataTables, asi como bootstrap para diseño y css.
	- Hemos utilizado 2 niveles de seguridad, el administrativo y el usuario Profesor.
	- El sistema muestra los errores de cada formulario.
	- Uso de EntityFramework con Code First O.

*Manual Usuario:

	- Se puede distinguir diferentes tipos de usuarios y su listado nada mas loguearse.
	- Al iniciar como administrador de la app, podras crear asignaturas y ver un listado
general de las asignaturas con profesores o en su defecto, detalles de las asignaturas si se necesita.
	- Al iniciar la app como usuario Profesor, podremos ver todas las listas de asignaturas
a las que nos podemos unir, tendremos que clicar en un identificador de la timetable de asignaturas,
para ello, veremos un formulario que nos obligara escribir y crear una serie de condiciones
que cumpla para esa asignatura un dia de la semana, y se le asociara a ese profesor por nombre, 
tambien podria ser por id.
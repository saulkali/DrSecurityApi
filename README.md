# DrSecurityApi
DrSecurity api

##Descripcion Breve
### la api solo retorna un crud de la tabla de Usuario y tarjeta cumpliendo sus 4 metodos (get,delete,put,post), tiene como base de datos SQL Server usando el orm de entity framework para el mapeo de la base de datos.

## funciones
### Eliminar, Editar, Crea y Consulta usuarios desde la siguiente url
> /api/Usuario   => (get) retorna todos los usuarios

> /api/Usuario/{id}  => (get) retorna solo el usuario con dicho id

> /api/Usuario/{id} => (Delete) eliminar el usuario y no retorna por el momento nada en el cuerpo

>/api/Usuairo/{id} => (Put) actualiza los datos del usuario el id se pasa mediante el url y los datos mediante el body de la peticion http

>/api/Usuario => (Post) crea un nuevo usuario los datos se envian mediante el body en json con la estrctura de la entidad Usuario

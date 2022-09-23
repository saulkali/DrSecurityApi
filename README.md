# DrSecurityApi
DrSecurity api

## Descripcion Breve
### Creacion de una api rest con asp core API, aplicando el orm Entity Framework el cual conlleva las operaciones con la base de datos sql server, se desarrollo una api la cual retorna dos modelos Usuario y Tarjeta con un crud simple (get,post,put,delete).

## funciones
### Eliminar, Editar, Crea y Consulta usuarios desde la siguiente url
> /api/Usuario   => (get) retorna todos los usuarios

> /api/Usuario/{id}  => (get) retorna solo el usuario con dicho id

> /api/Usuario/{id} => (Delete) eliminar el usuario y no retorna por el momento nada en el cuerpo

>/api/Usuairo/{id} => (Put) actualiza los datos del usuario el id se pasa mediante el url y los datos mediante el body de la peticion http

>/api/Usuario => (Post) crea un nuevo usuario los datos se envian mediante el body en json con la estrctura de la entidad Usuario

### esto tambien aplica para el crud de tarjetas solo cambiando la direccion url
> /api/Tarjeta

al igual core api tiene su documentacion automatica que se ejecuta de manera automatica al ejecutar la api.

## Como instalarlo
primera manera es importandolo directo de git en visual studio, al inicar visual studio, nos otorga la funcion de clonar un repositorio

![alt text](https://i.ytimg.com/vi/c4nuFjV9yms/maxresdefault.jpg)
 le otorgas la url de este repositorio, y automaticamente y por teoria tendria que instalar todo.

### configurar base de datos
en la raiz del proyecto se encuentra un json.
> appsettings.json

Con el siguiente formato
 {
   "ConnectionStrings:{
     "drsecurity": "Server= <nombre servidor> ; Database=DrSecurity; Trusted_Connection=True;"
   },
    "Loggin":{
     .......
    }
 }
  
  
donde debemos poner nuestra conexion a la base de datos.

### Cargar backup de base de datos
dentro del proyecto en la raiz se encuentra un archivo llamado DrSecurity.bak, es el backup de la base de datos, el cual se puede cargar en SQL Server Management. para evitar crear toda la base de datos desde 0.  
  
![alt text](https://learn.microsoft.com/es-es/sql/relational-databases/backup-restore/media/quickstart-backup-restore-database/backup-db-ssms.png?view=sql-server-ver16)
  
darle en la carpeta database click derecho y en la opcion task se encuentra el de restore, aqui se puede cargar la copia de seguridad de la base de datos.
 
 
 ## bugs
 > en si no le vi un bug pero me gustaria poder ver mejorado el retorno de la respuesta a una mejor estructurada por ejemplo una clase que guarde el status un mensaje de error y los datos en tipo lista con esto podria tener el front end un mensaje de error en la api mas especifico, junto con la respusta y el listado de datos.
> todos los origenes son aceptados pero solo es por fines practicos.
 

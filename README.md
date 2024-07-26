# API para el Control de Alumnos

Esta API está diseñada para gestionar y mantener una tabla de alumnos en un sistema de administración de colegio. Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los registros de alumnos.

## Endpoints

### Obtener todos los alumnos

- **URL**: `/api/alumnos`
- **Método**: `GET`
- **Descripción**: Obtiene una lista de todos los alumnos.
- **Respuesta**:
  - **Código de estado**: `200 OK`
  - **Cuerpo**: Lista de objetos `Alumno`.

### Obtener un alumno por ID

- **URL**: `/api/alumnos/{id}`
- **Método**: `GET`
- **Descripción**: Obtiene un alumno específico por su ID.
- **Parámetros**:
  - `id` (path): El ID del alumno.
- **Respuesta**:
  - **Código de estado**: `200 OK`
  - **Cuerpo**: Objeto `Alumno` correspondiente al ID.
  - **Código de estado**: `404 Not Found` si el alumno no existe.

### Actualizar un alumno

- **URL**: `/api/alumnos/{id}`
- **Método**: `PUT`
- **Descripción**: Actualiza los datos de un alumno específico.
- **Parámetros**:
  - `id` (path): El ID del alumno a actualizar.
- **Cuerpo de la solicitud**:
  - Objeto `Alumno` con los datos actualizados.
- **Respuesta**:
  - **Código de estado**: `204 No Content` si la actualización es exitosa.
  - **Código de estado**: `400 Bad Request` si el ID en la URL no coincide con el ID en el cuerpo de la solicitud.
  - **Código de estado**: `404 Not Found` si el alumno no existe.

### Crear un nuevo alumno

- **URL**: `/api/alumnos`
- **Método**: `POST`
- **Descripción**: Crea un nuevo registro de alumno.
- **Cuerpo de la solicitud**:
  - Objeto `Alumno` con los datos del nuevo alumno.
- **Respuesta**:
  - **Código de estado**: `201 Created`
  - **Cuerpo**: Objeto `Alumno` creado con su ID.
  - **Ubicación**: URL del nuevo recurso en el encabezado `Location`.

### Eliminar un alumno

- **URL**: `/api/alumnos/{id}`
- **Método**: `DELETE`
- **Descripción**: Elimina un alumno específico por su ID.
- **Parámetros**:
  - `id` (path): El ID del alumno a eliminar.
- **Respuesta**:
  - **Código de estado**: `204 No Content` si la eliminación es exitosa.
  - **Código de estado**: `404 Not Found` si el alumno no existe.

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/tu-repositorio.git

# EmpresaApi
🚀 API REST de Empleados y Productos (ASP.NET Core)
Descripción del Proyecto : Este es un proyecto de API REST desarrollado con ASP.NET Core 7/8 que permite consultar información clave de la empresa, 
como datos de empleados y productos, mediante una serie de endpoints asíncronos (async/await) utilizando un patrón de Repositorio y Entity Framework Core.
## 🌟 Objetivos de la API
La API REST de Empleados y Productos fue diseñada para cumplir con los siguientes propósitos principales:

Consulta de Empleados: Exponer información detallada de los empleados, permitiendo un filtrado eficiente por identificador (ID), nombre completo, país de residencia y cálculo de antigüedad (empleado de mayor edad).

Estadísticas Laborales: Proporcionar métricas de la fuerza laboral mediante el cálculo del conteo de empleados agrupados por título/puesto.

Consulta de Productos: Facilitar la obtención de información de productos con sus respectivas categorías asociadas (mediante joins implícitos de Entity Framework Core).

Cumplimiento de Especificaciones: Asegurar que todos los parámetros de filtrado se manejen correctamente a través del binding [FromQuery] y que todas las operaciones de acceso a datos sean asíncronas (async/await).

### 🛠️ Tecnologías Utilizadas
Framework: ASP.NET Core
APILenguaje: C#
Acceso a Datos: Entity Framework 
CorePatrón: Inyección de Dependencias (DI) 
Repositorio.Base de Datos: SQLite 

#### ⚙️ Configuración y Ejecución Local 
Sigue estos pasos para levantar la API en tu entorno de desarrollo.

Prerrequisitos
Asegúrate de tener instalado en tu sistema:

SDK de .NET: Versión 7.0 o superior (Verifica ejecutando dotnet --version en la terminal).

Editor de Código: Visual Studio o VS Code con las extensiones y herramientas de C#.

Pasos para Ejecutar
Clonar el Repositorio:

Navegar al Directorio del Proyecto:

Restaurar Dependencias: Descarga todos los paquetes NuGet necesarios para el proyecto.

Ejecutar la Aplicación: Compila y ejecuta la API. Esto iniciará el servidor Kestrel.

La API se iniciará y estará disponible, por defecto, en https://localhost:7000 (el puerto puede variar ligeramente).

Acceder a Swagger/OpenAPI (Documentación): Una vez que la aplicación esté en funcionamiento, abre tu navegador y navega a la URL de Swagger para ver y probar interactivamente todos los endpoints disponibles:

##### 🧭 Endpoints Disponibles (Consulta de Empleados)
GET /api/Empleados/TodosLosEmpleados: Devuelve la lista completa de empleados.

GET /api/Empleados/CantidadEmpleados: Devuelve el número total de empleados en la empresa.

GET /api/Empleados/EmpleadoPorID?empleadoID={id}: Devuelve la información de un empleado a partir de su ID.

GET /api/Empleados/EmpleadosPorNombre?nombreEmpleado={nombre}: Devuelve el empleado cuyo nombre coincida con el valor ingresado.

GET /api/Empleados/IDempleadoPorTitulo?titulo={puesto}: Devuelve el empleado que ocupa el puesto indicado.

GET /api/Empleados/EmpleadoPorPais?country={país}: Devuelve un empleado que viva en el país especificado.

GET /api/Empleados/TodosLosEmpleadosPorPais?country={país}: Devuelve todos los empleados de un país determinado.

GET /api/Empleados/ElEmpleadoMasGrande: Devuelve el empleado de mayor edad



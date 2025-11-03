# EmpresaApi
🚀 API REST de Empleados y Productos (ASP.NET Core)
Descripción del Proyecto : Este es un proyecto de API REST desarrollado con ASP.NET Core 7/8 que permite consultar información clave de la empresa, 
como datos de empleados y productos, mediante una serie de endpoints asíncronos (async/await) utilizando un patrón de Repositorio y Entity Framework Core.
La API cumple con los siguientes objetivos:
Exponer información de empleados con filtrado por ID, nombre, país y antigüedad.
Proporcionar estadísticas de la fuerza laboral (conteo por título).
Consultar información de productos con sus categorías asociadas.Todos los parámetros de consulta se manejan mediante [FromQuery].

## 🛠️ Tecnologías Utilizadas
Framework: ASP.NET Core
APILenguaje: C#
Acceso a Datos: Entity Framework 
CorePatrón: Inyección de Dependencias (DI) 
Repositorio.Base de Datos: SQLite 

### ⚙️ Configuración y Ejecución LocalSigue estos pasos para levantar la API en tu entorno local.
Prerequisitos : Asegúrate de tener instalado:SDK de .NET: Versión 7.0 o superior (Verifica con dotnet --version).Visual Studio / VS Code: Con las herramientas de C#.
Pasos para Ejecutar: 
1.Clonar el Repositorio: [(https://github.com/virginia-garcia/EmpresaApi.git)]
2.cd EmpresaApi
3.Restaurar Dependencias:Bashdotnet restore
4.Ejecutar la Aplicación:Bashdotnet run
La API se iniciará y estará disponible, por defecto, en https://localhost:7000 
5.Acceder a Swagger/OpenAPI:Abre tu navegador y navega a la URL de Swagger para ver y probar todos los endpoints disponibles:https://localhost:7000/swagger/index.html

#### 🧭 Endpoints Disponibles
o	GET api/TodosLosEmpleados: Devuelve la lista completa de empleados.
o	GET api/CantidadEmpleados: Devuelve el número total de empleados en la empresa.
o	GET api/EmpleadoPorID?empleadoID=5: Devuelve la información de un empleado a partir de su ID.
o	GET api/EmpleadosPorNombre?nombreEmpleado=””: Devuelve el empleado cuyo nombre coincida con el valor ingresado.
o	GET api/IDempleadoPorTitulo?titulo=Manager: Devuelve el empleado que ocupa el puesto indicado.
o	GET api/EmpleadoPorPais?country=””: Devuelve un empleado que viva en el país especificado.
o	GET api/TodosLosEmpleadosPorPais?country=””: Devuelve todos los empleados de un país determinado.
o	GET api/ElEmpleadoMasGrande: Devuelve el empleado de mayor edad.



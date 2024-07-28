<p align="center">
  <img src="https://simpleicons.org/icons/dotnet.svg" style="filter:invert(1);" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">Domain Driven Design Aplicando CQRS</h1>
</p>
<p align="center">
    <em>¡Gestión Ágil de Clientes usando la Arquitectura Domain Driven Design!</em>
</p>
<p align="center">
	<img src="https://img.shields.io/github/license/juansdev/DDD?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/juansdev/DDD?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/juansdev/DDD?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/juansdev/DDD?style=default&color=0080ff" alt="repo-language-count">
<p>
<p align="center">
	<!-- default option, no dependency badges. -->
</p>

<br><!-- TABLE OF CONTENTS -->
<details>
  <summary>Tabla de Contenidos</summary><br>

- [ Resumen](#-resumen)
- [ Características](#-características)
- [ Estructura del Repositorio](#-estructura-del-repositorio)
- [ Módulos](#-módulos)
- [ Comenzando](#-comenzando)
    - [ Instalación](#-instalación)
    - [ Uso](#-uso)
    - [ Pruebas](#-pruebas)
</details>
<hr>

##  RESUMEN

Aplicación Domain Driven Design aplicando CQRS

La aplicación aprovecha el Diseño Orientado al Dominio y la Segregación de Responsabilidades de Comandos y Consultas (DDD-CQRS). La capa del dominio central incluye la gestión de Clientes con métodos para operaciones CRUD utilizando el ICustomerRepository. La identidad del Cliente se maneja utilizando identificadores Guid globalmente únicos. Los ValueObjects incluyen comprobaciones de conformidad del formato del Número de Teléfono y validación de Dirección con una clase de registro inmutable para la consistencia de la persistencia de datos.

Externamente, el soporte de MySQL y EntityFrameworkCore se incorpora dentro de la capa de Infraestructura, asegurando una comunicación fluida con la base de datos a través de la inyección de dependencias en ASP.NET Core Web API. ApplicationDbContext maneja las operaciones de la base de datos, mientras que CustomerConfiguration configura el esquema para las entidades de cliente. Las migraciones gestionan la evolución del esquema para la tabla de Clientes con campos esenciales, clave primaria e índices para facilitar una interacción eficiente dentro de nuestra arquitectura.

---

##  Características

| Característica          | Descripción                                                                                                                           |
|-------------------------|---------------------------------------------------------------------------------------------------------------------------------------|
| Arquitectura            | Un proyecto .NET que implementa el Diseño Orientado al Dominio (DDD) y el patrón de Segregación de Responsabilidades de Comandos y Consultas (CQRS) para una modularidad organizada. |
| Calidad del Código      | Código bien estructurado, limpio y legible siguiendo los estándares de codificación establecidos en .NET, con una correcta organización de espacios de nombres, clases y métodos. |
| Integraciones           | Dependencia de MediatR para la gestión eficiente de comandos y consultas, así como FluentValidation para la validación de datos. |
| Modularidad             | La estructura modular permite un fácil mantenimiento y escalabilidad al separar la aplicación en capas distintas: dominio, aplicación e infraestructura. |
| Pruebas                 | Pruebas unitarias gestionadas a través de configuraciones dentro de las sesiones de prueba en archivos de prueba unitaria, como `CreateCustomerCommandHandlerUnitTests`. |
| Rendimiento             | Eficiencia optimizada utilizando prácticas de rendimiento de .NET y adherencia a patrones; el uso de recursos debe ser comparable a proyectos similares de la misma escala. |
| Seguridad               | No se discuten medidas de seguridad específicas dentro de los archivos del proyecto proporcionados, por lo que se asume que no se implementan mecanismos de protección explícitos. |
| Dependencias            | Las dependencias principales incluyen `sln`, `cs`, `csproj`, `user` y varias bibliotecas del marco .NET para la funcionalidad de la aplicación. |

---

##  Estructura del Repositorio

```sh
└── DDD/
    ├── netDDD-CQRS.sln
    ├── netDDD-CQRS.sln.DotSettings.user
    ├── src
    │   ├── Application
    │   ├── Domain
    │   ├── Infrastructure
    │   └── Web.API
    └── tests
        └── UnitTests
```

---

##  Módulos

<details closed><summary>.</summary>

| Archivo                                                                                                          | Resumen                                                                                                                                                                                                                                                                                               |
| ---                                                                                                              | ---                                                                                                                                                                                                                                                                                                   |
| [netDDD-CQRS.sln.DotSettings.user](https://github.com/juansdev/DDD/blob/master/netDDD-CQRS.sln.DotSettings.user) | Gestiona las sesiones de prueba dentro de las pruebas unitarias para nuestra Aplicación de Dominio. Al definir estados de sesión, este archivo de configuración agiliza el proceso de ejecución para CreateCustomerCommandHandlerUnitTests, asegurando pruebas continuas sin problemas durante el ciclo de desarrollo. |
| [netDDD-CQRS.sln](https://github.com/juansdev/DDD/blob/master/netDDD-CQRS.sln)                                   | Debug|

</details>

<details closed><summary>src.Application</summary>

| Archivo                                                                                                                         | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                             |----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Application/DependencyInjection.cs)                   | Habilita la inyección de dependencias para MediatR y FluentValidation en la aplicación dada. Registra implementaciones de servicios de los ensamblados relevantes para asegurar una interacción fluida con las capas de lógica de negocio. Facilita el uso de pipelines de validación y validadores para mantener la integridad de los datos en los componentes de la aplicación.                                          |
| [ApplicationAssemblyReference.cs](https://github.com/juansdev/DDD/blob/master/src/Application/ApplicationAssemblyReference.cs) | Compila y referencia los ensamblados clave de la aplicación dentro de la arquitectura Net DDD-CQRS, agilizando su modularidad y escalabilidad. Esto asegura una integración fluida con otras capas, incluyendo dominio e infraestructura, manteniendo una estructura de solución limpia y organizada para el proyecto de la API web.                                                                                       |
| [Application.csproj](https://github.com/juansdev/DDD/blob/master/src/Application/Application.csproj)                           | Implementa la lógica de aplicación para las operaciones de clientes en un proyecto .NET 7 basado en Diseño Orientado al Dominio (DDD) y Segregación de Responsabilidades de Comandos y Consultas (CQRS). Utiliza MediatR, FluentValidation, EntityFrameworkCore y ErrorOr para asegurar la validez y consistencia de los datos. Presenta carpetas para comandos relacionados con Delete, GetAll, GetById y Update. |

</details>

<details closed><summary>src.Application.Customers.GetById</summary>

| Archivo                                                                                                                                         | Resumen                                                                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                     |
| [GetCustomerByIdQuery.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetById/GetCustomerByIdQuery.cs)               | Potencia la recuperación de datos impulsada por el usuario dentro de la arquitectura de la aplicación DDD-CQRS. Al aprovechar la biblioteca MediatR, la clase GetCustomerByIdQuery permite la extracción fluida de detalles de CustomerResponse para un Id dado desde el módulo de Clientes. Esta interacción eficiente soporta un flujo de trabajo flexible y escalable en la aplicación. |
| [GetCustomerByIdQueryHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetById/GetCustomerByIdQueryHandler.cs) | Maneja las consultas de clientes recuperando datos específicos del cliente desde el repositorio, construyendo un objeto `CustomerResponse` y devolviéndolo al solicitante cuando se encuentra un Id coincidente. Contribuye a la capa de aplicación en la arquitectura DDD-CQRS, asegurando una experiencia fluida para la interacción del usuario con la API de Clientes.   |

</details>

<details closed><summary>src.Application.Customers.GetAll</summary>

| Archivo                                                                                                                                        | Resumen                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                             |
| [GetAllCustomersQueryHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetAll/GetAllCustomersQueryHandler.cs) | Ejecuta una consulta para recuperar todas las respuestas de los clientes en una aplicación estructurada con CQRS. Implementa el GetAllCustomersQueryHandler, manejando GetAllCustomersQuery y comunicándose con el ICustomerRepository para obtener los datos de los clientes, mapeándolos en objetos CustomerResponse.                                             |
| [GetAllCustomersQuery.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetAll/GetAllCustomersQuery.cs)               | Este archivo (GetAllCustomersQuery.cs) en nuestra capa de aplicación orquesta la recuperación de todos los registros de clientes desde la base de datos a través del patrón MediatR y devuelve una colección como Error-or-proof IReadOnlyList de objetos CustomerResponse, mejorando nuestra arquitectura CQRS para una gestión de clientes eficiente y confiable. |

</details>

<details closed><summary>src.Application.Customers.Update</summary>

| Archivo                                                                                                                                                 | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [UpdateCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommandHandler.cs)         | Facilita la actualización de los detalles del cliente en una arquitectura escalable impulsada por CQRS manejando `UpdateCustomerCommand` utilizando MediatR, asegurando la validación y la interacción con el `CustomerRepository`. Las acciones incluyen verificar la existencia, la validez del número de teléfono y la dirección, actualizar los datos del cliente y guardar los cambios en la base de datos.                                      |
| [UpdateCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommandValidator.cs)     | Valida los comandos de actualización de clientes entrantes, asegurando la consistencia y corrección antes de que lleguen a la lógica de negocio en la capa de aplicación de nuestra arquitectura DDD-CQRS. La validación incluye comprobaciones estrictas para los campos requeridos (por ejemplo, id del cliente, nombre), límites de longitud máxima para cada campo, tipos de datos adecuados (formato de correo electrónico, número de teléfono, código postal) y asegura que los atributos necesarios estén presentes (por ejemplo, bandera de activo). |
| [UpdateCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommand.cs)                       | Facilita la actualización de datos del cliente dentro del sistema construyendo un objeto `UpdateCustomerCommand` que contiene atributos esenciales como Id, Nombre, Correo Electrónico, Número de Teléfono y detalles de la Dirección, adhiriéndose al patrón Command utilizando MediatR. Esta acción ayuda a asegurar información precisa del cliente en la arquitectura de la Aplicación DDD-CQRS.                                                                           |

</details>

<details closed><summary>src.Application.Customers.Common</summary>

| Archivo                                                                                                                  | Resumen                                                                                                                                                                                                                                                                                                                                               |
| ---                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                                   |
| [CustomerResponse.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Common/CustomerResponse.cs) | CustomerResponse. Consolida los detalles esenciales del cliente, como ID, nombre, correo electrónico, número de teléfono y dirección. La `AddressResponse` incluida ofrece país, líneas de calle, ciudad, estado y código postal. Estos registros de respuesta contribuyen a una experiencia de aplicación más unificada en toda la arquitectura netDDD-CQRS, específicamente en la `Web.API`. |

</details>

<details closed><summary>src.Application.Customers.Create</summary>

| Archivo                                                                                                                                                 | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CreateCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommand.cs)                       | En este directorio de Aplicación dentro de nuestra solución CQRS de Diseño Orientado al Dominio (DDD), el CreateCustomerCommand realiza la tarea esencial de aceptar la entrada del usuario para crear un nuevo registro de cliente. Al proporcionar detalles clave como nombre, correo electrónico, número de teléfono e información de dirección, permite a la aplicación poblar su entidad Cliente con datos bien estructurados. Este comando utiliza MediatR para iniciar los flujos de procesamiento apropiados, asegurando una experiencia sin problemas para el usuario. |
| [CreateCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommandValidator.cs)     | Asegura que se proporcionen campos esenciales como nombre, apellido, correo electrónico, número de teléfono, país y direcciones, mientras mantiene restricciones de longitud de cadena, valida formatos de correo electrónico y números de teléfono, y proporciona una experiencia optimizada de creación de clientes.                                                                                                                                                                                                                             |
| [CreateCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommandHandler.cs)         | Maneja las solicitudes de los usuarios para crear nuevas entidades de clientes dentro de la capa de aplicación en este repositorio de diseño orientado al dominio, asegurando la integridad de los datos a través de reglas de validación y persistencia con repositorios y unidad de trabajo.                                                                                                                                                                                                                                                 |

</details>

<details closed><summary>src.Application.Customers.Delete</summary>

| Archivo                                                                                                                                                 | Resumen                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                              |
| [DeleteCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommand.cs)                       | En el repositorio netDDD-CQRS, el DeleteCustomerCommand en la carpeta Application/Customers/Delete es una solicitud que inicia la eliminación de un registro específico de un cliente. El comando utiliza MediatR y lleva un ID del cliente objetivo, facilitando la modificación eficiente y estructurada de los datos dentro de la aplicación. |
| [DeleteCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommandHandler.cs)         | En esta carpeta de Aplicación se encuentra el archivo DeleteCustomerCommandHandler. Este manejador procesa las solicitudes de Delete Customer Command dentro del dominio de Clientes, eliminando el cliente especificado y guardando los cambios utilizando IUnitOfWork, asegurando una gestión de datos eficiente e integridad en la arquitectura general DDD-CQRS.       |
| [DeleteCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommandValidator.cs)     | En este código a nivel de aplicación, se define una regla de validación para DeleteCustomerCommand, asegurando que el comando contenga un campo Id que no esté vacío antes de proceder con su ejecución. Esto refuerza la integridad de los datos de entrada dentro de la capa de Dominio en nuestra arquitectura API estructurada CQRS/DDD.                                |

</details>

<details closed><summary>src.Application.Data</summary>

| Archivo                                                                                                                | Resumen                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                              |
| [IApplicationDbContext.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Data/IApplicationDbContext.cs) | Gestiona el almacenamiento de datos de la aplicación definiendo una interfaz para el `IApplicationDbContext`. Esta interfaz describe una conexión a la base de datos a través de `DbSet<Customer>` y ofrece el método `SaveChangesAsync` para guardar los cambios dentro del contexto, esencial para mantener y organizar los datos de los clientes dentro de nuestra aplicación de Segregación de Responsabilidades de Comandos y Consultas (CQRS). |

</details>

<details closed><summary>src.Application.Common.Behaviors</summary>

| Archivo                                                                                                                       | Resumen                                                                                                                                                                                                                                                                                                       |
| ---                                                                                                                         | ---                                                                                                                                                                                                                                                                                                           |
| [ValidationBehavior.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Common/Behaviors/ValidationBehavior.cs) | ValidationBehavior asegura la validación adecuada de datos en todas las solicitudes de la aplicación dentro del repositorio. Esto se logra empleando FluentValidation, MediatR y el manejo de errores para escenarios de solicitudes inválidas. Esto optimiza el pipeline de procesamiento de datos en la arquitectura netDDD-CQRS para minimizar errores. |

</details>

<details closed><summary>src.Web.API</summary>

| Archivo                                                                                                                         | Resumen                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                          | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [appsettings.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/appsettings.json)                                 | El archivo `appsettings.json` ajusta los niveles de registro de la aplicación (para facilitar la depuración) y permite el acceso desde cualquier host (*), lo cual es vital para un despliegue sin problemas dentro de nuestra arquitectura basada en Diseño Orientado al Dominio y CQRS.                                                                                                                                                                                                                                          |
| [Web.API.csproj](https://github.com/juansdev/DDD/blob/master/src/Web.API/Web.API.csproj)                                     | El archivo proporcionado configura un proyecto Web API de .NET dentro del repositorio DDD-CQRS. Hace referencia a las dependencias necesarias como Entity Framework Core y Swagger, así como especificaciones OpenAPI para documentación. Este proyecto API sirve para conectar clientes externos con la lógica de negocio central contenida en la Aplicación y servicios de infraestructura encapsulados en la carpeta Infrastructure.                                                                       |
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/DependencyInjection.cs)                     | Configura las dependencias de la aplicación para los servicios de la capa de presentación dentro del proyecto Web API. Las características clave incluyen la configuración de Swagger para la documentación de la API, el registro de controladores, el middleware de manejo de errores y la integración con el explorador de endpoints, enriqueciendo la funcionalidad de la API y la experiencia del usuario.                                                                                                                                                                          |
| [PresentationAssemblyReference.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/PresentationAssemblyReference.cs) | Establece la referencia de ensamblado dentro del proyecto Web.API, esencial para una integración sin problemas entre componentes, asegurando una arquitectura coherente según la estructura de la solución DDD-CQRS.                                                                                                                                                                                                                                                                                          |
| [Program.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Program.cs)                                             | Lanza una web API dentro de la arquitectura de la aplicación DDD-CQRS más grande. Implementa la inyección de dependencias configurando capas de servicio y middlewares. Facilita el manejo de excepciones, la autorización y la integración con la documentación de Swagger. Inicia la migración si está en un entorno de desarrollo. Proporciona una plataforma para que los controladores definan endpoints.                                                                                                               |
| [appsettings.Development.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/appsettings.Development.json)         | Configura la conexión a la base de datos y los ajustes de registro para la aplicación web API dentro de la arquitectura del proyecto DDD-CQRS, permitiendo un almacenamiento de datos eficiente y manejo de errores a través de los servicios.                                                                                                                                                                                                                                                                                       |

</details>

<details closed><summary>src.Web.API.Middlewares</summary>

| Archivo                                                                                                                                             | Resumen                                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                                                                            |
| [GlobalExceptionHandlingMiddleware.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Middlewares/GlobalExceptionHandlingMiddleware.cs) | Aumenta la resiliencia en nuestra API al manejar errores inesperados de manera elegante. El GlobalExceptionHandlingMiddleware captura excepciones y devuelve detalles estructurados del problema junto con los códigos de estado HTTP apropiados para mejorar la experiencia del usuario y las capacidades de resolución de problemas. Esto asegura que la aplicación se mantenga confiable mientras se adhiera a las mejores prácticas RESTful. |

</details>

<details closed><summary>src.Web.API.Extensions</summary>

| Archivo                                                                                                                | Resumen                                                                                                                                                                                                                                                      |
| ---                                                                                                                 | ---                                                                                                                                                                                                                                                          |
| [MigrationExtensions.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Extensions/MigrationExtensions.cs) | Aumenta la funcionalidad de la base de datos de las aplicaciones al ejecutar migraciones. Ubicado dentro de la carpeta de Extensiones de la Web API, este código mejora la capa de infraestructura del proyecto, asegurando una integración sin problemas con el ApplicationDbContext al iniciar. |

</details>

<details closed><summary>src.Web.API.Properties</summary>

| Archivo                                                                                                          | Resumen                                                                                                                                                                                                               |
| ---                                                                                                           | ---                                                                                                                                                                                                                   |
| [launchSettings.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/Properties/launchSettings.json) | Configura los ajustes de lanzamiento de la aplicación para el desarrollo, ofreciendo acceso a localhost a través de HTTP, HTTPS y IIS Express para el proyecto Web API dentro del repositorio DDD-CQRS, optimizando el proceso de pruebas y depuración. |

</details>

<details closed><summary>src.Web.API.Common.Http</summary>

| Archivo                                                                                                                 | Resumen                                                                                                                                                                                                                                                                    |
| ---                                                                                                                  | ---                                                                                                                                                                                                                                                                        |
| [HttpContextItemKeys.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Common/Http/HttpContextItemKeys.cs) | Optimiza el manejo de errores para las respuestas de la API al definir una clave constante de errores para los elementos del contexto HTTP, integrándose perfectamente con la capa Web.API de este proyecto de arquitectura de diseño impulsado por el dominio (DDD) y CQRS, promoviendo una comunicación API más limpia y organizada. |

</details>

<details closed><summary>src.Web.API.Common.Errors</summary>

| Archivo                                                                                                                                   | Resumen                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                                                                                                    |
| [NetDDDProblemDetailsFactory.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Common/Errors/NetDDDProblemDetailsFactory.cs) | Gestiona el manejo de errores para la capa de la API de la aplicación. NetDDDProblemDetailsFactory personaliza y mejora las respuestas de error al establecer metadatos relevantes, incluidos identificadores de seguimiento, detalles de errores específicos del cliente y códigos de error personalizados cuando sea necesario, mejorando el diagnóstico de errores en la WebAPI. |

</details>

<details closed><summary>src.Web.API.Controllers</summary>

| Archivo                                                                                                                 | Resumen                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                  | ---                                                                                                                                                                                                                                                                                                                                                         |
| [CustomersController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/CustomersController.cs) | Optimiza el proceso de creación de clientes a través de solicitudes API. Aprovecha MediatR para la mensajería y el despacho de comandos, asegurando una arquitectura escalable en la API web.                                                                                                                                                              |
| [ErrorsController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/ErrorsController.cs)       | Este código define un mecanismo de manejo de errores para la API de la aplicación en la capa `Web.API`. El `ErrorsController` captura excepciones aprovechando `IExceptionHandlerFeature`. Transforma estas excepciones en respuestas de Problemas, asegurando una gestión eficiente y elegante de fallos, mejorando en última instancia la fiabilidad de la aplicación.               |
| [ApiController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/ApiController.cs)             | En esta solución Web API, el archivo `ApiController.cs` mejora el manejo de errores para las solicitudes entrantes mediante la implementación de detalles de problemas personalizados. Al encontrar un error, proporciona respuestas significativas con códigos de estado apropiados, mejorando efectivamente la resiliencia general de la aplicación y la experiencia del usuario dentro de la arquitectura DDD-CQRS. |

</details>

<details closed><summary>src.Domain</summary>

| Archivo                                                                                  | Resumen                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                   | ---                                                                                                                                                                                                                                                                                                                                       |
| [Domain.csproj](https://github.com/juansdev/DDD/blob/master/src/Domain/Domain.csproj) | El archivo `src/Domain/Domain.csproj` configura un proyecto para gestionar el dominio central de la aplicación. Integra ErrorOr y MediatR, lo que permite un manejo eficiente de errores y la gestión de operaciones comerciales a través de comandos, fortaleciendo aún más la arquitectura de la aplicación basada en los principios de Diseño Guiado por el Dominio (DDD) y CQRS. |

</details>

<details closed><summary>src.Domain.DomainErrors</summary>

| Archivo                                                                                                         | Resumen                                                                                                                                                                            |
| ---                                                                                                          | ---                                                                                                                                                                                |
| [Errors.Customer.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/DomainErrors/Errors.Customer.cs) | Valida los datos del cliente dentro de la capa del Dominio de la arquitectura de la aplicación NetDDD-CQRS, haciendo cumplir la conformidad de formato para números de teléfono y direcciones para asegurar la integridad de los datos. |

</details>

<details closed><summary>src.Domain.Primitives</summary>

| Archivo                                                                                                   | Resumen                                                                                                                                                                                                                                                   |
| ---                                                                                                    | ---                                                                                                                                                                                                                                                       |
| [AggregateRoot.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/AggregateRoot.cs) | Clase AggregateRoot. Este componente esencial sirve como el centro para eventos de dominio, promoviendo la consistencia y la trazabilidad dentro de la capa de Dominio. Es crucial para el manejo cohesivo de transiciones de estado complejas en esta arquitectura de microservicios. |
| [DomainEvent.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/DomainEvent.cs)     | Encapsula eventos de dominio, asegurando la consistencia de eventos dentro de la capa de Dominio de la aplicación. Facilita la comunicación entre microservicios usando MediatR para la arquitectura de Command and Query Responsibility Segregation (CQRS).           |
| [IUnitOfWork.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/IUnitOfWork.cs)     | Gestiona la integridad de los datos en la arquitectura coordinando las operaciones de persistencia a través de la interfaz `IUnitOfWork`, permitiendo la escritura transaccional confiable en el almacén de datos en la capa de Dominio del proyecto netDDD-CQRS.                                           |

</details>

<details closed><summary>src.Domain.Customers</summary>

| Archivo                                                                                                              | Resumen                                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Customer.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/Customer.cs)                       | Gestiona las entidades de Cliente a través de la aplicación, garantizando la consistencia de los datos mediante la encapsulación con el patrón AggregateRoot. **Características:** Propiedades inmutables, constructor para instanciación, método estático UpdateCustomer para alterar detalles del cliente. Proporciona una capa de abstracción esencial para la gestión de Clientes en el diseño dirigido por el dominio de nuestra aplicación NetDDD-CQRS.                    |
| [ICustomerRepository.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/ICustomerRepository.cs) | Gestiona las interacciones de datos de clientes en la arquitectura del repositorio DDD-CQRS. Proporciona métodos como GetByIdAsync, GetAll, Add, Delete, ExistsAsync y Update, permitiendo operaciones CRUD para las entidades de clientes. Es parte de la capa de Dominio, encapsulando la lógica de negocio relacionada con la gestión de datos de clientes.                                                                                              |
| [CustomerId.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/CustomerId.cs)                   | Codifica de manera única las identidades de los clientes dentro del modelo de dominio de la aplicación. **Característica Clave:** Utiliza `Guid` para la identificación globalmente única y persistente de clientes a través de múltiples transacciones y servicios. **Impacto:** Proporciona un manejo de datos consistente, escalable y resistente a errores que mantiene la integridad de las entidades de clientes en nuestra arquitectura basada en DDD y CQRS. |

</details>

<details closed><summary>src.Domain.ValueObjects</summary>

| Archivo                                                                                                 | Resumen                                                                                                                                                                                                      |
| ---                                                                                                  | ---                                                                                                                                                                                                          |
| [PhoneNumber.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/ValueObjects/PhoneNumber.cs) | Asegura que el formato del número de teléfono cumpla con el patrón predefinido en la lógica de negocio central de la aplicación, garantizando la consistencia y corrección de los datos.                                                         |
| [Address.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/ValueObjects/Address.cs)         | Valida y almacena los detalles de la dirección del usuario dentro de la capa de dominio, siguiendo el enfoque model-agnostic mediante el uso de clases de registro inmutables para la persistencia y consistencia de datos en toda la lógica de negocio. |

</details>

<details closed><summary>src.Infrastructure</summary>

| Archivo                                                                                                          | Resumen                                                                                                                                                                                                                 |
| ---                                                                                                           | ---                                                                                                                                                                                                                     |
| [Infrastructure.csproj](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Infrastructure.csproj) | Incorpora soporte de base de datos externa a través de MySQL y EntityFrameworkCore para nuestra aplicación DDD-CQRS. Facilita el enlace de dependencias a las capas de lógica de dominio y aplicación dentro de nuestra estructura de repositorio. |

</details>

<details closed><summary>src.Infrastructure.Services</summary>

| Archivo                                                                                                                     | Resumen                                                                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                                      |
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Services/DependencyInjection.cs) | Configura la inyección de dependencias para los servicios de la capa de persistencia, permitiendo una comunicación fluida con las bases de datos en la aplicación ASP.NET Core Web API. El servicio central incluye la gestión de la unidad de trabajo y las implementaciones del patrón de repositorio, facilitando el acceso eficiente a los datos en el diseño orientado al dominio (DDD) y la arquitectura de Segregación de Responsabilidades de Comando y Consulta (CQRS) de este proyecto. |

</details>

<details closed><summary>src.Infrastructure.Persistence</summary>

| Archivo                                                                                                                          | Resumen                                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                 |
| [ApplicationDbContext.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/ApplicationDbContext.cs) | Orquesta las operaciones de persistencia para la aplicación DDD-CQRS, gestionando el ApplicationDbContext que maneja las interacciones con la base de datos como el almacenamiento y la recuperación de entidades de Cliente. El contexto también desencadena la publicación de eventos a MediatR tras cambios en el dominio, garantizando una difusión eficiente de mensajes dentro del sistema. |

</details>

<details closed><summary>src.Infrastructure.Persistence.Configuration</summary>

| Archivo                                                                                                                                          | Resumen                                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                                       |
| [CustomerConfiguration.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Configuration/CustomerConfiguration.cs) | Configura el esquema de la base de datos para las entidades de clientes, definiendo tablas, claves primarias, índices únicos y tipos de propiedades dentro de la tabla `Customers`. La estructura se adhiere a las restricciones de longitud especificadas, manejando tanto datos de cadena como numéricos, junto con un tipo complejo `Address` utilizando la API fluida de EFCore para la configuración del modelo en la capa de infraestructura de este repositorio en una solución DDD-CQRS. |

</details>

<details closed><summary>src.Infrastructure.Persistence.Migration</summary>

| Archivo                                                                                                                                                                            | Resumen                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                                                            |
| [ApplicationDbContextModelSnapshot.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/ApplicationDbContextModelSnapshot.cs)               | Gestiona las migraciones del esquema de la base de datos para la entidad Cliente en esta capa de infraestructura, garantizando la consistencia y la correcta mapeo con el modelo de Cliente especificado a través de tablas y columnas, facilitando la interacción sin problemas dentro de nuestra arquitectura DDD-CQRS.                                                                                                 |
| [20240323230828_InitialMigration.Designer.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/20240323230828_InitialMigration.Designer.cs) | Inicializa el esquema de la base de datos para la entidad Cliente con propiedades como Id, Active, Email, LastName, Name y PhoneNumber. También incluye un objeto de valor Address embebido, que tiene propiedades como City, Country, Line1, Line2, State y ZipCode. Esto asegura que la capa de persistencia esté preparada para almacenar los detalles del cliente y la dirección dentro de la aplicación. |
| [20240323230828_InitialMigration.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/20240323230828_InitialMigration.cs)                   | Inicia la migración del esquema de la base de datos para la tabla Cliente en esta aplicación ASP.NET Core de múltiples capas siguiendo el diseño orientado al dominio (DDD) y el patrón arquitectónico de Segregación de Responsabilidades de Comando y Consulta (CQRS). Incluye campos esenciales, clave primaria e índice de correo electrónico para apoyar la identificación única de clientes y consultas eficientes.                |

</details>

<details closed><summary>src.Infrastructure.Persistence.Repositories</summary>

| Archivo                                                                                                                                   | Resumen                                                                                                                                                                                                                     |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                         |
| [CustomerRepository.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Repositories/CustomerRepository.cs) | Gestiona la persistencia de los datos del Cliente dentro de ApplicationDbContext para operaciones eficientes de almacenamiento y recuperación. Proporciona métodos para agregar, eliminar, actualizar clientes y consultar por id o obtener todos los clientes de manera asíncrona. |

</details>

---

##  Comenzando

**Requerimientos del Sistema:**

* **CSharp**: `versión 11`
* **.NET**: `versión 7`

###  Instalación

<h4>Desde <code>source</code></h4>

> 1. Clona el repositorio DDD:
>
> ```console
> $ git clone https://github.com/juansdev/DDD
> ```
>
> 2. Cambia al directorio del proyecto:
> ```console
> $ cd DDD
> ```
>
> 3. Instala las dependencias:
> ```console
> $ dotnet build
> ```
>
> 4. Edite la conexión a su BD de MySQL en la llave "Database" alojada en el archivo Web.API/appsettings.Development.json.
>
> 5. Active el servidor Apache y MySQL.

###  Uso

<h4>Desde <code>source</code></h4>

> Despliega el proyecto mediante el perfil de lanzamiento HTTPS.

###  Pruebas

> Ejecuta la suite de pruebas utilizando el siguiente comando:
> ```console
> $ dotnet test
> ```

---

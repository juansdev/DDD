<p align="center">
  <img src="https://simpleicons.org/icons/dotnet.svg" style="filter:invert(1);" width="100" alt="project-logo">
</p>
<p align="center">
    <h1 align="center">Domain Driven Design</h1>
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
  <summary>Table of Contents</summary><br>

- [ Overview](#-overview)
- [ Features](#-features)
- [ Repository Structure](#-repository-structure)
- [ Modules](#-modules)
- [ Getting Started](#-getting-started)
  - [ Installation](#-installation)
  - [ Usage](#-usage)
  - [ Tests](#-tests)
</details>
<hr>

##  Overview

DDD-CQRS Application

The application leverages Domain-Driven Design and Command Query Responsibility Segregation (DDD-CQRS). The core domain layer includes Customer management with methods for CRUD operations using the ICustomerRepository. Customer identity is handled using globally unique Guid identifiers. The ValueObjects include PhoneNumber format compliance checks, and Address validation with an immutable record class for data persistence consistency.

Externally, MySQL and EntityFrameworkCore support are incorporated within the Infrastructure layer, ensuring seamless database communication through dependency injection in ASP.NET Core Web API. ApplicationDbContext handles database operations, while CustomerConfiguration sets up the schema for customer entities. Migrations manage schema evolution for the Customer table with essential fields, primary key, and indexes to facilitate efficient interaction within our architecture.

---

##  Features

| Feature                | Description                                                                                                                           |
|--------------------------|---------------------------------------------------------------------------------------------------------------------------------------|
| Architecture            | A .NET project implementing Domain-Driven Design (DDD) and the Command & Query Responsibility Segregation (CQRS) pattern for organized modularity.                  |
| Code Quality            | Well-structured, clean and readable code following established .NET coding standards, with proper namespacing, class and method organization.          |
| Integrations            | Dependency on MediatR for efficient handling of commands and queries, as well as FluentValidation for data validation.      |
| Modularity              | The modular structure allows for easy maintenance and scalability by separating the application into distinct layers: domain, application, and infrastructure. |
| Testing                | Unit tests managed through settings within testing sessions in unit test files, such as `CreateCustomerCommandHandlerUnitTests`.                  |
| Performance             | Efficiency optimized using .NET performance practices and pattern adherence; resource usage should be comparable to similar projects of the same scale. |
| Security                | No specific security measures discussed within the provided project files, so assume no explicit protection mechanisms are implemented.             |
| Dependencies            | Primary dependencies include `sln`, `cs`, `csproj`, `user`, and various .NET framework libraries for application functionality.                      |

---

##  Repository Structure

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

##  Modules

<details closed><summary>.</summary>

| File                                                                                                             | Summary                                                                                                                                                                                                                                                                                                |
| ---                                                                                                              | ---                                                                                                                                                                                                                                                                                                    |
| [netDDD-CQRS.sln.DotSettings.user](https://github.com/juansdev/DDD/blob/master/netDDD-CQRS.sln.DotSettings.user) | Manages** testing sessions within unit tests for our Domain Application. By defining session states, this setting file streamlines the execution process for CreateCustomerCommandHandlerUnitTests, ensuring seamless continuous testing during the development cycle.                                 |
| [netDDD-CQRS.sln](https://github.com/juansdev/DDD/blob/master/netDDD-CQRS.sln)                                   | Debug|Any CPU and Release|Any CPU. Each solution has its respective ActiveCfg and Build.0 settings. A nested project named {CE1BE02E-C786-4F24-A9BF-D323FDE1F7E1} references another solution {9936F538-B9A5-4AA7-A65C-3BD941764EFE}.                                                                  |

</details>

<details closed><summary>src.Application</summary>

| File                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                                                            |
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Application/DependencyInjection.cs)                   | Enables dependency injection for MediatR and FluentValidation in the given application. Registers service implementations from relevant assemblies to ensure seamless interaction with business logic layers. Facilitates the use of validation pipelines and validators for maintaining data integrity across application components.                                         |
| [ApplicationAssemblyReference.cs](https://github.com/juansdev/DDD/blob/master/src/Application/ApplicationAssemblyReference.cs) | Compiles and references key application assemblies within the Net DDD-CQRS architecture, streamlining its modularity and scalability. This ensures seamless integration with other layers including domain and infrastructure while maintaining a clean and organized solution structure for the web API project.                                                              |
| [Application.csproj](https://github.com/juansdev/DDD/blob/master/src/Application/Application.csproj)                           | Implementing application logic for customer operations in a.NET 7 project based on Domain-Driven Design (DDD) and Command Query Responsibility Segregation (CQRS). Utilizes MediatR, FluentValidation, EntityFrameworkCore, and ErrorOr libraries to ensure data validity and consistency. Features folders for Delete, GetAll, GetById, and Update customer-related commands. |

</details>

<details closed><summary>src.Application.Customers.GetById</summary>

| File                                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                     |
| [GetCustomerByIdQuery.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetById/GetCustomerByIdQuery.cs)               | Empowers user-driven data retrieval within the DDD-CQRS application architecture. By leveraging the MediatR library, the GetCustomerByIdQuery class enables seamless extraction of CustomerResponse details for a given Id from the Customers module. This efficient interaction supports a flexible and scalable application workflow. |
| [GetCustomerByIdQueryHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetById/GetCustomerByIdQueryHandler.cs) | Handles customer queries by retrieving specific customer data from the repository, constructing a `CustomerResponse` object, and returning it to the caller when a matching Id is found. Contributes to the application layer in the DDD-CQRS architecture, ensuring a smooth experience for user interaction with the Customers API.   |

</details>

<details closed><summary>src.Application.Customers.GetAll</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                             |
| [GetAllCustomersQueryHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetAll/GetAllCustomersQueryHandler.cs) | Executes a query for retrieving all customer responses in a CQRS-structured application. Implements the GetAllCustomersQueryHandler, handling GetAllCustomersQuery, and communicates with the ICustomerRepository to fetch customer data, mapping it into CustomerResponse objects.                                             |
| [GetAllCustomersQuery.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/GetAll/GetAllCustomersQuery.cs)               | This file (GetAllCustomersQuery.cs) in our application layer orchestrates the retrieval of all customer records from the database via the MediatR pattern and returns a collection as Error-or-proof IReadOnlyList of CustomerResponse objects, enhancing our CQRS architecture for efficient and reliable customer management. |

</details>

<details closed><summary>src.Application.Customers.Update</summary>

| File                                                                                                                                                | Summary                                                                                                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                 | ---                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [UpdateCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommandHandler.cs)     | Facilitates updating customer details in a scalable CQRS-driven architecture by handling `UpdateCustomerCommand` using MediatR, ensuring validation and interaction with the `CustomerRepository`. Actions include checking existence, phone number, address validity, updating customer data, and saving changes to the database.                                                                                              |
| [UpdateCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommandValidator.cs) | Validates incoming customer update commands, ensuring consistency and correctness before they reach business logic in the application tier of our DDD-CQRS architecture. The validation includes strict checks for required fields (e.g., customer id, name), maximum length limits for each field, proper data types (email format, phone number, zip code), and ensures necessary attributes are present (e.g., active flag). |
| [UpdateCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Update/UpdateCustomerCommand.cs)                   | Facilitates updating customer data within the system by constructing an `UpdateCustomerCommand` object that contains essential attributes like Id, Name, Email, Phone Number, and Address details, adhering to the Command pattern using MediatR. This action helps ensure accurate customer information in the DDD-CQRS Application architecture.                                                                              |

</details>

<details closed><summary>src.Application.Customers.Common</summary>

| File                                                                                                                    | Summary                                                                                                                                                                                                                                                                                                                                               |
| ---                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                                   |
| [CustomerResponse.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Common/CustomerResponse.cs) | CustomerResponse`. It consolidates essential customer details such as ID, name, email, phone number, and address. The included `AddressResponse` offers country, street lines, city, state, and zip code. These response records contribute to a more unified application experience across the netDDD-CQRS architecture, specifically the `Web.API`. |

</details>

<details closed><summary>src.Application.Customers.Create</summary>

| File                                                                                                                                                | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ---                                                                                                                                                 | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CreateCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommand.cs)                   | In this Application directory within our Domain-Driven Design (DDD) CQRS solution, the CreateCustomerCommand performs the essential task of accepting user input to create a new customer record. By providing key details such as name, email, phone number, and address information, it enables the application to populate its Customer entity with well-structured data. This command leverages MediatR to initiate the appropriate processing workflows, ensuring a seamless experience for the user. |
| [CreateCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommandValidator.cs) | Ensures essential fields like name, last name, email, phone number, country, and addresses are provided, while maintaining string length restrictions, validating email formats and phone numbers, and providing a streamlined customer creation experience.                                                                                                                                                                                                                                               |
| [CreateCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Create/CreateCustomerCommandHandler.cs)     | Handles user requests to create new customer entities within the application layer in this domain-driven design repository, ensuring data integrity via validation rules and persistence with repositories and unit of work.                                                                                                                                                                                                                                                                               |

</details>

<details closed><summary>src.Application.Customers.Delete</summary>

| File                                                                                                                                                | Summary                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                 | ---                                                                                                                                                                                                                                                                                                                              |
| [DeleteCustomerCommand.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommand.cs)                   | In the netDDD-CQRS repository, the DeleteCustomerCommand in the Application/Customers/Delete folder is a request that initiates the removal of a specific customer record. The command uses MediatR and carries an ID for the targeted customer, facilitating efficient and structured data modification within the application. |
| [DeleteCustomerCommandHandler.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommandHandler.cs)     | In this Application folder lies the DeleteCustomerCommandHandler file. This handler processes Delete Customer Command requests within the Customers domain by removing the specified customer and saving changes using IUnitOfWork, ensuring efficient data management and integrity in the overall DDD-CQRS architecture.       |
| [DeleteCustomerCommandValidator.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Customers/Delete/DeleteCustomerCommandValidator.cs) | In this application-level code, a validation rule for DeleteCustomerCommand is defined, ensuring the command contains an Id field that is not empty before proceeding with its execution. This enforces input data integrity within the Domain layer in our CQRS/DDD-structured API architecture.                                |

</details>

<details closed><summary>src.Application.Data</summary>

| File                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                              |
| [IApplicationDbContext.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Data/IApplicationDbContext.cs) | Manage application data storage by defining an interface for the `IApplicationDbContext`. This interface outlines a connection to the database through `DbSet<Customer>` and offers `SaveChangesAsync` method to save changes within the context, essential for maintaining and organizing customer data within our Command Query Responsibility Segregation (CQRS) application. |

</details>

<details closed><summary>src.Application.Common.Behaviors</summary>

| File                                                                                                                        | Summary                                                                                                                                                                                                                                                                                                       |
| ---                                                                                                                         | ---                                                                                                                                                                                                                                                                                                           |
| [ValidationBehavior.cs](https://github.com/juansdev/DDD/blob/master/src/Application/Common/Behaviors/ValidationBehavior.cs) | ValidationBehavior ensures proper data validation across application requests within the repository. This is achieved by employing FluentValidation, MediatR, and error handling for invalid request scenarios. This streamlines the data processing pipeline in netDDD-CQRS architecture to minimize errors. |

</details>

<details closed><summary>src.Web.API</summary>

| File                                                                                                                         | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                          | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [appsettings.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/appsettings.json)                                 | The `appsettings.json` file fine-tunes application logging levels (for easier debugging) and permits access from any host (*), vital for seamless deployment within our Domain-Driven Design and CQRS-based solution architecture.                                                                                                                                                                                                                                          |
| [Web.API.csproj](https://github.com/juansdev/DDD/blob/master/src/Web.API/Web.API.csproj)                                     | The provided file configures a.NET Web API project within the DDD-CQRS repository. It references necessary dependencies like Entity Framework Core and Swagger, as well as OpenAPI specifications for documentation. This API project serves to connect external clients with the core business logic contained in Application and infrastructure services encapsulated in the Infrastructure folder.                                                                       |
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/DependencyInjection.cs)                     | Configures application dependencies for presentation layer services within Web API project. Key features include Swagger setup for API documentation, controller registration, error handling middleware, and integration with endpoint explorer, enriching API functionality and user experience.                                                                                                                                                                          |
| [PresentationAssemblyReference.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/PresentationAssemblyReference.cs) | Establishes assembly reference within Web.API project, essential for seamless integration between components, ensuring a coherent architecture as per DDD-CQRS solution structure.                                                                                                                                                                                                                                                                                          |
| [Program.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Program.cs)                                             | Launches a web API within the larger DDD-CQRS application architecture. Implements dependency injection by configuring service layers and middlewares. Facilitates exception handling, authorization, and integration with Swagger documentation. Initiates migration if in development environment. Provides a platform for controllers to define endpoints.                                                                                                               |
| [appsettings.Development.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/appsettings.Development.json)         | Configures database connection and logging settings for web API application within DDD-CQRS project architecture, enabling efficient data storage and error handling across services.                                                                                                                                                                                                                                                                                       |

</details>

<details closed><summary>src.Web.API.Middlewares</summary>

| File                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                                                                            |
| [GlobalExceptionHandlingMiddleware.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Middlewares/GlobalExceptionHandlingMiddleware.cs) | Amplifies resilience in our API by handling unexpected errors gracefully. The GlobalExceptionHandlingMiddleware catches exceptions and returns structured problem details along with appropriate HTTP status codes for improved user experience and troubleshooting capabilities. This ensures that the application remains reliable while adhering to RESTful best practices. |

</details>

<details closed><summary>src.Web.API.Extensions</summary>

| File                                                                                                                | Summary                                                                                                                                                                                                                                                      |
| ---                                                                                                                 | ---                                                                                                                                                                                                                                                          |
| [MigrationExtensions.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Extensions/MigrationExtensions.cs) | Amplifies applications database functionality by executing migrations. Located within the Web APIs Extension folder, this code enhances the project's infrastructure layer, ensuring seamless integration with the ApplicationDbContext upon initialization. |

</details>

<details closed><summary>src.Web.API.Properties</summary>

| File                                                                                                          | Summary                                                                                                                                                                                                               |
| ---                                                                                                           | ---                                                                                                                                                                                                                   |
| [launchSettings.json](https://github.com/juansdev/DDD/blob/master/src/Web.API/Properties/launchSettings.json) | Configures application launch settings for development, offering localhost access via HTTP, HTTPS, and IIS Express to the Web API project within DDD-CQRS repository, streamlining the testing and debugging process. |

</details>

<details closed><summary>src.Web.API.Common.Http</summary>

| File                                                                                                                 | Summary                                                                                                                                                                                                                                                                    |
| ---                                                                                                                  | ---                                                                                                                                                                                                                                                                        |
| [HttpContextItemKeys.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Common/Http/HttpContextItemKeys.cs) | Streamlines error handling for API responses by defining a constant Errors item key for HTTP context items, integrating seamlessly with the Web.API layer of this domain-driven design and CQRS architecture project, promoting cleaner, more organized API communication. |

</details>

<details closed><summary>src.Web.API.Common.Errors</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                                                                                                    |
| [NetDDDProblemDetailsFactory.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Common/Errors/NetDDDProblemDetailsFactory.cs) | Manages error handling for the applications API layer. NetDDDProblemDetailsFactory customizes and enhances error responses by setting relevant metadata, including trace identifiers, client-specific error details, and custom error codes when necessary, enriching error diagnostics in the WebAPI. |

</details>

<details closed><summary>src.Web.API.Controllers</summary>

| File                                                                                                                 | Summary                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                  | ---                                                                                                                                                                                                                                                                                                                                                         |
| [CustomersController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/CustomersController.cs) | Streamlines the process of creating customers via API requests. Leverages MediatR for messaging and command dispatch to ensure a scalable architecture in the Web API.                                                                                                                                                                                      |
| [ErrorsController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/ErrorsController.cs)       | This code defines an error handling mechanism for the applications API in the `Web.API` layer. The `ErrorsController` catches exceptions by leveraging `IExceptionHandlerFeature`. It transforms these exceptions into Problems' responses, ensuring efficient and graceful failure management, ultimately improving application reliability.               |
| [ApiController.cs](https://github.com/juansdev/DDD/blob/master/src/Web.API/Controllers/ApiController.cs)             | In this Web API solution, the provided `ApiController.cs` file enhances error handling for incoming requests by implementing custom problem details. Upon encountering an error, it provides meaningful responses with appropriate status codes, effectively improving overall application resilience and user experience within the DDD-CQRS architecture. |

</details>

<details closed><summary>src.Domain</summary>

| File                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                   | ---                                                                                                                                                                                                                                                                                                                                       |
| [Domain.csproj](https://github.com/juansdev/DDD/blob/master/src/Domain/Domain.csproj) | The `src/Domain/Domain.csproj` file sets up a project for managing the central domain of the application. It integrates ErrorOr and MediatR, enabling efficient error handling and handling business operations via commands, further strengthening the application architecture based on Domain-Driven Design (DDD) and CQRS principles. |

</details>

<details closed><summary>src.Domain.DomainErrors</summary>

| File                                                                                                         | Summary                                                                                                                                                                            |
| ---                                                                                                          | ---                                                                                                                                                                                |
| [Errors.Customer.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/DomainErrors/Errors.Customer.cs) | Validates customer data within the Domain layer of the NetDDD-CQRS application architecture, enforcing format compliance for phone numbers and addresses to ensure data integrity. |

</details>

<details closed><summary>src.Domain.Primitives</summary>

| File                                                                                                   | Summary                                                                                                                                                                                                                                                   |
| ---                                                                                                    | ---                                                                                                                                                                                                                                                       |
| [AggregateRoot.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/AggregateRoot.cs) | AggregateRoot class. This essential component serves as the hub for domain events, promoting consistency and traceability within the Domain layer. Its pivotal for the cohesive handling of complex state transitions in this microservices architecture. |
| [DomainEvent.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/DomainEvent.cs)     | Encapsulates domain events, ensuring event consistency within the Domain layer of the application. Enables: Facilitates communication between microservices using MediatR for Command and Query Responsibility Segregation (CQRS) architecture.           |
| [IUnitOfWork.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Primitives/IUnitOfWork.cs)     | Manages data integrity in the architecture by coordinating persistence operations via `IUnitOfWork` interface, enabling reliable transactional writing to datastore in the Domain layer of netDDD-CQRS project.                                           |

</details>

<details closed><summary>src.Domain.Customers</summary>

| File                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                       |
| [Customer.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/Customer.cs)                       | Manages Customer entities across the application, enforcing data consistency through encapsulation with the AggregateRoot pattern. **Features:** Immutable properties, constructor to instantiate, UpdateCustomer static method to alter customer details. Provides an essential abstraction layer for Customer management in the domain-driven design of our NetDDD-CQRS application.                    |
| [ICustomerRepository.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/ICustomerRepository.cs) | Manages customer data interactions in the DDD-CQRS repository architecture. Provides methods like GetByIdAsync, GetAll, Add, Delete, ExistsAsync and Update, enabling CRUD operations for customer entities. Its part of the Domain layer, encapsulating business logic related to customer data management.                                                                                              |
| [CustomerId.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/Customers/CustomerId.cs)                   | Uniquely encodes customer identities within the applications domain model.**Key Feature:** Uses `Guid` for globally unique and persistent identification of customers across multiple transactions and services.**Impact:** Provides consistent, scalable, and error-resilient data handling that upholds the integrity of the customer entities in our Domain-Driven Design and CQRS-based architecture. |

</details>

<details closed><summary>src.Domain.ValueObjects</summary>

| File                                                                                                 | Summary                                                                                                                                                                                                      |
| ---                                                                                                  | ---                                                                                                                                                                                                          |
| [PhoneNumber.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/ValueObjects/PhoneNumber.cs) | Ensures phone number format complies with the predefined pattern in the applications core business logic, ensuring data consistency and correctness.                                                         |
| [Address.cs](https://github.com/juansdev/DDD/blob/master/src/Domain/ValueObjects/Address.cs)         | Validates and stores user address details within the domain layer, adhering to the model-agnostic approach by using immutable record classes for data persistence and consistency across all business logic. |

</details>

<details closed><summary>src.Infrastructure</summary>

| File                                                                                                          | Summary                                                                                                                                                                                                                 |
| ---                                                                                                           | ---                                                                                                                                                                                                                     |
| [Infrastructure.csproj](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Infrastructure.csproj) | Incorporates external database support through MySQL and EntityFrameworkCore for our DDD-CQRS application. Facilitates dependency linkage to core domains and application logic layers within our repository structure. |

</details>

<details closed><summary>src.Infrastructure.Services</summary>

| File                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                                      |
| [DependencyInjection.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Services/DependencyInjection.cs) | Configures dependency injection for persistence layer services, enabling seamless communication with databases in the ASP.NET Core Web API application. The core service includes unit-of-work management and repository pattern implementations, facilitating efficient data access in the domain-driven design (DDD) and Command-Query Responsibility Segregation (CQRS) architecture of this project. |

</details>

<details closed><summary>src.Infrastructure.Persistence</summary>

| File                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                             |
| ---                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                 |
| [ApplicationDbContext.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/ApplicationDbContext.cs) | Orchestrates** persistence operations for the DDD-CQRS application, managing the ApplicationDbContext which handles database interactions like storing and retrieving Customer entities. The context also triggers event publication to MediatR upon changes in the domain, ensuring efficient message broadcast within the system. |

</details>

<details closed><summary>src.Infrastructure.Persistence.Configuration</summary>

| File                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                                                                                   |
| ---                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                                       |
| [CustomerConfiguration.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Configuration/CustomerConfiguration.cs) | Configures database schema for customer entities, defining tables, primary keys, unique indexes, and property types within the `Customers` table. The structure adheres to the specified length constraints, handling both string and numeric data, along with a complex `Address` type using EFCores fluent API for model configuration in this repositorys infrastructure layer of a DDD-CQRS solution. |

</details>

<details closed><summary>src.Infrastructure.Persistence.Migration</summary>

| File                                                                                                                                                                            | Summary                                                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                                                             | ---                                                                                                                                                                                                                                                                                                                                                            |
| [ApplicationDbContextModelSnapshot.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/ApplicationDbContextModelSnapshot.cs)               | Manages database schema migrations for Customer entity in this infrastructure layer, ensuring consistency and correct mapping with the specified Customer model across tables and columns, facilitating seamless interaction within our DDD-CQRS architecture.                                                                                                 |
| [20240323230828_InitialMigration.Designer.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/20240323230828_InitialMigration.Designer.cs) | Initializes database schema for customer entity with properties such as Id, Active, Email, LastName, Name and PhoneNumber. Also includes an embedded Address value object, which has properties like City, Country, Line1, Line2, State, and ZipCode. This ensures persistence layer is prepared to store customer and address details within the application. |
| [20240323230828_InitialMigration.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Migration/20240323230828_InitialMigration.cs)                   | Initiates database schema migration for Customer table in this multi-layered ASP.NET Core application following Domain-driven Design (DDD) and Command Query Responsibility Segregation (CQRS) architectural pattern. Includes essential fields, primary key, and email index to support unique customer identification and efficient querying.                |

</details>

<details closed><summary>src.Infrastructure.Persistence.Repositories</summary>

| File                                                                                                                                   | Summary                                                                                                                                                                                                                     |
| ---                                                                                                                                    | ---                                                                                                                                                                                                                         |
| [CustomerRepository.cs](https://github.com/juansdev/DDD/blob/master/src/Infrastructure/Persistence/Repositories/CustomerRepository.cs) | Manages persistence of Customer data within the ApplicationDbContext for efficient storage and retrieval operations. Provides methods to add, delete, update customers and query by id or get all customers asynchronously. |

</details>

---

##  Getting Started

**System Requirements:**

* **CSharp**: `version 11`
* **.NET**: `version 7`

###  Installation

<h4>From <code>source</code></h4>

> 1. Clone the DDD repository:
>
> ```console
> $ git clone https://github.com/juansdev/DDD
> ```
>
> 2. Change to the project directory:
> ```console
> $ cd DDD
> ```
>
> 3. Install the dependencies:
> ```console
> $ dotnet build
> ```

###  Usage

<h4>From <code>source</code></h4>

> Run DDD using the command below:
> ```console
> $ dotnet run
> ```

###  Tests

> Run the test suite using the command below:
> ```console
> $ dotnet test
> ```

---

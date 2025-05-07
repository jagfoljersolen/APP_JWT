# APP_JWT
A simple ASP.NET Core Web API project for practicing JWT (JSON Web Token) authentication and role-based authorization.
Features

    User authentication with JWT tokens

    Role-based access to endpoints (e.g., "admin", "user")

    Endpoints for user management and protected resources

    Example endpoint for drawing a random prime number

Getting Started

    Clone the repository:

bash
git clone https://github.com/jagfoljersolen/APP_JWT.git
cd APP_JWT

Configure JWT secret:

    Edit appsettings.json and set your JWT key in the JWT:Key section.

Run the application:

    bash
    dotnet run

    The API will be available at http://localhost:5259.

    Explore the API:

        Open http://localhost:5259/swagger in your browser for interactive API documentation.

Example Endpoints

    POST /api/users/authenticate - Get JWT token by providing username and password

    GET /api/users/getallusers - Get all users (admin role required)

    GET /api/users/getregistereduserscount - Get count of registered users (user role required)

    GET /api/prime/draw - Get a random prime number between 2 and 13

Technologies

    ASP.NET Core

    JWT (JSON Web Token)

    Swagger (OpenAPI)

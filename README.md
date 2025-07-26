# ASP.NET Core 9 Web API with JWT Auth, PostgreSQL, CRUD, Rate Limiting & Docker

A clean, secure REST API built with .NET 9 featuring JWT authentication, PostgreSQL integration using EF Core, full CRUD operations, request rate limiting, and Docker support.

---

## Features

- JWT Authentication for secure access  
- Full CRUD API endpoints  
- PostgreSQL database integration with EF Core  
- Request rate limiting to prevent abuse  
- Dockerized for easy containerized deployment  

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- [Docker](https://www.docker.com/get-started) (optional, for containerized deployment)  
- Running PostgreSQL instance  

---

## Setup & Running

### 1. Configure PostgreSQL

- Create your PostgreSQL database.
- Update the connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=your_host;Port=your_port;Database=your_db;Username=your_user;Password=your_password"
}
```

---

### 2. Apply Database Migrations

Run the following command in the project directory to apply EF Core migrations:

```bash
dotnet ef database update
```

---

## Running Locally (without Docker)

1. Clone the repository:

```bash
git clone https://github.com/KUBIXQAZ/API-EF-JWT.git
cd API-EF-JWT
```

2. Update your connection string as above.

3. Run the API:

```bash
dotnet run
```

Access the API at:

* `http://localhost:8080`
* `https://localhost:8081`

---

## Running with Docker

1. Build the Docker image:

```bash
docker build -t api .
```

2. Run the container, mapping host ports to container ports 8080 (HTTP) and 8081 (HTTPS):

```bash
docker run -d -p 8080:8080 -p 8081:8081 --name api api
```

Access the API at:

* `http://localhost:8080`
* `https://localhost:8081`

---

## API Endpoints

| Method | Endpoint                    | Description              | Auth Required? |
| ------ | --------------------------- | ------------------------ | ------------- |
| POST   | `/api/auth/register`        | Register a new user      | No            |
| POST   | `/api/auth/login`           | Authenticate and get JWT | No            |
| GET    | `/api/products`             | Get all products         | Yes           |
| GET    | `/api/products/{id}`        | Get product by ID        | Yes           |
| POST   | `/api/products/create`      | Create a new product     | Yes           |
| PUT    | `/api/products/update/{id}` | Update existing product  | Yes           |
| DELETE | `/api/products/delete/{id}` | Delete a product         | Yes           |

---

## Authentication

Include JWT token in the Authorization header for protected endpoints:

```
Authorization: Bearer YOUR_JWT_TOKEN
```

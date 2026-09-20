# 📚 Book Management API
A simple ASP.NET Core Web API demonstrating basic **CRUD operations** using an in-memory collection.
## 🛠️ Tech Stack
* C#
* ASP.NET Core Web API
* .NET
* Swagger / OpenAPI
* In-Memory `List<Book>`

## ✨ Features
* Create a book
* Get all books
* Get a book by ID
* Update a book
* Delete a book

## 🔗 API Endpoints

| Method | Endpoint          | Description    |
| ------ | ----------------- | -------------- |
| GET    | `/api/books`      | Get all books  |
| GET    | `/api/books/{id}` | Get book by ID |
| POST   | `/api/books`      | Create a book  |
| PUT    | `/api/books/{id}` | Update a book  |
| DELETE | `/api/books/{id}` | Delete a book  |

## 🚀 Run the Project

```bash
dotnet restore
dotnet run
```

Open Swagger:

```text
https://localhost:<port>/swagger
```

## 📝 Note

This project uses **in-memory storage**, so all data will be lost when the application is restarted.

Created as a learning project to understand CRUD operations and ASP.NET Core Web API fundamentals.

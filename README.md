# **Library Management API**

Welcome to the **Library Management API**, a demonstration project that implements **Domain-Driven Design (DDD)** principles with JWT authentication. This application allows users to interact with a library system, borrow books, and manage their library collection securely.

---

## **Features** 🚀

- **Domain-Driven Design (DDD)** for clean architecture.
- **JWT Authentication** for secure access.
- **PostgreSQL Database** integration for data persistence.
- **Swagger** for API documentation and testing.
- **Memory Caching** to enhance performance.

---

## **Technologies Used** 🛠️

- **.NET 8**
- **Entity Framework Core**
- **PostgreSQL**
- **JWT Authentication**
- **Swashbuckle (Swagger)**

---

## **Project Architecture**

This project follows the **Clean Architecture** approach, with the following layers:

1. **API**: Exposes endpoints for user interaction.
2. **Application**: Contains business logic (e.g., `JwtTokenService`).
3. **Infrastructure**: Handles database interaction and repository implementation.
4. **Domain**: Core domain models and rules.

---

## **Setup Instructions** ⚙️

### **1. Clone the Repository**

---

### **2. Configure the Environment**

#### **Update `appsettings.json`**

Replace the connection string and JWT key with your own values:

```json
"ConnectionStrings": {
    "LibraryDatabase": "Host=localhost;Port=5432;Database=LibraryManagement;Username=postgres;Password=yourpassword"
},
"Jwt": {
    "Key": "your-secure-jwt-key"
}
```

---

### **3. Run Migrations**

Ensure you have PostgreSQL installed and running locally. Create the database schema using EF Core migrations:

```bash
dotnet ef database update
```

---

### **4. Run the Application**

Start the API:

```bash
dotnet run
```

The API will be available at:

```
https://localhost:7082
```

---

### **5. Test with Swagger**

1. Open Swagger at:
   ```
   https://localhost:7082/swagger
   ```

2. **Login Endpoint**: 
   - Use `/api/auth/login` to generate a JWT token.
   - Copy the token.

3. **Authorize**:
   - Click the **Authorize** button in Swagger.
   - Paste the token in the format: `<your-token>`.

4. Access secured endpoints like `/api/books`.

---

## **Endpoints Overview**

### **1. Authentication**

| Method | Endpoint         | Description                |
|--------|------------------|----------------------------|
| POST   | `/api/auth/login` | Generates a JWT token.     |

### **2. Books**

| Method | Endpoint          | Description                      |
|--------|-------------------|----------------------------------|
| GET    | `/api/books`      | Retrieves all books.             |
| POST   | `/api/books/{id}/borrow` | Borrows a book by ID.          |

---

## **Tips for Success** 🌟

- Use **strong, secret keys** for JWT to ensure security.
- Store tokens securely (e.g., HttpOnly cookies for web apps).
- Always validate the JWT token on the server side.

---

## **Future Enhancements** 🚀

- Add user roles and claims for role-based authorization.
- Implement refresh tokens for long-lived sessions.
- Add search and filtering options for books.

---

## **Contributing**

Feel free to fork the repository, create pull requests, or raise issues for enhancements or bugs. Contributions are always welcome! 💻

---

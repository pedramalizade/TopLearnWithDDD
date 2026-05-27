# TopLearn - Enterprise Educational Platform

An enterprise-inspired educational platform built with modern software engineering principles using **ASP.NET Core**, **Domain-Driven Design (DDD)**, **CQRS**, and **Clean Architecture**.

This project demonstrates how to design and implement a scalable, maintainable, and domain-centric application by applying real-world architectural patterns and best practices used in modern backend systems.

---

## 🚀 Overview

TopLearn is an online learning platform designed to simulate a real-world educational ecosystem where users can explore courses, watch lessons, manage payments, interact through comments and reviews, and securely authenticate into the system.

The project focuses heavily on **software architecture**, **domain modeling**, and **maintainable backend design**, rather than just CRUD implementation.

---

## 🏛️ Architecture & Design Principles

This project is built using enterprise-level architectural concepts:

- **Domain-Driven Design (DDD)**
- **CQRS (Command Query Responsibility Segregation)**
- **Clean Architecture**
- **Aggregate Root Pattern**
- **Factory Pattern**
- **Value Objects**
- **Domain Events**
- **Custom Domain Exceptions**
- **Dependency Injection**
- **Caching Strategies**
- **Validation Pipeline using FluentValidation**

The architecture is designed to encourage:

- Separation of concerns
- High maintainability
- Testability
- Scalability
- Domain-centric business logic

---

## 🧩 Features

### 👤 User Management
- User registration and authentication
- Role-based authorization
- JWT authentication mechanism
- Secure access management

### 🎓 Course Management
- Course creation and management
- Category-based organization
- Video lesson support
- Course-related interactions

### 💳 Payment Management
- Payment handling system
- Transaction processing workflow
- Business-oriented payment logic

### 🔐 Authentication & Authorization
- JWT-based authentication
- Secure API endpoints
- Authorization mechanisms

### 📝 Comments & Reviews
- Course feedback system
- User interaction and engagement

### 📚 Categories
- Categorized learning experience
- Organized course structure

### 🎥 Video Lessons
- Video-based learning modules
- Lesson management system

---

## ⚙️ Tech Stack

### Backend
- ASP.NET Core
- Entity Framework Core (EF Core)
- SQL Server

### Security
- JWT Authentication
- Authorization Policies

### Validation
- FluentValidation

### Documentation
- Swagger / OpenAPI

### Performance
- Caching

---

## 🧠 Domain-Driven Design Concepts Used

This project applies several DDD tactical patterns:

### Aggregate Roots
Aggregates are designed to maintain consistency boundaries and enforce domain rules.

### Value Objects
Immutable domain concepts are modeled using value objects to improve expressiveness and prevent invalid states.

### Domain Events
Domain events are used to decouple business workflows and improve extensibility.

### Factories
Factories encapsulate object creation logic and ensure domain invariants are respected.

### Domain Exceptions
Custom exceptions are used to enforce business rules and provide meaningful domain-specific feedback.

---

## 📂 Project Structure

```bash
TopLearn
│── Domain
│── Application
│── Infrastructure
│── Persistence
│── API
```

Following **Clean Architecture** principles to keep business logic independent from external concerns.

---

## 🌱 Seed Data

The project includes seed data to simplify development, testing, and local environment setup.

---

## 📖 API Documentation

Swagger is integrated for API testing and documentation.

After running the project, navigate to:

```bash
/swagger
```

---

## 🚀 Getting Started

### Prerequisites

- .NET SDK
- SQL Server
- Visual Studio / Rider

### Clone the repository

```bash
git clone https://github.com/pedramalizade/TopLearnWithDDD.git
```

### Configure Database

Update the connection string inside:

```bash
appsettings.json
```

### Run Migrations

```bash
update-database
```

### Run the project

```bash
dotnet run
```

---

## 🎯 Project Goals

The purpose of this project is to explore and implement:

- Enterprise application architecture
- Scalable backend design
- Domain modeling using DDD
- CQRS-based separation
- Secure authentication systems
- Maintainable and clean code structure

---

## 🤝 Contributions

Contributions, suggestions, and discussions are always welcome.

---

## 📄 License

This project is intended for educational and portfolio purposes.

# 🎓 SchoolPortal — Final Project (.NET 8 + Docker)

A containerized school management system built with **ASP.NET Core MVC (.NET 8)**, demonstrating a **microservices architecture** using **Docker Compose**, **SQL Server**, and inter-service communication via **HttpClient**.

---

## 🚀 Tech Stack

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core (Code-First)
- SQL Server (Docker Container)
- Docker & Docker Compose
- HttpClient (Microservice Communication)
- Razor Views

---

## 🏗️ System Architecture

The system consists of **3 containers**:

### 👨‍🎓 Students MVC Service (`students-mvc`)
- 🌐 URL: http://localhost:5001
- Full CRUD operations for students
- Acts as the **source of truth** for student data
- Provides JSON API endpoint for integration

---

### 🧾 Grades MVC Service (`grades-mvc`)
- 🌐 URL: http://localhost:5002
- Full CRUD operations for grades
- Fetches student data from Students service using **HttpClient**
- Displays combined data (**Grade + Student Name**)

---

### 🗄️ SQL Server Container
- Stores application data
- Uses Docker volume for persistence (`sql_data`)
- Contains `StudentsDb` and `GradesDb`

---

## 🔗 Service Communication

The Grades service communicates with the Students service inside Docker using:http://students-mvc/
No `localhost` communication is used between containers.  
Services communicate via **Docker service names** inside a shared network.

---
## 🐳 How to Run

### 🔧 Build and Start All Services

```bash
docker compose up --build

All services communicate through a shared Docker network: school-net

📁 Project Structure
SchoolPortal/
├── Students.Mvc
│   ├── Controllers
│   ├── Models
│   ├── Views
│   └── Data
│
├── Grades.Mvc
│   ├── Controllers
│   ├── Services (HttpClient)
│   ├── Models
│   └── Views
│
├── docker-compose.yml
└── README.md
🎯 Purpose of Project

This project demonstrates:

How to build real-world microservices
How to connect services using Docker networking
How to manage data using EF Core + SQL Server
How to handle inter-service communication safely

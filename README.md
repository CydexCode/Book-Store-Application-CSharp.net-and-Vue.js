# 📘 Book Store Project Overview

Welcome to the Book Store Project! This project aims to provide a comprehensive overview of its architecture, tech stack, and design patterns utilized.

## Architecture: 4-Layer 🏗️

The Book Store Project is structured using a 4-layer architecture to ensure separation of concerns and maintainability:

- **UI 🌐**: Responsible for presenting information to users and handling user interactions.
- **Business 💼**: Contains the core business logic and rules of the application.
- **Data Access 🛠️**: Handles interactions with the data storage system.
- **Database 🗃️**: Stores the data used by the application.

## Tech Stack:

- **Backend: C# (.NET, REST API) 🖥️**: The backend is built using C# and the .NET framework(netcoreapp3.1), providing robustness and scalability. It exposes RESTful APIs to interact with the frontend.
- **Frontend: Vue.js 🖼️**: The frontend is developed using Vue.js, a progressive JavaScript framework. Vue.js offers flexibility and performance, making it suitable for dynamic web applications.
- **Database: SQL, Entity Framework 🛢️**: SQL databases are used to store application data, and Entity Framework is utilized for data modeling, querying, and manipulation within the .NET ecosystem.

## Design Patterns: Creational

The Book Store Project incorporates various creational design patterns to improve maintainability and flexibility:

1. **Singleton Pattern 🏢**: Manages database connections efficiently by ensuring that only one instance of the connection exists throughout the application's lifecycle.
   
2. **Factory Method 🏭**: Facilitates object creation in the Business Layer by providing an interface for creating objects without specifying their concrete classes.
   
3. **Abstract Factory 🔄**: Promotes UI component modularity by providing an interface for creating families of related or dependent objects without specifying their concrete classes.
   
4. **Builder Pattern 🔨**: Simplifies the construction of complex query objects in the Data Access layer, allowing the creation of different representations of a query using the same building process.

## Installation and Setup

To set up the Book Store Project locally, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/CydexCode/Book-Store-Application-CSharp.net-and-Vue.js

2. Run the Code

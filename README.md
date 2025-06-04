# DocumentApp

A modular C# console-based document processor app demonstrating "abstraction", "inheritance", and "interface segregation"-  
- principles with a focus on real-world document types like PDF, Word, and Excel. Designed with clean folder architecture for educational purposes.

---

## Features

- Create and process PDF, Word, and Excel documents.
- Use of Factory Pattern to create document instances.
- Practice abstract classes, interfaces, method overriding, composition, and file operations.
- Includes metadata validation and file parsing.

---

## Technologies Used

- Language: C#
- Platform: Ubuntu (Mono / .NET SDK)
- IDE: Visual Studio Code
- Run Tool: "dotnet" or "mcs + mono"

---

## Folder Structure

DocumentApp/
│
├── bin/ # Compiled binaries
├── obj/ # Temporary object files
│
├── Documents/ # Core document logic
│ ├── DocumentFactory.cs
│ ├── DocumentProcessor.cs
│ ├── ExcelDoc.cs
│ ├── PdfDoc.cs
│ ├── WordDoc.cs
│ ├── Interfaces.cs
│ └── Metadata.cs
│
├── Helpers/ # Utility classes
│ └── Validator.cs
│
├── Data/ # Sample data files
│ ├── jason.csv
│ └── Life of pi.txt
│
├── Menu/ # Menu interaction
│ └── MenuOperation.cs
│
├── Program.cs # Entry point
├── DocumentApp.csproj # Project configuration
└── DocumentApp.sln # Solution file

---

## How to Build and Run

This section guides you to build and run the project on **Ubuntu** using **VS Code** and **.NET SDK**.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- Visual Studio Code with the 'C# Extension'/ Visual Studio
- Terminal access on Ubuntu

### Steps

bash
### Step 1: Open terminal and navigate to the project root directory
cd ~/DocumentApp

### Step 2: Restore project dependencies
dotnet restore

### Step 3: Build the project
dotnet build

### Step 4: Run the project
dotnet run

--

## Author

Suraj Tamang
C# Learner, exploring .NET world step-by-step from console to full stack.
Email: Suraj Tamang
Location: Nepal





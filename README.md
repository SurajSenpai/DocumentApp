# DocumentApp

A modular C# console-based document processor app demonstrating key OOP principles such as **abstraction**, **inheritance**, and **interface segregation** with a focus on real-world document types like **PDF, Word, and Excel**. Designed with clean folder architecture for educational purposes.

---

## Features

- Create and process **PDF**, **Word**, and **Excel** documents.
- Uses the **Factory Pattern** to create document instances dynamically.
- Demonstrates **abstract classes**, **interfaces**, **method overriding**, **composition**, and **file operations**.
- Validates metadata and supports structured file parsing.

---

## Technologies Used

- **Language:** C#
- **Platform:** Ubuntu (Mono / .NET SDK)
- **IDE:** Visual Studio Code
- **Build/Run Tool:** `dotnet` CLI or `mcs` with `mono`

---

## Folder Structure

```
DocumentApp/
├── bin/                     # Compiled binaries
├── obj/                     # Temporary object files

├── Documents/               # Core document logic
│   ├── DocumentFactory.cs
│   ├── DocumentProcessor.cs
│   ├── ExcelDoc.cs
│   ├── PdfDoc.cs
│   ├── WordDoc.cs
│   ├── Interfaces.cs
│   └── Metadata.cs

├── Helpers/                 # Utility classes
│   └── Validator.cs

├── Data/                    # Sample data files
│   ├── jason.csv
│   └── Life of pi.txt

├── Menu/                    # Menu interaction logic
│   └── MenuOperation.cs

├── Program.cs               # Entry point
├── DocumentApp.csproj       # Project configuration
└── DocumentApp.sln          # Solution file
```



---

## How to Build and Run (Ubuntu + .NET SDK)

### Prerequisites

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
- Visual Studio Code with the **C# Extension** or Visual Studio
- Terminal access on Ubuntu

### Steps

```bash
# Step 1: Open terminal and navigate to the project root
cd ~/DocumentApp

# Step 2: Restore dependencies
dotnet restore

# Step 3: Build the project
dotnet build

# Step 4: Run the application
dotnet run
```

---

## Author

- **Name:** Suraj Tamang(C# Learner, exploring .NET world step-by-step from console to full stack.)
- **Email:** xenonepal0101@gmail.com
- **Location:** Nepal

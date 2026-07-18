# Variable Declaration, Initialization, Assignment and Display

> **Chapter 1 – Variables**

This project is part of the **CSharpPractice** repository, a structured collection of C# exercises and projects designed to strengthen programming fundamentals through practical implementation and professional software development practices.

---

# Overview

Variables are one of the most fundamental building blocks in C#. This project demonstrates how variables are declared, initialized, assigned values, read from user input, and displayed within a .NET Console Application.

The project serves as an introduction to storing and manipulating data — using explicit types, implicit (`var`) typing, safe string parsing, and multiple output formatting styles — while following clean coding and documentation practices.

---

# Objectives

The objectives of this project are to:

- Demonstrate variable declaration using explicit types (`int`, `double`, `bool`, `string`, `decimal`).
- Demonstrate refactoring variables to implicit typing using `var`.
- Demonstrate reading user input safely with `Console.ReadLine()` and `.Parse()`.
- Display variable values using `Console.WriteLine()`.
- Demonstrate three output formatting styles: string concatenation, composite formatting, and string interpolation.

---

# Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Programming language |
| .NET | Application framework |
| Visual Studio 2022 | Integrated Development Environment (IDE) |
| Git | Version control |
| GitHub | Source code hosting and repository management |

---

# Project Structure

```

```

### Folder Description

| Folder/File | Description |
|-------------|-------------|
| Images | Stores screenshots and diagrams used in the documentation. |
| Program.cs | Contains the source code for the exercise. |
| README.md | Project documentation. |

---

# Development Method

The project was developed using the following workflow:

1. Understand the exercise requirements (spec 1.1.1–1.2 in the exercise suite).
2. Design the program logic (declare → refactor to `var` → prompt/parse → display).
3. Implement the solution in C#.
4. Test the application against the sample console output in the exercise suite.
5. Document the project.
6. Commit changes using Git.
7. Push the completed work to GitHub.

---

# Deployment Method

## Requirements

- Visual Studio 2022
- .NET SDK
- Git (Optional)

## Steps

1. Clone the repository.
2. Open the solution using Visual Studio.
3. Build the project.
4. Run the application.
5. Verify the console output.

---

# Features

- Explicit-typed variable declaration
- Implicit (`var`) typed variable declaration
- Safe user input parsing (`int.Parse`, `double.Parse`, `bool.Parse`, `decimal.Parse`)
- Console output via concatenation, composite formatting, and string interpolation

---

# Release Notes

## Version 1.0.0

### Initial Release

Features included:

- Implemented variable declaration with explicit types.
- Refactored declarations to use `var`.
- Implemented `Console.WriteLine()` display using concatenation.
- Implemented composite formatting and string interpolation display styles.
- Implemented interactive user input via `Console.ReadLine()` with safe type parsing.
- Added project documentation.
- Added Git version control.

---

# Program Flow

The application follows the workflow below.

## Flowchart

> *(Insert Flowchart image here)*

```markdown
(diagram.png
```

---

# Use Case Diagram

The user runs the application, enters their nickname, age, height, residency status, estimated net worth, and LinkedIn profile when prompted, and the system displays a formatted summary back to the console.

> *(Insert Use Case Diagram here)*

```markdown
![Use Case Diagram](Images/UseCaseDiagram.png)
```





---

# Testing

## Test Plan

The project was tested to verify that:

- Variables are declared and initialized correctly with both explicit types and `var`.
- User input is read and parsed into the correct type without runtime errors on valid input.
- Console output matches the expected results and formatting for each display style.

---

# Test Cases

| Test ID | Test Description | Expected Result | Status |
|----------|------------------|-----------------|--------|
| TC-001 | Declare variables with explicit types | Variables are successfully created with correct types | ✅ Pass |
| TC-002 | Refactor variables to `var` | Compiler infers correct type from initializer | ✅ Pass |
| TC-003 | Parse valid user input | Value is correctly converted to its target type | ✅ Pass |
| TC-004 | Display variable values (concatenation) | Correct values appear in the console | ✅ Pass |
| TC-005 | Display variable values (composite formatting) | Correct values appear in the console | ✅ Pass |
| TC-006 | Display variable values (string interpolation) | Correct values appear in the console | ✅ Pass |
| TC-007 | Enter invalid boolean input (e.g. "yes") | `FormatException` thrown (known limitation — no validation yet) | ⚠️ Expected failure |

---

# Sample Output

> *(Insert screenshot here)*

```markdown
![Program Output](Images/ProgramOutput.png)
```




---

# References

- Microsoft Learn
- Microsoft C# Documentation
- .NET Documentation
- Visual Studio Documentation
- Git Documentation
- GitHub Documentation
- C# .NET Practices Exercise Suite (Course Material)

---

# Author

**Donald Mudzani**

Repository: **CSharpPractice**

2026
This project introduces the fundamental concepts of variables in C#. Understanding variables is essential because almost every C# application stores and manipulates data using variables.
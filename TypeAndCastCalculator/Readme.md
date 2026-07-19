


# Data Types and Casting
 
> **( Data Types and Casting)**
 
This project is part of the **CSharpPractices** repository, a structured collection of C# exercises and projects designed to strengthen programming fundamentals through practical implementation and professional software development practices.
 
---
 
# Overview
 
This project demonstrates arithmetic operations on integer input and the importance of explicit type casting when working with division in C#. It highlights how integer division truncates fractional results, and how an inline cast to `double` prevents that truncation.
 
---
 
# Objectives
 
The objectives of this project are to:
 
- Prompt the user for two integer values.
- Perform addition and store the result in a `sum` variable.
- Perform division and store the result in a `quotient` variable.
- Demonstrate safe handling of integer division using an explicit inline type-cast (`(double)`) to prevent fractional truncation.
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
| Program.cs | Contains the source code for the exercise. |
| README.md | Project documentation. |
 
---
 
# Development Method
 
The project was developed using the following workflow:
 
1. Understand the exercise requirements (spec 1.3.1 in the exercise suite).
2. Design the program logic (prompt → parse → add → divide with safe cast → display).
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
 
- Integer input parsing (`int.Parse`)
- Addition without truncation risk
- Division with explicit inline cast to `double` to prevent integer-division truncation
- Console output via string interpolation
---
 
# Release Notes
 
## Version 1.0.0
 
### Initial Release
 
Features included:
 
- Implemented prompting and parsing of `number1` and `number2` as integers.
- Implemented `sum` calculation via addition.
- Implemented `quotient` calculation via division, using an inline `(double)` cast on `number1` to prevent truncation.
- Displayed both results using string interpolation.
- Added project documentation.
- Added Git version control.
---
 
# Program Flow
 
The application follows the workflow below.
 
## Flowchart
 
> 
 
```
```
 
---
 
# Use Case Diagram
 
The user runs the application, enters two integer numbers when prompted, and the system displays the sum and the (non-truncated) quotient of the two numbers.
 
>
 
```
```
 
---
 
# Testing
 
## Test Plan
 
The project was tested to verify that:
 
- Integer input is parsed correctly.
- Addition produces the correct integer sum.
- Division produces a correctly-cast decimal result rather than a truncated integer result.
- Console output matches the expected labelled format.
---
 
# Test Cases
 
| Test ID | Test Description | Expected Result | Status |
|----------|------------------|-----------------|--------|
| TC-001 | Enter two valid integers | Both values parsed correctly as `int` | ✅ Pass |
| TC-002 | Add two integers (e.g. 2 + 3) | `sum` = 5 | ✅ Pass |
| TC-003 | Divide two integers with a non-whole result (e.g. 2 / 3) | `quotient` displays as a decimal (e.g. 0.6666666666666666), not truncated to 0 | ✅ Pass |
| TC-004 | Divide two integers with a whole result (e.g. 4 / 2) | `quotient` displays as 2 | ✅ Pass |
 
---
 
# Sample Output
 
> 
 
```
```
 
---
 
# Future Improvements
 
Potential enhancements include:
 
- Adding subtraction, multiplication, and modulus operations.
- Adding input validation to handle non-numeric input gracefully (covered later in Chapter 12 – Exception Handling).
- Rounding the displayed quotient to a fixed number of decimal places for readability.
---
 
# Change Requests
 
No change requests have been implemented.
 
Future enhancements will only be introduced after the original project requirements have been completed.
 
---
 

 
# Author
 
**Donald Mudzani**
 
Repository: CSharpPractices
 

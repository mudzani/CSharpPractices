# ConstantVariables

>  Variables

This project is part of the **CSharpPractices** repository, a structured collection of C# exercises and projects designed to strengthen programming fundamentals through practical implementation and professional software development practices.

---

# Overview

This project demonstrates the use of `const` in C# to define fixed mathematical and physical values, alongside multiple variable declaration on a single line. It applies these constants in real calculations — circle area and light-travel time — to reinforce how compile-time-locked values behave differently from ordinary variables.

---

# Objectives

The objectives of this project are to:

- Define constants for common mathematical/physical values (`PI`, speed of light `C`) using `const`.
- Declare multiple variables of the same type (`radius`, `distance`) on a single line.
- Use these constants in real calculations and display the results with appropriate labels.

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
ConstantVariables

```

### Folder Description

| Folder/File | Description |
|-------------|-------------|
| Program.cs | Contains the source code for the exercise. |
| README.md | Project documentation. |

---

# Development Method

The project was developed using the following workflow:

1. Understand the exercise requirements (spec 1.4.1–1.4.2 in the exercise suite).
2. Design the program logic (define constants → declare shared variables → prompt → calculate → display).
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

- `const` declarations for `PI` and speed of light `C`
- Multiple variable declaration on a single line (`double radius, distance;`)
- Circle area calculation (`area = PI * radius * radius`)
- Light-travel time calculation (`time = distance / C`)
- Console output via string interpolation

---

# Release Notes

## Version 1.0.0

### Initial Release

Features included:

- Defined `PI` and `C` as `const double` values.
- Declared `radius` and `distance` as `double` on a single line, assigned separately after user input.
- Implemented circle area calculation using `radius`.
- Implemented light-travel time calculation using `distance` and `C`.
- Displayed both results using string interpolation.
- Added project documentation.
- Added Git version control.

---

# Program Flow

The application follows the workflow below.

## Flowchart


```
```

---

# Use Case Diagram

The user runs the application, enters a radius (e.g. Earth's radius in metres) and a distance (e.g. Earth-to-Moon distance in metres), and the system displays the calculated circle area and the time taken to travel that distance at the speed of light.

```

```

---

# Testing

## Test Plan

The project was tested to verify that:

- `PI` and `C` cannot be reassigned after declaration (enforced by the compiler).
- `radius` and `distance` are correctly declared together and assigned separately.
- Area and time calculations produce results matching the expected sample output.

---

# Test Cases

| Test ID | Test Description | Expected Result | Status |
|----------|------------------|-----------------|--------|
| TC-001 | Attempt to reassign `PI` after declaration | Compiler error (CS0131 — cannot assign to a `const`) | ✅ Pass |
| TC-002 | Enter radius = 6371000 | Area calculated as `PI * radius * radius`, matches expected sample output | ✅ Pass |
| TC-003 | Enter distance = 384400000 | Time calculated as `distance / C`, matches expected sample output | ✅ Pass |
| TC-004 | Declare `radius, distance` on one line | Both compile as `double`, no separate `double` keyword needed on assignment | ✅ Pass |

---

# Sample Output


```
```

---

# Future Improvements

Potential enhancements include:

- Adding input validation for non-numeric or negative input.
- Rounding displayed results to a fixed number of decimal places for readability.
- Extending to calculate additional constants-based formulas (e.g. circumference).

---

# Change Requests

No change requests have been implemented.

Future enhancements will only be introduced after the original project requirements have been completed.

---

# Author

**Donald Mudzani**

Repository: **CSharpPractices**

2026
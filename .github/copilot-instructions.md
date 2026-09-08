# Project Instructions

## Project
    This is an ASP.NET Web Core API project that manages order creation, searching for orders and just showing orders
## Architecture
    - OrderController.cs in Controllers
    - OrderModel.cs in Models
    - Index.cshtml in Views/Order

## Rules

# Testing
    Write unit tests for all controller actions before merging any changes

    Test coverage must be at least 80% for new code

    Test both success and failure scenarios for API endpoints

    Validate model validation rules in tests

    Use xUnit as the testing framework

    Mock external dependencies using Moq

    Tests must pass in CI/CD pipeline

# Before Changing Code
    Review existing code to understand current implementation

    Check if there are existing tests that might be affected

    Confirm the change is necessary and properly documented

    Update the project documentation if needed

    Consider backward compatibility implications

# After
    Run all tests to ensure no regressions were introduced

    Update the change log with a brief description of the changes

    Clean up any debug code, console logs, or commented-out code

    Optimize performance if applicable

    Add comments for complex logic

    Update Swagger/OpenAPI documentation for API changes *If Swagger exists

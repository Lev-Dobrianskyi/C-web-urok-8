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

    Include integration tests for database operations

    Test both success and failure scenarios for API endpoints

    Validate model validation rules in tests

    Use xUnit as the testing framework

    Mock external dependencies using Moq

    Run all tests locally before creating a pull request

    Tests must pass in CI/CD pipeline

# Before Changing Code
    Review existing code to understand current implementation

    Check if there are existing tests that might be affected

    Confirm the change is necessary and properly documented

    Create a feature branch following naming convention: feature/description or bugfix/description

    Pull the latest changes from the main branch

    Update the project documentation if needed

    Consider backward compatibility implications

    Check for any open issues or pull requests that might conflict

# After
    Run all tests to ensure no regressions were introduced

    Update the change log with a brief description of the changes

    Clean up any debug code, console logs, or commented-out code

    Optimize performance if applicable

    Add comments for complex logic

    Update Swagger/OpenAPI documentation for API changes

    Create a pull request with clear description of changes

    Request code review from at least one team member

    Ensure the build succeeds in the CI/CD pipeline

    Deploy to staging environment first before production
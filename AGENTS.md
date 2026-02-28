```markdown
# AGENTS.md Guidelines

These guidelines outline the principles and requirements for the AGENTS.md file, ensuring a maintainable, scalable, and robust AI coding agent project.  Adherence to these principles is mandatory for all development activities.

**1. DRY (Don't Repeat Yourself)**

*   All functionalities and code snippets must be encapsulated within individual, well-named files.
*   Existing code should be refactored and extracted into dedicated components where appropriate, rather than being duplicated.
*   Use functions and classes to encapsulate reusable logic.

**2. KISS (Keep It Simple, Stupid)**

*   Code should be as concise and easily understandable as possible.
*   Avoid unnecessary complexity.
*   Prioritize readability over cleverness.
*   Favor straightforward solutions over convoluted ones.

**3. SOLID Principles**

*   **Single Responsibility Principle:** Each class/function should have a single, well-defined responsibility.
*   **Open/Closed Principle:** The system should be extensible without modifying its core code.  New functionality should be added through new classes/functions, not by modifying existing ones.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Clients should not be forced to implement interfaces they do not use.
*   **Dependency Inversion Principle:**  High-level modules (classes) should not depend on low-level modules (classes).  They should depend on abstractions.

**4. YAGNI (You Aren't Gonna Need It)**

*   Avoid adding functionality or code that is not currently required.
*   Focus on the core functionality and the essential requirements.
*   Refactor existing code to remove unneeded elements.

**5. Code Structure & File Management**

*   **File Size Limit:** Each file must be no more than 180 lines of code.  Any code exceeding this limit will be rejected.
*   **Naming Conventions:** Files must follow a consistent naming convention (e.g., `agent_module.py`).
*   **Directory Structure:**  A logical directory structure is essential. Suggested structure:
    ```
    AGENTS.md
    ├── __init__.py
    ├── config.py
    ├── agents.py
    ├── utils.py
    ├── models.py
    ├── data_management.py
    └── ... (other modules)
    ```
*   **Module Structure:** Modules should be organized logically and have clear responsibilities.
*   **Documentation:**  Use docstrings to explain the purpose, parameters, and return values of functions, classes, and modules.  Docstrings should be clear and concise.

**6. Test Coverage Requirements**

*   **Minimum:** 80% of the code must be covered by tests.
*   **Test Types:**  Include unit tests, integration tests, and potentially end-to-end tests where applicable.
*   **Test Framework:** Utilize a standard testing framework (e.g., `unittest`, `pytest`).
*   **Test Organization:**  Organize tests logically, grouping related tests together.

**7. Code Quality & Style**

*   **Comments:**  Include concise comments explaining complex logic or non-obvious decisions.  Don’t over-comment.
*   **Naming:** Use descriptive and consistent naming conventions.
*   **Whitespace:**  Follow PEP 8 style guidelines for whitespace.
*   **Error Handling:** Implement robust error handling and logging.

**8.  Specific Considerations (Specific to AGENTS):**

*   **Agent State Management:**  Clearly define and document the agent's state model.
*   **Communication Protocols:**  Provide clear specifications for agent communication.
*   **Data Storage:**  Specify the data storage mechanisms and strategies.
*   **Security:**  Consider security implications when implementing agent functionalities.

**9.  Development Practices**

*   **Version Control:** Use Git for version control.
*   **Code Reviews:** Implement a code review process to ensure code quality and adherence to standards.
*   **Continuous Integration (CI):**  Consider integrating CI/CD for automated testing and building.

**10.  Dependencies:**

*   All external dependencies must be listed in a `requirements.txt` file.  This should be kept updated.

These guidelines are intended to provide a foundation for the AGENTS.md file.  Regular review and updates are encouraged to maintain the project's health and maintainability.
```
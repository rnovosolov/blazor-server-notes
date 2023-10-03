# Blazor Server Notes - Junior C# Developer Test Task

Blazor Server Notes is a test task for a Junior Developer position. It is a simple web application built using Blazor Server and PostgreSQL that allows users to manage notes. It provides basic functionality for adding, editing, and deleting notes. There is no authentication implemented, so users can view and edit all notes.

Please note that the connection string to the PostgreSQL database is stored in a secrets configuration. When cloning the repository, make sure to add your own connection string to the secrets configuration to ensure proper database connectivity.

**To add your connection string use following commands:**

`dotnet user-secrets init`

`dotnet user-secrets set ConnectionStrings:DefaultConnection "Host=localhost;Port=5432;Database=BlazorServerNotesDB;Username=postgres;Password=password;"`



## Features

- Create new notes with titles and content.
- Edit existing notes.
- Delete notes.
- Search notes by title or content.

## Getting Started

To run this project locally, follow these steps:

1. **Clone the Repository:**


`git clone https://github.com/rnovosolov/BlazorServerNotes.git
cd BlazorServerNotes`

2. **Build and Run the Application:**

`dotnet run`

3. **Open the Application:**

Once the application is running, open your web browser and navigate to `https://localhost:5001` to access the Blazor Server Notes application.

## Usage

 **Add New Note:**
- Click on the "New Note" button to create a new note.
- Fill in the title and content fields.
- Click the "Add" button to save the note.

 **Edit Note:**
- Click the "Edit" button next to a note to edit it.
- Update the title or content as needed.
- Click the "Save" button to save your changes.

 **Delete Note:**
- Click the "Delete" button next to a note to remove it.
- Confirm the deletion when prompted.

 **Search Notes:**
- Use the search bar at the top to filter notes by title or content.

## Running Tests

This project includes xUnit tests for the CRUD (Create, Update, Delete) operations. To run the tests, follow these steps:

1. **Navigate to the Tests Folder:**

`cd BlazorServerNotes.Tests`

2. **Run the Tests:**

`dotnet test`



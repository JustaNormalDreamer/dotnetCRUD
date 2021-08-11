### Dotnet REST API
#### CRUD Operations with dotnet using Entity Framework, uses postgres database.

### Installation
<p>Install Postgres DB, and create a db name dotnet incase of using different db and user, configure in the appsettings.json.</p>


### Entities
    - Person
    - Post

### Endpoints
    - For Persons
        - Fetch all persons: GET: http://localhost:5001/api/v1/persons
        - Fetch single person: GET: http://localhost:5001/api/v1/persons/{id}
        - Store person: POST: http://localhost:5001/api/v1/persons
        - Update person: PUT: http://localhost:5001/api/v1/persons/{id}
        - Delete person: DELETE: http://localhost:5001/api/v1/persons/{id}

    - For Posts
        - Fetch all posts: GET: http://localhost:5001/api/v1/posts
        - Fetch single post: GET: http://localhost:5001/api/v1/posts/{id}
        - Store post: POST: http://localhost:5001/api/v1/posts
        - Update post: PUT: http://localhost:5001/api/v1/posts/{id}
        - Delete post: DELETE: http://localhost:5001/api/v1/posts/{id}
        
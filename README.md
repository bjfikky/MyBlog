## About myBlog
This is a Content Managment System that will allow an authenticated user to add posts to the website.

## Tools
- C#
- ASP.NET CORE 2.1
- Postgres database
- Model-View-Controller Architecture
- Entity Framework Core
- Razor Pages
- TinyMCE

## Models
1. **User** (setup using asp.net core identity)
2. **Post**
    - id (pk)
    - title
    - body
    - datetime
    - user (fk)
    - category (fk)
3. **Category**
    - id (pk)
    - name

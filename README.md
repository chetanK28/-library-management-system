
# **Library Management System**

The **Library Management System** is a web-based application designed to manage library operations such as adding, updating, viewing, and deleting books. This system streamlines library management and enables efficient tracking of books and their availability.

---

## **Features**

### **Manage Books**
- **Add new books** to the library.
- **Edit book details** like title, ISBN, genre, and availability.
- **Delete books** from the system.

### **View Books**
- Display a **list of all books** with details like title, author, publisher, genre, and availability.

### **Search Books**
- **Search for books** by title or other attributes (future enhancement).

### **Responsive Interface**
- Easy-to-use and **mobile-friendly web interface**.

---

## **Technologies Used**

### **Backend**
- **ASP.NET Core MVC**
- **Entity Framework Core** (optional for database ORM)
- **MySQL** for database management

### **Frontend**
- **Razor Views**
- **HTML, CSS, and Bootstrap** for responsive UI

### **IDE**
- **Visual Studio 2022**

---

## **Prerequisites**
- **.NET SDK** 6.0 or later
- **MySQL Server**
- **Visual Studio** or any code editor
- **A web browser**

---

## **Installation**

### 1. **Clone the Repository**
```bash
git clone https://github.com/chetanK28/-library-management-system.git
cd library-management-system
```

### 2. **Configure Database**
- Create a **MySQL database**.
- Update the `appsettings.json` file with your database connection string:
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "server=localhost;database=LibraryDB;user=root;password=your_password;"
    }
  }
  ```

### 3. **Restore Dependencies**
```bash
dotnet restore
```

### 4. **Run the Application**
```bash
dotnet run
```

### 5. **Access the Application**
- Open your browser and navigate to:  
  **`https://localhost:5001`**

---

## **Project Structure**

### **Controllers**
- `BookController.cs`: Handles requests and responses for book-related operations.

### **Models**
- `Book.cs`: Represents the book entity with properties like `BookID`, `Title`, `ISBN`, etc.

### **Repositories**
- `IBookRepository.cs`: Interface for book-related database operations.
- `BookRepository.cs`: Implements `IBookRepository` to interact with the database.

### **Services**
- `IBookService.cs`: Interface for business logic.
- `BookService.cs`: Implements `IBookService` to manage application logic.

### **Views**
- Razor views for **adding**, **editing**, **viewing**, and **managing books**.

---

## **Usage**

### 1. **Add Books**
- Navigate to the **"Add Book"** page and fill in the book details.
- Click **"Create"** to save the book in the library.

### 2. **View All Books**
- Navigate to the **"Get All Books"** page to see a list of all books in the library.

### 3. **Edit Books**
- Click **"Edit"** next to a book in the list to update its details.

### 4. **Delete Books**
- Click **"Delete"** to remove a book from the library.

---

## **Future Enhancements**
- Add **user authentication** and role-based access control (e.g., Admin and Librarian).
- Implement **book search functionality**.
- Add a **dashboard with statistics** (e.g., total books, available books).
- Enable **member management** and borrowing/return tracking.

---

## **Contributing**

### Steps to Contribute:
1. **Fork the repository**.
2. Create a **feature branch**:
   ```bash
   git checkout -b feature/your-feature
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add some feature"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/your-feature
   ```
5. Open a **pull request**.

---

## **License**
This project is licensed under the [MIT License](LICENSE).

---

## **Contact**

For any inquiries, feel free to reach out:
- **Email**: [chetankirange28@gmail.com](mailto:chetankirange28@gmail.com)

---

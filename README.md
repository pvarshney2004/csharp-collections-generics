# csharp-collections-generics
This repository focuses on Collections and Generics in C#, covering built-in collection libraries, generic classes and methods, and practical use cases.
The goal is to build a strong foundation in type-safe, efficient data handling and improve problem-solving skills using real-world examples.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio Code
- **Version Control:** Git & GitHub

---

## ✨ Features
- Structured **branch-wise learning approach**
- Separate branches for different **concepts**
- Beginner-friendly **C# practice problems**
- Focus on **logic building and fundamentals**

---

## 📂 Branch Structure

### 🔹 `generics` branch
This branch focuses on **Generics in C#**, demonstrating how to write **type-safe, reusable, and scalable code** using generic classes, generic methods, constraints, interfaces, and variance. The problems are modeled around **real-world systems** to show how generics improve flexibility while maintaining compile-time safety.

---

### 📝 Practice Problems

### Smart Warehouse Management System  
**Concepts:** Generic Classes, Constraints, Variance  
- Manage different warehouse items such as Electronics, Groceries, and Furniture.  
- Use a generic `Storage<T>` class constrained to a base `WarehouseItem`.  
- Store and display items safely using `List<T>`.

---

### Dynamic Online Marketplace  
**Concepts:** Type Parameters, Generic Methods, Constraints  
- Build a generic product catalog supporting multiple product categories.  
- Apply discounts using generic methods while ensuring type safety.  
- Support diverse product types within a single catalog.

---

### Multi-Level University Course Management System  
**Concepts:** Generic Classes, Constraints, Variance  
- Manage different course evaluation types such as exam-based and assignment-based courses.  
- Use a generic `Course<T>` class constrained to a base `CourseType`.  
- Handle multiple course types dynamically using collections.

---

### Personalized Meal Plan Generator  
**Concepts:** Generic Methods, Constraints, Interfaces  
- Generate meal plans like Vegetarian, Vegan, Keto, and High-Protein.  
- Use interfaces with generic classes to enforce meal plan rules.  
- Dynamically validate and generate meal plans using generic methods.

---

### AI-Driven Resume Screening System  
**Concepts:** Generic Classes, Generic Methods, Constraints  
- Process resumes for different job roles such as Software Engineer and Data Scientist.  
- Use a generic `Resume<T>` class constrained to a base `JobRole`.  
- Screen and manage multiple resumes efficiently using generic collections.

---

### 🎯 Learning Outcomes

- Understand generic classes and generic methods  
- Apply constraints and variance effectively  
- Improve code reusability and type safety  
- Design real-world systems using generics  
- Strengthen collection handling with generics

---

### 🔹 `collections` branch
This branch focuses on **C# Collection Libraries**, covering practical usage of  `List`, `Set`, `Queue`, and `Map (Dictionary)` through **problem-solving and real-world scenarios**.  
The emphasis is on **efficient data handling, traversal, modification, and edge-case management**.

---

📁 Folder Structure

collections/
├── List/
├── Set/
├── Queue/
├── Map/
└── Collections_Extra_Questions/

---

## 📂 List    
Problems based on the `List` interface focusing on element traversal, manipulation, and order preservation.

**Problem Statements:**  
- Reverse a list without using built-in reverse methods  
- Find frequency of elements using a dictionary  
- Rotate elements of a list by N positions  
- Remove duplicates while preserving order  
- Find the Nth element from the end of a linked list  

---

## 📂 Set   
Problems emphasizing uniqueness, set operations, and comparisons using `Set` collections.

**Problem Statements:**  
- Check whether two sets are equal  
- Find union and intersection of two sets  
- Compute symmetric difference  
- Convert a set into a sorted list  
- Check if one set is a subset of another  

---

## 📂 Queue   
Problems demonstrating FIFO behavior and priority-based processing using queues.

**Problem Statements:**  
- Reverse a queue using only queue operations  
- Generate first N binary numbers using a queue  
- Hospital triage system using a priority queue  

---

## 📂 Map  
Problems focused on key–value data handling using dictionaries.

**Problem Statements:**  
- Count word frequency from text input  
- Invert a dictionary to map values to multiple keys  

---

## 📂 Collections Extra Questions (Advanced Scenarios)

### Chat Message Cleanup System  
**Data Structures Used:**  
`Dictionary<string, LinkedList<Message>>`

**Tasks:**  
- Delete messages:
  - Older than 30 days  
  - Read and not starred  
- Fetch last `N` valid messages efficiently  

**Edge Cases:**  
- Deleting while traversing  
- Message exactly 30 days old  
- All messages deleted  
- Order preservation  
- Null references  

---

### Student Performance Analyzer  
**Data Structures Used:**  
- `List<Student>`  
- `Dictionary<int, List<int>>` (RollNo → Marks)

**Tasks:**  
- Calculate average marks  
- Pass criteria:
  - Average ≥ 40  
  - No subject < 30  
- Display:
  - Students passed overall but failed in ≥1 subject  
  - Top scorer per subject  
- Remove students failing 3 consecutive exams  

**Edge Cases:**  
- No marks recorded  
- Boundary marks (30, 40)  
- Different subject counts  
- Safe removal during iteration  
- Duplicate roll numbers  

---

## 🎯 Learning Outcomes

- Master List, Set, Queue, and Dictionary usage  
- Handle real-world edge cases safely  
- Improve data traversal and mutation logic  
- Strengthen problem-solving with collections  
- Write efficient and maintainable C# code
  
---

## 👤 Author
**Prashant Varshney**  
B.Tech CSE (Data Analytics) 

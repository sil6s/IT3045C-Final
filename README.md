# **IT3045C Final Project: Team Member Database**

## **Overview**
This project provides a structured way to manage data about team members and their related information, such as:
- **Breakfast habits**
- **Hobbies**
- **Pets**

The database consists of four main tables: `TeamMembers`, `BreakfastFood`, `Hobbies`, and `Pets`, with well-defined relationships that make querying and data manipulation efficient.

---

## **Database Structure**
Our database has the following structure:

### **TeamMember Table**
Holds the primary data about each team member.  
**Fields:**
- `Id`: Primary Key
- `FullName`: Name of the team member
- `Birthdate`: The date they were born
- `CollegeProgram`: Their program of study
- `YearInProgram`: Current year (e.g., Freshman, Sophomore)

---

### **BreakfastFood Table**
Stores information about the breakfast habits of a team member.  
**Fields:**
- `Id`: Primary Key
- `BreakfastYN`: Indicates whether they eat breakfast
- `Drink`: Favorite drink (e.g., coffee, tea)
- `Protein`: Main protein source (e.g., eggs, sausage)
- `Carbs`: Main carbohydrate source (e.g., bread, cereal)
- `FruitsOrVeggies`: Fruits or veggies included in the meal
- `TeamMemberId`: Foreign Key linking to the `TeamMember` table

---

### **Hobby Table**
Tracks the hobbies a team member enjoys.  
**Fields:**
- `Id`: Primary Key
- `HobbyYN`: Indicates whether they have hobbies
- `Artistic`: Artistic hobby (e.g., painting, drawing)
- `Athletic`: Athletic hobby (e.g., soccer, running)
- `Musical`: Musical hobby (e.g., guitar, singing)
- `Academic`: Academic hobby (e.g., reading, writing)
- `TeamMemberId`: Foreign Key linking to the `TeamMember` table

---

### **Pet Table**
Stores information about the pets owned by a team member.  
**Fields:**
- `Id`: Primary Key
- `PetType`: Type of pet (e.g., dog, cat)
- `Name`: Pet’s name
- `Age`: Age of the pet
- `Color`: Color of the pet
- `Gender`: Gender of the pet
- `TeamMemberId`: Foreign Key linking to the `TeamMember` table

---

## **Entity-Relationship Diagram (ERD)**

Below is the visual representation of the relationships between the tables, using **Mermaid** syntax for rendering diagrams:

```mermaid
erDiagram
    TEAMMEMBER {
        int Id PK
        string FullName
        date Birthdate
        string CollegeProgram
        string YearInProgram
    }
    BREAKFASTFOOD {
        int Id PK
        string BreakfastYN
        string Drink
        string Protein
        string Carbs
        string FruitsOrVeggies
        int TeamMemberId FK
    }
    HOBBY {
        int Id PK
        string HobbyYN
        string Artistic
        string Athletic
        string Musical
        string Academic
        int TeamMemberId FK
    }
    PET {
        int Id PK
        string PetType
        string Name
        string Age
        string Color
        string Gender
        int TeamMemberId FK
    }

    TEAMMEMBER ||--o| BREAKFASTFOOD : "Has"
    TEAMMEMBER ||--o| HOBBY : "Has"
    TEAMMEMBER ||--o| PET : "Has"

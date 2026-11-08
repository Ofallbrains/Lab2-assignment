# .NET Lab 2 – Bicycle Rental and Mushroom App

**Student:** Uwamwezi Denyse  
**Student ID:** 27976  
**Technology:** C# Windows Forms  
**Target framework:** .NET 10

## Project Description

This mini project is a Windows Forms application developed for Lab 2. It demonstrates:

- Variables and data types
- User input and validation
- Arithmetic operations
- `if` statements
- Loops
- Multiple Windows Forms
- Button click events
- Message boxes and text boxes

The application contains two practical problems:

1. A bicycle rental calculator
2. A mushroom identification program

## Application Flow

1. The application opens with the login form.
2. The user enters the test credentials and selects **Login**.
3. After successful login, the menu form is displayed.
4. From the menu, the user can choose **Bicycle Rental** or **Mushroom**.
5. The user can select **Logout** to return to the login form.

### Login for Testing

Use the following credentials to test the application:

- **Username:** `Denyse`
- **Password:** `12345`

## Bicycle Rental Calculator

The user enters a starting hour and an ending hour. The application validates that:

- The starting hour is between 0 and 23.
- The ending hour is between 1 and 24.
- The starting hour is less than the ending hour.
- Decimal numbers and invalid text are rejected.

### Hourly Rates

| Time range | Rate per hour |
|---|---:|
| 00:00–07:00 | 500 RWF |
| 07:00–14:00 | 1,000 RWF |
| 14:00–19:00 | 1,500 RWF |
| 19:00–21:00 | 1,000 RWF |
| 21:00–24:00 | 500 RWF |

The program checks each rented hour, adds the correct rate, and displays the total amount in the result textbox.

## Mushroom Identification

The user thinks of one of six mushrooms and answers **Yes** or **No** questions:

- Does it have a ring?
- Does it grow in a forest?
- Does it have gills?
- Does it have a convex cup?

The program asks no more than three questions and displays the identified mushroom in a message box.

### Possible Results

- Agaric jaunissant
- Amanite tue-mouche
- Cepe de bordeaux
- Coprin chevelu
- Girolle
- Pied bleu

## Screenshots

### Login Form

![Login form](<docs/screenshots/Screenshot (224).png>)

### Main Menu

![Main menu](<docs/screenshots/Screenshot (225).png>)

### Bicycle Rental Calculator

![Bicycle rental calculator](<docs/screenshots/Screenshot (226).png>)

### Mushroom Identification Questions

![Mushroom question 1: forest](<docs/screenshots/Screenshot (227).png>)

![Mushroom question 2: convex cup](<docs/screenshots/Screenshot (228).png>)

![Mushroom question 3: gills](<docs/screenshots/Screenshot (229).png>)

### Mushroom Identification Result

![Mushroom result: Girolle](<docs/screenshots/Screenshot (230).png>)

![Mushroom identified message](<docs/screenshots/Screenshot (231).png>)

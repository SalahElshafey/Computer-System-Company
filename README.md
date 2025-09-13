# Computer Systems Co.

A Windows Forms (C#) desktop application for browsing and purchasing PC components with basic inventory management.  
The app supports user authentication and a simple employee console, backed by **Firebase** (Authentication + Database).

> This repository presents a functional prototype suitable for coursework/portfolio demonstration.

---

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Architecture](#architecture)
- [Screenshots](#screenshots)
- [Documentation](#documentation)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Usage](#usage)
- [Known Limitations](#known-limitations)
- [Tech Stack](#tech-stack)
- [Contributors](#contributors)
- [License](#license)

---

## Overview

**Computer Systems Co.** enables customers to sign up, sign in, browse available PC components, and place purchase requests.  
Employees can add/update items with prices and remove items from the catalog. All changes are synchronized with Firebase.

Project goals:
- Provide a clean, simple desktop UI for a small computer shop.
- Demonstrate authentication, CRUD operations, and role-based screens.
- Use a cloud backend (Firebase) to persist users and inventory.

---

## Features

### User
- Sign Up and Sign In (email/password).
- Fetch and display available components.
- Add desired items to a purchase request and submit.

### Employee
- Add a new item with name and price.
- Remove an existing item from the catalog.
- Changes persist to Firebase and reflect in the user view.

### General
- Windows Forms UI with clear sections for User and Employee tasks.
- Basic validation and error notifications.
- Cloud data storage for portability.

---

## Architecture

**Client:** Windows Forms (.NET / C#)  
**Backend:** Firebase (Authentication + Database)

Typical flow:
1. **Authentication**: Users and employees authenticate using email/password (Firebase Auth).
2. **Data Access**: Inventory is stored in Firebase (Realtime Database or Firestore). The app reads/writes items via a .NET Firebase client or REST calls.
3. **UI**: Separate forms for Users (browse/purchase) and Employees (manage inventory).

> Note: The repository contains `.sln` and `.csproj` files indicating a standard WinForms solution structure. Paths and exact class names may vary.

---

## Screenshots

### Main UI
![Main Interface](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/images.png?raw=true)

### User Section
![User - Home](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200320.png?raw=true)
![User - Sign Up](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200420.png?raw=true)
![User - Sign In](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200442.png?raw=true)

### Shop
![Shop - Browse](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200508.png?raw=true)
![Shop - Purchase](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200547.png?raw=true)

### Employee Section
![Employee - Add/Remove 1](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200618.png?raw=true)
![Employee - Add/Remove 2](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200645.png?raw=true)
![Employee - Add/Remove 3](https://github.com/SalahElshafey/Computer-System-Company/blob/main/Screenshots/Screenshot%202023-03-01%20200729.png?raw=true)

---

## Documentation

- Project write-up / design notes:  
  [Documentation (Google Drive)](https://drive.google.com/file/d/1GvopfSSP55JSOHk7IQf6RaXHpg47nWOA/view?usp=sharing)

---

## Getting Started

### Prerequisites
- Windows 10/11
- Visual Studio 2019 or 2022 (Desktop development with .NET workload)
- .NET Framework 4.7.2+ (or the framework version configured in the `.csproj`)

### Build & Run
1. **Clone** the repository and open the solution:
   ```bash
   git clone https://github.com/SalahElshafey/Computer-System-Company.git
   cd Computer-System-Company
   ```
   Open `projectFinal.sln` (or `CloudFireEng.sln`) in Visual Studio.

2. **Restore NuGet packages** (Visual Studio will prompt automatically).

3. **Configure Firebase** (see [Configuration](#configuration)).

4. **Run** the application (`F5` or Debug → Start Debugging).

---

## Configuration

Create a Firebase project and enable:
- **Authentication** → Sign-in method → Email/Password
- **Database** → Realtime Database or Firestore (choose one)

Add your Firebase configuration to the app (common approaches):
- A config class (e.g., `FirebaseConfig`), or
- `App.config` with keys such as:
  ```xml
  <appSettings>
    <add key="FirebaseApiKey" value="YOUR_API_KEY" />
    <add key="FirebaseAuthDomain" value="YOUR_PROJECT.firebaseapp.com" />
    <add key="FirebaseDatabaseUrl" value="https://YOUR_PROJECT.firebaseio.com" />
  </appSettings>
  ```
Adjust names/keys to match the code in your project.

**Example Inventory Document (conceptual):**
```json
{
  "items": {
    "gpu-rtx-4070": { "name": "NVIDIA RTX 4070", "price": 599.99 },
    "cpu-ryzen-7":  { "name": "AMD Ryzen 7 5800X", "price": 299.00 }
  }
}
```

---

## Usage

### User Flow
1. **Sign Up / Sign In** with email and password.
2. **Browse Components** — items load from Firebase into the UI list/box.
3. **Purchase** — select items and click *Purchase* to submit a request.

### Employee Flow
1. Access the **Employee** window.
2. **Add Item** — enter name and price, then click *Add* (syncs to Firebase).
3. **Remove Item** — select an item and click *Remove* (deletes from Firebase).
4. Verify the **User view** reflects changes.

---

## Known Limitations

- The purchasing action represents a request/record, not a payment gateway.
- Input validation is basic; production systems should include stronger validation and error handling.
- Network connectivity to Firebase is required.
- Role separation is UI-based; add Firebase security rules for production.

---

## Tech Stack
- **Language/Framework:** C# (Windows Forms, .NET)
- **Backend:** Firebase (Authentication + Database)
- **IDE:** Visual Studio 2019/2022

---

## Contributors
- **Salah Elshafey**
- **Amr Elmeligi**
- **Ahmed Amr**

---

## License
This project is available under the terms of the MIT License. See [`LICENSE`](./LICENSE) for details.

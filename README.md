# 🚗 DVLD - Driving & Vehicle License Department System

A training system for managing driver and vehicle licensing operations, including issuance, renewal, replacement of licenses, test management, license classes, and user management. The system follows realistic requirements for traffic licensing departments.

## 📍 Technologies Used

💻 C# - Windows Forms

🗂 SQL Server

🔗 ADO.Net (3-Tier Architecture)

## 📃 System Description

The system offers various services related to driver license management. Requests are handled according to predefined legal conditions and requirements. The system uses a centralized database and employs separation of layers (Presentation - Business Logic - Data Access) for easy maintenance and development.

## ❇ Main Features

## 📄 Supported Requests:

| *Service*                        | *Request Fee* |
|------------------------------------|-----------------|
| New License Issuance               | $5              |
| Retest                             | $5              |
| License Renewal                    | $5              |
| Lost License Replacement           | $5              |
| Damaged License Replacement        | $5              |
| License Unblocking                 | $5              |
| International License Issuance     | $5              |

---

📝 *Notes:*

- Additional fees for tests and licenses apply.
- Duplicate incomplete requests of the same type are prevented.

## 🧑‍💼 Applicant Information:

• National ID (unique key)

• Full Name

• Date of Birth

• Address

• Phone Number

• Email

• Nationality

• Personal Photo

## 📄 License Classes

| *Class* | *Description*                             | *Minimum Age* |
|-----------|---------------------------------------------|-----------------|
| 1st       | Small Motorcycles                          | 18              |
| 2nd       | Heavy Motorcycles                          | 21              |
| 3rd       | Light Vehicles / Cars                      | 18              |
| 4th       | Commercial Vehicles (Taxi/Limousine)       | 21              |
| 5th       | Agricultural Vehicles                      | 21              |
| 6th       | Small and Medium Buses                     | 21              |
| 7th       | Trucks and Heavy Vehicles                  | 21              |

## 🧪 License Tests:

1. *Vision Test* – Fee: $10

2. *Theoretical Test* – Fee: $20 (Score out of 100)

3. *Practical Driving Test* – Fee varies by license class

   - Applicants must pass each test before proceeding to the next.

   - All results and appointments are recorded in the system.

## 📋 Additional Services

• *International License Issuance :*

   - Available only to holders of the 3rd class license.

   - License must be valid and not blocked.

   - Only one active international license allowed; issuing a new one cancels the previous and keeps a record.

• *Retesting:*

   - Allowed only after failure.
    
   - Linked to the original request.

• *License Unblocking:*

   - Requires payment of fines and recording unblock date.

## 🔐 System Administration

## 👤 User Management:

• Add/Edit/Freeze/Delete users.

• Link users to real persons in the system.

• Assign permissions.

## 👥 Person Management:

• Prevent duplicate National IDs.

• Edit personal data.

• Search by National ID.

## 📄 Request Management:

• Filter by request status.

• Link request to person.

• Edit request fees.

## 🛠 License Classes & Tests Management:

• License classes are fixed but properties can be edited.

• Test fees are adjustable.

## ▶ How to Run

 • Open the project in Visual Studio.
 
 • Update the database connection string.
 
 • Seed the system with users.
 
 • Run the application and log in.
 
 ## Login Credentials:

| *Username* | *Password* |
|--------------|--------------|
| ha1.q            | ha123            |

## 🧑‍💻 Author

*ELHussain Adam*

💻 C# .NET Developer

📧 elhussain.adam20@gmail.com (placeholder)

© 2025 ELHussain Adam – All rights reserved.

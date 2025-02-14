# MaskeTakip - Mask Tracking Application

## Project Description
**MaskeTakip** is a **Windows Forms Application** designed to track mask usage and ensure compliance with safety protocols. The application allows users to input mask usage data, track the total number of masks worn, and display statistics related to mask compliance. It includes features like real-time tracking, data storage, and user-friendly reporting.

## Features
- **Track Mask Usage:** Record when a mask is worn and when it is removed.
- **Statistics Reporting:** View statistics on total mask usage, non-compliance, etc.
- **Data Management:** Store and manage mask usage data.
- **Simple User Interface:** An easy-to-use interface for tracking mask usage.

## Technologies Used
- **C#** (Programming language)
- **Windows Forms** (UI framework)
- **JSON** (For saving and loading data)
- **Newtonsoft.Json** (For JSON serialization and deserialization)

## Installation

### Prerequisites
Ensure you have the following installed:
- **Visual Studio** (or any C# compatible IDE)
- **.NET Framework** (for building and running Windows Forms applications)

### Steps to run the project

1. **Clone the repository:**
git clone https://github.com/ErkaySen26/MaskeTakip.git
2. **Navigate to the project folder:**
cd MaskeTakip

3. **Open the project in Visual Studio** (or your preferred IDE).

4. **Build and run the project** in Visual Studio:
- Press `F5` or use the **Run** button to execute the program.

5. **Use the application** to track mask usage, view statistics, and manage data.

## Usage
- **Track Mask Usage:** Enter details about mask usage, including when it was worn and removed.
- **View Statistics:** View real-time data on mask usage, including total counts and compliance rates.
- **Export Data:** Save mask usage data in JSON format for future reference or analysis.

## Example Data Model (JSON Format)

```json
{
"Date": "29.10.2023",
"MaskUsage": [
 {
   "Name": "John Doe",
   "MaskWornTime": "08:00 AM",
   "MaskRemovedTime": "08:30 AM"
 }
]
}
Contributing
If you would like to contribute to this project, feel free to fork the repository and submit a pull request with your improvements.
License
This project is licensed under the MIT License.

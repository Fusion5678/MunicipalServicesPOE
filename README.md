# SA Municipal Services Application

A C# .NET Framework 4.7.2 Windows Forms application that enables South African citizens to
report municipal issues, and will later provide access to local events and service-request tracking.

---

## Prerequisites

| Requirement | Minimum Version |
|---|---|
| Windows OS | Windows 7 / Windows 10 / 11 |
| .NET Framework | 4.7.2 (pre-installed on Windows 10/11) |
| Visual Studio | 2019 or 2022 (Community edition is free) |

---

## How to Compile

### Option A — Visual Studio (recommended)

1. Open **Visual Studio**.
2. Choose **File → Open → Project/Solution**.
3. Navigate to the project folder and open **`MunicipalServices.sln`**.
4. Visual Studio will load the solution with one project: `MunicipalServices`.
5. From the menu choose **Build → Build Solution** (or press **Ctrl + Shift + B**).
6. Verify the Output window shows `Build succeeded`.

### Option B — Command Line (MSBuild)

```cmd
cd "path\to\MunicipalServices"
msbuild MunicipalServices.sln /p:Configuration=Release
```

The compiled executable will be placed in:
```
MunicipalServices\bin\Release\MunicipalServices.exe
```

---

## How to Run

### From Visual Studio
Press **F5** (Debug) or **Ctrl + F5** (Run without debugging).

### From the File Explorer
Navigate to `MunicipalServices\bin\Debug\` (or `Release\`) and double-click **`MunicipalServices.exe`**.

### From the Command Line
```cmd
MunicipalServices\bin\Release\MunicipalServices.exe
```

---

## How to Use the Application

### Main Menu
On startup the application shows three service cards:

| Card | Status | Description |
|---|---|---|
| **Report Issues** | ✅ Enabled | Report municipal problems in your area |
| **Local Events & Announcements** | 🔒 Coming Soon | Disabled (Part 2) |
| **Service Request Status** | 🔒 Coming Soon | Disabled (Part 3) |

Click the **Report Issues** card or its **"Get Started"** button to proceed.

---

### Report Issues Form

The form guides you through four steps with a **real-time progress bar** that fills as you complete each field:

| Step | Field | Required? |
|---|---|---|
| 1 | **Location** — enter a street address, suburb, or landmark | Yes |
| 2 | **Category** — choose from the dropdown (Roads, Sanitation, Water, etc.) | Yes |
| 3 | **Description** — detailed description of the problem (max 1 000 characters) | Yes |
| 4 | **Media Attachments** — attach photos/PDFs via the file dialog | Optional |

**Buttons:**

- **+ Attach File(s)** — opens a file dialog; supports `.jpg .png .pdf .doc .docx .txt` and more.
- **Remove Selected** — removes the highlighted attachment from the list.
- **Clear Form** — resets all fields (asks for confirmation).
- **Submit Report** — validates and saves the report; shows a confirmation with a reference ID.
- **← Back to Menu** — returns to the main menu (warns if there is unsaved data).

**Progress Bar / Engagement Feature:**

The bar advances in 25% increments as each of the four fields is populated.  
Encouraging messages above the bar guide the user through the process:

- `0 %`  → *"Let's get started! Fill in the location…"*
- `25 %` → *"Great start! Now choose a category…"*
- `50 %` → *"You're halfway there! Please describe the issue…"*
- `75 %` → *"Almost done! You can optionally attach photos…"*
- `100 %` → *"Everything's filled in — press Submit!"*

The **Submit** button is disabled until Location, Category, and Description are all filled in.

---

## Data Structures Used

Submitted reports are stored in a `List<IssueReport>` (`ReportIssuesForm.IssueStore`), which is
a static list that persists for the lifetime of the application session.

Each `IssueReport` object holds:

| Property | Type | Description |
|---|---|---|
| `Id` | `int` | Auto-incrementing unique reference number |
| `Location` | `string` | User-entered location text |
| `Category` | `string` | Selected category |
| `Description` | `string` | Detailed description |
| `AttachedMediaPaths` | `List<string>` | Full file paths of attached files |
| `ReportedAt` | `DateTime` | Timestamp when the object was created |
| `Status` | `string` | Initial value: `"Pending"` |

---

## Project Structure

```
MunicipalServices.sln
MunicipalServices/
├── MunicipalServices.csproj
├── Program.cs                         ← Entry point
├── Models/
│   └── IssueReport.cs                 ← Data model + List store
├── Forms/
│   ├── MainMenuForm.cs                ← Main menu logic & events
│   ├── MainMenuForm.Designer.cs       ← Main menu UI layout
│   ├── ReportIssuesForm.cs            ← Reporting logic, validation, engagement
│   └── ReportIssuesForm.Designer.cs   ← Report form UI layout
└── Properties/
    └── AssemblyInfo.cs
```

---

## User Engagement Strategy

The chosen strategy is **Guided Progress Feedback**: a `ProgressBar` combined with contextual
encouraging messages that update in real time as the citizen fills in each field.  
This keeps users motivated, reduces form-abandonment, and clearly communicates how much
work remains — crucial for users who may be less familiar with digital forms.

---

## Module Information

| Item | Value |
|---|---|
| Module | PROG7312 / AAPD7112 — Programming 3B / Advanced Application Development |
| Part | Part 1 — Report Issues |
| Framework | .NET Framework 4.7.2, C# WinForms |
| Version | 1.0.0 |

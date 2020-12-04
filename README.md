# PG-Coding-Challenge
## C# console app to let customers enter their info and recieve an estimate.
### To run this project, you will need to have .NET Framework installed. You can read more about installing [here](https://github.com/dotnet/docs/blob/master/docs/framework/install/guide-for-developers.md).
All necessary files can be found in PG-Coding-Challenge/PG-Coding-Challenge. A solution (.sln) file is **not** required.

## This application contains the following:

### Main program class - PG-Coding-Challenge/PG-Coding-Challenge/Program.cs
Displays console menu in Main, instantiates Customer class and presents a short menu.
The user can enter their data, display it, or calculate their policy estimate which is based upon their info.

### Customer class - PG-Coding-Challenge/PG-Coding-Challenge/Customer.cs
Contains class information, constructors, member variables (Name, age, gender, conditions). Also has Calculate Estimate function.

### PG-Coding-Challenge/PG-Coding-Challenge/App.config
XML file with many predefined configuration sections available and support for custom configuration sections. A "configuration section" is a snippet of XML with a schema meant to store some type of information.

### PG-Coding-Challenge/PG-Coding-Challenge/Properties/
Contains Properties and resources that added to project. Contains AssemblyInfo.cs - information about project, including versioning information. 

### PG-Coding-Challenge/PG-Coding-Challenge/PG-Test-Cases
Unit Tests created for all Customer.cs functions. Ran using Test Explorer in Visual Studio 2019. Test -> Run All Tests.

#### Can use Visual Studio or VSCode, anything that can run a C# Console Application. (.NET Framework)
        
Decided to create a Customer class because this opens the door for reusable code
Class has member variables and member functions to be used throughout the program and can be built upon as necessary.
        
Any changes can be made within the calculate estimate function if the policy happens to change.

# Pierre's Bakery

#### Epicodus Coding School, Console Application Independent Project #8 with C# & .Net, 12.11.2020

#### By Danielle Thompson

## Description

This project is a C# console application made for a bakery and includes the following functionality:

- One class for Bread and one for Pastry.
- When the user runs the application, they receive a prompt with a welcome message, along with the cost for both Bread and Pastry.
- A user can specify how many loaves of Bread and how many Pastries they'd like.
- The total cost of the order is returned to the user.

Pierre offers the following deals:
  - Bread: Buy 2, get 1 free. A single loaf costs $5.
  - Pastry: Buy 1 for \$2 or 3 for $5.

All functionality for the models is tested.

## Technologies Used

- Git
- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL

## Installation Requirements

This project requires the technologies listed in the above 'Technologies Used' section. If you need to acquire any of the above technologies to access this project, please follow the instructions included below.

Commands necessary for running this console application and its tests will be found at the bottom of the instructions list. 


#### Installing Git
###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/PierresBakery.Solution], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/PierresBakery.Solution.git`.


#### Installing C#, .NET, dotnet script, & MySQL

* Install C# and .Net according to your operating system below. 

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder, PierresBakery.Solutions, on your Terminal or CMD.
* Move to the PierresBakery subfolder, and `dotnet build` will get bin/ and obj/ folders downloaded for the program to run.
* Move to the PierresBakery.Tests subfolder. Running `dotnet restore` will install other necessary packages listed in project's boilerplate. 
* When in the PierresBakery.Tests subfolder, `dotnet test` will allow you to run the test-driven-development tests for the project's Models. 
* In the main project folder, `dotnet run` will run the application in the console. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :----------------------------|
| **Takes user entry and turns string into array**    | User enters: palindrome | Return: ["palindrome"] |



### Tests

Describe: testMethod()
Test: testMethod(userInput).toEqual(userInput read backwards, in order)
Expect: testMethod(palindrome).toEqual(emordnilap)

Describe: checkMethodStatus()
Test:
If Array.Reverse() == userInputPalindrome
  return true
  Console.WriteLine("You've found a palindrome!")
Else Array.Reverse(). !== userInputPalindromes
  return false
  Console.WriteLine("That is not a palindrome.")
Expect: checkPalindromeStatus(palindrome).return(False - emordnilap)
Expect: checkPalindromeStatus(racecar).return(True - racecar)

## Known bugs

No known bugs as of now. 

### Legal, or License

_MIT_ Copyright (c) 2020 *_Danielle Thompson_**

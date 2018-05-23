# Leap Year (C#)

A web app, built with C#, that prompts users to enter a calendar year and determines whether the input was (or will be) a leap year.

## Installation

1. Install .NET, if not already present on your local machine.

2. Clone this repository.

3. In your preferred shell, navigate to the leap-year folder and run the following commands:

 ```
 $ dotnet restore
 ```
(above not required for .NET Core 2.0 SDK or newer releases)

 ```
 $ dotnet run
 ```

4. Navigate to localhost:5000 in your preferred browser.

## Specifications

1. Program checks if user input is a number, and if not, shows a message box asking them to enter a number.
  
  example input: "dfs?"
  
  example output: "Please enter a number"

2. Program returns false if the number is not evenly divisible by 4, OR if it is divisible by both 4 and 100 AND is not divisible by 400.

  example input: 2005

  example output: "2005 is not a leap year"

  example input: 1900

  example output: "1900 is not a leap year"

3. Program returns true if the number is evenly divisible by 4 AND is not evenly divisible by 100, unless it is also divisible by 400.
  
  example input: 2000
  
  example output: "2000 is a leap year!"
  
  example input: 2004
  
  example output: "2004 is a leap year!"

### Built With

* [Atom](https://atom.io/) - Open-source, hackable code editor running on the Electron framework.

### Support and Contact Details
If you encounter any bugs or would like to make suggestions regarding this project, please feel free to open an issue within the repository.

### License

This project is distributed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

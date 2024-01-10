# IdentResponseChecker

## Description
IdentResponseChecker is a straightforward and effective C# utility designed to test server responses to ident queries on port 113. The tool aims to facilitate the assessment of server configuration regarding ident service handling and to aid in identifying potential security vulnerabilities.

## Features
- Establishes a connection to a server on port 113.
- Sends a simple ident query and waits for the server's response.
- Outputs the server's response, helping in diagnosing the ident service behavior.

## Requirements
- .NET Framework or .NET Core

## Installation
1. Clone the repository to your local machine using:
git clone https://github.com/pajus1337/IdentResponseChecker.git

2. Open the project in your preferred C# development environment.

## Usage
1. Run the program.
2. The default server IP is set to `127.0.0.1` and the port to `113`. Modify in the `IdentChecker` class instantiation in `Program.cs` if necessary.
3. Observe the server's response displayed on the console.

## Code Structure
- `Program.cs`: The entry point of the application, initiating the `IdentChecker` process.
- `IdentChecker.cs`: Contains the `IdentChecker` class which handles the creation of a TCP client, sends the ident query, and processes the server response.

## License
MIT license

## Disclaimer
This tool is intended for educational purposes and testing your own servers. Unauthorized use to initiate connections to servers you do not own or have permission to test may be illegal.

## Author
Pajus1337

## Contributions
Contributions are welcome! If you would like to contribute, please fork the repository, create a new branch, make your changes, and submit a Pull Request.


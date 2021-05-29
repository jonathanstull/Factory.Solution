# Dr. Sillystringz's Factory

### A Week X Epicodus Project, 28 May 2021

_By Jonathan Stull_

## **Description**

In May 2021, I was contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. [This MVC web application](https://github.com/jonathanstull/Factory.Solution.git) helps factory managers track Dr. Sillystringz's engineers and the machines they are licensed to fix. It allows the factory manager to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. A many-to-many relationship between engineers and machines enables the factory to associate innumerable engineers and machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.

## **Setup/Installation Requirements**

* Software requirements (internet browser, code editor, etc.)
  1. Internet browser
  2. A code editor like VSCode or Atom to view or edit the codebase

* Download/clone instructions
  1. Download this repository onto your computer by clicking the 'code' button
  2. Open the project folder.

* Open via Bash/GitBash:
  1. Clone this repository onto your computer: `git clone https://github.com/jonathanstull/Factory.Solution.git`
  2. In a terminal window, navigate into the `~/Factory.Solution` directory and open in VSCode or preferred text editor with the command `code .`
  3. This project uses C#/.NET. To build and execute the code, use the command `dotnet run`

* Setting up a MySQL database
  1. Download and install MySQL and MySQLWorkbench in accordance with [this tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
  2. In your cloned repository, navigate to the production directory `~/Factory` and restore all dependencies with `dotnet restore`
  3. In the CLI, create a new file with the command `touch .appsettings.json` file to specify the MySQL database using the settings indicated below (please note that **you must change `[YOUR_DATABASE_NAME]`, `[YOUR_USERNAME]` and `[YOUR_PASSWORD]`** to reflect your user information; see below):
  4. In the CLI, enter the command `dotnet ef migrations add Initial` to build the initial database migration
  5. In the CLI, enter the command `dotnet ef database update` to generate the schema and corresponding tables
  
    ```
    {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[YOUR_USERNAME];pwd=[YOUR_PASSWORD];"
      }
    }
    ```


## **Known Bugs**

* None

## **Specs**

* The factory manager needs to see a list of all engineers and all machines
* The factory manager needs to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair
* The factory manager needs to be able to select a machine, see its details, and see a list of all engineers licensed to repair it
* The factory manager needs to add new engineers to the system when they are hired
* The factory manager needs to add new machines to the system when they are installed
* The factory manager should be able to add new machines even if no engineers are employed
* The factory manager should also be able to add new engineers even if no machines are installed
* The factory manager needs to add or remove machines that a specific engineer is licensed to repair
* The factory manager also needs to modify this relationship from the other side and add or remove engineers from a specific machine
* The factory manager should be able to navigate to a splash page that lists all engineers and machines and be able to click on an individual engineer or machine to see all the engineers/machines that belong to it

## **Technologies Used**

* C#/.NET
* MySQL and MySQLWorkbench
* Entity Framework Core (5.0.0) and Pomelo (5.0.0-alpha.2)
* HTML/CSS
* VS Code
* Google Chrome/Mozilla Firefox

## **MIT License**

Copyright (c) 2021 Jonathan Stull

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## **Contact Information**

If you are interested in this work, please reach out to Jonathan at <jonathan.d.stull@gmail.com>.
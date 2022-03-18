# _Engineer To Machinery Relationship_

#### By _**Chase Stokes_**

#### _A webpage to keep track of employees and machinery._

## Technologies Used

* _C#_
* _Markdown_
* _HTML5_
* _CSS_
* _Razor_
* _Bootstrap_
* _EntityCore_
*_MySql_
*_MySqlWorkbench_

## Description

_An epicodus project using a many to many relationship, to help the user keep track of which employees can use which machines._


## Setup/Installation Requirements
* _Requires VSCode and MySql_

* _You can find the github repository [here](https://github.com/ChaseStokes/DrSilly.Solution)_
* _Click the code button, and copy the https link_
* _In your in git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: "git clone" followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_

_**In order to access a usable version of the sql database you will need to do the following:**_

* _Create a file named appsettings.json in the SalonClient directory_
* _The file should contain this block of code except with your own username and password for the server(brackets around private information not included):_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=chase_stokes;uid=[Your Id Goes Here];pwd=[Your Password Here];"
  }
}
```
* _Navigate to the Factory directory_
*_Run the command "dotnet restore"_
*_Run the command "dotnet build"_
*_Run the command "dotnet ef database update"_


*_To view and interact the webpage run the command "dotnet watch run"_


## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you run into any problems or find a bug, would like to reach me for a separate reason, feel free to send me an email at chasehstokes@gmail.com with details of your issue._

Copyright (c) _2022_ _Chase Stokes_
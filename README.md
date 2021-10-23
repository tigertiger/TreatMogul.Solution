<img align="left" src="TreatMogul/wwwroot/img/cake.png">  

# Pierre's Fine & Fancy Treats & Eats
#### _by Melissa Schatz-Miller_  

  
#### Did you know that Pierre hides a diamond ring in one out of every 100 treats he makes? Maybe you should buy as many as you can afford...you might make it all back, and then some!
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>

## Technologies Used

* _C#_
* _NuGet_
* _.NET 5_
* _Identity_
* _ASP.NET Core_
* _Entity Framework Core_

## Instructions

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

### Setup/Installation


* Clone [this repository](https://github.com/tigertiger/TreatMogul.Solution) to an empty folder or to your desktop, or download and open the Zip on your local machine. Instructions for cloning can be found [here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository).
* Open the Treats folder in your preferred text editor. We'll come back to this shortly.

* Set up your SQL database:
  - Create a new ```appsettings.json``` file in your TreatMogul.Solution/TreatMogul folder
  - Copy the following code into that file, replacing YOUR_PASSWORD with your MySql password:
```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=treats;uid=root;pwd=YOUR_PASSWORD;"
      }
    }
```
* This repo includes database Migrations. To make use of those, simply run ```dotnet ef database update``` in your TreatMogul.Solution/TreatMogul folder


* Restore and build the project:
  - Navigate to the TreatMogul.Solution/TreatMogul folder in the command line or terminal  
    -- Run ```dotnet restore``` to restore the project dependencies  
    -- Run ```dotnet build``` to build and compile the project  

* Use the Web App:
  - Navigate to the TreatMogul.Solution/TreatMogul folder in the terminal
  - Run ```dotnet run``` 
  - If you would like to be able to continue viewing the site while making changes to its content, instead run ```dotnet watch run```
  - Access http://localhost:5000/ in your browser to view & interact with the web app
  - This app includes authentication via Identity. If you'd like to interact with the website as a logged-in user, click the "log in or register as admin" link in the lower left corner of the screen.
  - From the Authentication page, choose Register: type in your desired username and password, confirm your password and click Register
  - Then log in
  - You will now have the ability to create, edit, and delete treats & flavors, as well as to add flavors to treats & vice versa.
  - Enjoy.

## Known Issues

* _No known bugs at this time_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_
_Copyright (c) 2021, Melissa Schatz-Miller_

## Contact Information  

Melissa Schatz-Miller <melissa.scmi@gmail.com>  
_Please feel free to reach out to me with suggested changes/improvements, or if you have any questions._
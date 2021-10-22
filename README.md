<p align="left"><img style="float:left; padding:0 30px 0 0;" src="Treats/wwwroot/img/cake.png"></p>  

# Pierre's Sweet & Savory Treats

#### Pierre, Pierre, Pierre

#### _by Melissa Schatz-Miller_

## Technologies Used

* _C#_
* _NuGet_
* _.NET 5_
* _Identity_
* _ASP.NET Core_
* _Entity Framework Core_

## Description

_Detailsssss_  

## Instructions

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

### Setup/Installation


* Clone [this repository](https://github.com/tigertiger/TreatMogul.Solution) to an empty folder or to your desktop, or download and open the Zip on your local machine. Instructions for cloning can be found [here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository).
* Open the Treats folder in your preferred text editor. We'll come back to this shortly.

* Set up your SQL database:
  - Create a new ```appsettings.json``` file in your TreatMogul.Solution/Treats folder
  - Copy the following code into that file, replacing YOUR_PASSWORD with your MySql password:
```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=treats;uid=root;pwd=YOUR_PASSWORD;"
      }
    }
```
* This repo includes database Migrations. To make use of those, simply run ```dotnet ef database update``` in your TreatMogul.Solution/Treats folder


* Restore and build the project:
  - Navigate to the TreatMogul.Solution/Treats folder in the command line or terminal  
    -- Run ```dotnet restore``` to restore the project dependencies  
    -- Run ```dotnet build``` to build and compile the project  

* Use the Web App:
  - Navigate to the TreatMogul.Solution/Treats folder in the terminal
  - Run ```dotnet run``` 
  - If you would like to be able to continue viewing the site while making changes to its content, instead run ```dotnet watch run```
  - Access http://localhost:5000/ in your browser to view & interact with the web app

## Known Issues

* _No known bugs at this time_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_
_Copyright (c) 2021, Melissa Schatz-Miller_

## Contact Information  

Melissa Schatz-Miller <melissa.scmi@gmail.com>  
_Please feel free to reach out to me with suggested changes/improvements, or if you have any questions._
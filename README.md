# TestTask
Setup

ASP.NET Web Application for Visual C#
Leave Create directory for solution unchecked.
Create new Git repository checked.
Select MVC template.
Select MVC for Add folders and core references for.
Adding a Model
Right click Models folder in the project > Add > Class
See Model in Models/Salary.cs
Adding a Controller
Right click Controllers folder in the project > Add > Class
Filename for a controller class must end in Controller so Visual Studio can distinguish controllers from regular classes.
Our controller must inherit from the MVC controller base class and include using System.Web.Mvc
Controller must be public so its accessible.
See Controller/EmployeeController.cs
Adding a View
In View folder right click Add > MVC 5 View Page to add a view or right click on a controller method.
You may need to create a folder for each controller and have the view be inside that folder. See Views/Employee/Index.cshtml and Views/Employee/Info.cshtml
Razor is a view language allowing you to create views by combining C# and HMTL.
ViewBag is an object built into MVC that allows you to pass data from a controller to a view.
Debug the project

Program name: RugsPride

Program purpose: Create an MVC ASP.NET application
using .NET Core 3.1
Authentication: Individual Accounts

Program Author: Manvir Kaur Brar
Date Created: 2023-02-15 2130UTC

On Date: 2023-02-04
My assigned Product is Rugs to generate a product catalog allowing for CRUD operations.
The six properties of my product are Brand, Color, Pattern, Price, Shape, and Material. Additionally, ID is a primary key, and when we will add a new field, I will add Rating as my new property to the object.

Created Welcome page
Created Git Repository

Started part 1
Completed Part 1 of tutorial 

Started Part 2
455 ET
Added a new controller : RugController
Changed the content of controller based on the tutorial 
tested it in the browser
for now skipped the Welcome method to include two parameters

Completed part 2 of tutorial

Started Part 3 Add a view 515 ET

Replaced the Index method with the given code because currently the Index method returns a string with a message in the controller class.
And this calls the controller's View method
Created a new folder named Rug and added a new item with Razor view- empty and named that file Index.cshtml

Trying to add live date and time and added line in index.cshtml 
It's Okay I will add it later.

Date: 2023-02-16 600ET
 
 Continue...

 Didn’t forget to Clean the code. 
Then Build it again and checked the terminal to see succeeded 1, and failed 0.
Then Run the code to test it by pressing IIS Express.

Now Checking the content of the Views/Shared/_Layout.cshtml file with the given markup.

Everthing looks fine. 
Ready to move on next step.

In the tutorial I can see the difference between the two titles.

Changing title of Index.cshtml view file along with the title of the page.

Part 3 of the tutorial: Add a view is completed 630ET

NO ERROR till now.
Going smoothly!

Starting Part 4: Add a Model 637ET

Created a class file named: Rug.cs in the Models folder
Added mine decided properties of my Rugs in the class file with the suitable datatypes.

Added NuGet packages(already existed)

In the data folder I made a file name RugsPrideContext.cs
and created a DbSet<Rug> property for the entity set. this will typically responds to a database table.

Changed the connection in the appsettings.json

Added a scaffolded item in the controller
Then added model class, Data context class, and got my controller name as RugsController. 

Got an error 740ET
Error:
There was an error running the selected code generator
'Value cannot be null. (Parameter connectionString)

But not to worry!
 I have to just add a default connection rather tha RugsPride Connection.

Solved it!
Now I have my RugsController.cs file in hte controller folder

Now moving to the next part which is going to add mogration and updating Database
Add-Migration InitialCreate
Update-Database
Running both the commands in the Package Manager Console

Both the commands were successful
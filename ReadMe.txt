BMR Calculator

BMR calculator is a program to calculate the BMR (Basal Metabolic Rate) of a person based on the gender, age, weight and height.

It can be calculated in metric or imperial system.

----

Features:

First pane:
It was used a ComboBox to select the unit system (metric or imperial)
Radio Buttons to select the gender
Label and TextBlock for age, height and weight.
A Button called "Calculate BMI" to calculate the BMI and populate the data in the DataGrid in the oter pannel.
A Button called "Reset" to reset all the application data.
A Button called "Exit Application" to finish the program.
A Label and a TextBox to preset the BMI result.

Second pane:
A DataGrid to show all the created BMIs.
Label and TextBlock to show the age, height and weight from previous data.
An Update Button
A Delete Button.

I used a List to store all the BMI data in the BMIService class.
I used a Dictionary (as a requirement) in the BMIData cosntructor to present a message that the data was sucessfully created.
I used a generic class in the Update method (as a erquirement)

All the data that were previously created will be uploaded in the DataGrid on the right pane.

All the data files are stores as a .xml file and each record has its own file.

I also used 4 query buttons. One for BMI less than 1500, one to get the maximum BMI, one for the minimum and another one for the average. All you need to do is press the button and it will show the result on the screen.

I created a class called BMIData that contains all the information to calculate the BMI and a service static class called BMIServices that contains the CRUD method.












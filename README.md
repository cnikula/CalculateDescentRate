CalculateDescentRate

This is a desktop application written in C# and .NET 6

The purpose of this application is to calculate descent rate for airplanes.

The MainViewPresenter class in MainViewPresenter.cs is responsible for handling the logic related to descent calculations in a flight application. 
Here is a summary of the key functionalities:

1.	Constructor:
•	Initializes the presenter with an instance of IMainView.
2.	CalculateDescendOnly:
•	Validates and parses input values for descent calculations.
•	Calculates the descent rate in feet per nautical mile.
•	Displays the result or an error message based on the validity of the inputs.
3.	CalculateDescendRate:
•	Validates and parses input values for pitch angle and descent speed.
•	Calculates the descent rate based on the pitch angle and speed.
•	Displays the result or an error message based on the validity of the inputs.
4.	CalculateDescentAngle:
•	Validates and parses input values for descent calculations.
•	Calculates the pitch angle required for a given descent rate.
•	Displays the result or an error message based on the validity of the inputs.
The class uses the RegularExpression utility to validate decimal inputs and handles exceptions by displaying error messages. The results of the calculations are set in the 

Claims Service

The solution contains 5 projects.

1.	Claims.Model – Business entities live here.
2.	Claims.Repository – Repository class that abstracts away all database operations. Provides a DummyClaimRepository class which provides hard coded values/claim records for testing purpose.         This class is also used for providing functionality in non-test environment as no database has been created for this application.
3.	ClaimsService – This is a Web API service that serves “claims” functionality like get claim, get multiple claims and create claim over http.
4.	ClaimsService.Client – Client application that calls ClaimsService.
5.	ClaimsService.Test – Unit tests for testing ClaimsService.

Technologies used: .NET 4.5, ASP.NET MVC 4/Web API, Microsoft Unity, Visual Studio 2012

Steps to run the application:
1.	Open the solution in Visual Studio (2012) and build it.
2.	Run the application using F5 (with debugging) or Ctrl-F5 (without debugging).
3.	This will open a web page (service) as well as a WinForm application (client). Let the web page load.
4.	WinForm client application has all of the fields pre-populated with test values.
5.	Press the “Get Claim” button to test the “Get” functionality with claim number as input.
6.	Press the “Get Claims” button to test the “GetList” functionality with start date and end date.
7.	Press the “Create Claim” button to test the “CreateClaim” functionality with Mitchell Claim XML as input.

This application works against the dummy repository which has hard coded claims information. 
•	Claim number 22c9c23bac142856018ce14a26b6c299 will fetch one hard coded claim using “Get” functionality.
•	Start Date and End Date between 07/09/2014 and 08/09/2014 will bring back two hard coded claims using “GetList” functionality.
•	Any valid XML that adheres to MitchellClaim.xsd will work for the “CreateClaim” functionality. 

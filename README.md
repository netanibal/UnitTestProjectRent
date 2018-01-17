# UnitTestProjectRent
Set of classes with its automated tests.

=========
Design
=========

Abstract class
---------------
Rent 

Classes derived from Rent
------------------------
DailyRent
HourlyRent
WeeklyRent


Class Price
-----------
Static class containing unit prices of rental types.

PriceTest
---------
Class to test integrally.


****************************************************************************************************************
************** Note: *******************************************************************************************
************** It is assumed that a logic of convenience regarding prices/type of rent is not beign     ********
************** asked. For example: If a customer is renting a bike for 7hs, even though in this case it ********
************** is advisable to rent per day, the system will not make such evaluation. *************************
****************************************************************************************************************
****************************************************************************************************************

==================================
Development practices applied
==================================
Classes that define different fees were created to take advantage of class inheritance,
making it possible to calculate the total to charge based on the amount of time that is rented in one place

========================
File organization
========================
A folder called Rent is created, that contains the derived classes and the abstract class Rent.
In the root are left the classes Price and Pricetest.

=========
Test
=========

How to use PriceTest
-----------------------
Method Price: Method for testing rentals. Change the parameters of the constructors of the classes HourlyRent, DailyRent and/or WeeklyRent
to obtain different totals.

Method PriceFamily: Method for testing family discounts. Add any type of Rent to the Rentals list and change the parameters of the 
constructors of the classes HourlyRent, DailyRent and/or WeeklyRent to obtain different totals. 
The method calculates a general total and applies a discount if correspomnde.

Method WithDiscount: Method for evaluating the conditions to apply the discount, it is used by the PriceFamily method.



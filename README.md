# Exercise 1 - FlightManager
Flight Manager is a Single Page Application with AspNet Core 2.0 and Angular 4.2

## Pre-Requirements
1. You need to have NPM installed to run this project because front-end dependencies (Install NodeJs)

To run:
1. ```cd FlightManager.Web```
2. ```npm install```
3. ```dotnet build```
4. ```dotnet run```. The application will run locally on kestrel at http://localhost:5000

# Exercise 2 - Quality of existing code
I would rate it as badly designed because it violates the Open-Close principle. If there was a requirement to add further Message classes
the existing code would need to be modified to acommodate these changes.
I would use polymorphism to improve the quality of this code, where a non instantiable abstract class would have abstract methods that must be overriden
For example the following code would achieve the same:
```
public abstract class Message
{
   // some common functionality here
   public abstract void MyCustomMethod();
}

public class MessageA : Message 
{
   public override void MyCustomMethod()
   {
      // implementation for messageA
   }
}
public class MessageB : Message 
{
   public override void MyCustomMethod()
   {
      // implementation for messageB
	  this.SomeAdditionalMethodOnB();
   }
   
   private void SomeAdditionalMethodOnB()
   {
      // something else
   }
}
public class MessageC : Message 
{
   public override void MyCustomMethod()
   {
      // implementation for messageC
   }
}

```

this way if we need to add more Message classes we can simply create them and inherit from the abstract class Message providing a custom
implementation for the MyCustomMethod and we could invoke ```message.MyCustomMethod();``` without casting

# Exercise 3 - Library
I haven't had time to add this implementation but it's a clear fit for the *strategy pattern* where at runtime different implementations of an
interface such as ```IFileReader``` could be used depending on the needs. In order to respect the open-close principle we could also have
some factory class in charge of providing the proper implementation of ```IFileReader``` depending on the needs.
When a new fileReader implementation is added we would only need to add support for it at this factory class or use some dependency injection system
to automatically inject the appropriate implementation we need.

As per the role based authorization, if this was a web application I would implement some middleware that sits before Mvc on the http pipeline
and that is in charge of implementing the authorization based on the identity info (e.g: roles) that the middleware would have received
within a JWT token with claims. Then I would decorate the endpoint with some authorization policy pointing to this middleware implementation
# Learn About ViewData, ViewBag And TempData In ASP.NET MVC5

### ViewData
 
ViewData is a dictionary of objects that is derived from ViewDataDictionary class and accessible using strings as keys. It is useful in transferring data from Controller to View.
 
### ViewBag
 
ViewBag is actually a wrapper around ViewData. ViewBag transfers data from the controller to the view, ideally temporary data which is not included in a model.
 
### TempData
 
TempData can be used to store data between two consecutive requests. TempData values will be retained during redirection.

## Difference between ViewData, ViewBag and TempData
 
### ViewData
* ViewData is a dictionary object that is derived from ViewDataDictionary class.
* ViewData is a property of ControllerBase class.
* ViewData is used to pass data from controller to corresponding view.
* Its life lies only during the current request.
* If redirection occurs then its value becomes null.
* Its required typecasting for getting data and checking for null values to avoid error.

### ViewBag
* ViewBag is a dynamic property that takes advantage of the new dynamic features in C# 4.0.
* Basically it is a wrapper around the ViewData and also used to pass data from controller to corresponding view.
* ViewBag is a property of ControllerBase class.
* Its life also lies only during the current request.
* If redirection occurs then its value becomes null.
* It doesn’t required typecasting for getting data. 

### TempData
* TempData is a dictionary object that is derived from TempDataDictionary class and stored in short lives session.
* TempData is a property of ControllerBase class.
* TempData is used to pass data from current request to subsequent request (means redirecting from one page to another).
* Its life is very short and lies only till the target view is fully loaded.
* It’s required typecasting for getting data and check for null values to avoid error.
* It is used to store only one time messages like error messages, validation messages. To persist data with TempData refer this article.

TempData is also a dictionary object that stays for the time of an HTTP Request. So, TempData can be used to maintain data between one controller action to the other controller action.

TempData is used to check the null values each time. TempData contain two method keep() and peek() for maintain data state from one controller action to others.

### When TempDataDictionary object is read, At the end of request marks as deletion to current read object.

The keep() and peek() method is used to read the data without deletion the current read object.

You can use Peek() when you always want to hold/prevent the value for another request. You can use Keep() when prevent/hold the value depends on additional logic.

Overloading in TempData.Peek() & TempData.Keep() as given below.

TempData.Keep() have 2 overloaded methods.

* void keep() : That menace all the data not deleted on current request completion.
* void keep(string key) : persist the specific item in TempData with help of name.

TempData.Peek() no overloaded methods.

object peek(string key) : return an object that contain items with specific key without making key for deletion.
Example for return type of TempData.Keep() & TempData.Peek() methods as given below.

* public void Keep(string key) { _retainedKeys.Add(key); }
* public object Peek(string key) { object value = values; return value; }

## For More information visit below article

https://www.c-sharpcorner.com/article/learn-about-viewdata-viewbag-and-tempdata-in-asp-net-mvc/


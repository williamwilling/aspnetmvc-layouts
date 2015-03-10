# ASP.NET MVC: Layouts

HTML pages often have a lot of boilerplate code. You can put this code in a layout and then tell your view to use this layout.

##Exploring the code

* `Views\Shared\_Layout.cshtml` contains the layout.
* `Views\_ViewStart.cshtml` tells all views which layout to use.
* `Views\Greetings\*.cshtml` are the views themselves. Note how they don't contain any boilerplate code.

If you want to try and implement a layout yourself, you can check out the `start`-branch, which is the starting point for this example.
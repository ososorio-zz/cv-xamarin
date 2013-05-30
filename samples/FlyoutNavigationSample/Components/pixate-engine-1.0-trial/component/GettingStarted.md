## Initialize the Pixate Engine

To get started, you'll need to call into the main start point for the Pixate Engine.

At the top of your Main.cs file, add this import line:

```csharp
	using PixateLib;
```

Then, at the beginning of your Main method, add this line:

```csharp
	PXEngine.LicenseKeyForUser("SERIAL NUMBER", "USER NAME");
```

If you are trying the product, you can just use empty double quotes for the **SERIAL NUMBER** and **USER NAME** fields:

```csharp
	PXEngine.LicenseKeyForUser("", "");
```

## Adding a CSS File

Now right-click on your project's *Resources* folder and select Add -> New File. Choose 'Misc' from the list on the left, and 'Empty Text File' from the list in the middle. Name your file '*default.css*'.

## Setting up for Styling (via Xcode)

At this point, let's add a button or two to our application. Double-click on the .xib file for your project (e.g. <ProjectName>ViewController.xib). Add a couple of buttons to your main view.
	
With each of the new buttons you added, select one, activate the Identity Inspector in the Utilities View. 

Now we need to give the buttons a "styleId" so that you can reference it from your CSS. We'll add a Runtime Attribute. Click the small '+' and add an entry with a key path of `styleId`, a type of `String`, and a value of `button1`. For the second button add a `styleId`, a type of `String`, and a value of `button2`.

Now save and close Xcode. 

## Setting up for Styling (in code)

Creating a few buttons in code is just as easy, just do something like this in your main view controller:

```csharp
UIButton button1 = UIButton.FromType (UIButtonType.RoundedRect);
button1.SetStyleId ("button1");
button1.SetStyleClass ("myButtons");

UIButton button2 = UIButton.FromType (UIButtonType.RoundedRect);
button2.SetStyleId ("button2");
button2.SetStyleClass ("myButtons");
```

## Styling the Buttons

Now comes the easy part, just open your default.css file and add some CSS. For our two buttons, let's try something simple:

```css
.myButtons {
	size: 100px 50px;
	left: 110px;
    border-radius: 10px;
}

#button1 {
	top: 50px;
	text: Pixate;
  	color           : #ffffff;
  	background-color: linear-gradient(#3c4145, #585e62);
  	border-width    : 1px;
  	border-color    : #212325;
  	box-shadow      : inset 0 1px 0 rgba(255,255,255,0.3),
                          0 1px 1px rgba(0,0,0,0.5);
}

#button2 {
	top: 120px;
	text: Engine;
	color          : #ffffff;
  	background-color: linear-gradient(#215a88, #4d93dd);
  	border-width   : 1px;
  	border-color   : #212325;
  	box-shadow     : inset 0 1px 0 rgba(101,177,232,0.9),
                           0 1px 2px rgba(0,0,0,0.5);
}
```

Notice here we style the *button* type generically as well as the two specific instances we set *styleId* on.

## Sample App

There is a sample app included in this component that styles two buttons. Be sure to take a look.

## Documentation

* Visit the [Pixate Documentation Center](http://www.pixate.com/documentation.html).
* MonoTouch Module on Github [repository](https://github.com/Pixate/MonoTouch-Pixate).

## Licensing

Please visit the [Pixate Store](http://sites.fastspring.com/pixate/product/purchase) to purchase a permanent, commercial license to the Pixate Engine for iOS.


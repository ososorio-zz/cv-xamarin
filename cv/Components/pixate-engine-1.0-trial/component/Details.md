
Pixate Engine makes styling your native mobile app as easy as styling
a web page. Style by type (e.g. 'button') or by assigning CSS IDs or
Classes to your views. Styles can be changed at run-time as well by
downloading CSS and assets on demand.

```csharp
	UIButton button1 = UIButton.FromType (UIButtonType.RoundedRect);
	button1.SetStyleId ("button1");
	button1.SetStyleClass ("myButtons");

	UIButton button2 = UIButton.FromType (UIButtonType.RoundedRect);
	button2.SetStyleId ("button2");
	button2.SetStyleClass ("myButtons");
```

```css
.myButtons {
	border-radius: 10px;
	size: 100px 50px;
}

#button1 {
	background-color: blue;
	color: white;
	text: Hello World;
	position: 10px 100px;
}

#button2 {
	background-color: yellow;
	color: black;
	text: WOW!;
	position: 10px 160px;
}
```

Style your entire app effortlessly while dramatically reducing code and
make your app's design dynamically updatable without an app update. Learn
more at [Pixate.com](http://www.pixate.com).

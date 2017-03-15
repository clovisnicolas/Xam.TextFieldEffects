# Xam.TextFieldEffects
Xamarin.iOS Bindings for [TextFieldEffects Swift Library](https://github.com/raulriera/TextFieldEffects)

## Install
Available on NuGet

[![NuGet](https://img.shields.io/nuget/v/Xam.TextFieldEffects.svg?label=NuGet)](https://www.nuget.org/packages/Xam.TextFieldEffects/)

## Quickstart
```csharp
HoshiTextField textField = new HoshiTextField();
textField.Placeholder = "Hoshi";
textField.PlaceholderColor = Colors.DarkGray;
textField.TextColor = Colors.DarkGray;
textField.BorderActiveColor = Colors.Green;
textField.BorderInactiveColor = Colors.DarkGray;
textField.Frame = hoshiView.Bounds;
this.hoshiView.AddSubview(textField);    
```

## Build

Bindings have been made thanks to [Lucas Teixeira](https://github.com/Flash3001) unofficial Swift3 bindings for Xamarion.iOS.

Instructions are on [StackOverflow](http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries)

## License
MIT © Clovis Nicolas

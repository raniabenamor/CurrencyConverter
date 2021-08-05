# CurrencyConverter
Currency Converter is a WPF application designed to convert one currency into another to check its corresponding value. 
It is based on the current market or bank exchange rates using the fixer API (http://fixer.io/)

To convert one currency into another, all you need to do is enter an amount of money  and choose the currency and select the monetary value (e.g. “swedish krona”).
You can try with the multiple monetary selections. The application then displays the corresponding amount of money.
# DesignDescription
* the app consists of a window splited into 4 stack panels and containing rows/columns
that contains buttons, comboboxes,labels and textboxes
* the BorderBrush property is used as well ,it represents the brush that is used to draw the Border. BorderThickness is a property which represents the thickness of the Border.

* The Corner Radius is a property used to indicate the degree to which the corners of the border will be rounded. For creating curved borders for the windows, you need to use CornerRadius property of the ChromelessWindow. Also, the default value is zero, which implies sharp corners.

* The linear gradient brush paints an area with a linear gradient. The default value of the linear gradient is diagonal. The StartPoint and EndPoint properties of the LinearGradientBrush represent the start and endpoints of a gradient.
The gradient stop properties:
 ** Color – Property to set color is described using a predefined color name or hexadecimal notation.
 **OffSet – Offset determines the position of the color between your start and endpoints.

* the Title property value is set “Currency Converter” 
![sc4](https://user-images.githubusercontent.com/48763401/128333897-6a649408-3dd0-4dd3-8c42-50c928bb53d3.PNG)

![screen1](https://user-images.githubusercontent.com/48763401/128332040-84660c40-286a-42d7-821d-ce2b890091eb.PNG)
the app includes some message boxes to make sure you have an input amount and a currrency to convert to/from .
![scr2](https://user-images.githubusercontent.com/48763401/128332555-57f07d2d-83e0-442a-adbc-ea612195fd39.PNG)
![scr3](https://user-images.githubusercontent.com/48763401/128332584-a6938036-9f61-4d11-a625-f1dc5dccaeb9.PNG)

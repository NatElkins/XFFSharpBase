namespace XFFsharpBase

open Xamarin.Forms
open XFFsharpBase.Helpers

type App() =
    inherit Application()

    let stack =
        StackLayout.create
            [ Label(Text="Test 1", HorizontalOptions=LayoutOptions.Center)
              Label(XAlign=TextAlignment.Center, Text="This is another taaest!a") ]
    do
        base.MainPage <- ContentPage(Content = stack)

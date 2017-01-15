namespace XFFsharpBase

module Helpers =
    open Xamarin.Forms

    type StackLayout
        with
            static member create views =
                let stack = new StackLayout()
                for view in views do
                    stack.Children.Add view
                stack
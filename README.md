# InThing Interview

This is a little MAUI app that targets Android only to keep things simple.
So far it has only two screens to show off how things work in MAUI, get you going with MVVM, data binding and dependency injection.

## Important classes:

- UIComponentsServiceCollectionConfiguration - here we register all pages and their viewmodels
- NavigationService - used to navigate from page to page
- AppShellVM - here we register all routes that the navigation service can rout to, so far it's only the route to FirstPage

## First start

When you first launch the application, this is everything you will have:
![What you have](https://github.com/Gogzs/InThing-Interview/blob/main/WhatYouHave.png)

## What we want from you
![What you have](https://github.com/Gogzs/InThing-Interview/blob/main/WhatYouNeedToHave.png)

As shown in the picture above, this is what we want from you:
- implement a new page called "SecondPage"
- extend the navigation service to be able to navigate to your newly created page
- create a new viewmodel for your newly created page
- the user should be able to input text
- when the button is pressed, the text should be updated to "You entered: <user entered text>"

## In case of issues or questions
Open an issue on this repository, or even better. Create a fork or branch off of the main branch, push it and open a pull request and comment the parts that are bothering you.

Best of luck

# BLAZOR
Uses c# instead of js to make the frontend  
fullstack solution  

blazor hosting model, runs c# directly in the browser via webassembly  

essentially a controller, has endpoints  
when you take contact with the web browser, it contacts the blazor server  
instead of json data returned, it gives the c#  
sends data 

blazor hybdrid  
uses blazor in desktop apps  
a lot of fancy stuff OAO

## Key Concepts

Razor is component based  
components with its own view  

routing: blazing uses routing information 

data binding:
one way binding: from c# to the website  
two way binding: can receive updated from client as well

event handling: 
mouse hover, mouse click, what happens  

dependency injection:  
the exact the same as we're used to :)  
then use @inject to get access instead of through constructor  

component parameters via [Parameter]  
lifecycle methods  
dun geddit  

JS interop  
can call JS from C# and vice versa

## Project structure
app.razor is root component with router typically  
mainlayout.raor defines the layout for pages  
pages/ contains razor files for each route   
shared/ reusable components navmenu, header  
program.cs entry point for configuring services and app behavior

## Blazor syntax
@ establishes that this will include c# as well, so you can mix js and c#





---
!important check the rest of the documentation
!important check the video resources
!important
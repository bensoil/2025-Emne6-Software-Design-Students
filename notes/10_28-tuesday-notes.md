# Web Assembly 

Http client has a pipeline like middleware too

when a request from the clients, in the pipeline we add a code that adds username and password where we add such things

local login  
a sort of saving feature in the web client  

## Local Storage and Session storage
local storage will remain even if the tab is closed, as long as web browser remains  
session storage ends when fan is closed  

## Browser storage
When communicating with web storage,  
we need IJSRuntime  
we use js to communicate  

we use an @inject  
call storedge  

js has simple code for getitem removeitem etc.  

we need js.invokevoidasong("localstorage.setitemm");  

we create a storage handler so it's focused 

--- 
Check the doc for info about web assembly pl0x

!IMPORTANT this will be necessary for ur project buddy boy
cd 2025-emne7-avansert-programmering-students/
  326  cd week44/StudentBloggAPI
  327  dotnet ef migrations add -o Data/Migrations
  328  dotnet ef migrations add "Initial" -o Data/Migrations
  329  dotnet ef database update
  330  dotnet build
  331  dotnet ef database update
## Background  
https://dnncommunity.org/forums/aft/3080

What I really want is a way to notify my users when their session is about to end. I already have that built in JavaScript, but that notification only get's displayed on one of the open tabs in cases when multiple tabs are open. I want it to be displayed on all tabs and SignalR seemed like the best solution for the job.

## Solution  
I managed to cobble together a solution that works in DNN9. I built it using the Upendo DNN (https://github.com/UpendoVentures/generator-upendodnn) project structure, so the Solution may look a bit foreign to those only familiar with the ChrisToc templates (https://github.com/ChrisHammond/DNNTemplates). I based my work on this Microsoft Tutorial (https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr-and-mvc), which translated into the DNN world relatively easily. There's no fancy stuff like rooms, database tables for chat archival, or avatars. Right now, it's nothing more than a proof of concept with a lot of copy pasta, but it does work.

## Getting Started  
Clone the repository and perform a "Release" build for the solution. This will create a new folder within the solution directory called "Website". Within this new directory, you will find a "bin" folder and an "Install" directory. Under "Install", you will find both the module installer package and the Module Symbols installer package.

Typically for the Upendo DNN development process, that Website folder is where you would install your DNN instance. Performing a "Debug" build of the solution will place all the executables and all of the interpreted files where they need to be within the Website folder to update the module after it's been installed.
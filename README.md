## Background  
https://dnncommunity.org/forums/aft/3080

What I really want is a way to notify my users when their session is about to end. I already have that built in JavaScript, but that notification only get's displayed on one of the open tabs in cases when multiple tabs are open. I want it to be displayed on all tabs and SignalR seemed like the best solution for the job.

## Solution  
I managed to cobble together a solution that works in DNN9. I built it using the Upendo DNN (https://github.com/UpendoVentures/generator-upendodnn) project structure, so the Solution may look a bit foreign to those only familiar with the ChrisToc templates (https://github.com/ChrisHammond/DNNTemplates). I based my work on this Microsoft Tutorial (https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr-and-mvc), which translated into the DNN world relatively easily. There's no fancy stuff like rooms, database tables for chat archival, or avatars. Right now, it's nothing more than a proof of concept with a lot of copy pasta, but it does work.
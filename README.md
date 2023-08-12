# MapSpanAndImageButtonIssue
this is used as a replication to an issue that happens with the map span when using imagebutton instead of button to navigate to the map

# Before Running 
you should aquire an api key as mentioned in the steps in the official docs here [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/map] and then put the api key in -platforms/android/AndroidManifest.xml replace 'the Enter Your APIKEY Here' with your aquired api key

![api key](/ScreenShots/ApiKey.png?raw=true)

#problem description
this is the buttons view it simple has a button and an imagebutton to clearify that the problem happens only with the image button 

![api key](/ScreenShots/ButtonsViewCode.png?raw=true)

![api key](/ScreenShots/ButtonsView.png?raw=true)

*Note : i used 2 different commands because when using the same command for both the buttons when clicking one of the buttons it acts as if both buttons were clicked and it's even obvious in the click animation, in this case the problem doesn't happen as the regular button is clicked , however is the ordinary button were invisible the problem arises again. these are 2 additional wierd things that happen*
*but both commands are identical as follows*

![buttons commands](/ScreenShots/ButtonsCommands.png?raw=true)


NavigateToAsync simply navigates to the map route

![NavigateToAsync](/ScreenShots/NavigateToAsync.png?raw=true)


this is the map view code the map should initially view the region specified by the map span 

![map view code](/ScreenShots/MapViewCode.png?raw=true)

when clicking the button the correct behaviour happens and the map shows as follows

![right map span](/ScreenShots/map1.png?raw=true)

but when clicking the image button the map shows as if there is no map span specified as follows (but it works fine with other map functionality)

![wrong map span](/ScreenShots/map2.png?raw=true)


# Eve Online Moon Calculator

###About

Tool designed to calculate the approximate value of a moon in the MMO game Eve Online. Moons can have structures anchored in their orbit that blast a chunk of the moon and then tractor it over a set period of time. When the chunk finishes it's extraction cycle it will be fracked, blowing up the chunk and launching mineable ore in the vicinity. Cycles can be set from 1-4 weeks, with longer pulls resulting in more ore to mine (Roughly 20,000 m3 per hour). This calculator currently assumes a month long extraction. Values are displayed as both raw ore as well as the refined value with maxed skills.

###What it can currently do

Take in a single moon input and display the raw and refined value of each individual ore

### Known Issues
*Multiple inputs will display every ore in each table
*Multiple inputs will cause the planet and moon name to have the moon id appending in front of it (delimiting error)
*Repeating the same ore type with multiple inputs will cause an error

###Future additions
*Allow for multiple inputs with no errors
*Set up database to retain information for all inputted moons
*Better error handling

###Required Software
*ASP.NET Core 2.2.5

# Hepsiburada Mars Rover
 <strong>Process Steps:</strong>
 <ul>

 <li>
  In order to better understand the desired problem, a demo was drawn on paper and an idea was obtained about how the process was.
 </li>
 <li>
  Application named Net 5 MarsRover was created
 </li>
 <li>
  The work on paper made for the application has been moved to the Images folder
 </li>
 <li>
In the application, the information about which direction to go was determined according to the incoming command. The directions on the right and left sides change according to the direction information in each incoming command. For this reason, a separate command object was created in each 4 directions. The position of the existing object was changed according to the command type in each command object.
  
For example, if a vehicle that shows North as a position is commanded to turn to the right, its direction will turn east, if the command is to turn left, it will turn to West.

Coding was done according to the above process
  </li>
 </ul>

<hr>
A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth.

A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

Input:
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.

The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.
   
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

Output:
The output for each rover should be its final co-ordinates and heading.

Input and Output
Test Input:<br>
55 <br>
12N <br>
LMLMLMLMM <br>
33E <br>
MMRMMRMRRM <br>
Expected Output: <br>
13N
51E

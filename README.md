# Flappy-Bird
 Flappy Bird desktop app using C#

### Instructions for Playing:
1. Press and hold the spacebar to fly.
2. The speed keeps increasing with time.
3. If the bird touches the top or the ground or any of the pipes, the game is over.
4. Game Over! will be seen when the game ends.


### Basic operation
1. Start a Project in Windows Forms App (.NET framework )
2. Design an Outlay on the Designer 
2. Use Tools from Toolbox
   * Tools required : 4-PictureBox, 1-label, 1-timer
3. Write Code
   * Declare variables
   * in gameTimerEvent: (event in timer named gameTimer ) add gravity. move pipes to the left and print score.
   * check if any pipe left the screen, and if yes, add the score.
   * if the bird hits the ground or touches pipes, run endGamr function.
   * increase pipe speed according to the score.
   * exit function gameEventTimer
   * in gamekeyisdown (spacebar pressed) and gamekeyisup (spacebar )

### How to download the code and play the game
1. Clone the repository / Go to Code -> Download zip
2. Extract the folder from the zip file.
3. Open the code on Visual Studio (windows form)
4. Click on Form1.cs from the solution explorer.

![solnexp](https://user-images.githubusercontent.com/63497370/103634836-a39df600-4f6d-11eb-8c02-8c7e37ba7672.PNG)

5. This will open up the code in C#, which would look like this:

![Form1](https://user-images.githubusercontent.com/63497370/103634943-cf20e080-4f6d-11eb-9715-0cf5e81261fc.PNG)

6. Now click on Form1.Designer.cs from the solution explorer.
7. This opens the code of the design and will look like this:

![Form1 Designer](https://user-images.githubusercontent.com/63497370/103635095-07282380-4f6e-11eb-9872-0c3b39f0f8c7.PNG)

8. Now click on the green start button and make sure the selected startup item is  Form1.Designer.cs

![start](https://user-images.githubusercontent.com/63497370/103635210-3474d180-4f6e-11eb-90fc-56fcf6d04380.PNG)

9. Happy Playing!

![Game](https://user-images.githubusercontent.com/63497370/103635273-48b8ce80-4f6e-11eb-9702-165f9e7602f2.PNG)

ThankYou! :smiley:
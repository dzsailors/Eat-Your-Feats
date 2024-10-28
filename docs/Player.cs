/*
Name: Ginny Ke
Date Created: 10/27/24
Date Revised: 10/27/24
Purpose: Creates Player class template to store player data 
*/

public class Player // creates player class to store player info in mongodb database for later

{
    public string Id { get; set; } // Unique identifier for the player
    public string Name { get; set; } // Player's name
    public int Progress { get; set; } // Player's progress in the game
}

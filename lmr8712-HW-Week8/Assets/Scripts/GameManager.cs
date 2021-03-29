using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Create a space to store the current location of the player
    public LocationScriptableObject currentLocation;

    // Create a space to store the name and description of the locations
    public Text locationName;
    public Text locationDescription;

    // Create a space to store the buttons
    public GameObject northButton;
    public GameObject southButton;
    public GameObject eastButton;
    public GameObject westButton;
    
    // Start is called before the first frame update
    void Start()
    {
        Updatelocation(); //run UpdateLocation function
    }

    // Function to determine movement 
    public void MoveDirection(int direction) {
        
        switch (direction) {
            case 0:                                                 //for case 0
                currentLocation = currentLocation.northLocation;    //move to the north location
                break;                                              //get out of function
            
            case 1:                                                 //for case 1
                currentLocation = currentLocation.southLocation;    //move to the south location
                break;                                              //get out of function
            
            case 2:                                                 //for case 2
                currentLocation = currentLocation.eastLocation;     //move to the east location
                break;                                              //get out of function
            
            case 3:                                                 //for case 3
                currentLocation = currentLocation.westLocation;     //move to the west location
                break;                                              //get out of function
        }
        Updatelocation();                                           //run UpdateLocation function
    }
    
    // Function to keep the current location updated
    void Updatelocation() {
        locationName.text = currentLocation.locationName;                   //change location name to the current location name
        locationDescription.text = currentLocation.description;             //change location description to the current location description

        if (currentLocation.northLocation == null) {                        //if no location to the north of the current location
            northButton.SetActive(false);                                   //deactivate the north button
        }
        
        else {
            currentLocation.northLocation.southLocation = currentLocation;  //auto fill the south location with the previous location
            northButton.SetActive(true);                                    //activate the north button
        }

        if (currentLocation.southLocation == null) {                        //if no location to the south of the current location
            southButton.SetActive(false);                                   //deactivate the south button
        }
        else {
            currentLocation.southLocation.northLocation = currentLocation;  //auto fill the north location with the previous location  
            southButton.SetActive(true);                                    //activate the south button
        }

        if (currentLocation.eastLocation == null) {                         //if no location to the east of the current location
            eastButton.SetActive(false);                                    //deactivate the east button
        }
        else {
            currentLocation.eastLocation.westLocation = currentLocation;    //auto fill the west location with the previous location
            eastButton.SetActive(true);                                     //activate the east button
        }

        if (currentLocation.westLocation == null) {                         //if no location to the west of the current location
            westButton.SetActive(false);                                    //deactivate the west button
        }
        else {
            currentLocation.westLocation.eastLocation = currentLocation;     //auto fill the east location with the previous location
            westButton.SetActive(true);                                      //activate the west button
        }
    }
}

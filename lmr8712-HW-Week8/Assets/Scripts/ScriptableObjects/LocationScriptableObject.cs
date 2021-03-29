using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Location",   
    menuName = "ScriptableObjects/Location", order = 0)]
    
public class LocationScriptableObject : ScriptableObject
{
    // Create a space to store strings
    public string locationName = "New Place";
    public string description = "Default Description";

    // Create a space to store scriptable objects
    public LocationScriptableObject northLocation;
    public LocationScriptableObject southLocation;
    public LocationScriptableObject eastLocation;
    public LocationScriptableObject westLocation;
}

﻿/****************************** Script Header ******************************\
Script Name: 
Project: CodeFactory
Author: 
Editors: 

<Description>

\***************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class GameAssets : MonoBehaviour
{
    // This entire script allows you to make multiple GameAssets through code and give them their sprite or other gameasset through a GameAsset Prefab in Unity

    // Creates an internal reference
    private static GameAssets _i;

    // Basically reads all the GameAssets in this script and allows each one of them to be given their gameasset through a GameAsset Prefab in Unity
    public static GameAssets i
    {
        get
        {
            if (_i == null)
            {
                _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            }
            return _i;
        }
    }

    // The GameAssets
    public Sprite pog; // Holds the sprite for pogs
    public Sprite bronzePog; // Holds the sprite for bronze pogs
    public Sprite silverPog; // Holds the sprite for silver pogs
    public Sprite goldPog; // Holds the sprite for gold pogs
    public Sprite diamondPog; // Holds the sprite for diamond pogs
    public Sprite stone; // Holds the sprite for the stone icon
    public Sprite coal; // Holds the sprite for the coal icon
    public Sprite iron; // Holds the sprite for the iron icon
    public Sprite gold; // Holds the sprite for the gold icon
    public Sprite diamond; // Holds the sprite for the diamond icon
}

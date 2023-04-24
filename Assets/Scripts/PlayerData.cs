using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    //[OdinSerialize, ShowInInspector]
    public PlayerCurrency currency;

    //[OdinSerialize, ShowInInspector]
    public MaterialCurrency materials;

    //A static variable which holds a reference to the single created instance
    private static PlayerData instance = null;

    //A public static means of getting the reference to the single created instance, creating one if necessary
    public static PlayerData Instance
    {
        get
        {
            if (instance == null)
            {
                // Find singleton of this type in the scene
                var instance = GameObject.FindObjectOfType<PlayerData>();

                // If there is no singleton object in the scene, throw error
                if (instance == null)
                {
                    Debug.LogError("ERROR: No Player Data instance found!");
                }
            }

            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            // Init the singleton

            // The singleton object shouldn't be destroyed when we switch between scenes
            DontDestroyOnLoad(this.gameObject);
        }
        // because we inherit from MonoBehaviour whem might have accidentally added several of them to the scene,
        // which will cause trouble, so we have to make sure we have just one!
        else
        {
            Destroy(gameObject);
        }
    }
}

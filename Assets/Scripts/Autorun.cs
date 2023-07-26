using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autorun : MonoBehaviour
{
    public static Autorun Instance;

    // variables moving across scenes
    public int highScore;
    public string playerID;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        // initialization of variables
        highScore = 0;
        playerID = string.Empty;
    }
}

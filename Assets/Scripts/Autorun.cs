using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autorun : MonoBehaviour
{
    public static Autorun Instance;

    // variable(s) moving across scenes
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
        playerID = string.Empty;
    }
}

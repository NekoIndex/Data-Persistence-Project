using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPlayerID : MonoBehaviour
{
    private string userID;
    public void SavingUserID(string inputID)
    {
        userID = inputID;
        Autorun.Instance.playerID = userID;
        Debug.Log(userID);
    }
}

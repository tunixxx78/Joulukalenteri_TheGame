using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataButtons : MonoBehaviour
{
    public DataHolder gameDataHolder;

    public void GameHasStarted()
    {
        DataHolder.dataInstance.gameHasStarted = true;
        DataHolder.dataInstance.SaveData();
    }
}

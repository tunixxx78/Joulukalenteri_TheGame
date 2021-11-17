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
    public void PresentOneOpened()
    {
        DataHolder.dataInstance.presentOne = true;
        DataHolder.dataInstance.presentOneOpened = true;
        DataHolder.dataInstance.SaveData();
    }
}

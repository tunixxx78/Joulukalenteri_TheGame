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
        Invoke("PresentTwo", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentTwoOpened()
    {
        DataHolder.dataInstance.presentTwo = true;
        DataHolder.dataInstance.presentTwoOpened = true;
        Invoke("PresentThree", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentThreeOpened()
    {
        DataHolder.dataInstance.presentThree = true;
        DataHolder.dataInstance.presentThreeOpened = true;
        Invoke("PresentFour", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentFourOppened()
    {
        DataHolder.dataInstance.presentFour = true;
        DataHolder.dataInstance.presentFourOpened = true;
        Invoke("PresentFive", 1);
        DataHolder.dataInstance.SaveData();
    }

    void PresentTwo()
    {
        DataHolder.dataInstance.presentTwoSpawned = true;
        DataHolder.dataInstance.SaveData();

    }
    void PresentThree()
    {
        DataHolder.dataInstance.presentThreeSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentFour()
    {
        DataHolder.dataInstance.PresentFourSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentFive()
    {
        DataHolder.dataInstance.presentFiveSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
}

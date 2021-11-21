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
    public void PresentFiveOppened()
    {
        DataHolder.dataInstance.presentFive = true;
        DataHolder.dataInstance.presentFiveOpened = true;
        Invoke("PresentSix", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentSixOppened()
    {
        DataHolder.dataInstance.presentSix = true;
        DataHolder.dataInstance.presentSixOpened = true;
        Invoke("PresentSeven", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentSevenOppened()
    {
        DataHolder.dataInstance.presentSeven = true;
        DataHolder.dataInstance.presentSevenOpened = true;
        Invoke("PresentEight", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentEightOppened()
    {
        DataHolder.dataInstance.presentEight = true;
        DataHolder.dataInstance.presentEightOpened = true;
        Invoke("PresentNine", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentNineOppened()
    {
        DataHolder.dataInstance.presentNine = true;
        DataHolder.dataInstance.presentNineOpened = true;
        Invoke("PresentTen", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void PresentTenOppened()
    {
        DataHolder.dataInstance.presentTen = true;
        DataHolder.dataInstance.presentTenOpened = true;
        Invoke("Present11", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present11Oppened()
    {
        DataHolder.dataInstance.present11 = true;
        DataHolder.dataInstance.present11Opened = true;
        Invoke("Present12", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present12Oppened()
    {
        DataHolder.dataInstance.present12 = true;
        DataHolder.dataInstance.present12Opened = true;
        Invoke("Present13", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present13Oppened()
    {
        DataHolder.dataInstance.present13 = true;
        DataHolder.dataInstance.present13Opened = true;
        Invoke("Present14", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present14Oppened()
    {
        DataHolder.dataInstance.present14 = true;
        DataHolder.dataInstance.present14Opened = true;
        Invoke("Present15", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present15Oppened()
    {
        DataHolder.dataInstance.present15 = true;
        DataHolder.dataInstance.present15Opened = true;
        Invoke("Present16", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present16Oppened()
    {
        DataHolder.dataInstance.present16 = true;
        DataHolder.dataInstance.present16Opened = true;
        Invoke("Present17", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present17Oppened()
    {
        DataHolder.dataInstance.present17 = true;
        DataHolder.dataInstance.present17Opened = true;
        Invoke("Present18", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present18Oppened()
    {
        DataHolder.dataInstance.present18 = true;
        DataHolder.dataInstance.present18Opened = true;
        Invoke("Present19", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present19Oppened()
    {
        DataHolder.dataInstance.present19 = true;
        DataHolder.dataInstance.present19Opened = true;
        Invoke("Present20", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present20Oppened()
    {
        DataHolder.dataInstance.present20 = true;
        DataHolder.dataInstance.present20Opened = true;
        Invoke("Present21", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present21Oppened()
    {
        DataHolder.dataInstance.present21 = true;
        DataHolder.dataInstance.present21Opened = true;
        Invoke("Present22", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present22Oppened()
    {
        DataHolder.dataInstance.present22 = true;
        DataHolder.dataInstance.present22Opened = true;
        Invoke("Present23", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present23Oppened()
    {
        DataHolder.dataInstance.present23 = true;
        DataHolder.dataInstance.present23Opened = true;
        Invoke("Present24", 1);
        DataHolder.dataInstance.SaveData();
    }
    public void Present24Oppened()
    {
        DataHolder.dataInstance.present24 = true;
        DataHolder.dataInstance.present24Opened = true;
        //Invoke("PresentFive", 1);
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
        DataHolder.dataInstance.presentFourSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentFive()
    {
        DataHolder.dataInstance.presentFiveSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentSix()
    {
        DataHolder.dataInstance.presentSixSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentSeven()
    {
        DataHolder.dataInstance.presentSevenSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentEight()
    {
        DataHolder.dataInstance.presentEightSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentNine()
    {
        DataHolder.dataInstance.presentNineSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void PresentTen()
    {
        DataHolder.dataInstance.presentTenSpawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present11()
    {
        DataHolder.dataInstance.present11Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present12()
    {
        DataHolder.dataInstance.present12Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present13()
    {
        DataHolder.dataInstance.present13Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present14()
    {
        DataHolder.dataInstance.present14Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present15()
    {
        DataHolder.dataInstance.present15Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present16()
    {
        DataHolder.dataInstance.present16Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present17()
    {
        DataHolder.dataInstance.present17Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present18()
    {
        DataHolder.dataInstance.present18Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present19()
    {
        DataHolder.dataInstance.present19Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present20()
    {
        DataHolder.dataInstance.present20Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present21()
    {
        DataHolder.dataInstance.present21Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present22()
    {
        DataHolder.dataInstance.present22Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present23()
    {
        DataHolder.dataInstance.present23Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
    void Present24()
    {
        DataHolder.dataInstance.present24Spawned = true;
        DataHolder.dataInstance.SaveData();
    }
}

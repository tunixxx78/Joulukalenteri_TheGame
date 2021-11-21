using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class DataHolder : MonoBehaviour
{
    public static DataHolder dataInstance;

    public bool gameHasStarted, presentOne, presentTwo, presentThree, presentFour, presentFive, presentSix, presentSeven, presentEight, presentNine, presentTen, present11, present12, present13, present14, present15, present16, present17, present18, present19, present20,
        present21, present22, present23, present24;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened, presentFourOpened, presentFiveOpened, presentSixOpened, presentSevenOpened, presentEightOpened, presentNineOpened, presentTenOpened, present11Opened, present12Opened, present13Opened, present14Opened,
        present15Opened, present16Opened , present17Opened, present18Opened, present19Opened, present20Opened, present21Opened, present22Opened, present23Opened, present24Opened;
    public bool presentTwoSpawned, presentThreeSpawned, presentFourSpawned, presentFiveSpawned, presentSixSpawned, presentSevenSpawned, presentEightSpawned, presentNineSpawned, presentTenSpawned, present11Spawned, present12Spawned, present13Spawned, present14Spawned,
        present15Spawned, present16Spawned, present17Spawned, present18Spawned, present19Spawned, present20Spawned, present21Spawned, present22Spawned, present23Spawned, present24Spawned;

    private void Awake()
    {
        LoadData();

        if(dataInstance != null && dataInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        dataInstance = this;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameHasStarted = false;
            presentOne = false;
            presentTwo = false;
            presentThree = false;
            presentFour = false;
            presentOneOpened = false;
            presentTwoOpened = false;
            presentThreeOpened = false;
            presentFourOpened = false;
            presentTwoSpawned = false;
            presentThreeSpawned = false;
            presentFourSpawned = false;
            presentFiveSpawned = false;

            SaveData();
        }
    }

    public void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamedata.dat");
        GameData data = new GameData();

        data.gameHasStarted = gameHasStarted;
        data.presentOne = presentOne;
        data.presentTwo = presentTwo;
        data.presentThree = presentThree;
        data.presentFour = presentFour;
        data.presentFive = presentFive;
        data.presentSix = presentSix;
        data.presentSeven = presentSeven;
        data.presentEight = presentEight;
        data.presentNine = presentNine;
        data.presentTen = presentTen;
        data.present11 = present11;
        data.present12 = present12;
        data.present13 = present13;
        data.present14 = present14;
        data.present15 = present15;
        data.present16 = present16;
        data.present17 = present17;
        data.present18 = present18;
        data.present19 = present19;
        data.present20 = present20;
        data.present21 = present21;
        data.present22 = present22;
        data.present23 = present23;
        data.present24 = present24;
        
        
        data.presentOneOpened = presentOneOpened;
        data.presentTwoOpened = presentTwoOpened;
        data.presentThreeOpened = presentThreeOpened;
        data.presentFourOpened = presentFourOpened;
        data.presentFiveOpened = presentFiveOpened;
        data.presentSixOpened = presentSixOpened;
        data.presentSevenOpened = presentSevenOpened;
        data.presentEightOpened = presentEightOpened;
        data.presentNineOpened = presentNineOpened;
        data.presentTenOpened = presentTenOpened;
        data.present11Opened = present11Opened;
        data.present12Opened = present12Opened;
        data.present13Opened = present13Opened;
        data.present14Opened = present14Opened;
        data.present15Opened = present15Opened;
        data.present16Opened = present16Opened;
        data.present17Opened = present17Opened;
        data.present18Opened = present18Opened;
        data.present19Opened = present19Opened;
        data.present20Opened = present20Opened;
        data.present21Opened = present21Opened;
        data.present22Opened = present22Opened;
        data.present23Opened = present23Opened;
        data.present24Opened = present24Opened;

        data.presentTwoSpawned = presentTwoSpawned;
        data.presentThreeSpawned = presentThreeSpawned;
        data.presentFourSpawned = presentFourSpawned;
        data.presentFiveSpawned = presentFiveSpawned;
        data.presentSixSpawned = presentSixSpawned;
        data.presentSevenSpawned = presentSevenSpawned;
        data.presentEightSpawned = presentEightSpawned;
        data.presentNineSpawned = presentNineSpawned;
        data.presentTenSpawned = presentTenSpawned;
        data.present11Spawned = present11Spawned;
        data.present12Spawned = present12Spawned;
        data.present13Spawned = present13Spawned;
        data.present14Spawned = present14Spawned;
        data.present15Spawned = present15Spawned;
        data.present16Spawned = present16Spawned;
        data.present17Spawned = present17Spawned;
        data.present18Spawned = present18Spawned;
        data.present19Spawned = present19Spawned;
        data.present20Spawned = present20Spawned;
        data.present21Spawned = present21Spawned;
        data.present22Spawned = present22Spawned;
        data.present23Spawned = present23Spawned;
        data.present24Spawned = present24Spawned;

        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadData()
    {
        if (File.Exists(Application.persistentDataPath + "/gamedata.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamedata.dat", FileMode.Open);
            GameData data = (GameData)bf.Deserialize(file);

            gameHasStarted = data.gameHasStarted;
            presentOne = data.presentOne;
            presentTwo = data.presentTwo;
            presentThree = data.presentThree;
            presentFour = data.presentFour;
            presentFive = data.presentFive;
            presentSix = data.presentSix;
            presentSeven = data.presentSeven;
            presentEight = data.presentEight;
            presentNine = data.presentNine;
            presentTen = data.presentTen;
            present11 = data.present11;
            present12 = data.present12;
            present13 = data.present13;
            present14 = data.present14;
            present15 = data.present15;
            present16 = data.present16;
            present17 = data.present17;
            present18 = data.present18;
            present19 = data.present19;
            present20 = data.present20;
            present21 = data.present21;
            present22 = data.present22;
            present23 = data.present23;
            present24 = data.present24;

            presentOneOpened = data.presentOneOpened;
            presentTwoOpened = data.presentTwoOpened;
            presentThreeOpened = data.presentThreeOpened;
            presentFourOpened = data.presentFourOpened;
            presentFiveOpened = data.presentFiveOpened;
            presentSixOpened = data.presentSixOpened;
            presentSevenOpened = data.presentSevenOpened;
            presentEightOpened = data.presentEightOpened;
            presentNineOpened = data.presentNineOpened;
            presentTenOpened = data.presentTenOpened;
            present11Opened = data.present11Opened;
            present12Opened = data.present12Opened;
            present13Opened = data.present13Opened;
            present14Opened = data.present14Opened;
            present15Opened = data.present15Opened;
            present16Opened = data.present16Opened;
            present17Opened = data.present17Opened;
            present18Opened = data.present18Opened;
            present19Opened = data.present19Opened;
            present20Opened = data.present20Opened;
            present21Opened = data.present21Opened;
            present22Opened = data.present22Opened;
            present23Opened = data.present23Opened;
            present24Opened = data.present24Opened;

            presentTwoSpawned = data.presentTwoSpawned;
            presentThreeSpawned = data.presentThreeSpawned;
            presentFourSpawned = data.presentFourSpawned;
            presentFiveSpawned = data.presentFiveSpawned;
            presentSixSpawned = data.presentSixSpawned;
            presentSevenSpawned = data.presentSevenSpawned;
            presentEightSpawned = data.presentEightSpawned;
            presentNineSpawned = data.presentNineSpawned;
            presentTenSpawned = data.presentTenSpawned;
            present11Spawned = data.present11Spawned;
            present12Spawned = data.present12Spawned;
            present13Spawned = data.present13Spawned;
            present14Spawned = data.present14Spawned;
            present15Spawned = data.present15Spawned;
            present16Spawned = data.present16Spawned;
            present17Spawned = data.present17Spawned;
            present18Spawned = data.present18Spawned;
            present19Spawned = data.present19Spawned;
            present20Spawned = data.present20Spawned;
            present21Spawned = data.present21Spawned;
            present22Spawned = data.present22Spawned;
            present23Spawned = data.present23Spawned;
            present24Spawned = data.present24Spawned;

        }
    }


}

[Serializable]

class GameData
{
    public bool gameHasStarted, presentOne, presentTwo, presentThree, presentFour, presentFive, presentSix, presentSeven, presentEight, presentNine, presentTen, present11, present12, present13, present14, present15, present16, present17, present18, present19, present20,
         present21, present22, present23, present24;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened, presentFourOpened, presentFiveOpened, presentSixOpened, presentSevenOpened, presentEightOpened, presentNineOpened, presentTenOpened, present11Opened, present12Opened, present13Opened, present14Opened,
        present15Opened, present16Opened, present17Opened, present18Opened, present19Opened, present20Opened, present21Opened, present22Opened, present23Opened, present24Opened;
    public bool presentTwoSpawned, presentThreeSpawned, presentFourSpawned, presentFiveSpawned, presentSixSpawned, presentSevenSpawned, presentEightSpawned, presentNineSpawned, presentTenSpawned, present11Spawned, present12Spawned, present13Spawned, present14Spawned,
        present15Spawned, present16Spawned, present17Spawned, present18Spawned, present19Spawned, present20Spawned, present21Spawned, present22Spawned, present23Spawned, present24Spawned;
}

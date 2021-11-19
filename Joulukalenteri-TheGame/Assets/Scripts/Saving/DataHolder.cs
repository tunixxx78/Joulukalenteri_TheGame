using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class DataHolder : MonoBehaviour
{
    public static DataHolder dataInstance;

    public bool gameHasStarted, presentOne, presentTwo, presentThree, presentFour;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened, presentFourOpened;
    public bool presentTwoSpawned, presentThreeSpawned, PresentFourSpawned, presentFiveSpawned;

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
            PresentFourSpawned = false;
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
        data.presentOneOpened = presentOneOpened;
        data.presentTwoOpened = presentTwoOpened;
        data.presentThreeOpened = presentThreeOpened;
        data.presentFourOpened = presentFourOpened;
        data.presentTwoSpawned = presentTwoSpawned;
        data.presentThreeSpawned = presentThreeSpawned;
        data.PresentFourSpawned = PresentFourSpawned;
        data.presentFiveSpawned = presentFiveSpawned;

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
            presentOneOpened = data.presentOneOpened;
            presentTwoOpened = data.presentTwoOpened;
            presentThreeOpened = data.presentThreeOpened;
            presentFourOpened = data.presentFourOpened;
            presentTwoSpawned = data.presentTwoSpawned;
            presentThreeSpawned = data.presentThreeSpawned;
            PresentFourSpawned = data.PresentFourSpawned;
            presentFiveSpawned = data.presentFiveSpawned;
        }
    }


}

[Serializable]

class GameData
{
    public bool gameHasStarted, presentOne, presentTwo, presentThree, presentFour;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened, presentFourOpened;
    public bool presentTwoSpawned, presentThreeSpawned, PresentFourSpawned, presentFiveSpawned;
}

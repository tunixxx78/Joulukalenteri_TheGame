using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class DataHolder : MonoBehaviour
{
    public static DataHolder dataInstance;

    public bool gameHasStarted, presentOne, presentTwo, presentThree;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened;
    public bool presentTwoSpawned, presentThreeSpawned, PresentFourSpawned;

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
            presentOneOpened = false;
            presentTwoOpened = false;
            presentThreeOpened = false;
            presentTwoSpawned = false;
            presentThreeSpawned = false;
            PresentFourSpawned = false;
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
        data.presentOneOpened = presentOneOpened;
        data.presentTwoOpened = presentTwoOpened;
        data.presentThreeOpened = presentThreeOpened;
        data.presentTwoSpawned = presentTwoSpawned;
        data.presentThreeSpawned = presentThreeSpawned;
        data.PresentFourSpawned = PresentFourSpawned;

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
            presentOneOpened = data.presentOneOpened;
            presentTwoOpened = data.presentTwoOpened;
            presentThreeOpened = data.presentThreeOpened;
            presentTwoSpawned = data.presentTwoSpawned;
            presentThreeSpawned = data.presentThreeSpawned;
            PresentFourSpawned = data.PresentFourSpawned;
        }
    }


}

[Serializable]

class GameData
{
    public bool gameHasStarted, presentOne, presentTwo, presentThree;
    public bool presentOneOpened, presentTwoOpened, presentThreeOpened;
    public bool presentTwoSpawned, presentThreeSpawned, PresentFourSpawned;
}

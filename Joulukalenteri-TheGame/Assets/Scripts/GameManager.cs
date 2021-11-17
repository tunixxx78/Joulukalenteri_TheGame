using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Date gameDate;
    [SerializeField] GameObject presentOne, spawnPointOne, presentTwo, spawnPointTwo, presentThree, spawnPointThree;
    public bool isSpawned = true, isSpawned2 = false, isSpawned3 = false;

    private void Awake()
    {
        gameDate = FindObjectOfType<Date>();
        
    }

    private void Update()
    {
        DayOne();
        DayTwo();
        DayThree();
    }
    public void StartGameNow()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void IsSpawnedToTrue()
    {
        if (DataHolder.dataInstance.presentTwoSpawned == false)
        {
            isSpawned2 = true;
        }
        
    }


    public void QuitGame()
    {
        Application.Quit();
    }

    void DayOne()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            

            if (isSpawned)
            {
                Debug.Log("T??ll?");
                if (gameDate.dateInInt >= 16)
                {
                    Instantiate(presentOne, spawnPointOne.transform.position, Quaternion.identity);
                    isSpawned = false;
                }
            }
        }
        
        
        
    }
    void DayTwo()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            if (isSpawned2 == true)
            {
                if (gameDate.dateInInt >= 17 )
                {
                    Instantiate(presentTwo, spawnPointTwo.transform.position, Quaternion.identity);
                    isSpawned2 = false;
                }
            }
        }
    }

    void DayThree()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {
            if (isSpawned2 == true)
            {
                if (gameDate.dateInInt >= 18)
                {
                    Instantiate(presentThree, spawnPointThree.transform.position, Quaternion.identity);
                    isSpawned3 = false;
                }
            }
        }
    }
}

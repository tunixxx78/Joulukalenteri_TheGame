using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Date gameDate;
    [SerializeField] GameObject presentOne, spawnPointOne, presentTwo, spawnPointTwo, presentThree, spawnPointThree, presentFour, spawnPointFour;
    public bool isSpawned = true, isSpawned2 = false, isSpawned3 = false, isSpawned4 = false;

    private void Awake()
    {
        gameDate = FindObjectOfType<Date>();
        
    }

    private void Update()
    {
        DayOne();
        DayTwo();
        DayThree();
        DayFour();
    }
    public void StartGameNow()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PresentTwoSpawned()
    {
        if (DataHolder.dataInstance.presentTwoSpawned == false)
        {
            isSpawned2 = true;
        }
        
    }
    public void PresentThreeSpawned()
    {
        if (DataHolder.dataInstance.presentThreeSpawned == false)
        {
            isSpawned3 = true;
        }

    }
    public void PresentFourSpawned()
    {
        if(DataHolder.dataInstance.PresentFourSpawned == false)
        {
            isSpawned4 = true;
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
                if (gameDate.dateInInt >= 15)
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
                if (gameDate.dateInInt >= 16)
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
            
            if (isSpawned3 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 17)
                {
                    Instantiate(presentThree, spawnPointThree.transform.position, Quaternion.identity);
                    isSpawned3 = false;
                }
            }
        }
    }
    void DayFour()
    {
        if (gameDate.dateInInt >= 1 && gameDate.dateInInt <= 24)
        {

            if (isSpawned4 == true)
            {
                Debug.Log("PASKAA");
                if (gameDate.dateInInt >= 18)
                {
                    Instantiate(presentFour, spawnPointFour.transform.position, Quaternion.identity);
                    isSpawned4 = false;
                }
            }
        }
    }
}

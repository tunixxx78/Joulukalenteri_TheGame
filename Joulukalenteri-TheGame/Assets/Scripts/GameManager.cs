using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Date gameDate;
    [SerializeField] GameObject presentOne, spawnPointOne;
    bool isSpawned = true;

    private void Awake()
    {
        gameDate = FindObjectOfType<Date>();
        
    }

    private void Update()
    {
        DayOne();
    }
    public void StartGameNow()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void DayOne()
    {
        if (gameDate.dateInInt < 17)
        {
            
        }
        if (isSpawned)
        {
            if (gameDate.dateInInt == 17)
            {
                Instantiate(presentOne, spawnPointOne.transform.position, Quaternion.identity);
                isSpawned = false;
            }
        }
        
        
    }
}

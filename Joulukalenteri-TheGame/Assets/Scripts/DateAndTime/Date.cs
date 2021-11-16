using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Date : MonoBehaviour
{
    [SerializeField] TMP_Text timeText;
    public TMP_Text dateText, monthText;
    public int dateInInt;

    private void Start()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd");
        string month = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        print(time);
        print(date);
        timeText.text = time;
        dateText.text = date;
        monthText.text = month;
    }

    private void Update()
    {

        CurrentDate();
        
    }

    public void CurrentDate()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd");
        string month = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        print(time);
        timeText.text = time;
        dateText.text = date;

        int.TryParse(date, out dateInInt);
        Debug.Log(dateInInt);
    }
}

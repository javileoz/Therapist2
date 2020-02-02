using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI timerText;
    public static float currentTimer = 190; //Segundos con los que empieza el timer a contar
    public bool countDown;
    public bool paused=false;

    // Update is called once per frame
    void Update()
    {
        if(paused == false)
        {
            if (countDown == true)
            {
                currentTimer = currentTimer - Time.deltaTime;
                if (currentTimer <= 0)
                {
                    countDown = false;
                    currentTimer = 0;
                    paused = true;
                }
            }

            else
            {
                currentTimer = currentTimer + Time.deltaTime;
            }

            UpdateUI();
        }

        if (currentTimer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            currentTimer = 190;
        }

    }

    void UpdateUI()
    {
        int min = Mathf.FloorToInt(currentTimer / 60);
        int sec = Mathf.FloorToInt(currentTimer - (min * 60));

        timerText.text = string.Format("{0:00}:{1:00}", min, sec);

        
    }
}

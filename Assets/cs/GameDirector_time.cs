using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector_time : MonoBehaviour
{
    GameObject timeGuage;
    GameObject GameOver;
    GameObject Die;
    GameObject Success;

    // Start is called before the first frame update
    void Start()
    {
        this.timeGuage = GameObject.Find("timeGuage");
        this.GameOver = GameObject.Find("GameOver");
        this.Die = GameObject.Find("Die");
        this.Success = GameObject.Find("Success");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimeGuage();
        if (timeGuage.GetComponent<Image>().fillAmount == 0)
        {
            if (this.Die.GetComponent<TextMeshProUGUI>().text==" " && this.Success.GetComponent<TextMeshProUGUI>().text==" ")
            {
                this.GameOver.GetComponent<TextMeshProUGUI>().text = "Game Over";

            }
        }
        else
        {
            this.GameOver.GetComponent<TextMeshProUGUI>().text = " ";
        }
    }

    void UpdateTimeGuage()
    {
        this.timeGuage.GetComponent<Image>().fillAmount -= 0.00005f;
    }

    public void IncreaseTimeGuage()
    {
        this.timeGuage.GetComponent<Image>().fillAmount += 0.2f;
    }
}

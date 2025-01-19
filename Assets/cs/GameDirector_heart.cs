using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector_heart : MonoBehaviour
{
    GameObject heartGuage;
    GameObject Die;
    GameObject Success;
    GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        this.heartGuage = GameObject.Find("heartGuage");
        this.Die = GameObject.Find("Die");
        this.Success = GameObject.Find("Success");
        this.GameOver = GameObject.Find("GameOver");
    }

    void Update()
    {
        if (heartGuage.GetComponent<Image>().fillAmount == 0)
        {
            if(this.Success.GetComponent<TextMeshProUGUI>().text==" " && this.GameOver.GetComponent<TextMeshProUGUI>().text==" ")
            {
                this.Die.GetComponent<TextMeshProUGUI>().text = "You Died!";
            }
        }
        else
        {
            this.Die.GetComponent<TextMeshProUGUI>().text = " ";
        }
    }

    public void BigDecreaseHp()
    {
        this.heartGuage.GetComponent<Image>().fillAmount -= 0.2f;
    }

    public void DecreaseHp()
    {
        this.heartGuage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp()
    {
        this.heartGuage.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void FullHp()
    {
        this.heartGuage.GetComponent<Image>().fillAmount = 1.0f;
    }

}

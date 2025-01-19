using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameDirector_starfish : MonoBehaviour
{
    public static int cnt = 10;

    GameObject player;
    GameObject starfish;
    GameObject starfishCount;
    GameObject Success;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.starfish = GameObject.Find("starfish");
        this.starfishCount = GameObject.Find("starfishCount");
        this.Success = GameObject.Find("Success");
    }

    // Update is called once per frame
    void Update()
    {
        this.starfishCount.GetComponent<TextMeshProUGUI>().text = "Left starfish : " + cnt;
        if (cnt <= 0)
        {
            this.starfishCount.GetComponent<TextMeshProUGUI>().text = "Left starfish : 0";
            this.Success.GetComponent<TextMeshProUGUI>().text = "Success!";
        }
        else
        {
            this.Success.GetComponent<TextMeshProUGUI>().text = " ";
        }
    }

    public static void IncreaseCnt()
    {
        cnt--;
    }
}

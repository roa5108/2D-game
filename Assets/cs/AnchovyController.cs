using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchovyController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f, 0, 0);

        if (transform.position.x < -7.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector_heart");
            director.GetComponent<GameDirector_heart>().IncreaseHp();
            Destroy(gameObject);
        }
    }
}

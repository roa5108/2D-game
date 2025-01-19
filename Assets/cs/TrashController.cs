using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    GameObject diver;
    GameObject player;
    bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.diver = GameObject.Find("diver");
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(0, -0.01f, 0);
        }

        if (transform.position.y < -4.4f)
        {
            isMoving = false; // ÀÌµ¿ ¸ØÃã »óÅÂ·Î º¯°æ
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 p3 = this.diver.transform.position;

        Vector2 dir = p1 - p2;
        Vector2 dir2 = p1 - p3;

        float d = dir.magnitude;
        float d2 = dir2.magnitude;

        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2 || d2 < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector_heart");
            director.GetComponent<GameDirector_heart>().DecreaseHp();
            Destroy(gameObject);
        }

    }
}

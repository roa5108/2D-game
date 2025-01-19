using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);
            GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);
            GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 2, 0);
            GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -2, 0);
            GetComponent<AudioSource>().Play();
        }
    }
}

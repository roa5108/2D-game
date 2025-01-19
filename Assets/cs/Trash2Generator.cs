using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash2Generator : MonoBehaviour
{
    public GameObject trash2Prefab;
    float span = 8.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(trash2Prefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}

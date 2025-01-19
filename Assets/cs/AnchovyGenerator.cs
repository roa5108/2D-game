using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchovyGenerator : MonoBehaviour
{
    public GameObject anchovyPrefab;
    float span = 3.0f;
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
            GameObject go = Instantiate(anchovyPrefab) as GameObject;
            int py = Random.Range(-6, 7);
            go.transform.position = new Vector3(7, py, 0);
        }
    }
}

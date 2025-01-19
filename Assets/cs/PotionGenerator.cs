using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionGenerator : MonoBehaviour
{
    public GameObject potionPrefab;
    float span = 15.0f;
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
            GameObject go = Instantiate(potionPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            int py = Random.Range(-5, 5);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}

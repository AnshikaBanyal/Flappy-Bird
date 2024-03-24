using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerSpawnerScript : MonoBehaviour
{
    public GameObject piller;
    public float spawnRate = 5;
    public float heightOffset;
    private float timer = 0;

    void Start()
    {
        swanPipe();
    }


    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else {
             swanPipe();
             timer = 0;
        }
    }
    void swanPipe(){
        float lowestPt = transform.position.y - heightOffset;
        float hightestPt = transform.position.y + heightOffset;
        Instantiate(piller, new Vector3(transform.position.x, Random.Range(lowestPt,hightestPt), 10), transform.rotation);
    }
}

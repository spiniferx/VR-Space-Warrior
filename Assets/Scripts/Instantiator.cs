using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] instantiatePos;
    public int count=0;
    public int timeToInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count>=timeToInstantiate)
        {
            count = 0;
            int i = Random.Range(0, prefabs.Length);
            int j = Random.Range(0, instantiatePos.Length);
            GameObject go= Instantiate(prefabs[i], new Vector3(instantiatePos[j].position.x, transform.position.y-2f, transform.position.z), transform.rotation * Quaternion.Euler(0f, 180f, 0f));
            Destroy(go, 20);
            Debug.Log("Planet Destroyed");
           // if (timeToInstantiate > 50)
           // {
           //    timeToInstantiate -= 1;
           // }
        }
        
    }
}

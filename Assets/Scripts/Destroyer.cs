using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
   // public GameObject muzzle1;
  //  public GameObject muzzle2;
    public AudioSource blast;

    MeshRenderer ms;
    void Start()
    {
        MeshRenderer ms = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void destroyer()
    {
        gameObject.GetComponentInChildren<Renderer>().enabled = false;
        explosion.SetActive(true);
        blast.Play();
    //  muzzle1.SetActive(true);
    //  muzzle2.SetActive(true);
        Destroy(gameObject, 1f);
        Debug.Log("Destructed");
    }
}

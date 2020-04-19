using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public int speedIncreaseCounter;
   // public ParticleSystem muzzleflash1;
   // public ParticleSystem muzzleflash2;
 // public ParticleSystem explosion;

    // Update is called once per frame
    int muzzleCounter = 0;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            muzzleCounter++;
          //  if (muzzleCounter >= 2 ) {
             //   muzzleCounter = 0;
               // muzzleflash1.Play();
               // muzzleflash2.Play();
            //}
            Debug.Log(hit.transform.name);
        //  ParticleSystem go = Instantiate(explosion,hit.transform.position,Quaternion.identity);
         // Destroy(go, 1);
        }
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //speedIncreaseCounter++;
       // if(speedIncreaseCounter>=500)
       // {
         //   speedIncreaseCounter = 0;
         //   speed = speed + .01f;
      // }
    }

}

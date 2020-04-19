using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    private Vector3 target = new Vector3(5.0f, 0.0f, 0.0f);

    void Update()
    {
        transform.Rotate(.2f,.2f,.2f);
    }
}

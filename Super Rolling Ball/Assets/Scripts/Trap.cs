using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject sphere;    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.position = new Vector3(0.118f, 0.131f, 2.038f);            
        }
    }
}

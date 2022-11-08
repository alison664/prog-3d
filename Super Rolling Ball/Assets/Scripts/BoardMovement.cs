using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public float speed;
    public Transform transf;

    private void Start()
    {
        transf = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(speed * Time.deltaTime * Vector3.right);
        }            
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(speed * Time.deltaTime * -Vector3.right);
        }            

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(speed * Time.deltaTime * Vector3.forward);
        }            

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(speed * Time.deltaTime * -Vector3.forward);
        }
    }   
}

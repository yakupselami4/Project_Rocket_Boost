using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput(){
        if(Input.GetKey(KeyCode.Space)){
            rigidBody.AddRelativeForce(Vector3.up);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddRelativeForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddRelativeForce(Vector3.right);
        }
        }
}

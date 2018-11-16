using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    CharacterController cC;
    public float speed = 5;
    public float rotationSpeed = 2;

    // Use this for initialization
    void Start()
    {
        cC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertInput = Input.GetAxis("Vertical");
        {
            cC.SimpleMove(transform.forward * vertInput * speed);
        }
        float horizInput = Input.GetAxis("Horizontal");
        {
            transform.Rotate(Vector3.up * horizInput * rotationSpeed);
        }
        


    }
}

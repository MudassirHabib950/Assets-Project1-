using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // Private Variables
   // [SerializeField] private float speed = 20.0f;
   [SerializeField]private float horsePower = 0f;
   private const float turnSpeed = 45.0f;
   private float horizontalInput;
   private float verticalInput;
   private Rigidbody playerRb;
    // start is callled once
   void Start()
   {
   playerRb = GetComponent<Rigidbody>();
 }

    // Update is called once per frame
    void FixedUpdate(){
       // This is where we get player input
       horizontalInput=Input.GetAxis("Horizontal");
       verticalInput =Input.GetAxis("Vertical");
        // We move the Player forward by arrow key up and down
       //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); 
       playerRb.AddForce(Vector3.forward * horsePower * verticalInput );
        // rotates the car based on horizontaInput
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);
       
        }   
}
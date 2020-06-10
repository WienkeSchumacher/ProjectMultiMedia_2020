// Script for simple Player Movement
using UnityEngine;

public class Movement : MonoBehaviour{
    public float moveSpeed;
    public float jumpForce = 20;

    // This is a reference to the Rigidbody component called "cat"
    public Rigidbody cat;

    // Variable that determines the force of movement
    public float force;

    // We marked this as "Fixed"Update because we
    // are using it to deal with physics.
    void Start()
    {
        cat = GetComponent<Rigidbody>();
    }
      
    void Update()
    {
        cat.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, cat.velocity.y, Input.GetAxis("Vertical") * moveSpeed);


        // Hier sind 2 Spring Methoden die ich Probiert habe. Leider habe ich nicht verstanden wieso sie nicht Funktionieren. Werde versuchen sie zu verbessern sobald ich Zeit habe :) Vielleicht siehst du ja meinen Fehler.
        // Der Code klappt auch wenn es einkommentiert ist, aber die katze springt einfach nicht :C
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //Methode 1
        //    Debug.Log("Moving: springen gedrückt");
        //    cat.velocity = new Vector3(cat.velocity.x, force, cat.velocity.z);
        //    Debug.Log("Moving: springt " + cat.velocity.y.ToString());


        //    //Methode 2
        //    //cat.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //}
    }




    //void FixedUpdate(){

    //    if (Input.GetKey("w")){

    //        // Add a force to the front
    //        // Time.deltaTime to handle framerates
    //        cat.AddForce(0, 0, -force * Time.deltaTime);
    //    }

    //        if (Input.GetKey("s")){

    //            // Add a force to the back
    //            cat.AddForce(0, 0, force* Time.deltaTime);
    //}

    //    if (Input.GetKey("d")){ 
    //        // Add a force to the right
    //        cat.AddForce(-force * Time.deltaTime, 0, 0);
    //    }

    //    if (Input.GetKey("a")){
    //        // Add a force to the left
    //        cat.AddForce(force * Time.deltaTime, 0, 0);
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

    public float speed = 2;
    bool moveFB = false;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        

        if (Input.GetMouseButtonDown(0))
            moveFB = true;

        if (Input.GetMouseButtonUp(0))
            moveFB = false;

        MoveForward();



    }

    void MoveForward(){


        if (!moveFB)
            return;

        Vector3 movement = new Vector3(0, 0, speed);

        transform.Translate(movement*Time.deltaTime);

    }

}

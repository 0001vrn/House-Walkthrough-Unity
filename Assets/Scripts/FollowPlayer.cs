﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
	// Use this for initialization
	void Start () {
        
	}
	
   	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }
}

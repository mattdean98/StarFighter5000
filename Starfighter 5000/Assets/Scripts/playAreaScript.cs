﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAreaScript : MonoBehaviour {

    public  playerMovement playerScript;

    public GameObject player;

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "inside_panels")
        {
            Debug.Log("Left");
            player.GetComponent<playerMovement>().isInPlayArea = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "inside_panels")
        {
            Debug.Log("Entered");
            player.GetComponent<playerMovement>().isInPlayArea = true;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

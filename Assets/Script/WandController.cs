﻿using UnityEngine;
using System.Collections;

public class WandController : MonoBehaviour {

    private bool mActive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider collider)
    {

    }

    public bool isActive()
    {
        return mActive;
    }
}

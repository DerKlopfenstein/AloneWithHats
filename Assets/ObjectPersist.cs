﻿using UnityEngine;
using System.Collections;

public class ObjectPersist : MonoBehaviour {

	// Use this for initialization
	void Awake () 
    {

		DontDestroyOnLoad(this.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}

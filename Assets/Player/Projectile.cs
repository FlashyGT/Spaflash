﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		transform.Translate(0f, GameManager.Instance.realTimeSpeed * 2f, 0f);
    }
}

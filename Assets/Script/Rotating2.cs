﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating2 : MonoBehaviour
{
    public float speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * speed, 0));
    }
}

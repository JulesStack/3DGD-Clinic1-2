﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour {

    public Transform target;
    public Transform myTransform;

  

    // Update is called once per frame
    void Update () {

        myTransform.LookAt(target);
        myTransform.Translate(Vector3.forward * 3 * Time.deltaTime);

	}
}

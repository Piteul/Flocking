using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float translationX = Input.GetAxis("Horizontal") * speed;
        float translationY = Input.GetAxis("Vertical") * speed;
        translationX *= Time.deltaTime;
        translationY *= Time.deltaTime;
        transform.Translate(0, translationY, 0);
        transform.Translate(translationX,0, 0);
		
	}
}

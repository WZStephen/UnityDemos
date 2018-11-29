using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  public float moveSpeed = 50.0f;

  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 pos = transform.position;
        //retrieves a value from the Horizontal component of the Input Manager
    pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //retrieves a value from the vertical component of the Input Manager
        //That value indicates how much time has passed since the last Update()
    pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
    transform.position = pos;
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodySleep : MonoBehaviour {

	void Start(){
		RigidBody rb = GetComponent<Rigidbody>();
		if(rb != null) rb.Sleep();
	}
}

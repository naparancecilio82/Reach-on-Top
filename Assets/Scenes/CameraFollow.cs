using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public float smoothSpeed = .3f;	

	public Transform bg1;
	public Transform bg2;

	private float size;
	
	void Start() {
		size = bg1.GetComponent<BoxCollider2D>().size.y;
	}

	void Update() {
		if(target.position.y > transform.position.y) {
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}

		if(transform.position.y >= bg2.position.y) {
			bg1.position = new Vector3(bg1.position.x, bg2.position.y + size, bg1.position.z);
			SwitchBg();
		}
	}

	private void SwitchBg() {
		Transform temp = bg1;
		bg1 = bg2;
		bg2 = temp;
	}
 }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Vector3 mouse_pos;
    public Transform target;
    public Camera mainCamera;
    private Vector3 object_pos;
    private float angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            mouse_pos = Input.mousePosition;
            mouse_pos.y = 0;
            object_pos = mainCamera.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.z = mouse_pos.z - object_pos.z;
            angle = Mathf.Atan2(mouse_pos.z, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(target.rotation.x, target.rotation.y + angle, target.position.z);
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMotion : MonoBehaviour
{
	int back;
    Rigidbody m_Rigidbody;
    public float m_Speed = 5.0f;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        //m_Rigidbody = gameObject.AddComponent<Rigidbody>();//GetComponent<Rigidbody>();
        //m_Rigidbody.drag = 5.0f;
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
        	back = Camera.main.transform.rotation.x < 0.20 ? 1 : -1;
        	//move back when player looks down by some degree which I'm not sure to the horizontal
        	
        	//Debug.Log(back + " " + Camera.main.transform.rotation.x);
        	Vector3 forwardHorizontally = Camera.main.transform.forward;
        	forwardHorizontally.y = 0;

            transform.position = transform.position + back * (forwardHorizontally * m_Speed * Time.deltaTime);
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMotion : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5.0f;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = gameObject.AddComponent<Rigidbody>();//GetComponent<Rigidbody>();
        m_Rigidbody.drag = 5.0f;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            m_Rigidbody.velocity = new Vector3(transform.forward.x, 0, transform.forward.z) * m_Speed;
            Debug.Log(m_Rigidbody.name);
        }
    }
}
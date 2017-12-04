using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{

    private Rigidbody m_Rigidbody;
    [SerializeField]private double m_dAcceleration;

	void Awake ()
    {
       m_Rigidbody = GetComponent<Rigidbody>();
	}

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
      
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.AddForce(Vector3.up * (float)m_dAcceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_Rigidbody.AddForce(-Vector3.up * (float)m_dAcceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_Rigidbody.AddForce(Vector3.right * (float)m_dAcceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.AddForce(-Vector3.right * (float)m_dAcceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            m_Rigidbody.AddForce(Vector3.forward * (float)m_dAcceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            m_Rigidbody.AddForce(-Vector3.forward * (float)m_dAcceleration, ForceMode.Force);
        }

    }
}
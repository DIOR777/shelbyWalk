using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelMoves : MonoBehaviour
{

    public float velocity = 0.1f;
    public float angularVelocity = 10f;
    new public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * velocity;
        transform.Rotate(1f, 0.0f, 0.0f, Space.Self);
    }
}

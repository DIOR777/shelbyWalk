using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMoves : MonoBehaviour
{

    public float velocity = 0.1f;
    private float amplitude = 0.2f;
    new public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * velocity;
        transform.Rotate(Mathf.Sin(Time.time * 5f) * amplitude, 0.0f, 0.0f, Space.Self);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMoves : MonoBehaviour
{

    public float velocity = 0.1f;
    private int nitroUsage = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * velocity; // Движение автомобиля

        if (Input.GetKey(KeyCode.LeftShift) && nitroUsage > 0) {
            velocity += 0.02f;
            nitroUsage -= 1;
            Debug.Log("Nitro: " + nitroUsage);
        }

        if (velocity > 0.1f && !Input.GetKey(KeyCode.LeftShift)) {
            velocity -= 0.02f;
        }
    }

}

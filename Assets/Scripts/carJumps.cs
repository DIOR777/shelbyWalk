using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carJumps : MonoBehaviour
{
    private Quaternion startingRotation;
    private float amplitude = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        startingRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(-amplitude, 0.0f, 0.0f, Space.Self); // Наклон по оси x при зажатой клавише
        }

        if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(amplitude, 0.0f, 0.0f, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            transform.rotation = startingRotation;
        }
    }
}

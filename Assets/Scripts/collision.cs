using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    new public GameObject gameObject;

    private void OnTriggerEnter(Collider collider) {
        Destroy(collider.gameObject);
    }
}

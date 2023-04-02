using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider) {
        Destroy(collider.gameObject);
    }
}

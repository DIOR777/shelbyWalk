using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carInfo : MonoBehaviour
{
    new private string name = "Shelby-GT500 1963";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter() {
        Debug.Log("Model of this car: " + name);
    }
}

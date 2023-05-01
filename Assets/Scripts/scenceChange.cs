using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenceChange : MonoBehaviour
{
    private void Update()
    {
          if (Input.GetKeyDown(KeyCode.J))
          {
               Application.LoadLevel("shelbySummer");        
          }

          if (Input.GetKeyDown(KeyCode.K))
          {
               Application.LoadLevel("shelbyWinter");  
          }
    }
}

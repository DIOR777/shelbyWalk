using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carColor : MonoBehaviour
{
    private Renderer rendererProp;
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        rendererProp = target.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        rendererProp.material.shader = Shader.Find("HDRP/Lit");
        rendererProp.material.SetColor("_BaseColor", Random.ColorHSV());
    }

}

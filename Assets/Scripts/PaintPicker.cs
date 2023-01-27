using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintPicker : MonoBehaviour
{

    [SerializeField]
    MeshRenderer tipRender;

    [SerializeField]
    TrailRenderer trailRenderer;

    [SerializeField]
    Material currentMaterial;



    private void OnTriggerEnter(Collider other)
    {

        currentMaterial = other.GetComponent<Renderer>().material;
        tipRender.material = currentMaterial;
        trailRenderer.material = currentMaterial;
    }

}

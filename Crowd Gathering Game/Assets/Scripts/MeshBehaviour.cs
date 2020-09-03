using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshBehaviour : MonoBehaviour
{
     public List<Color> TintColors;

    void Awake()
    {
        if ( TintColors.Count > 0) {
            Color c = TintColors[Random.Range(0,TintColors.Count)];
            GetComponent<Renderer>().material.color = c;
        }
    }

    void Update()
    {
        
    }
}

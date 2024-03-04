using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour
{
   
    Animator anim;
    GameObject cutscenetrigger;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        GameObject cut = GameObject.FindWithTag("trigger");
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))   
     {
        anim.SetTrigger("Next Text");
     }
    
    }

    
}

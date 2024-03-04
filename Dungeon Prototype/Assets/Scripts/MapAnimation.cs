using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAnimation : MonoBehaviour
{
    
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    if (Input.GetKeyDown("tab")){
    anim.SetTrigger("Button Press");
    
    }
    }

    public void mapPlay() {

    anim.SetTrigger("Button Press");

    }

        
}

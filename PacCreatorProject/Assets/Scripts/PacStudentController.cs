using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string lastInput;
    private Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            
        }
        
         if (Input.GetKeyDown("a"))
        {
            
        }

         if (Input.GetKeyDown("s"))
        {
            
        }

         if (Input.GetKeyDown("d"))
        {
            
        }


    }
}

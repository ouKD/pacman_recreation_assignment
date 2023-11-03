using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    string lastInput;
    private Tweener tweener;
    public Animator pacMovement;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")){
            pacMovement.SetTrigger("UpParam");

        }
        
         if (Input.GetKeyDown("a")){
            pacMovement.SetTrigger("LeftParam");
            
        }

         if (Input.GetKeyDown("s")){
            pacMovement.SetTrigger("DownParam");
        }

         if (Input.GetKeyDown("d")){
            pacMovement.SetTrigger("RightParam");
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotDelay : MonoBehaviour
{

     public GameObject panal;
   

     public float sec = 1f;
     void Start()
     {
        //  if (panal.activeInHierarchy)
        //      panal.SetActive(false);
 
        //  StartCoroutine(LateCall());
     }

    
     IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(sec);
 
         panal.SetActive(true);

         //Do Function here...
         
  
     }

     public void show()
         {

             Start();
             if (panal.activeInHierarchy)
             panal.SetActive(false);
 
             StartCoroutine(LateCall());


         }

   
}

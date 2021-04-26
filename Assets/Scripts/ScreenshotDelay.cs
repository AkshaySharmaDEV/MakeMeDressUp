using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotDelay : MonoBehaviour
{

     public GameObject panal;
     public GameObject ButtonPanal;
   

     public float sec = 1f;
     

    
     IEnumerator LateCall()
     {
 
         yield return new WaitForSeconds(sec);
 
         panal.SetActive(true);

         //Do Function here...
         
  
     }

     IEnumerator Makeitvisible()
     {
 
         yield return new WaitForSeconds(sec);
 
         ButtonPanal.SetActive(true);

         //Do Function here...
         
  
     }

     public void show()
     {

         
         if (panal.activeInHierarchy)
         {

             panal.SetActive(false);

         }
         

         StartCoroutine(LateCall());


     }
     public void disablebuttons()
     {

         StartCoroutine(Makeitvisible());
         ButtonPanal.SetActive(false);

     }



   
}

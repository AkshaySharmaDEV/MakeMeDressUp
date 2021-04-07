using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{

    public GameObject Object;
    public GameObject Object1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhenButtonClicked()
    {

        if(Object.activeInHierarchy == false && Object1.activeInHierarchy == false)
        {
            Object.SetActive(true);
            Object1.SetActive(true);
        }
        else
        {
            Object.SetActive(false);
            Object1.SetActive(false);

        }

    }


}    
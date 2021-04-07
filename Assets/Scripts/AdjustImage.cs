using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustImage : MonoBehaviour
{
    private bool selected;

    void update()
    {
        if(selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);

        }

        if(Input.GetMouseButtonUp(0))
        {
            selected = false;

        }

    }

    void OnTouchOver(){
        if(Input.GetMouseButtonDown(0))
        {
            selected = true;

        }
    }
   
}

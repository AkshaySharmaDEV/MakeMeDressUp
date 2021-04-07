using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFace : MonoBehaviour
{

    public Image Original;
    public Sprite face1;
    public Sprite face2;
    public Sprite face3;
    public Sprite face4;
    public Sprite face5;
    public Sprite face6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhenFace1Pressed()
    {
        Original.sprite = face1;

    }

    public void WhenFace2Pressed()
    {
        Original.sprite = face2;

    }

    public void WhenFace3Pressed()
    {
        Original.sprite = face3;

    }

    public void WhenFace4Pressed()
    {
        Original.sprite = face4;

    }

    public void WhenFace5Pressed()
    {
        Original.sprite = face5;

    }

    public void WhenFace6Pressed()
    {
        Original.sprite = face6;

    }

}

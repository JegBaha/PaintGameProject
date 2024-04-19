using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class toolHandler : MonoBehaviour
{
    public toolHandler instence;


    [SerializeField] private GameObject panelThing;
    



    private void Start()
    {
        instence = this;
    }
    public void eraserHandler()
    {
        if(Pen.instance.eraser)
            Pen.instance.eraser = false;
        else
        {
        Pen.instance.eraser = true;
        Pen.instance.pen = false;
        Pen.instance.bucket = false;
            Pen.instance.stamp = false;
        }



    }
    public void lineHandler()
    {
        boolthing(false);
        panelThing.SetActive(true);


    }
    public void resumeButton()
    {
        panelThing.SetActive(false);
    }
    public void stopButton()
    {
        Application.Quit();
    }
    public void penHandler()
    {
        if(Pen.instance.pen)
            Pen.instance.pen = false;
        else
        {
            Pen.instance.pen = true;
            Pen.instance.eraser = false;
            Pen.instance.bucket = false;
            Pen.instance.stamp = false;
        }



    }
    public void stampHandler()
    {
        if (Pen.instance.stamp)
            Pen.instance.stamp = false;
        else
        {
            Pen.instance.pen = true;
            Pen.instance.bucket = false;
            Pen.instance.eraser = false;
            Pen.instance.stamp = true;
            Dot.instence.dotRender.color = Color.white;
        }
            


    }
    public void bucketHandler()
    {
        
        Pen.instance.bucket = true;


    }
    public void bucketBackGround()
    {
        Pen.instance.pen = false;
        Pen.instance.bucket = false;
        Pen.instance.eraser = false;
        Pen.instance.bucket = true;
        Pen.instance.stamp = false;
        if (Pen.instance.bucket)
            BackGround.instence.bucketThing();

    }
    private void boolthing(bool boo)
    {
        {
            Pen.instance.pen = boo;
            Pen.instance.bucket = boo;
            Pen.instance.eraser = boo;
            Pen.instance.bucket = boo;
            Pen.instance.stamp = boo;
        }
    }


  
}

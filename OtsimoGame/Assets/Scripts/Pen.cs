using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pen : MonoBehaviour
{

    public static Pen instance;



    
    //Vectors-Transform

    [SerializeField] public Transform baseDot;
    private Vector2 mousePos;
    private Vector2 objPos;


    //Booleans
    [SerializeField] public bool eraser;
    [SerializeField] public bool bucket;
    [SerializeField] public bool stamp;
    [SerializeField] public bool pen;
    private void Start()
    {

        //penLine.positionCount = 1;
        instance = this;
    }

    private void Update()
    {

        penDraw();
        Debug.Log(Input.touchCount);
        
    }
 
    void penDraw()
    {

        mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);// Mouse koordinatlarý.
        objPos = Camera.main.ScreenToWorldPoint(mousePos);//ScreenToWorldPoint yardýmýyla Unity objeleri ile mouse koordinatlarýný senkronize etme.

        if (Input.GetMouseButton(0) ) 
        {
            if (!eraser && pen && !stamp)
            {
               
                Instantiate(baseDot, objPos, baseDot.rotation);
                
            }
        }
        if (Input.GetMouseButtonDown(0) )
        {
            if (!eraser && stamp)
            {

                Instantiate(baseDot, objPos, baseDot.rotation);

            }
        }

    }
    
}
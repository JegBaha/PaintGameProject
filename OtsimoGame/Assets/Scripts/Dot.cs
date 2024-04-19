using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public static Dot instence;
    private bool stamThing;
    [SerializeField]public SpriteRenderer dotRender;



    private void Start()
    {
        instence = this;
        stamThing = Pen.instance.stamp;
        dotRender=GetComponent<SpriteRenderer>();
        

    }
    private void Update()
    {
        Dot.instence.dotRender.color = ColorPicker.instence.color;
    }
    private void OnMouseOver()
    {
        
        if(Input.GetMouseButton(0)&&!stamThing)
            if(Pen.instance.eraser)
                Destroy(gameObject);
    }
 



}
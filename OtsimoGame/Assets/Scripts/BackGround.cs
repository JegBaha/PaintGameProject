using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    public static BackGround instence;
    [SerializeField] SpriteRenderer sprite;
    private void Start()
    {
        instence = this;
        
    }

    public void bucketThing()
    {
        sprite.color = ColorPicker.instence.color;
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage _img;

    //These floats controller the speed of the backgrounds movement. 
    [SerializeField] private float _x, _y;

    void Update()
    {
        //This will move the image(WHICH MUST BE RAW IMAGE) to move the BG.
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    public Bullet Bullet;
    public SpriteRenderer circleUnderPlayer; 

    private Color[] colors = { Color.red, Color.yellow, Color.blue };
    private int currentColorIndex = 0;

    void Start()
    {
        UpdateCircleColor();
    }

    void OnMouseOver()
    {
  
        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
        }
    }
    string[] color;
    void ChangeColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        UpdateCircleColor();
        /*color[currentColorIndex].*/
    }

    void UpdateCircleColor()    
    {

        if (circleUnderPlayer != null)
        {
            circleUnderPlayer.color = colors[currentColorIndex];
        }
    }
}

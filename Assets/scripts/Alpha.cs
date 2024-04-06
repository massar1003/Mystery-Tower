using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alpha : MonoBehaviour
{
    public Text text;
    private int count = 0;
    private float alpha = 0.9f;

    void Start()
    {
        Application.targetFrameRate = 30;   //フレームレートを30で固定
    }

    void Update()
    {
        if (count <= 60)
        {
            alpha -= 0.01f;
            text.color = new Color(214, 214, 214, alpha);
        }
        else if(count <= 120)
        {
            alpha += 0.01f;
            text.color = new Color(214, 214, 214, alpha); 
        }
        else
        {
            count = 0;
        }
        count += 1;
    }
}

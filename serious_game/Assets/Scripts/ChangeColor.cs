using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material myMaterial;
    
    private void Awake()
    {
        Time.fixedDeltaTime = 5f;
    }

    private void FixedUpdate()
    {
        myMaterial.color = Random.ColorHSV();
    }
}

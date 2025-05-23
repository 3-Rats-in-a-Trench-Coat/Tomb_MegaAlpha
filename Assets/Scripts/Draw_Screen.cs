using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_Screen : MonoBehaviour
{
    
    public RenderTexture renderTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest) {
        Graphics.Blit(renderTarget, (RenderTexture)null);
    }
}

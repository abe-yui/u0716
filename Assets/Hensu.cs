using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hensu : MonoBehaviour
{
    int a = 10;

    // Start is called before the first frame update
    public void Proc()
    {
        
        float fw =  3.14f;
        string str = "こんにちは";
        bool bl = true;

        Debug.Log(a+a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Proc2()
    {
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

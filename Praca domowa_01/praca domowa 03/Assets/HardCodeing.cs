using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCodeing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        float b = 15;

        bool c = false, d = true;

        string e = "Programuje w C#", f = "EPG";

        Zad04(a, b, c, d, e, f);

        Zad05(a, b);

        Zad06(e, f);

        Zad07(c, d);

      
    }
    public void Zad04(int a, float b, bool c, bool d, string e, string f ){
        Debug.Log("a: " + a + " b: " + b + " c: " + c +" d: " + d + "e: " + e + " f: " + f);
        }
   public void Zad05(int a, float b)
    {
        if (a == b)
            Debug.Log("tak");
        else Debug.Log("nie");

        if (a != b)
            Debug.Log("tak");
        else Debug.Log("nie");

        if (a > b)
            Debug.Log("tak");
        else Debug.Log("nie");

        if (a >= b)
            Debug.Log("tak");
        else Debug.Log("nie");

        if (a < b)
            Debug.Log("tak");
        else Debug.Log("nie");

        if (a <= b)
            Debug.Log("tak");
        else Debug.Log("nie");

    }

    public void Zad06(string e, string f)
    {
        if (!e.Equals(f))
            Debug.Log("różne");

    }

    public void Zad07(bool c, bool d)
    {
        Debug.Log("c && d: " + (c && d));
        Debug.Log("c || d: " + (c || d));

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

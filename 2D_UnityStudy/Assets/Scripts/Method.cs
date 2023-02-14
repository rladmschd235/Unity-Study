using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void Start()
    {
        SayHello();
        CallName("Tom");

        int answer = Add(2, 3);
        Debug.Log(answer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //배열 사용하기
        int[] arr = new int[5];

        arr[0] = 2;
        arr[1] = 10;
        arr[2] = 5;
        arr[3] = 15;
        arr[4] = 3;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(arr[i]);
        }

        int[] points = { 83, 99, 52, 93, 15 };

        for(int i = 0; i < points.Length; i++)
        {
            if(points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;
        
        for(int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        int average = sum / points.Length;
        Debug.Log(average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

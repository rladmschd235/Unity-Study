using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStatement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if 문으로 조건 분기하기
        int berbnum = 1;
        if(berbnum == 1)
        {
            Debug.Log("체력을 50회복");
        }

        //if ~ else문으로 조건 분기하기
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("공격!");
        }
        else
        {
            Debug.Log("방어!");
        }

        //if 문 추가하기
        hp = 180;
        if (hp <= 50)
        {
            Debug.Log("도망!");
        }
        else if(hp >= 200)
        {
            Debug.Log("공격!");
        }
        else
        {
            Debug.Log("방어!");
        }

        //for 문으로 반복하기
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for(int i =0; i < 10; i += 2)
        {
            Debug.Log(i);
        }

        for(int i = 3; i <= 5; i++)
        {
            Debug.Log(i);
        }

        for(int i = 3; i >= 0; i--)
        {
            Debug.Log(i);
        }

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

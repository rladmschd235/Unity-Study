using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStatement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if ������ ���� �б��ϱ�
        int berbnum = 1;
        if(berbnum == 1)
        {
            Debug.Log("ü���� 50ȸ��");
        }

        //if ~ else������ ���� �б��ϱ�
        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("����!");
        }
        else
        {
            Debug.Log("���!");
        }

        //if �� �߰��ϱ�
        hp = 180;
        if (hp <= 50)
        {
            Debug.Log("����!");
        }
        else if(hp >= 200)
        {
            Debug.Log("����!");
        }
        else
        {
            Debug.Log("���!");
        }

        //for ������ �ݺ��ϱ�
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

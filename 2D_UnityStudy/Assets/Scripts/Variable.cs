using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� �����ϱ�
        int age;
        age = 30;
        Debug.Log(age);

        //���� �ʱ�ȭ�� ����
        float height1 = 160.5f; // ������ �ʱ�ȭ: �������� �̸� ������ = ������ ��;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        //������ ���ڿ� ����
        string name;
        name = "Sara"; // ������ ���ڿ��� �����ϴ� ���: ������ = "������ ���ڿ�";
        Debug.Log(name);

        //������ ����
        int answer;
        answer = 1 + 2; // ������ ��� ����� �����ϴ� ���: ������ = ���� + ����;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        //������ ������ ����
        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        //���� �� �����ϰ� �ø���
        answer = 10;
        answer += 5;
        Debug.Log(answer);

        //���� �� 1�� ���� �� ����
        answer = 10;
        answer++;
        Debug.Log(answer);

        answer = 10;
        answer--;
        Debug.Log(answer);

        //���ڿ��� ���ڿ��� ����
        string str1 = "happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        //���ڿ��� ������ ����
        string str = "happy ";
        int num = 123;

        message = str + num;
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

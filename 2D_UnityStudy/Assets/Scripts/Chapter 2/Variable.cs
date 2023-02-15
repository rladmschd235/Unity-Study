using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 변수 선언하기
        int age;
        age = 30;
        Debug.Log(age);

        //변수 초기화와 대입
        float height1 = 160.5f; // 변수의 초기화: 데이터형 이름 변수명 = 대입할 값;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        //변수에 문자열 대입
        string name;
        name = "Sara"; // 변수에 문자열을 대입하는 방법: 변수명 = "대입할 문자열";
        Debug.Log(name);

        //변수와 연산
        int answer;
        answer = 1 + 2; // 변수에 계산 결과를 대입하는 방법: 변수명 = 숫자 + 숫자;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        //변수와 변수의 연산
        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        //변수 값 일정하게 늘리기
        answer = 10;
        answer += 5;
        Debug.Log(answer);

        //변수 값 1씩 증가 및 감소
        answer = 10;
        answer++;
        Debug.Log(answer);

        answer = 10;
        answer--;
        Debug.Log(answer);

        //문자열과 문자열의 연결
        string str1 = "happy ";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        //문자열과 숫자의 연결
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

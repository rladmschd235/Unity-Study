using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���������� ���̸� ���Ѵ�. (�߰�)
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipLength = endPos.x - startPos.x;

            // �������� ���̸� ó�� �ӵ��� �����Ѵ�.
            this.speed = swipLength / 500.0f;

            // ȿ������ ����Ѵ�
            GetComponent<AudioSource>().Play();
        }

        // �̵�
        transform.Translate(this.speed, 0, 0);
        // ����
        this.speed *= 0.98f;
    }
}

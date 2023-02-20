using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float mawWalkSpeed = 2.0f;
    float threshold = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // �����Ѵ�
        if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // �¿� �̵�
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < this.threshold) key = -1;

        // �÷��̾��� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // ���ǵ� ����
        if(speedx < this.mawWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // �����̴� ���⿡ ���� �����Ѵ�
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // �÷��̾��� �ӵ��� ���缭 �ִϸ��̼� �ӵ��� �ٲ۴�
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        // �÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴�
        this.animator.speed = speedx / 2.0f;

        // �÷��̾ ȭ�� ������ �����ٸ� ó������
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("Chapter 6(1)");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("��");
        SceneManager.LoadScene("Chapter 6(2)");
    }
}

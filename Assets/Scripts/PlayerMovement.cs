using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // ������
    [SerializeField] float moveX;
    [SerializeField] float moveZ;

    // ������ �ٵ�
    private Rigidbody playerRb;

    // ������ ����
    private Vector3 moveDirection;

    // ������ �ӵ�
    private float moveSpeed;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        moveSpeed = 5;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");

        moveDirection = transform.TransformDirection(new Vector3(moveX, 0, moveZ) + new Vector3(0, playerRb.velocity.y, 0));

        playerRb.velocity = moveDirection * moveSpeed;
    }
}

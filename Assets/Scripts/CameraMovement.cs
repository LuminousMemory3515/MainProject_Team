using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTr;

    // ���콺 �Է� (�� ����)
    private float mouseX;
    private float mouseY;

    private void Start()
    {
        playerTr = GetComponentInParent<Transform>();
    }

    private void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse Y");
        mouseY = Input.GetAxisRaw("Mouse X");
    }

    private void FixedUpdate()
    {
        Rotation();
    }     

    // ȸ��
    private void Rotation()
    {
        transform.Rotate(0, mouseY, 0);
        playerTr.Rotate(mouseX, 0, 0);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMovement : MonoBehaviour
{
    static float moveSpeed = 1.0f;
    static float rotateSpeed = 10.0f;

    private Camera camera;
    private bool isMove;
    private Vector3 destination;

    //public LayerMask layermask;

    private void Awake()
    {
        camera = Camera.main;
        //layermask = 7;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                SetDestination(hit.point);
            }
        }
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
    }


    private void Move()
    {
        if (isMove)
        {
            if (Vector3.Distance(destination, transform.position) <= 0.1f)
            {
                isMove = false;
                return;
            }
            var dir = destination - transform.position;
            transform.position += dir.normalized * Time.deltaTime * 5f;
            dir.y = 0;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }
    }

    // 출처: https://wergia.tistory.com/228 [베르의 프로그래밍 노트]
    // 이동 시 카메라 떨림 현상 있음. 물리 연산을 Update가 아닌 FixedUpdate에서 하도록 변경하였음
}

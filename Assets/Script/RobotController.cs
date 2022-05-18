using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robot;
    Animator animator;
    float walkSpeed = 10.0f;
    float maxSpeed = 6.0f;
    public float jumpPower = 5.0f;
    bool isjumping = false;
    // Start is called before the first frame update
    void Start()
    {
        robot = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.speed = 0f;
    }

    void Jump(){
        if(Input.GetKey(KeyCode.Space) == true){

            if(isjumping == false){
                animator.SetTrigger("JumpCall");
                robot.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                isjumping = true;
            }
            else{
                return;
            }

        }
    }


    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }

    public void Move(){
         float speedx = Mathf.Abs(robot.velocity.x);

        if(speedx < maxSpeed){

        if(Input.GetKey(KeyCode.LeftArrow) == true){
            robot.AddForce(transform.right * -1 * walkSpeed);
             transform.localScale = new Vector3(-1.0f, 1.0f, 1);
            }
        if(Input.GetKey(KeyCode.RightArrow) == true){
            robot.AddForce(transform.right * walkSpeed);
            transform.localScale = new Vector3(1.0f, 1.0f, 1);
            }
        }

        animator.speed = speedx;
    }
    private void OnCollisionEnter2D(Collision2D Col){
        if(Col.gameObject.CompareTag("GROUND")){
            isjumping = false;
            animator.SetTrigger("WalkCall");
        }
    }
}

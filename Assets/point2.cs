using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point2 : MonoBehaviour
{      public float speed;
    public Animator animator;
private int dash;
    public GameObject pointt1,pointt2;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void stopdash()
        {
animator.SetBool("dash",false);
Debug.Log("test");
        }
    // Update is called once per frame
    void Update()
    {
      jump();
        
    }
            void OnCollisionEnter2D(Collision2D col){
                  animator.SetBool("touch",true);
                  dash=1;

Vector3 dir = (pointt1.transform.position - pointt2.transform.position).normalized;
               
        rb.velocity=dir*speed;



            }
            void OnCollisionExit2D(Collision2D other)
    {
      

        Debug.Log("exited");
                          animator.SetBool("touch",false);

    }
    public void jump()
    {
      if (Input.GetKeyDown("space")&&dash>0){
        Debug.Log("space pressed");
        dash=dash-1;

                          animator.SetBool("dash",true);
          Invoke("stopdash", 0.5f);

        Vector3 dir = (pointt1.transform.position - pointt2.transform.position).normalized;
               
        rb.velocity=dir*speed*1.5f;
      }
    }
}


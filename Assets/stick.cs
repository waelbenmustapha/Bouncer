using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
        public Animator animator;
public void stopdash()
        {
animator.SetBool("dash",false);
Debug.Log("test");
        }
 Vector3 lastvel;
 public GameObject txt,point1,point2;
    public Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
   
    void awake()
    
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    { 



        if(Input.GetAxis("Horizontal")==0){ rigidBody2D.constraints = RigidbodyConstraints2D.FreezeRotation;}
        else{
                float x = -Input.GetAxis ("Horizontal")*1.25f;

                rigidBody2D.rotation += x;
                }
                

    }
    
        void OnCollisionEnter2D(Collision2D col)
        {


 if(col.gameObject.tag=="house")
 {
Destroy(this.gameObject);
txt.SetActive(true);
 }
          

        }
     

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point1 : MonoBehaviour
{
    public Animator animator;
    	[Range(0, .3f)] [SerializeField] public float m_MovementSmoothing = .01f;	// How much to smooth out the movement
	private Vector3 m_Velocity = Vector3.zero;

      public GameObject player,pointt1,pointt2;
      public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col){
Debug.Log("touched");
player.transform.localScale = new Vector3(
          player.transform.localScale.x , 
          player.transform.localScale.y*(-1), 
          player.transform.localScale.z);
                  animator.SetBool("touch",true);

Vector3 dir = (pointt2.transform.position - pointt1.transform.position).normalized;
                                   //rb.velocity=dir*speed;
                                   Debug.Log("this is 1");
        rb.velocity=dir*speed;

        


        }
    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("exited");
                          animator.SetBool("touch",false);

    }
}

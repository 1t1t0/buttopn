using UnityEngine;
 
public class Move : MonoBehaviour
{

    private float speed = 0.2f;
    
    void Update()
    {
      Operation();
      
    }
 
    void Operation()
      
    {
      Vector3 tmp = GameObject.Find("Sphere").transform.position;
      if (Input.GetKey (KeyCode.UpArrow) ) 
          transform.position += transform.up * speed * Time.deltaTime;
 
      if (Input.GetKey (KeyCode.DownArrow)) 
          transform.position -= transform.up * speed * Time.deltaTime;

      if(Input.GetKey(KeyCode.RightArrow))
        transform.position += speed * transform.right * Time.deltaTime;

      if(Input.GetKey(KeyCode.LeftArrow))
        transform.position -= speed * transform.right * Time.deltaTime;

      if(Input.GetKey(KeyCode.W))
        transform.position += speed * transform.forward * Time.deltaTime;

      if(Input.GetKey(KeyCode.S))
        transform.position -= speed * transform.forward * Time.deltaTime;

    }
}

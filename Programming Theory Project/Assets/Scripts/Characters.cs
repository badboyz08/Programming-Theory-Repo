using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    //behave
    private Vector3 outOfBound = new Vector3(40f,0f,25f);


    public float walkSpeed { get; private set; } = 10; // ENCAPSULATION



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Walk(); // ABSTRACTION
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1);
    }

    void Jump()
    {
        transform.Translate(Vector3.up * 2 * Time.deltaTime);
    }


    public virtual void OutOfBound(Vector3 bound)// POLYMORPHISM
    {
        
        if (bound.x < -outOfBound.x)
        {
            Debug.Log("out of bound" + bound);
            transform.Rotate(0f, 45f, 0f);
            Jump();
        }
        else if (bound.z < -outOfBound.z)
        {
            Debug.Log("out of bound" + bound);
            transform.Rotate(0f, 45f, 0f);
            Jump();
        }
        else if (bound.x > outOfBound.x)
        {
            Debug.Log("out of bound" + bound);
            transform.Rotate(0f, 45f, 0f);
            Jump();
        }
        else if (bound.z > outOfBound.z)
        {
            Debug.Log("out of bound" + bound);
            transform.Rotate(0f, 45f, 0f);
            Jump();
        }
        
    }

    public virtual void OutOfBound(Collider collider)// POLYMORPHISM
    {
        
        if (collider.CompareTag("Wall"))
        {
            Debug.Log("HIT WALL");
            transform.Rotate(0f, Random.Range(135, 180), 0f);
        }
        
    }

    public void Walk()
    {
        transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        OutOfBound(transform.position);
    }

    

    void DoStuff()
    {
        

    }

    void EvadeHit()
    {

    }

}

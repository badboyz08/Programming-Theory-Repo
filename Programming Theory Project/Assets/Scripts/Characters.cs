using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    //behave
    private bool toDo;
    private string doWhat;

    private float walkSpeed = 3;
    private int randomNegative=2;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            StartCoroutine(WaitThenDo());
    }

    IEnumerator WaitThenDo()
    {
        yield return new WaitForSeconds(2);
        
    }

    int CreateRandomNegative()
    {
        
        if(randomNegative == 2)
        {
            randomNegative = -2;
        }else if(randomNegative == -2)
        {
            randomNegative = 2;
        }
        return randomNegative;
    }

    void RotateSelf()
    {
        transform.Rotate(0f, Random.Range(90f,180f) * Time.deltaTime * CreateRandomNegative(), 0f);
    }

    void Walk()
    {
        transform.Translate(0, 0, walkSpeed * Time.deltaTime);
    }

    void DoStuff()
    {

    }

    void EvadeHit()
    {

    }
}

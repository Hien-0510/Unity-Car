using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{

    public string Key_1,Key_2,Key_3,Key_4;

    void Update()
    {
        if(Input.GetKeyDown(Key_1))
        {
            transform.Translate(0, 0.1f, 0);
        }
    }
}

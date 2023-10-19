using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject P_1,P_2;
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject == P_1){
            print ("Player 1 Win");
        }
        else if (collision.gameObject == P_2){
            print ("Player 2 Win");
        }
        P_1.GetComponent<MoveByKey>().enabled = false;
        P_2.GetComponent<MoveByKey>().enabled = false;
    }
}

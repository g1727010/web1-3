using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += 1;
        }

        Debug.Log(sum);
    }
}
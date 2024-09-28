using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxInt = int.MaxValue;
        Debug.Log("Max int: " + maxInt);

        float maxFloat = float.MaxValue;
        Debug.Log("Max float: " + maxFloat);

        double maxDouble = double.MaxValue;
        Debug.Log("Max double: " + maxDouble);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

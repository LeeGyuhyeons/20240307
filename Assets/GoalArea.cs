using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public static bool goal;
    void Start()
    {
        goal = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal = true;
            Debug.Log("Gooaaaallll!@!@!@!@");
        }
    }
}

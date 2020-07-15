using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartAnimation();
    }

   void StartAnimation()
    {
        this.gameObject.GetComponent<Animator>().SetBool("Roll", true);
    }
}

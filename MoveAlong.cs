using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlong : MonoBehaviour
{
    CountItHigger cih;

    private void Start()
    {
       cih = this.gameObject.GetComponent<CountItHigger>();
    }
    void LateUpdate()
    {
        if (cih != null )
        {
            float tX = cih.currentNum / 10f;
            Vector3 tempLoc = pos;
            tempLoc.x = tX;
            pos = tempLoc;
        }
    }

    public Vector3 pos 
    {
        get { return (this.transform.position); }
        set { this.transform.position = value; }
    }
}

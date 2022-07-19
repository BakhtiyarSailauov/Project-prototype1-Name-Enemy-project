using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float fireRate = 0.3f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move() 
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject other = coll.gameObject;
        switch(other.tag)
        {
            case "Hero":
                //no value.But, to be contined
                break;
            case "Here Loses":
                //killer it's hero
                Destroy(this.gameObject);
                break;
        }
    }

    //Ёто свойства(функци€ определ€юща€ как поле)
    public Vector3 pos 
    {
        get { return (this.transform.position); }
        set { this.transform.position = value; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public float distance2;
    public GameObject bombPrefabs;
    public Transform castPoint;

    
    // Update is called once per frame
    void Update()
    {
        if (CanSeeTK(distance2)) {
            Debug.Log("Terumbu karang!");
            Shoot();
        }
    }

    void Shoot () {
        //shooting logic
        Instantiate(bombPrefabs, castPoint.position, castPoint.rotation);
    }

    bool CanSeeTK(float distance2) {
        bool val = false;
        float casDist = distance2;

        Vector2 endPos = castPoint.position + Vector3.down * distance2; 
        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endPos, 1 << LayerMask.NameToLayer("Action"));
        
        if(hit.collider !=null) {
            if(hit.collider.gameObject.CompareTag("TerumbuKarang")) {
                val = true;
            }
            else {
                val = false;
            }
        }
        return val;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemcollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("diamond"))
        {
            Destroy(collision.gameObject);
            Scoremanager.instance.AddPoints();
 
        }
    }
}

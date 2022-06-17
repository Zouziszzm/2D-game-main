using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{

    private int diamonds = 0;

    [SerializeField] private Text diamondsy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {

            Destroy(collision.gameObject);
            diamonds++;
            diamondsy.text = "score:" + diamonds;
        }
    }
}

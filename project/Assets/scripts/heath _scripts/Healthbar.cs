using UnityEngine.UI;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthbar;
    [SerializeField] private Image currenthealthbar;


    private void Start()
    {
        totalhealthbar.fillAmount = playerHealth.currentHelath / 3;
    }
    private void Update()
    {
        currenthealthbar.fillAmount = playerHealth.currentHelath / 3;
    }

}

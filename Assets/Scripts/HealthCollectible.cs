using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int healhp;
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (other.tag == "Player")
        {
            if (controller.hp < controller.maxhp)
            {
                controller.hpChange(healhp);
                Destroy(gameObject);
            }
        }
    }
}

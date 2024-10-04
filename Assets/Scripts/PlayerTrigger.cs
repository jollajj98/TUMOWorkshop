using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TriggerArea area = other.GetComponent<TriggerArea>();
        if (area != null)
        {
            area.Trigger();
        }
    }
}

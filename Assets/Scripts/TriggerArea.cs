using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerArea : MonoBehaviour
{

    [SerializeField]
    GameObject[] objectsToActivate;
    [SerializeField]
    GameObject[] objectsToDeactivate;
    [SerializeField]
    AudioSource soundToPlay;
    public void Trigger()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }

        }

        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }

        }
            if (soundToPlay != null)
            {
                soundToPlay.Play();
            }


    }
}

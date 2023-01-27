using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButonInteractable : MonoBehaviour
{
    [SerializeField]
    private float _minPushDistance;

    [SerializeField]
    private float _maxPushDistance;

    public UnityEvent onPushed;

    Vector3 localPosition;

   public bool wasPushed;

    void Update()
    {
        localPosition = transform.localPosition;
        localPosition.x = 0;
        localPosition.z = 0;
        localPosition.y = Mathf.Clamp(localPosition.y, _minPushDistance, _maxPushDistance);

        transform.localPosition = localPosition;

        if (!wasPushed && localPosition.y > _maxPushDistance * .8) 
        {
         
            wasPushed = true;
            onPushed?.Invoke();
        }

        if (wasPushed && localPosition.y < _maxPushDistance * .6) 
        {
            wasPushed = false;
        }
    }
}

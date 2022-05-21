using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveBox : MonoBehaviour
{
    [SerializeField]
    private InteractiveBox next;
    [SerializeField]
    private bool debug;

    public void AddNext(InteractiveBox box)
    {
        if (box != null)
        {
            next = box;
            next.GetComponent<ObstacleItem>()?.onDestroyObstacle.AddListener(() => next = null);
        }
    }

    private void FixedUpdate()
    {
        if (next != null && Physics.Linecast(transform.position, next.transform.position, out RaycastHit hit))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);

            if (hit.collider.TryGetComponent<ObstacleItem>(out ObstacleItem temp))
            {
               temp.GetDamage(Time.deltaTime);
            }
        }
    }
}
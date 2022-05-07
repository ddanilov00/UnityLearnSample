using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage_True : MonoBehaviour
{
    [SerializeField]
    private List<SampleScript> script_list;

    // Start is called before the first frame update
    [ContextMenu("Start")]
    public void scripts_start()
    {
        for (int i = 0; i < script_list.Count; i++)
        {
            script_list[i].Use();
        }
    }

}

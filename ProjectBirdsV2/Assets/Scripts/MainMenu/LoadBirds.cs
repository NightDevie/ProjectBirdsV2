using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBirds : MonoBehaviour
{
    private static readonly BirdsInventory bI;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < bI.items.Count; i++)
        {
            if (bI.items[i].owned == true)
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

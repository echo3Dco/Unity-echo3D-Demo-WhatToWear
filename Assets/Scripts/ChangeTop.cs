using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script swaps through the tops available in the array
public class ChangeTop : MonoBehaviour
{
    public GameObject[] tops;
    public int currentTop;

    void Update()
    {
        // Calling NextTop method on space bar input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextTop();
        }
    }

    public void NextTop()
    {
        // Make each object in the array inactive
        foreach (GameObject top in tops)
        {
            top.SetActive(false);
        }

        // Choose 1 random top from the array to make active
        int i = Random.Range(0, tops.Length);
        tops[i].SetActive(true);
        print("Nice top!");
    }
}

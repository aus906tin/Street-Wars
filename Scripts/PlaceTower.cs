using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{

    public GameObject towerPrefab;
    private GameObject tower;

    private bool CanPlaceTower()
    {
        return tower == null;
    }
    void OnMouseUp()
    {
        //2
        if (CanPlaceTower())
        {
            //3
            tower = (GameObject)
              Instantiate(towerPrefab, transform.position, Quaternion.identity);
            // TODO: Deduct gold
        }
    }
}

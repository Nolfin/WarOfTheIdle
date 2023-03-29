using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeUnitLogic : MonoBehaviour
{
    private bool unitTrained = false;
    
    public GameObject unit;
    public GameObject spawnPoint;

    private GameObject obj;

    
    private void Start(){
    }
    //train or upgrade a unit
    public void UpgradeButtonClicked(){
        if(unitTrained){
            obj.GetComponent<UnitSpawn>().healthPoints += obj.GetComponent<UnitSpawn>().healthPoints/obj.GetComponent<UnitSpawn>().lvl;
            obj.GetComponent<UnitSpawn>().attack += obj.GetComponent<UnitSpawn>().attack/obj.GetComponent<UnitSpawn>().lvl;
        }
        if(!unitTrained){
            unitTrained = true;
            obj = Instantiate(unit, spawnPoint.transform.position, transform.rotation);
            obj.GetComponent<UnitSpawn>().isModelForUnit = false;
        }
        obj.GetComponent<UnitSpawn>().lvl++;
    }
}



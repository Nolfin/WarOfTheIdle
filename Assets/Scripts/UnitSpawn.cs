using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitSpawn : MonoBehaviour
{
    public int healthPoints;
    public int currentHealthPoints;
    public int attack;
    public int defense;
    public int lvl;
    public float attackSpeed;
    public float criticalChance;
    public int criticalDamage;
    public int range;
    public bool isModelForUnit = true;

    protected int startingHealthPoints;

    private Vector3 startPosition;
    private Vector3 endPosition;
    private float duration = 5f;
    private float elapsedTime;
    private AnimationCurve curve;
    private bool TargetReached = false;
    void Start(){
        SetStartingStats();
        endPosition = GameObject.FindWithTag("Enemy").transform.position - new Vector3(range,0,Random.Range(-15.0f, 15.0f));
        startPosition = transform.position;
    }
    void Update(){
        if(!TargetReached && !isModelForUnit){
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / duration;
            if(percentageComplete >= 1) TargetReached = true;
            transform.position = Vector3.Lerp(startPosition, endPosition, Mathf.SmoothStep(0,1, percentageComplete));
        }
    }
    private void SetStartingStats(){
        startingHealthPoints = healthPoints;
    }
}
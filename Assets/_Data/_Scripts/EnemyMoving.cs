using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoving : EnemyAbstract
{
    [SerializeField] protected PathMoving path;
    [SerializeField] protected int currentPointIndex = 0;
    [SerializeField] protected Point currentPoint;
    [SerializeField] protected float pointDistance = Mathf.Infinity;
    [SerializeField] protected float pointDistanceLimit = 2f;
    [SerializeField] protected bool isFinish = false;

    public Transform targetToMove;
    //public NavMeshAgent agent;

    void FixedUpdate()
    {
        
        this.Moving();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPathMoving();
    }

    protected virtual void LoadPathMoving()
    {
        if (this.path != null) return;
        this.path = GameObject.Find("PathMoving").GetComponent<PathMoving>();
        Debug.Log(transform.name + ": LoadPathMoving", gameObject);
    }

    protected virtual void Moving()
    {
        if (this.isFinish)
        {
            this.ctrl.Agent.isStopped = true;
            return;
        }
        //PathMoving pathMoving = GameObject.Find("PathMoving").GetComponent<PathMoving>();
        //Point point = this.path.GetPoint(this.currentPoint.transform.position);

        //this.agent.SetDestination(this.targetToMove.position);

        this.GetNextPoint();
        this.ctrl.Agent.SetDestination(this.currentPoint.transform.position);
    }

    protected virtual void GetNextPoint()
    {
        this.currentPoint = this.path.GetPoint(this.currentPointIndex);
        this.pointDistance = Vector3.Distance(this.currentPoint.transform.position, transform.position);
        if (this.pointDistance < this.pointDistanceLimit) this.currentPointIndex++;
        if (this.currentPointIndex > this.path.Points.Count-1) this.isFinish = true;

    }

}

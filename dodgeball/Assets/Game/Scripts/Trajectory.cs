using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField]
    public LineRenderer _lineRenderer;

    [SerializeField]
    [Range(3,30)]
    private int _lineSegmentCount = 20;

    private List<Vector3> _linePoints = new List<Vector3>();

    #region Singleton

    public static Trajectory Instance;

    private void Awake()
    {
        Instance=this;
    }

    #endregion

    // private void Start() {
    //     transform.position = new Vector3(0, 0, 3);
    // }

    public void UpdateTrajectory(Vector3 forceVector, Rigidbody rigidBody, Vector3 startingPoint)
    {
        Vector3 velocity = (forceVector / rigidBody.mass)*Time.fixedDeltaTime; //F/mass = a/change in time = v
        float FlightDuration = (2*velocity.y) / Physics.gravity.y;
        float stepTime = FlightDuration / _lineSegmentCount;

        _linePoints.Clear();
        //_linePoints.Add(startingPoint);

        //building trajectory
        for(int i=0; i < _lineSegmentCount; i++)
        {
            float stepTimePassed = stepTime * i;

            Vector3 MovementVector = new Vector3(
                                                velocity.x * stepTimePassed,
                                                //using velocity, time, and acceleration to calculate change in distance, not needed now
                                                //velocity.y * stepTimePassed - 0.5f * Physics.gravity.y * stepTimePassed * stepTimePassed,
                                                0,
                                                velocity.z * stepTimePassed
                                            );
            Vector3 NewPointOnLine = -MovementVector + startingPoint;

            //Cutting off trajectory line at collisions/obstacles
            // RaycastHit hit;
            // if (Physics.Raycast(_linePoints[i-1], NewPointOnLine-_linePoints[i-1], out hit, (NewPointOnLine-_linePoints[i-1]).magnitude))
            // {
            //     _linePoints.Add(hit.point);
            //     break;
            // }
                            
            _linePoints.Add(NewPointOnLine);
        }

        _lineRenderer.positionCount = _linePoints.Count;
        _lineRenderer.SetPositions(_linePoints.ToArray());

    }

    public void HideLine()
    {
        _lineRenderer.positionCount = 0;
    }
}

//https://www.youtube.com/watch?v=9iwdAMXydgo&list=PLGXzgnKhu_mCTmg_AS66j8U7duSzcsub7&index=7
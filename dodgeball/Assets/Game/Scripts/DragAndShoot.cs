using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    private Rigidbody rb;
    private bool isShoot;

    public Transform Ball;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown ()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseDrag() 
    {
        Vector3 forceInit = (Input.mousePosition-mousePressDownPos);
        Vector3 forceV = (new Vector3(forceInit.x, forceInit.y, forceInit.y))*forceMultiplier;

        if(!isShoot)
            Trajectory.Instance.UpdateTrajectory(forceV, rb, Ball.position);


    }

    private void OnMouseUp ()
    {
        Trajectory.Instance.HideLine();
        mouseReleasePos = Input.mousePosition;
        Shoot(mousePressDownPos-mouseReleasePos);
    }

    [SerializeField]
    private float forceMultiplier = 3;

    void Shoot(Vector3 Force)
    {
        if(isShoot)
            return;

        rb.AddForce(new Vector3(Force.x, 0, Force.y) * forceMultiplier);
        isShoot = true;
        Spawner.Instance.NewSpawnRequest();
    }
}

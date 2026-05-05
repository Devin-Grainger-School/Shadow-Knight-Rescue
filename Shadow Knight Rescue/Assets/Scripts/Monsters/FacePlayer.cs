using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FacePlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 followOffset;
    public float followSpeed;
    public bool lookAtTarget;
    public float lookSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Shadow Knight").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.LookAt(target, Vector2.left);
        transform.position = Vector3.MoveTowards(transform.position, target.position + followOffset, followSpeed);
        if (lookAtTarget)
        {
            // get a rotation that points Z axis forward, and the Y axis towards the target
            Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, (target.position - transform.position));

            // rotate toward the target rotation, never rotating farther than "lookSpeed" in one frame.
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, lookSpeed);

            // rotate 90 degrees around the Z axis to point X axis instead of Y
            transform.Rotate(0, 0, 1);
        }

    }
}

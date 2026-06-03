using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Lane Targets")]
    public Transform leftLane;
    public Transform centerLane;
    public Transform rightLane;

    public void MoveToLane(int lane)
    {
        Vector3 pos = transform.position;

        switch (lane)
        {
            case 0:
                pos.x = leftLane.position.x;
                break;

            case 1:
                pos.x = centerLane.position.x;
                break;

            case 2:
                pos.x = rightLane.position.x;
                break;
        }

        transform.position = pos;
    }
}
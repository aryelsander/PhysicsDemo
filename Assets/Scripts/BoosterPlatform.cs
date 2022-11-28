using UnityEngine;

public class BoosterPlatform : MonoBehaviour
{
    public Interactable baseBooster;
    public BoostDirection direction;
    public float speed;

    private void OnEnable()
    {
        baseBooster.OnEnterColission += ApplyBoost;
    }

    private void ApplyBoost(GameObject obj)
    {
        switch (direction)
        {
            case BoostDirection.Left:
                Debug.Log("Speed");
                obj.GetComponent<Rigidbody>().AddForce(Vector3.left * speed, ForceMode.Impulse);
                break;
            case BoostDirection.Right:
                obj.GetComponent<Rigidbody>().AddForce(Vector3.right * speed,ForceMode.Impulse);
                break;
            case BoostDirection.Foward:
                obj.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
                break;
            case BoostDirection.Back:
                obj.GetComponent<Rigidbody>().AddForce(Vector3.back * speed, ForceMode.Impulse);
                break;
        }
    }

    private void OnDisable()
    {
        baseBooster.OnEnterColission -= ApplyBoost;
    }

    public enum BoostDirection
    {
        Foward,
        Right,
        Back,
        Left
    }
}

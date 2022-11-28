using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotatorSpeed;
    public bool invert;
    private void Rotate()
    {
        float rotate = (invert ? -rotatorSpeed : rotatorSpeed) * Time.deltaTime;
        transform.Rotate(new Vector3(0,rotate,0));
    }
    private void Update()
    {
        Rotate();
    }


}

using UnityEngine;
using UnityEngine.UIElements;

public class PropellerRotation : MonoBehaviour
{
    private float speed = 4f;
    public GameObject propeller;
    private Vector3 spin = new Vector3(0, 0, 360);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin, speed);
    }
}

using UnityEngine;

public class Bewegung : MonoBehaviour
{
    public float speed = 5f;
    public KeyCode moveright;
    public KeyCode moveleft;
    public Vector3 currentPosition;

    private void Start()
    {
        currentPosition = this.transform.position;
    }

    private void Update()
    {
        if (Input.GetKey(moveright))
        {

            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(moveleft))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

}

using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
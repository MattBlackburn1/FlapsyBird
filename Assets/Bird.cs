using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public GameManager logic;
    public bool birdIsAlive = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    
    private void OnCollisionEnter2D()
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}

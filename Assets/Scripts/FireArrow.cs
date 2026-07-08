using UnityEngine;

public class FireArrow : MonoBehaviour
{
    public float speed = 3f;
    bool arrowMove = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arrowMove)
        {
            Vector3 directionToMove = Vector3.zero;
            directionToMove.x -= 1f;
            transform.position += directionToMove * speed * Time.deltaTime;
            ResetArrow();
        }
    }

    public void MoveArrow()
    {
        arrowMove = true;
    }

    void ResetArrow()
    {
        if(transform.position.x <= -10f)
        {
            arrowMove = false;
            transform.position = new Vector3(10f, 0.4f, 0);
        }
    }
}

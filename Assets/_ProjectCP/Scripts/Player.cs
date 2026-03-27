using UnityEngine;


public class Player : MonoBehaviour
{

    [Header("Player Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float stepSpeed;
    [SerializeField] private float currentLaneX;
    [SerializeField] private float currentLaneY;
    [SerializeField] private float laneLimitX = 4;
    [SerializeField] private float laneLimitY = 4;


    [Header("Controller Settings")]
    [SerializeField] private Vector3 movement;
  
    


    private Vector3 currentPosition;
   
    private void Start()
    {
       
        currentPosition = transform.position;

    }


    private void Update()
    {
        currentPosition = new Vector3(currentLaneX, currentLaneY, currentPosition.z);
        transform.position = Vector3.MoveTowards(transform.position, currentPosition, stepSpeed * Time.deltaTime);

    }



    public void ChangeLaneX(int direction)
    {

        if (direction < 0)
        {
            if (currentLaneX > -laneLimitX)
            {
                currentLaneX += direction;
            }
        }
        else if (direction > 0)
        {
            if (currentLaneX < laneLimitX)
            {
                currentLaneX += direction;
            }
        }


    }


    public void ChangeLaneY(int direction)
    {

        if (direction < 0)
        {
            if (currentLaneY > -laneLimitY)
            {
                currentLaneY += direction;
            }
        }
        else if (direction > 0)
        {
            if (currentLaneY < laneLimitY)
            {
                currentLaneY += direction;
            }
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            FindAnyObjectByType<GameManager>().GameOver();
          
        }
    }












}

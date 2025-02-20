using UnityEngine;

public class FrameEvents : MonoBehaviour
{
    // **********************************
    // *  Sample Frame Events in Unity  *
    // **********************************

    // public GameObjects in Hierarchy
    public GameObject car;
    public GameObject pivot;
    // public GameObject collectiblePrefab;

    // public variables
    public int carSize;

    // local variable
    float carSpeed;

    // ** Awake happens before the scene starts **
    // Best to use to set properties for the whole app
    void Awake()
    {
        // Set Car Scales
        car.transform.localScale = new Vector3(carSize, carSize, carSize);
    }

    // ** Start happens on the the first frame render ** 
    // Best to use to set properties for a specific game object
    void Start()
    {
        // Set Car Velocity
        carSpeed = 0.5f;
        
        // Create random numbers
        // float randomX = Random.Range(-3f, 3f);
        // float randomZ = Random.Range(-3f, 3f);

        // Place Prefab in scene at random location
        // Vector3 randomPosition = new Vector3(randomX, car.transform.position.y, randomZ);

        // Make a clone of the prefab with position and rotation  
        // GameObject clone = Instantiate(collectiblePrefab, randomPosition, Quaternion.identity);

    }

    // ** Fixed Update is called once per set framerate **
    // For moving Objects at specific timing
    void FixedUpdate()
    {
        // animate pivot rotation to drive in circles
        // Use local EulerAngles to update angles of rotation 
        pivot.transform.localEulerAngles = new Vector3(pivot.transform.localEulerAngles.x, pivot.transform.localEulerAngles.y + carSpeed, pivot.transform.localEulerAngles.z);
    
    }

    // ** Update is called once per frame **
    // For Capturing UI Input or animations without set framerate
    void Update()
    {

    }

    // ** Late Update is called after all the objects have been rendered **
    // Use for updating status and properties after actions have already happened
    void LateUpdate()
    {
        
    }

}

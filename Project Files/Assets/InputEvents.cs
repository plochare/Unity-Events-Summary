using UnityEngine;

public class InputEvents : MonoBehaviour
{
    // **********************************
    // *  Sample Input Events in Unity  *
    // **********************************

    // public GameObjects in Hierarchy
    public GameObject car;
    public GameObject pivot;

    // public FrameEvents frameScript; // set public varible reference to another script

    // ** Awake happens before the scene starts **
    // Best to use to set properties for the whole app
    void Awake()
    {

    }

    // ** Start happens on the the first frame render ** 
    // Best to use to set properties for a specific game object
    void Start()
    {

    }

    // ** Fixed Update is called once per set framerate **
    // For moving Objects at specific timing
    void FixedUpdate()
    {
          
    }

    // ** Update is called once per frame **
    // For Capturing UI Input or animations without set framerate
    void Update()
    {
        // Get Keyboard Inputs
        if (Input.GetKey("up"))
        {
            car.transform.localPosition = new Vector3(0f, 1f, car.transform.localPosition.z);
        }

        if (Input.GetKey("down"))
        {
            car.transform.localPosition = new Vector3(0f, 0f, car.transform.localPosition.z);
        }

        // Get Mouse Inputs
        if (Input.GetMouseButtonDown(0))
        {
            /*
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Use the hit variable to determine what was clicked on.
                if (hit.collider.name == "car"){
                    frameScript.reverseDirection(); // Call public function in another script
                }
            }
            */
        }
        
    }

    // ** Late Update is called after all the objects have been rendered **
    // Use for updating status and properties after actions have already happened
    void LateUpdate()
    {
        
    }
}

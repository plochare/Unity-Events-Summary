using UnityEngine;
using UnityEngine.UI; // need to add to control UI Components
using TMPro;          // need to add to control Text Mesh Pro Components

public class UIEvents : MonoBehaviour
{
    // **********************************
    // *  Sample UI Events in Unity  *
    // **********************************

    // public GameObjects in Hierarchy
    public GameObject car;
    public GameObject pivot;

    public Slider radiusUI;
    public TMP_Dropdown materialUI;

    // ** Awake happens before the scene starts **
    // Best to use to set properties for the whole app
    void Awake()
    {

    }

    // ** Start happens on the the first frame render ** 
    // Best to use to set properties for a specific game object
    void Start()
    {
        radiusUI.value = 0.5f;
    }

    // ** Fixed Update is called once per set framerate **
    // For moving Objects at specific timing
    void FixedUpdate()
    {

    }

    // ** Update is called once per frame **
    // For Capturing Input or animations without set framerate
    void Update()
    {

    } 

    // Create Public functions to update scene when the UI values change
    public void UpdateRadius(){
        float sliderVal = radiusUI.value; // float value between 0.0 -> 1.0
        car.transform.localPosition = new Vector3(0f, 0f, 0.5f + sliderVal*6);
    }

    public void UpdateMaterial(){
        float materialVal = materialUI.value; // integer value 0 -> total list number
    }

    // ** Late Update is called after all the objects have been rendered **
    // Use for updating status and properties after actions have already happened
    void LateUpdate()
    {
        
    }

}

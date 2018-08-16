using UnityEngine;

public class HostTest : MonoBehaviour
{

    public TextMesh debuglog;
    public NetWorkCtrl netCtrl;
    Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        debuglog.text="StartingHost";
        netCtrl.StartHost();
        debuglog.text = "StartHost";
    } 
    
    // Called by SpeechManager when the user says the "Drop sphere" command
    void OnDrop()
    {
        // Just do the same logic as a Select gesture.
        OnSelect();
    }
}

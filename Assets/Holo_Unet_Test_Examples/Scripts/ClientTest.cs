//using UnityEngine;

//public class SphereCommands : MonoBehaviour
//{
//    // Called by GazeGestureManager when the user performs a Select gesture
//    void OnSelect()
//    {
//        // If the sphere has no Rigidbody component, add one to enable physics.
//        if (!this.GetComponent<Rigidbody>())
//        {
//            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
//            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
//        }
//    }
//}

using UnityEngine;

public class ClientTest : MonoBehaviour
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

    //private void OnMouseDown()
    //{

    //    debuglog.text = "点击选中……";
    //    netCtrl.StartClient();
    //    debuglog.text = "正在连接……";
    //}
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        debuglog.text = "点击选中……";
        netCtrl.StartClient();
        debuglog.text = "正在连接……";
    }

    // Called by SpeechManager when the user says the "Reset world" command
    void OnReset()
    {
        // If the sphere has a Rigidbody component, remove it to disable physics.
        var rigidbody = this.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            DestroyImmediate(rigidbody);
        }

        // Put the sphere back into its original local position.
        this.transform.localPosition = originalPosition;
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    void OnDrop()
    {
        // Just do the same logic as a Select gesture.
        OnSelect();
    }
}

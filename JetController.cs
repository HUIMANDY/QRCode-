using MRTKExtensions.QRCodes;
using UnityEngine;

public class JetController : MonoBehaviour
{

    public GameObject triggerObj;
    [SerializeField]
    private QRTrackerController trackerController;


    private void Start()
    {

        trackerController.PositionSet += PoseFound;
    }

    public void PoseFound(object sender, Pose pose)
    {
        triggerObj = GameObject.Find("triggerObj");
        triggerObj.SendMessage("getbuttomdown");//找到"triggerObj"後觸發/執行裡面的"getbuttomdown"函數
        /*  QRloading.go1.gameObject.transform.SetParent(GameObject.Find("JetHolder").transform);
          var childObj = transform.GetChild(0);
          childObj.SetPositionAndRotation(pose.position, pose.rotation);
          childObj.transform.Translate(-3.09f, -1.33f, -1.32f, Space.Self);
          childObj.transform.Rotate(90, 0, 0, Space.Self);

          //pose.position + new Vector3(-3.09f, -1.45f, -0.1f);
          //childObj.transform.Rotate(90, 0, 0);
        */
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotManager : MonoBehaviour
{
    private int screenshotCount = 0;
    public Button screenshotButton;
    private GameObject toDisable;

    // Start is called before the first frame update
    // Setup the button to take a screenshot when clicked
    void Start()
    {
        screenshotButton.onClick.AddListener(TakeScreenshot);
        toDisable = screenshotButton.gameObject.transform.parent.gameObject;
    }

    public void TakeScreenshot()
    {
        // Take a screenshot and save it to the folder
        toDisable.SetActive(false);
        ScreenCapture.CaptureScreenshot("AR_Screenshot" + screenshotCount + ".png");
        toDisable.SetActive(true);
        screenshotCount++;
    }
}

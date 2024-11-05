using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ImageTracker : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    void OnEnable()
    {
        trackedImageManager.trackedImagesChanged +=
        OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -=
        OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            Debug.Log("Image tracked: " +
            trackedImage.referenceImage.name);
            trackedImage.transform.localScale = Vector3.one * 2;
        }
    }
}
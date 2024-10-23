using UnityEngine;

[RequireComponent(typeof(Camera))]
public class EnableDepthTextureForiOS : MonoBehaviour
{
    private Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();
        EnableDepthTexture();
    }

    void EnableDepthTexture()
    {
        // Ensure the camera's depth texture is enabled
        if (camera)
        {
            // Check if running on iOS
#if UNITY_IOS
            camera.depthTextureMode = DepthTextureMode.Depth;
            Debug.Log("Depth texture enabled for " + camera.name + " on iOS.");
#else
            Debug.LogWarning("This script is intended for iOS only.");
#endif
        }
        else
        {
            Debug.LogError("No Camera component found on this GameObject.");
        }
    }
}
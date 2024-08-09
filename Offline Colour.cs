using UnityEngine;
using Photon.VR;

public class ColorFromPhotonVRManager : MonoBehaviour
{
    public Material targetMaterial;
    public PhotonVRManager photonVRManager;

    private void Start()
    {
        if (photonVRManager != null && targetMaterial != null)
        {
            ApplyColorFromPhotonVRManager();
        }
    }

    private void Update()
    {
        if (photonVRManager != null && targetMaterial != null)
        {
            ApplyColorFromPhotonVRManager();
        }
    }

    private void ApplyColorFromPhotonVRManager()
    {
        if (photonVRManager != null)
        {
            Color color = photonVRManager.Colour;
            targetMaterial.color = color;
        }
    }
}

using UnityEngine;
using GoogleMobileAds.Api;

public class AddManager : MonoBehaviour
{
    public static AddManager instance;
    public Institatial institatial;

    public int gamePlayed;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            
        }
        institatial = GetComponent<Institatial>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        MobileAds.Initialize((InitializationStatus initstatus) =>
        {
            if (initstatus == null)
            {
                Debug.LogError("Google Mobile Ads initialization failed.");
                return;
            }

            Debug.Log("Google Mobile Ads initialization complete.");
        });


    }

}

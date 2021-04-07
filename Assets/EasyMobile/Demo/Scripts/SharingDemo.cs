using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using EasyMobile;

namespace EasyMobile.Demo
{
    public class SharingDemo : MonoBehaviour
    {
        public Image clockRect;
        public Text clockText;

        // Screenshot names don't need to include the extension (e.g. ".png")
        string TwoStepScreenshotName = "EM_Screenshot";
        string OneStepScreenshotName = "EM_OneStepScreenshot";
        string TwoStepScreenshotPath;
        string sampleMessage = "Download Make me Dressup from Playstore!";
        string sampleText = "Hello from Akshay Sharma";
        string sampleURL = "https://www.linkedin.com/in/akshay-sharma-27252418b/";

        void OnEnable()
        {
            ColorChooser.colorSelected += ColorChooser_colorSelected;
        }

        void OnDisable()
        {
            ColorChooser.colorSelected -= ColorChooser_colorSelected;
        }

        void ColorChooser_colorSelected(Color obj)
        {
            clockRect.color = obj;
        }

        void Update()
        {
            clockText.text = System.DateTime.Now.ToString("hh:mm:ss");
        }

        public void ShareText()
        {
            Sharing.ShareText(sampleText);
        }

        public void ShareURL()
        {
            Sharing.ShareURL(sampleURL);
        }

        public void SaveScreenshot()
        {
            StartCoroutine(CRSaveScreenshot());
        }

        public void ShareScreenshot()
        {
            if (!string.IsNullOrEmpty(TwoStepScreenshotPath))
            {
                Sharing.ShareImage(TwoStepScreenshotPath, sampleMessage);
            }
            else
            {
                NativeUI.Alert("Alert", "Please save a screenshot first.");
            }
        }

        public void OneStepSharing()
        {
            StartCoroutine(CROneStepSharing());
        }

        IEnumerator CRSaveScreenshot()
        {
            yield return new WaitForEndOfFrame();

            TwoStepScreenshotPath = Sharing.SaveScreenshot(TwoStepScreenshotName);

            NativeUI.Alert("Alert", "A new screenshot was saved at " + TwoStepScreenshotPath);
        }

        IEnumerator CROneStepSharing()
        {
            yield return new WaitForEndOfFrame();

            Sharing.ShareScreenshot(OneStepScreenshotName, sampleMessage);
        }
    }
}
    
using System.Collections.Generic;
using UnityEngine;

public class SkillMenuUI : MonoBehaviour
{
	public List<GameObject> modDetailWindows;
	public List<GameObject> charFigParts;

	public GameObject skillMenu;
	public GameObject closeButton;

	private Animation headAnimation;
	private Animation torsoAnimation;
	private Animation rightArmAnimation;
	private Animation leftArmAnimation;
	private Animation rightHandAnimation;
	private Animation leftHandAnimation;
	private Animation rightLegAnimation;
	private Animation leftLegAnimation;
	private Animation rightFootAnimation;
	private Animation leftFootAnimation;

	private bool isActive;

	void Start()
	{
		// Animation components of the character figure body parts
		headAnimation = charFigParts[0].GetComponent<Animation>();
		torsoAnimation = charFigParts[1].GetComponent<Animation>();
		rightArmAnimation = charFigParts[2].GetComponent<Animation>();
		leftArmAnimation = charFigParts[3].GetComponent<Animation>();
		rightHandAnimation = charFigParts[4].GetComponent<Animation>();
		leftHandAnimation = charFigParts[5].GetComponent<Animation>();
		rightLegAnimation = charFigParts[6].GetComponent<Animation>();
		leftLegAnimation = charFigParts[7].GetComponent<Animation>();
		rightFootAnimation = charFigParts[8].GetComponent<Animation>();
		leftFootAnimation = charFigParts[9].GetComponent<Animation>();
	}

	void Update()
	{
		OpenAndCloseSkillMenu();
		CloseDetailWindow();
	}

	// Open and close skill menu with keyboard input
	void OpenAndCloseSkillMenu()
	{
		if (!isActive)
		{
			if (Input.GetKeyDown(KeyCode.N))
			{
				skillMenu.SetActive(true);
				isActive = true;
			}
		}
		else if (isActive)
		{
			if (Input.GetKeyDown(KeyCode.N))
			{
				skillMenu.SetActive(false);
				isActive = false;
			}
		}
	}

	// Close mod detail windows with keyboard input
	void CloseDetailWindow()
	{
		for (int window = 0; window < modDetailWindows.Count; window++)
		{
			if (Input.GetKeyDown(KeyCode.Escape) && modDetailWindows[window].activeSelf)
			{
				modDetailWindows[window].SetActive(false);
			}
		}
	}

	public void CloseSkillMenu()
	{
		skillMenu.SetActive(false);
		isActive = false;
	}

	// Opening mod detail windows on button click
	public void OpenBMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[0].SetActive(true);
	}

	public void OpenBMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[1].SetActive(true);
	}

	public void OpenBMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[2].SetActive(true);
	}

	public void OpenTMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[3].SetActive(true);
	}

	public void OpenTMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[4].SetActive(true);
	}

	public void OpenTMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[5].SetActive(true);
	}

	public void OpenAMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[6].SetActive(true);
	}

	public void OpenAMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[7].SetActive(true);
	}

	public void OpenAMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[8].SetActive(true);
	}

	public void OpenHMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[9].SetActive(true);
	}

	public void OpenHMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[10].SetActive(true);
	}

	public void OpenHMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[11].SetActive(true);
	}

	public void OpenLMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[12].SetActive(true);
	}

	public void OpenLMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[13].SetActive(true);
	}

	public void OpenLMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[14].SetActive(true);
	}

	public void OpenFMOneWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[15].SetActive(true);
	}

	public void OpenFMTwoWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[16].SetActive(true);
	}

	public void OpenFMThreeWindow()
	{
		modDetailWindows[18].SetActive(true);
		modDetailWindows[17].SetActive(true);
	}

	// Closing mod detail windows on button click
	public void CloseBMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[0].SetActive(false);
	}

	public void CloseBMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[1].SetActive(false);
	}

	public void CloseBMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[2].SetActive(false);
	}

	public void CloseTMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[3].SetActive(false);
	}

	public void CloseTMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[4].SetActive(false);
	}

	public void CloseTMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[5].SetActive(false);
	}

	public void CloseAMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[6].SetActive(false);
	}

	public void CloseAMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[7].SetActive(false);
	}

	public void CloseAMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[8].SetActive(false);
	}

	public void CloseHMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[9].SetActive(false);
	}

	public void CloseHMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[10].SetActive(false);
	}

	public void CloseHMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[11].SetActive(false);
	}

	public void CloseLMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[12].SetActive(false);
	}

	public void CloseLMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[13].SetActive(false);
	}

	public void CloseLMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[14].SetActive(false);
	}

	public void CloseFMOneWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[15].SetActive(false);
	}

	public void CloseFMTwoWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[16].SetActive(false);
	}

	public void CloseFMThreeWindow()
	{
		modDetailWindows[18].SetActive(false);
		modDetailWindows[17].SetActive(false);
	}

	// Play character figure animations
	public void PlayCFHeadAnimation()
	{
		headAnimation.Play();
	}

	public void PlayCFTorsoAnimation()
	{
		torsoAnimation.Play();
	}

	public void PlayCFArmsAnimation()
	{
		rightArmAnimation.Play();
		leftArmAnimation.Play();
	}

	public void PlayCFHandsAnimation()
	{
		rightHandAnimation.Play();
		leftHandAnimation.Play();
	}

	public void PlayCFLegsAnimation()
	{
		rightLegAnimation.Play();
		leftLegAnimation.Play();
	}

	public void PlayCFFeetAnimation()
	{
		rightFootAnimation.Play();
		leftFootAnimation.Play();
	}

	// Stop character figure animations
	public void StopCFHeadAnimation()
	{
		headAnimation["Head Pulse Animation"].time = 0;

		headAnimation.Sample();
		headAnimation.Stop();
	}

	public void StopCFTorsoAnimation()
	{
		torsoAnimation["Torso Pulse Animation"].time = 0;

		torsoAnimation.Sample();
		torsoAnimation.Stop();
	}

	public void StopCFArmsAnimation()
	{
		rightArmAnimation["Right Arm Pulse Animation"].time = 0;
		leftArmAnimation["Left Arm Pulse Animation"].time = 0;

		rightArmAnimation.Sample();
		leftArmAnimation.Sample();
		rightArmAnimation.Stop();
		leftArmAnimation.Stop();
	}

	public void StopCFHandsAnimation()
	{
		rightHandAnimation["Right Hand Pulse Animation"].time = 0;
		leftHandAnimation["Left Hand Pulse Animation"].time = 0;

		rightHandAnimation.Sample();
		leftHandAnimation.Sample();
		rightHandAnimation.Stop();
		leftHandAnimation.Stop();
	}

	public void StopCFLegsAnimation()
	{
		rightLegAnimation["Right Leg Pulse Animation"].time = 0;
		leftLegAnimation["Left Leg Pulse Animation"].time = 0;

		rightLegAnimation.Sample();
		leftLegAnimation.Sample();
		rightLegAnimation.Stop();
		leftLegAnimation.Stop();
	}

	public void StopCFFeetAnimation()
	{
		rightFootAnimation["Right Foot Pulse Animation"].time = 0;
		leftFootAnimation["Left Foot Pulse Animation"].time = 0;

		rightFootAnimation.Sample();
		leftFootAnimation.Sample();
		rightFootAnimation.Stop();
		leftFootAnimation.Stop();
	}
}

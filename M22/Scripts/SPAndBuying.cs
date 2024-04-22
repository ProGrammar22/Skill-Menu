using Michsky.UI.Reach;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SPAndBuying : MonoBehaviour
{
	public TextMeshProUGUI skillPoints;

	public List<GameObject> buyWindows;
	public List<Image> modConnectors;
	public List<ButtonManager> buttonScripts;

	private int skillPointsCount;
	private int lowestModCost = 50;
	private int lowModCost = 100;
	private int normalModCost = 150;
	private int highModCost = 200;
	private int highestModCost = 300;
	
    void Start()
    {
		skillPoints.text = "10000";
    }

	// Skill points calculation and buying and availability of mods according to the progression
	public void BuyBMLevelOne()
	{
		buyWindows[0].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[0].isInteractable = false;
		modConnectors[0].color = new Color(255, 0, 0, 255);
		buttonScripts[1].isInteractable = true;
	}

	public void BuyBMLevelTwo()
	{
		buyWindows[1].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= normalModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[1].isInteractable = false;
		modConnectors[1].color = new Color(255, 0, 0, 255);
		buttonScripts[2].isInteractable = true;
	}

	public void BuyBMLevelThree()
	{
		buyWindows[2].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[2].isInteractable = false;
	}

	public void BuyTMLevelOne()
	{
		buyWindows[3].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[3].isInteractable = false;
		modConnectors[2].color = new Color(255, 0, 0, 255);
		buttonScripts[4].isInteractable = true;
	}

	public void BuyTMLevelTwo()
	{
		buyWindows[4].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= normalModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[4].isInteractable = false;
		modConnectors[3].color = new Color(255, 0, 0, 255);
		buttonScripts[5].isInteractable = true;
	}

	public void BuyTMLevelThree()
	{
		buyWindows[5].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[5].isInteractable = false;
	}

	public void BuyAMLevelOne()
	{
		buyWindows[6].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[6].isInteractable = false;
		modConnectors[4].color = new Color(255, 0, 0, 255);
		buttonScripts[7].isInteractable = true;
	}

	public void BuyAMLevelTwo()
	{
		buyWindows[7].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[7].isInteractable = false;
		modConnectors[5].color = new Color(255, 0, 0, 255);
		buttonScripts[8].isInteractable = true;
	}

	public void BuyAMLevelThree()
	{
		buyWindows[8].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[8].isInteractable = false;
	}

	public void BuyHMLevelOne()
	{
		buyWindows[9].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[9].isInteractable = false;
		modConnectors[6].color = new Color(255, 0, 0, 255);
		buttonScripts[10].isInteractable = true;
	}

	public void BuyHMLevelTwo()
	{
		buyWindows[10].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[10].isInteractable = false;
		modConnectors[7].color = new Color(255, 0, 0, 255);
		buttonScripts[11].isInteractable = true;
	}

	public void BuyHMLevelThree()
	{
		buyWindows[11].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[11].isInteractable = false;
	}

	public void BuyLMLevelOne()
	{
		buyWindows[12].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[12].isInteractable = false;
		modConnectors[8].color = new Color(255, 0, 0, 255);
		buttonScripts[13].isInteractable = true;
	}

	public void BuyLMLevelTwo()
	{
		buyWindows[13].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= normalModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[13].isInteractable = false;
		modConnectors[9].color = new Color(255, 0, 0, 255);
		buttonScripts[14].isInteractable = true;
	}

	public void BuyLMLevelThree()
	{
		buyWindows[14].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[14].isInteractable = false;
	}

	public void BuyFMLevelOne()
	{
		buyWindows[15].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowestModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[15].isInteractable = false;
		modConnectors[10].color = new Color(255, 0, 0, 255);
		buttonScripts[16].isInteractable = true;
	}

	public void BuyFMLevelTwo()
	{
		buyWindows[16].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= lowModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[16].isInteractable = false;
		modConnectors[11].color = new Color(255, 0, 0, 255);
		buttonScripts[17].isInteractable = true;
	}

	public void BuyFMLevelThree()
	{
		buyWindows[17].SetActive(false);
		buyWindows[18].SetActive(false);

		skillPointsCount = int.Parse(skillPoints.text);
		skillPointsCount -= highModCost;
		skillPoints.text = skillPointsCount.ToString();

		buttonScripts[17].isInteractable = false;
	}
}

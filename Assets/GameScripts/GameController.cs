using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour {
    //implement player deploy cards to the board and player attacking other players. 
    private static Player p1;
    private static Player p2;
    private static int totalTurns;
    private static int currentTurn;
    public static HeroCard VillagerCard = new HeroCard("Villager", 2, 2, 1, 1);
    public static HeroCard KnightCard = new HeroCard("Knight", 4, 4, 3, 2);
    public static HeroCard GuardianCard = new HeroCard("Guardian", 4, 0, 0, 7);
    public static HeroCard ClericCard = new HeroCard("Cleric", 6, 0, 0, 2);
    private static Hero Villager = new Hero("Villager", 2, 1, 1);
    private static Hero Knight = new Hero("Knight", 4, 3, 2);
    private static Hero Guardian = new Hero("Guardian", 0, 0, 7);
    private static Hero Cleric = new Hero("Cleric", 0, 0, 2);

    private CardManager cardManager = new CardManager();

    public GameObject P1VillagerCard; 
    public GameObject P1KnightCard;
    public GameObject P1GuardianCard;
    public GameObject P1ClericCard;
    public GameObject P1Villager; 
    public GameObject P1Knight;
    public GameObject P1Guardian;
    public GameObject P1Cleric;
    public GameObject P1SwordCard;
    public GameObject P1KnightWithSword;
    public GameObject P1ShieldCard;
    public GameObject P1GuardianWithShield;
    public GameObject P1StaffCard;
    public GameObject P1ClericWithStaff;
    public GameObject P1LightningSpellCard;
    public GameObject P1FireballSpellCard;
    public GameObject P1TornadoSpellCard;
    public GameObject P1HellfireSpellCard;
    public GameObject P1HealSpellSCard;
    public GameObject P1HealSpellMCard;
    public GameObject P1HealSpellLCard;
    public GameObject P1DoubleSlashSpellCard;
    public GameObject P2VillagerCard;
    public GameObject P2KnightCard;
    public GameObject P2GuardianCard;
    public GameObject P2ClericCard;
    public GameObject P2Villager;
    public GameObject P2Knight;
    public GameObject P2Guardian;
    public GameObject P2Cleric;
    public GameObject P2SwordCard;
    public GameObject P2KnightWithSword;
    public GameObject P2ShieldCard;
    public GameObject P2GuardianWithShield;
    public GameObject P2StaffCard;
    public GameObject P2ClericWithStaff;
    public GameObject P2LightningSpellCard;
    public GameObject P2FireballSpellCard;
    public GameObject P2TornadoSpellCard;
    public GameObject P2HellfireSpellCard;
    public GameObject P2HealSpellSCard;
    public GameObject P2HealSpellMCard;
    public GameObject P2HealSpellLCard;
    public GameObject P2DoubleSlashSpellCard;
    public GameObject P1Hand;
    public GameObject P2Hand;
    public GameObject P1Heroes; 
    public GameObject P2Heroes; 
    public GameObject P1Heroes_HP;
    public GameObject P2Heroes_HP;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four; 
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public Text p1HP; 
    public Text p1Energy;
    public Text p1Name;
    public Text p2HP; 
    public Text p2Energy;
    public Text p2Name;
    public Text currentTurnText;
    public Text totalTurnsText;
    public InputField inputField1;
    public InputField inputField2;
    public Button p1DrawCardButton;
    public Button p2DrawCardButton; 
    public Button p1PlayButton; 
    public Button p2PlayButton;
    public Button continueButton;

    public Text hpText;
    public Text turnText;

    public void Start() {
        if (SceneManager.GetActiveScene().name == "Main_Menu") {
            if (GameController.p1 == null) {
                continueButton.interactable = false;
            } else if (GameController.p2 == null) {
                continueButton.interactable = false;
            } else {
                if (GameController.p1.HP > 0 && GameController.p2.HP > 0) {
                    continueButton.interactable = true;
                } else {
                    continueButton.interactable = false;
                }
            }
        } else if (SceneManager.GetActiveScene().name == "P1_Card") {
            p1ShowCard();
            p1DrawCardButton.enabled = true;   
        } else if (SceneManager.GetActiveScene().name == "P2_Card") {
            p2ShowCard();
            p2DrawCardButton.enabled = true;
        } else if (SceneManager.GetActiveScene().name == "P1_Heroes") {
            p1ShowHeroes();
            p2ShowHeroes();
        } else if (SceneManager.GetActiveScene().name == "P2_Heroes") {
            p1ShowHeroes();
            p2ShowHeroes();
        } else if (SceneManager.GetActiveScene().name == "2_Player_Gameplay") {
            currentTurnText.text = "" + GameController.currentTurn;
            totalTurnsText.text = "" + GameController.totalTurns;
            if (GameController.p2.energy == -1) {
                p1PlayButton.enabled = true;
                p2PlayButton.enabled = false;
            } else if (GameController.p1.energy == -1) {
                p1PlayButton.enabled = false;
                p2PlayButton.enabled = true;
            } else {
                p1PlayButton.enabled = true; 
                p2PlayButton.enabled = false;
            } 
            if (GameController.currentTurn >= GameController.totalTurns) {
                if (GameController.p1.HP > GameController.p2.HP) {
                    SceneManager.LoadScene("P1_Win");
                } else if (GameController.p1.HP < GameController.p2.HP) {
                    SceneManager.LoadScene("P2_Win");
                } else {
                    SceneManager.LoadScene("Draw");
                }
            }
        }
    }

    public void Update() {
        if (GameController.p1 != null) {
            p1HP.text = GameController.p1.HP.ToString();
            p1Energy.text = GameController.p1.energy.ToString();
            p1Name.text = GameController.p1.name;
        }
        if (GameController.p2 != null) {
            p2HP.text = GameController.p2.HP.ToString();
            p2Energy.text = GameController.p2.energy.ToString();
            p2Name.text = GameController.p2.name;
        }
        if (SceneManager.GetActiveScene().name == "P1_Heroes") {
            p2ShowHeroes();
        } else if (SceneManager.GetActiveScene().name == "P2_Heroes") {
            p1ShowHeroes();
        }
        currentTurnText.text = "" + currentTurn;
    }

    public void initialize() {
        if (inputField1.text == "") {
            GameController.p1 = new Player("P1");
        } else {
            GameController.p1 = new Player(inputField1.text);
        }
        for (int i = 0; i < 5; i++) {
            GameController.p1.cards.Add(cardManager.draw());
        }
        if (inputField2.text == "") {
            GameController.p2 = new Player("P2");
        } else {
            GameController.p2 = new Player(inputField2.text);
        }
        for (int i = 0; i < 5; i++) {
            GameController.p2.cards.Add(cardManager.draw());
        }
        GameController.p1.HP = Int16.Parse(hpText.text);
        GameController.p2.HP = Int16.Parse(hpText.text);
        GameController.currentTurn = 1;
        GameController.totalTurns = Int16.Parse(turnText.text);
    }

    public void destroyItems() {
        foreach (Transform child in P1Hand.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void loadP1Hand() {
        SceneManager.LoadScene("P1_Card");
        if (SceneManager.GetActiveScene().name == "2_Player_Gameplay") {
            GameController.p1.energy = 15;
            foreach (Hero h in GameController.p1.heroes) {
                if (h.name == "Cleric") {
                    GameController.p1.HP += 1;
                } else if (h.name == "ClericWithStaff") {
                    GameController.p2.HP += 2;
                }
            }
        }
        p1ShowCard();
    }

    public void loadP2Hand() {
        SceneManager.LoadScene("P2_Card");
        if (SceneManager.GetActiveScene().name == "2_Player_Gameplay") {
            GameController.p2.energy = 15;
            foreach (Hero h in GameController.p2.heroes) {
                if (h.name == "Cleric") {
                    GameController.p2.HP += 1;
                } else if (h.name == "ClericWithStaff") {
                    GameController.p2.HP += 2;
                }
            }
        }
        p2ShowCard();
    }

    public void backTo2pFromP1() {
        SceneManager.LoadScene("2_Player_Gameplay");
        if (GameController.p2.skipped) {
            GameController.p1.energy = 0;
            GameController.p2.energy = -1;
            GameController.currentTurn += 1;
            GameController.p2.skipped = false; 
        } else {
            GameController.p1.energy = -1;
            GameController.p2.energy = 0;
        }
    }

    public void backTo2pFromP2() {
        SceneManager.LoadScene("2_Player_Gameplay");
        GameController.currentTurn += 1;
        if (GameController.p1.skipped) {
            GameController.p2.energy = 0;
            GameController.p1.energy = -1;
            GameController.p1.skipped = false;
        } else {
            GameController.p2.energy = -1;
            GameController.p1.energy = 0;
        }
    }

    public void p1ShowCard() {
        foreach (Transform child in P1Hand.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Card c in GameController.p1.cards) {
            if (c.getName() == "Villager") {
                GameObject currCard = Instantiate(P1VillagerCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Knight") {
                GameObject currCard = Instantiate(P1KnightCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Guardian") {
                GameObject currCard = Instantiate(P1GuardianCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Cleric") {
                GameObject currCard = Instantiate(P1ClericCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "LightningSpell") {
                GameObject currCard = Instantiate(P1LightningSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "FireballSpell") {
                GameObject currCard = Instantiate(P1FireballSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "TornadoSpell") {
                GameObject currCard = Instantiate(P1TornadoSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "HellfireSpell") {
                GameObject currCard = Instantiate(P1HellfireSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "HealSpellS") {
                GameObject currCard = Instantiate(P1HealSpellSCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "HealSpellM") {
                GameObject currCard = Instantiate(P1HealSpellMCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "HealSpellL") {
                GameObject currCard = Instantiate(P1HealSpellLCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "DoubleSlashSpell") {
                GameObject currCard = Instantiate(P1DoubleSlashSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Sword") {
                GameObject currCard = Instantiate(P1SwordCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Shield") {
                GameObject currCard = Instantiate(P1ShieldCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            } else if (c.getName() == "Staff") {
                GameObject currCard = Instantiate(P1StaffCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
            }
        }
    }

    public void p2ShowCard() {
        foreach (Transform child in P2Hand.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Card c in GameController.p2.cards) {
            if (c.getName() == "Villager") {
                GameObject currCard = Instantiate(P2VillagerCard, new Vector3(0,0,0), Quaternion.identity); //Need to change to p2villagercard, p2mediccard.
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Knight") {
                GameObject currCard = Instantiate(P2KnightCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Guardian") {
                GameObject currCard = Instantiate(P2GuardianCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Cleric") {
                GameObject currCard = Instantiate(P2ClericCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "LightningSpell") {
                GameObject currCard = Instantiate(P2LightningSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);                
            } else if (c.getName() == "FireballSpell") {
                GameObject currCard = Instantiate(P2FireballSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "TornadoSpell") {
                GameObject currCard = Instantiate(P2TornadoSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "HellfireSpell") {
                GameObject currCard = Instantiate(P2HellfireSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "HealSpellS") {
                GameObject currCard = Instantiate(P2HealSpellSCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "HealSpellM") {
                GameObject currCard = Instantiate(P2HealSpellMCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "HealSpellL") {
                GameObject currCard = Instantiate(P2HealSpellLCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "DoubleSlashSpell") {
                GameObject currCard = Instantiate(P2DoubleSlashSpellCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Sword") {
                GameObject currCard = Instantiate(P2SwordCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Shield") {
                GameObject currCard = Instantiate(P2ShieldCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Staff") {
                GameObject currCard = Instantiate(P2StaffCard, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            }
        }
    }
    public void p1DrawCard() { //Goes to P1 hand draw button
        GameController.p1.cards.Add(cardManager.draw());
        GameController.p1.cards.Add(cardManager.draw());
        p1ShowCard();
        p1DrawCardButton.enabled = false;
    }

    public void p2DrawCard() {//Goes to P2 hand draw button
        GameController.p2.cards.Add(cardManager.draw());
        GameController.p2.cards.Add(cardManager.draw());
        p2ShowCard();
        p2DrawCardButton.enabled = false;
    }

    public void insertHP(GameObject place, int number) {
        if (number == 1) {
            GameObject curr = Instantiate(one, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 2) {
            GameObject curr = Instantiate(two, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 3) {
            GameObject curr = Instantiate(three, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 4) {
            GameObject curr = Instantiate(four, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 5) {
            GameObject curr = Instantiate(five, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 6) {
            GameObject curr = Instantiate(six, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 7) {
            GameObject curr = Instantiate(seven, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 8) {
            GameObject curr = Instantiate(eight, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 9) {
            GameObject curr = Instantiate(nine, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } else if (number == 10) {
            GameObject curr = Instantiate(ten, new Vector3(0,0,0), Quaternion.identity);
            curr.transform.SetParent(place.transform, false);
        } 
    }
    public void p1ShowHeroes() {
        foreach (Transform child in P1Heroes.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in P1Heroes_HP.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Hero h in GameController.p1.heroes) {
            insertHP(P1Heroes_HP, h.getHP());
            if (h.name == "Villager") {
                GameObject currHero = Instantiate(P1Villager, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "Knight") {
                GameObject currHero = Instantiate(P1Knight, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "Guardian") {
                GameObject currHero = Instantiate(P1Guardian, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "Cleric") {
                GameObject currHero = Instantiate(P1Cleric, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "KnightWithSword") {
                GameObject currHero = Instantiate(P1KnightWithSword, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "GuardianWithShield") {
                GameObject currHero = Instantiate(P1GuardianWithShield, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            } else if (h.name == "ClericWithStaff") {
                GameObject currHero = Instantiate(P1ClericWithStaff, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P1Heroes.transform, false);
            }
        }
    }
    public void p2ShowHeroes() {
        foreach (Transform child in P2Heroes.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in P2Heroes_HP.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Hero h in GameController.p2.heroes) {
            insertHP(P2Heroes_HP, h.getHP());
            if (h.name == "Villager") {
                GameObject currHero = Instantiate(P2Villager, new Vector3(0,0,0), Quaternion.identity); //need to change to p2villager, p2 medic
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "Knight") {
                GameObject currHero = Instantiate(P2Knight, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "Guardian") {
                GameObject currHero = Instantiate(P2Guardian, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "Cleric") {
                GameObject currHero = Instantiate(P2Cleric, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "KnightWithSword") {
                GameObject currHero = Instantiate(P2KnightWithSword, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "GuardianWithShield") {
                GameObject currHero = Instantiate(P2GuardianWithShield, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            } else if (h.name == "ClericWithStaff") {
                GameObject currHero = Instantiate(P2ClericWithStaff, new Vector3(0,0,0), Quaternion.identity);
                currHero.transform.SetParent(P2Heroes.transform, false);
            }
        }
    }

    public void p1AttackP2(int energyCost, int attackPower) {
        if (GameController.p1.energy < energyCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p1.energy -= energyCost; 
            GameController.p2 = GameController.p2.attacked(attackPower);
            if (GameController.p2 == null) {
                Debug.Log("P2 Died!");
                SceneManager.LoadScene("P1_Win");
                //Goes to P1 Win scene
            }
        }

    }
    public void p1AttackP2Villager() {
        p1AttackP2(2, 1);
        p1ShowHeroes();
        p2ShowHeroes();
    }

    public void p1AttackP2Knight() {
        p1AttackP2(4, 3);
        p1ShowHeroes();
        p2ShowHeroes();
    }

    public void p1AttackP2KnightWithSword() {
        p1AttackP2(5, 5);
        p1ShowHeroes();
        p2ShowHeroes();
    }

    public void p2AttackP1(int energyCost, int attackPower) {
        if (GameController.p2.energy < energyCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p2.energy -= energyCost; 
            GameController.p1 = GameController.p1.attacked(attackPower);
            if (GameController.p1 == null) {
                Debug.Log("P1 Died!");
                SceneManager.LoadScene("P2_Win");
                //Goes to P2 Win scene (Win Scene Only has button to go back to main menu)
            }
        }
        p1ShowHeroes();
        p2ShowHeroes();
    }

    public void p2AttackP1Villager() {
        p2AttackP1(2, 1);
    }

    public void p2AttackP1Knight() {
        p2AttackP1(4, 3);
    }

    public void p2AttackP1KnightWithSword() {
        p2AttackP1(5, 5);
    }

    public void p1DeployHeroCard(HeroCard hc, Hero hero) {
        if (GameController.p1.energy < hc.deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p1.energy -= hc.deploymentCost;
            List<Card> cards = GameController.p1.cards;
            for (int i = 0; i < cards.Count; i++) {
                if (cards[i].name == hc.name) {
                    cards.RemoveAt(i);
                    GameController.p1.heroes.Add(hero);
                    GameController.p1.heroes.Sort();
                    break;
                } 
            }
            SceneManager.LoadScene("P1_Heroes");
        }
    }

    public void p1DeployVillager() {
        p1DeployHeroCard(GameController.VillagerCard, GameController.Villager);
    }

    public void p1DeployKnight() {
        p1DeployHeroCard(GameController.KnightCard, GameController.Knight);
    }
    public void p1DeployGuardian() {
        p1DeployHeroCard(GameController.GuardianCard, GameController.Guardian);
    }

    public void p1DeployCleric() {
        p1DeployHeroCard(GameController.ClericCard, GameController.Cleric);
    }

    public void p2DeployHeroCard(HeroCard hc, Hero hero) {
        if (GameController.p2.energy < hc.deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p2.energy -= hc.deploymentCost;
            List<Card> cards = GameController.p2.cards;
            for (int i = 0; i < cards.Count; i++) {
                if (cards[i].name == hc.name) {
                    cards.RemoveAt(i);
                    GameController.p2.heroes.Add(hero);
                    GameController.p2.heroes.Sort();
                    break;
                } 
            }
        }
        SceneManager.LoadScene("P2_Heroes");
    }

    public void p2DeployVillager() {
        p2DeployHeroCard(GameController.VillagerCard, GameController.Villager);
    }

    public void p2DeployKnight() {
        p2DeployHeroCard(GameController.KnightCard, GameController.Knight);
    }
    public void p2DeployGuardian() {
        p2DeployHeroCard(GameController.GuardianCard, GameController.Guardian);
    }
    public void p2DeployCleric() {
        p2DeployHeroCard(GameController.ClericCard, GameController.Cleric);
    }

    public void p1DeployAttackSpellCard(int deploymentCost, int attackPower, string name) {
        if (GameController.p1.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p1.energy -= deploymentCost;
            List<Card> cards = GameController.p1.cards;
            GameController.p2 = GameController.p2.village_attacked(attackPower);
            if (GameController.p2 == null) {
                Debug.Log("P2 Died!");
                SceneManager.LoadScene("P1_Win");
            } else {
                for (int i = 0; i < cards.Count; i++) {
                    if (cards[i].name == name) {
                        cards.RemoveAt(i);
                        break;
                    }
                }
                SceneManager.LoadScene("P1_Heroes");
            }
        }
    }
    public void p1DeployLightningSpellCard() {
        p1DeployAttackSpellCard(1, 1, "LightningSpell");
    }
    public void p1DeployFirebalSpellCard() {
        p1DeployAttackSpellCard(2, 3, "FireballSpell");
    }
    public void p1DeployTornadoSpellCard() {
        p1DeployAttackSpellCard(10, 4, "TornadoSpell");
        GameController.p2.skipped = true; 
    }
    public void p1DeployHellfireSpellCard() {
        p1DeployAttackSpellCard(15, 2, "HellfireSpell");
        List<Hero> old_heroes = GameController.p2.heroes;
        List<Hero> new_heroes = new List<Hero>();
        foreach (Hero h in old_heroes) {
            Hero k = h.attacked(2);
            if (k != null) {
                new_heroes.Add(k);
            }
        }
        GameController.p2.heroes = new_heroes;
        GameController.p2.heroes.Sort();
    }
    public void p1DeployDoubleSlashSpellCard() {
        if (GameController.p1.energy < 8) {
            Debug.Log("Not enough energy!");
        } else if (GameController.p2.heroes.Count == 0) {
            Debug.Log("p2 has no heroes!");
        } else {
            GameController.p1.energy -= 8;
            List<Hero> old_heroes = GameController.p2.heroes;
            List<Hero> new_heroes = new List<Hero>();
            if (old_heroes.Count == 1) {
                Hero k = old_heroes[0].attacked(3);
                if (k != null) {
                    new_heroes.Add(k);
                }
            } else if (old_heroes.Count == 2) {
                foreach (Hero h in old_heroes) {
                    Hero k = h.attacked(3);
                    if (k != null) {
                        new_heroes.Add(k);
                    }
                }
            } else if (old_heroes.Count > 2) {
                int first = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                int second = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                while (second == first) {
                    second = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                }
                for (int i = 0; i < old_heroes.Count; i++) {
                    if (i == first ^ i == second) {
                        Hero k = old_heroes[i].attacked(3);
                        if (k != null) {
                            new_heroes.Add(k);
                        }
                    } else {
                        new_heroes.Add(old_heroes[i]);
                    }
                }
            }
            GameController.p2.heroes = new_heroes;
            GameController.p2.heroes.Sort();
            SceneManager.LoadScene("P1_Heroes");
        }
    }
    public void p2DeployAttackSpellCard(int deploymentCost, int attackPower, string name) {
        if (GameController.p2.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p2.energy -= deploymentCost;
            List<Card> cards = GameController.p2.cards;
            GameController.p1 = GameController.p1.village_attacked(attackPower);
            if (GameController.p1 == null) {
                Debug.Log("P1 Died!");
                SceneManager.LoadScene("P2_Win");
            } else {
                for (int i = 0; i < cards.Count; i++) {
                    if (cards[i].name == name) {
                        cards.RemoveAt(i);
                        break;
                    }
                }
                SceneManager.LoadScene("P2_Heroes");
            }
        }
    }
    public void p2DeployLightningSpellCard() {
        p2DeployAttackSpellCard(1, 3, "LightningSpell");
    }
    public void p2DeployFireballSpellCard() {
        p2DeployAttackSpellCard(2, 5, "FireballSpell");
    }
    public void p2DeployTornadoSpellCard() {
        p2DeployAttackSpellCard(10, 4, "TornadoSpell");
        GameController.p1.skipped = true; 
    }
    public void p2DeployHellfireSpellCard() {
        p2DeployAttackSpellCard(15, 2, "HellfireSpell");
        List<Hero> old_heroes = GameController.p1.heroes;
        List<Hero> new_heroes = new List<Hero>();
        foreach (Hero h in old_heroes) {
            Hero k = h.attacked(2);
            if (k != null) {
                new_heroes.Add(k);
            }
        }
        GameController.p1.heroes = new_heroes;
        GameController.p1.heroes.Sort();
    }
    public void p2DeployDoubleSlashSpellCard() {
        if (GameController.p2.energy < 8) {
            Debug.Log("Not enough energy!");
        } else if (GameController.p1.heroes.Count == 0) {
            Debug.Log("p1 has no heroes!");
        } else {
            GameController.p2.energy -= 8;
            List<Hero> old_heroes = GameController.p1.heroes;
            List<Hero> new_heroes = new List<Hero>();
            if (old_heroes.Count == 1) {
                Hero k = old_heroes[0].attacked(3);
                if (k != null) {
                    new_heroes.Add(k);
                }
            } else if (old_heroes.Count == 2) {
                foreach (Hero h in old_heroes) {
                    Hero k = h.attacked(3);
                    if (k != null) {
                        new_heroes.Add(k);
                    }
                }
            } else if (old_heroes.Count > 2) {
                int first = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                int second = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                while (second == first) {
                    second = (int) Random.Range(0, (float) (old_heroes.Count + 0.99999 - 1));
                }
                for (int i = 0; i < old_heroes.Count; i++) {
                    if (i == first ^ i == second) {
                        Hero k = old_heroes[i].attacked(3);
                        if (k != null) {
                            new_heroes.Add(k);
                        }
                    } else {
                        new_heroes.Add(old_heroes[i]);
                    }
                }
            }
            GameController.p1.heroes = new_heroes;
            GameController.p1.heroes.Sort();
            SceneManager.LoadScene("P2_Heroes");
        }
    }

    public void p1DeployHealSpellCard(int deploymentCost, int healPower, string name) {
        if (GameController.p1.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p1.energy -= deploymentCost;
            List<Card> cards = GameController.p1.cards;
            GameController.p1.HP += healPower;
            for (int i = 0; i < cards.Count; i++) {
                if (cards[i].name == name) {
                    cards.RemoveAt(i);
                    break;
                }
            }
            SceneManager.LoadScene("P1_Heroes");
        }
    }

    public void p1DeployHealSpellS() {
        p1DeployHealSpellCard(3, 1, "HealSpellS");
    }
    public void p1DeployHealSpellM() {
        p1DeployHealSpellCard(5, 2, "HealSpellM");
    }
    public void p1DeployHealSpellL() {
        p1DeployHealSpellCard(7, 3, "HealSpellL");
    }

    public void p2DeployHealSpellCard(int deploymentCost, int healPower, string name) {
        if (GameController.p2.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            GameController.p2.energy -= deploymentCost;
            List<Card> cards = GameController.p2.cards;
            GameController.p2.HP += healPower;
            for (int i = 0; i < cards.Count; i++) {
                if (cards[i].name == name) {
                    cards.RemoveAt(i);
                    break;
                }
            }
            SceneManager.LoadScene("P2_Heroes");
        }
    }
    public void p2DeployHealSpellS() {
        p2DeployHealSpellCard(3, 1, "HealSpellS");
    }
    public void p2DeployHealSpellM() {
        p2DeployHealSpellCard(5, 2, "HealSpellM");
    }
    public void p2DeployHealSpellL() {
        p2DeployHealSpellCard(7, 3, "HealSpellL");
    }

    public void p1DeployWeapon(string weaponName, string heroName, int deploymentCost, int additionalAttackCost, int additionalAttack) {
        if (GameController.p1.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            bool can = false;
            List<Card> cards = GameController.p1.cards;
            for (int i = GameController.p1.heroes.Count - 1; i >= 0; i--) {
                if (GameController.p1.heroes[i].name == heroName) {
                    can = true;
                    for (int k = 0; k < cards.Count; k++) {
                        if (cards[k].name == name) {
                            cards.RemoveAt(k);
                            break;
                        }
                    }
                    Hero old = GameController.p1.heroes[i];
                    GameController.p1.heroes.Insert(i, new Hero(heroName + "With" + weaponName, 
                    old.attackCost + additionalAttackCost, old.attackPower + additionalAttack, old.HP));
                    GameController.p1.heroes.RemoveAt(i + 1);
                    if (weaponName == "Shield") {
                        GameController.p1.heroes[i].HP += 3;
                    }
                    break;
                }
            }
            if (can) {
                GameController.p1.energy -= deploymentCost;
                SceneManager.LoadScene("P1_Heroes");
            }
        }
    }
    public void p1DeploySword() {
        p1DeployWeapon("Sword", "Knight", 3, 1, 2);
    }
    public void p1DeployShield() {
        p1DeployWeapon("Shield", "Guardian", 1, 0, 0);
    }
    public void p1DeployStaff() {
        p1DeployWeapon("Staff", "Cleric", 2, 0, 0);
    }

    public void p2DeployWeapon(string weaponName, string heroName, int deploymentCost, int additionalAttackCost, int additionalAttack) {
        if (GameController.p2.energy < deploymentCost) {
            Debug.Log("Not enough energy!");
        } else {
            bool can = false;
            List<Card> cards = GameController.p2.cards;
            for (int i = GameController.p2.heroes.Count - 1; i >= 0; i--) {
                if (GameController.p2.heroes[i].name == heroName) {
                    can = true;
                    for (int k = 0; k < cards.Count; k++) {
                        if (cards[k].name == weaponName) {
                            cards.RemoveAt(k);
                            break;
                        }
                    }
                    Hero old = GameController.p2.heroes[i];
                    GameController.p2.heroes.Insert(i, new Hero(heroName + "With" + weaponName, 
                    old.attackCost + additionalAttackCost, old.attackPower + additionalAttack, old.HP));
                    GameController.p2.heroes.RemoveAt(i + 1);
                    if (weaponName == "Shield") {
                        GameController.p2.heroes[i].HP += 3;
                    }
                    break;
                }
            }
            if (can) {
                GameController.p2.energy -= deploymentCost;
                SceneManager.LoadScene("P2_Heroes");
            }
        }
    }
    public void p2DeploySword() {
        p2DeployWeapon("Sword", "Knight", 3, 1, 2);
    }
    public void p2DeployShield() {
        p2DeployWeapon("Shield", "Guardian", 1, 0, 0);
    }
    public void p2DeployStaff() {
        p2DeployWeapon("Staff", "Cleric", 2, 0, 0);
    }

}


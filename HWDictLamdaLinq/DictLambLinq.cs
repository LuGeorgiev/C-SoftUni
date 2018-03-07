using System;
using System.Collections.Generic;
using System.Linq;

namespace HWDictLamdaLinq
{
    class DictLambLinq
    {
        //1. and 2	Phonebook
        static SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
        public static void PhonebookAcrion()
        {
            string currentInput = Console.ReadLine();
            while (currentInput!="END")
            {
                string[] commands = currentInput.Split(' ').ToArray();
                if (commands[0]=="A")
                {
                    AddPhone(commands[1], commands[2]);
                }
                else if (commands[0] == "S")
                {
                    SearchName(commands[1]);
                }
                else if (commands[0] == "ListAll")
                {
                    ListAll();
                }
                currentInput = Console.ReadLine();
            }
        }
        private static void ListAll()
        {
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        private static void SearchName(string name)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
        private static void AddPhone(string name, string phone)
        {
            if (phonebook.ContainsKey(name))
            {
                phonebook[name] = phone;
            }
            else
            {
                phonebook.Add(name, phone);
            }
        }

        //3.	A Miner Task
        public static void ComodityDB()
        {
            Dictionary<string, long> comomdity = new Dictionary<string, long>();
            string comodityType = Console.ReadLine();
            while (comodityType != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (comomdity.ContainsKey(comodityType))
                {
                    comomdity[comodityType] = quantity+ comomdity[comodityType];
                }
                else
                {
                    comomdity.Add(comodityType, quantity);
                }
                comodityType = Console.ReadLine();
            }

            foreach (var item in comomdity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        //4.	Fix Emails
        public static void FixedMails()
        {
            Dictionary<string, string> emailsDB = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string eMail = Console.ReadLine();
                if (!(eMail.EndsWith("us")|| eMail.EndsWith("uk")))
                {
                    emailsDB.Add(name,eMail);
                }               
                name = Console.ReadLine();
            }

            foreach (var item in emailsDB)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        //5.	Hands of Cards NO FULL SCORES
        public static void HandsOfCards()
        {
            var playersCards = new Dictionary<string, List<string>>();

            
            string playersHand = Console.ReadLine();


            while (playersHand != "JOKER")
            {
                int indexName = playersHand.IndexOf(':');
                string player = playersHand.Substring(0, indexName);

                string[] cardsInHAnd = playersHand.Substring(indexName)
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                List<string> playerDeck = new List<string>();
                for (int i = 1; i < cardsInHAnd.Length; i++)
                {
                    playerDeck.Add(cardsInHAnd[i]);
                }
                //to remove duplicates
                playerDeck = new HashSet<string>(playerDeck)
                    .ToList();

                if (playersCards.ContainsKey(player))
                {
                    //add cards to existing player
                    for (int i = 0; i < playerDeck.Count; i++)
                    {
                        if (!playersCards[player].Contains(playerDeck[i]))
                        {
                            //adds another card
                            playersCards[player].Add(playerDeck[i]);
                        }
                    }
                }
                else
                {
                    //add new player
                    playersCards.Add(player, playerDeck);
                }

                playersHand = Console.ReadLine();
            }



            foreach (var item in playersCards)
            {
                int points = 0;
                Console.Write(item.Key+": ");
                foreach (var card in item.Value)
                {
                    int cardPower = 0;
                    int cardType = 0;
                    switch (card[0])
                    {
                        case '2':
                            cardPower = 2;
                            break;
                        case '3':
                            cardPower = 3;
                            break;
                        case '4':
                            cardPower = 4;
                            break;
                        case '5':
                            cardPower = 5;
                            break;
                        case '6':
                            cardPower = 6;
                            break;
                        case '7':
                            cardPower = 7;
                            break;
                        case '8':
                            cardPower = 8;
                            break;
                        case '9':
                            cardPower = 9;
                            break;
                        case '1':
                            cardPower = 10;
                            break;
                        case 'J':
                            cardPower = 11;
                            break;
                        case 'Q':
                            cardPower = 12;
                            break;
                        case 'K':
                            cardPower = 13;
                            break;
                        case 'A':
                            cardPower = 14;
                            break;
                        default:
                            break;
                    }
                    if (card.EndsWith("S"))
                    {
                        cardType = 4;
                    }
                    else if (card.EndsWith("H"))
                    {
                        cardType = 3;
                    }
                    else if (card.EndsWith("D"))
                    {
                        cardType = 2;
                    }
                    else if (card.EndsWith("C"))
                    {
                        cardType = 1;
                    }
                    points += cardPower * cardType;
                }
                Console.Write(points);
                Console.WriteLine();
            }
        }

        static void Main()
        {
            //1. and 2.	Phonebook
            //PhonebookAcrion();

            //3.	A Miner Task NOT SOLVED 75/100
            //ComodityDB();

            //4.Fix Emails
            //FixedMails();

            //5.Hands of Cards
            HandsOfCards();
        }
    }
}

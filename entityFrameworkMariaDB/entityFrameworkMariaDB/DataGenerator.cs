using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkMariaDB
{
    public static class DataGenerator
    {
        static Random rnd = new Random();


        private static string[] whisper =
        {
            "hey kiddo wanna buy a tikaphu? ",
            "haha ur so silly",
            "I like water element creatures the most.",
            "You wanna come with me to the next city?",
            "How did you do that??",
            "Where do I get Pinqueen I'm desperate",
            "How many of those do you have?",
            "I don't like those...",
            "Where did you get your creatures?",
            "I'm new could you help me? :( ",
            "Sorry for being stupid im a noob",
            "Haha I love this place",
            "I wish my creature was a different color :(",
            "Mine is a girl? I didnt know they could be male",
            "Where do I buy berries",
            "Which way to the next town?",
            "How many do you have so far?",
            "Are you a girl? irl?",
            "I usually play co-op with my gf",
            "I don't really like tikaphus but it's okay if you do",
            "I have no idea what youre talking about...lol",
            "wtf was that lmao",
            "u suck n ur bad lol",
            "tikaphu is such a ripoff creature imo",
            "I think the dev is smelly irl",
            "my dad knows the person who made this game and he can hack ur creatures",
            "Did you hear the developers were sued by nintendo?",
            "this game sux, do u want to play pokemon?",
            "the devs are lazy and this game is boring",
            "haha ur so right",
            "selling lobsters 49 gb each w304 varrock",
            "stoneman looks so stinky"
        };
        private static string[] SureNames =
        {
            "John",
            "Johnny",
            "Karl",
            "Jeff",
            "Anders",
            "Jens",
            "Michael",
            "Adam",
            "Chrispother",
            "Kristoffer",
            "Andreas",
            "Anna",
            "Cecelie",
            "James",
            "Jamie",
            "Jessie",
            "Sam",
            "Charlie",
            "Lola",
            "Larry",
            "Jerry",
            "Garry",
            "Ash",
            "Karen",
            "Jack",
            "Benny",
            "Ben",
            "Bo",
            "Mike",
            "Joseph",
            "Nate",
            "Jimmie",
            "Tom",
            "Karina",
            "Carina",
            "Mikkel",
            "Mads",
            "Olaf",
            "Elsa",
            "Elise",
            "Whitney",
            "Britney",
            "Elsabeth",
            "Jona",
            "Rigi",
            "Jenny",
            "Courtney"
        };

        private static string[] creatureNamess =
        {
            "Softy",
            "Squishy",
            "My best friend",
            "Fluffy",
            "Clover",
            "Pika",
            "Spike",
            "Jeff",
            "Tank",
            "Buddy",
            "Muffin",
            "Sprout",
            "Shredder",
            "Dumpy",
            "Stimpy",
            "Stumpy",
            "Sparkle",
            "Lola",
            "Larry",
            "Jerry",
            "Mina",
            "Baby",
            "Tough",
            "Blossom",
            "Rocky",
            "Bucky",
            "Mean Machine",
            "Lilly",
            "Stalin",
            "Sprinkles",
            "Jimmy",
            "Bob",
            "Buttercup",
            "Mr. Mean",
            "Earl",
            "Snake",
            "Tinky",
            "Stinky",
            "Jeremy",
            "Fred",
            "Osmosis",
            "Brotus",
            "Lucky",
            "Teddy",
            "Gilbert",
            "Surfy",
            "Happy",
            "F U N",
            "wow",
            "asdf123",
            "Funny boi",
            "Lil sunshine",
            "Mr. Moon",
            "Pigemnto",
            "Nickname",
            "Rascal"
        };

        private static string[] LastNames =
        {
            "Johnson",
            "Karlson",
            "Anderson",
            "Jensen",
            "Zubcevic",
            "Jackson",
            "Steward Stardust",
            "Mattheson",
            "Mikkelsen",
            "Davidson",
            "Musk",
            "Rogan",
            "Zuckerberg",
            "Brown",
            "White",
            "Black",
            "Green",
            "Fischer",
            "Smith",
            "Tveskaeg",
            "Poulsen",
            "Ackles",
            "Schneider",
            "Houston",
            "Washington",
            "Summer",
            "Miamoto",
            "Hinterseer",
            "Asher",
            "Mikkelsen",
            "Madsen",
            "Gates",
            "Thomson",
            "Pedersen",
            "Van Hooden",
            "Carrey",
            "Devries",
            "Lomholdt",
            "Sakarisdottir",
            "Hjort",
            "Nielsen"
        };

        private static string[] GamerTagsPrefix =
        {
            "xX",
            "zx",
            "_",
            "Faze_",
            "twitch_",
            "123",
            "69",
            "420",
            "owo"
        };
        private static string[] GamerTagsSuffix =
        {
            "xX",
            "zx",
            "_",
            "47",
            "xD",
            "123",
            "69",
            "420",
            "_l33t",
            "owo"
        };
        private static string[] GamerTags =
        {
            "jeSSsica",
            "jeSiKa",
            "Jess",
            "Heeadshotter",
            "IWannaBTheVeryBest",
            "iAmTheeBest",
            "gaamer",
            "gamer",
            "Kitty",
            "IamUnique",
            "_Stinky",
            "stinker",
            "iAmSpecial",
            "AshKechup",
            "rudeBoi",
            "iamNumbaOne",
            "wowe",
            "belle",
            "sonicFan",
            "PokeMonSux",
            "Yeasdsh",
            "the1",
            "Ansuz",
            "Emi",
            "B0aty",
            "OldWiseMan",
            "Naruto",
            "BestGamer",
            "PCMasterRace",
            "Redditor",
            "iamsilly",
            "funnyMan",
            "girlGamer",
            "MyMomIsMad",
            "urMomHaha",
            "jessiejames",
            "rickandmorty123",
            "isThisNameTaken",
            "stupidName",
            "mygamertag",
            "Iamverysmart"

        };

        private static string[] emails =
        {
            "@hotmail.com",
            "@gmail.com",
            "@yahoo.com",
            "@gmail.jp",
            "@gmail.dk",
            "@hotmail.jp",
            "@gmail.de"

        };

        public static void GenerateRandomAccount()
        {

            string firstname = SureNames[rnd.Next(SureNames.Length)];
            string lastname = LastNames[rnd.Next(LastNames.Length)];

            if (rnd.Next(10) <= 2)
            {
                lastname += " " + LastNames[rnd.Next(LastNames.Length)];
            }

            string gamertag = "";

            if (rnd.Next(10) <= 2)
            {
                gamertag += " " + GamerTagsPrefix[rnd.Next(GamerTagsPrefix.Length)];
            }
            gamertag += " " + GamerTags[rnd.Next(GamerTags.Length)];

            if (rnd.Next(10) <= 2)
            {
                gamertag += " " + GamerTagsSuffix[rnd.Next(GamerTagsSuffix.Length)];
            }
            if (rnd.Next(10) <= 2)
            {
                gamertag += "_" + rnd.Next(999);
            }

            string e = firstname.Split(firstname.ElementAt((int)(firstname.Length / 2)))[0];
            string a = gamertag.Split(gamertag.ElementAt((int)(gamertag.Length / 2)))[0];
            string email =
                e + a + emails[rnd.Next(emails.Length)]
                ;
            email = email.Replace(" ", "");
            gamertag = gamertag.Replace(" ", "");

            try
            {
                using (creaturesEntities db = new creaturesEntities())
                {
                    db.CreateAccountProcedure(email, gamertag, RandomDay(), firstname, lastname, gamertag);
                }
            }
            catch (Exception)
            {

            }
        }

        static DateTime RandomDay()
        {
            DateTime start = new DateTime(1960, 1, 1);
            DateTime end = new DateTime(2010, 1, 1);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        public static void createRandomAccounts(int idGreaterThan)
        {
            List<account> accs = new List<account>();


            using (creaturesEntities db = new creaturesEntities())
            {
                accs = db.account.Where(x => x.AccountID > idGreaterThan).ToList();

                foreach (account acc in accs)
                {
                    int x = rnd.Next(0, 3);

                    for (int i = 0; i < x; i++)
                    {

                        trainer t = new trainer()
                        {
                            AccountId = acc.AccountID,
                            TrainerName = randomGamertag()
                        };

                        while (true)
                        {

                            if (db.trainer.Where(d => d.TrainerName == t.TrainerName).Count() > 0)
                            {
                                t.TrainerName = randomGamertag();
                            }
                            else
                            {
                                break;
                            }

                        }

                        acc.trainer.Add(t);
                    }
                    try
                    {

                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(acc.trainer + e.ToString());

                        throw;
                    }
                }

            }


        }

        private static string randomGamertag()
        {
            string gamertag = "";

            do
            {
                gamertag = "";

                if (rnd.Next(10) <= 5)
                {
                    gamertag += " " + GamerTagsPrefix[rnd.Next(GamerTagsPrefix.Length)];
                }
                gamertag += " " + GamerTags[rnd.Next(GamerTags.Length)];

                if (rnd.Next(10) <= 5)
                {
                    gamertag += " " + GamerTagsSuffix[rnd.Next(GamerTagsSuffix.Length)];
                }
                if (rnd.Next(10) <= 7)
                {
                    gamertag += "_" + rnd.Next(999);
                }

            } while (gamertag.Length > 19);

            return gamertag;
        }

        public static void MakeRandomWhispers(int amount)
        {
            using (creaturesEntities db = new creaturesEntities())
            {

                for (int i = 0; i < amount; i++)
                {


                    account from = db.account.ToList()[rnd.Next(db.account.Count())];
                    account to;
                    while (true)
                    {
                         to = db.account.ToList()[rnd.Next(db.account.Count())];

                        if (to != null && to.AccountID != from.AccountID)
                        {
                            break;
                        }

                    }

                    whisper w = new entityFrameworkMariaDB.whisper()
                    {
                        FromId = from.AccountID,
                        ToId = to.AccountID,
                        Text = whisper[rnd.Next(whisper.Length )],
                        TimeStamp = DateTime.Now
                    };
                    db.whisper.Add(w);

                    db.SaveChanges();

                    Console.WriteLine(w.FromId);
                    Console.WriteLine(w.ToId);
                    Console.WriteLine(w.Text);

                    System.Threading.Thread.Sleep(rnd.Next(2000));
                }
            }

        }
        public static void assignRandomCreatures(int idGreaterThan)
        {
            List<account> accs = new List<account>();



            using (creaturesEntities db = new creaturesEntities())
            {
                accs = db.account.Where(a => a.AccountID > idGreaterThan).ToList();

                foreach (account acc in accs)
                {

                    List<trainer> trainers = new List<trainer>();

                    trainers = acc.trainer.ToList();

                    foreach (var tra in trainers)
                    {
                        Console.WriteLine("Adding creatures to trainer: " + tra.TrainerName + " ACC ID: " + tra.AccountId);

                        int amountOfCreatures = rnd.Next(1, 7);

                        for (int i = 0; i < amountOfCreatures; i++)
                        {
                            creature rndCreature;

                            rndCreature = db.creature.ToList()[rnd.Next(db.creature.Count())];

                            string nickName = creatureNamess[rnd.Next(creatureNamess.Length)];

                            caughtcreature cc = new caughtcreature()
                            {
                                CreatureName = rndCreature.CreatureName,
                                TrainerName = tra.TrainerName,
                                XP = rnd.Next(1000000),
                                NickName = rnd.Next(10) > 5 ? nickName : null,
                                Sex = rnd.Next(2) == 0 ? false : true,
                                CurrentHealth = 0
                            };

                            cc.CurrentHealth = rndCreature.Health * cc.XP.XPToLevel();

                            while (true)
                            {
                                creature_evolution sub = db.creature.Find(cc.CreatureName).creature_evolution1.FirstOrDefault();

                                if (sub != null && cc.XP.XPToLevel() <
                                    db.creature.Find(sub.CreatureName).creature_evolution.FirstOrDefault().EvolutionLevel)
                                {
                                    cc.CreatureName = sub.CreatureName;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            while (true)
                            {
                                if (db.creature.Find(cc.CreatureName).creature_evolution.Count() > 0 && cc.XP.XPToLevel() >
                                    db.creature.Find(cc.CreatureName).creature_evolution.FirstOrDefault().EvolutionLevel)
                                {
                                    cc.CreatureName = db.creature.Find(cc.CreatureName).creature_evolution.FirstOrDefault().EvolutionName;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            tra.caughtcreature.Add(cc);

                            Console.WriteLine("Creature added to trainer: " + tra.TrainerName + " ACC ID: " + tra.AccountId + "  Creature: " + cc.CreatureName);

                        }
                        db.SaveChanges();
                        Console.WriteLine("...");

                    }
                }



            }


        }



        public static void GenerateFriendships(int idGraterthan)
        {
            using (creaturesEntities db = new creaturesEntities())
            {
                List<account> accounts = db.account.Where(x => x.AccountID > idGraterthan).ToList();

                foreach (account account in accounts)
                {

                    int amountOfFriends = rnd.Next(0, 10);

                    for (int i = 0; i < amountOfFriends; i++)
                    {
                        while (true)
                        {
                            account rndAcount = db.account.ToList()[rnd.Next(db.account.Count())];


                            if (rndAcount.AccountID == account.AccountID)
                                continue;

                            if (db.friendship.Find(account.AccountID, rndAcount.AccountID) != null)
                                continue;
                            if (db.friendship.Find(rndAcount.AccountID, account.AccountID) != null)
                                continue;

                            /*
                            {
                                foreach (friendship friendship in account.friendship)
                                {
                                    if (friendship.account1.AccountID == rndAcount.AccountID)
                                    {
                                        //friendship exists
                                        success = false;
                                        break;
                                    }

                                    foreach (friendship otherfriendship in rndAcount.friendship)
                                    {
                                        if (otherfriendship.account1.AccountID == account.AccountID)
                                        {
                                            success = false;

                                        }
                                    }

                                }

                            }
                            */


                            if (account.AccountID == rndAcount.AccountID)
                            {
                                break;
                            }

                            db.friendship.Add(new friendship()
                            {
                                AccountId = account.AccountID,
                                FriendId = rndAcount.AccountID,
                                StartDate = DateTime.Today
                            });

                            db.SaveChanges();

                            Console.WriteLine(account.DisplayName + " added " + rndAcount.DisplayName);

                            if (rnd.Next(10) > 1)
                            {
                                db.AcceptFriendRequestProcedure(rndAcount.AccountID, account.AccountID);
                            }
                            break;



                        }
                    }

                }


            }
        }

        public static void assignAbilities(int idGreaterThan)
        {
            List<account> accs = new List<account>();

            using (creaturesEntities db = new creaturesEntities())
            {
                accs = db.account.Where(a => a.AccountID > idGreaterThan).ToList();

                foreach (account acc in accs)
                {
                    Console.WriteLine(" ACC ID: " + acc.AccountID);

                    List<trainer> trainers = new List<trainer>();

                    trainers = acc.trainer.ToList();

                    foreach (var tra in trainers)
                    {
                        Console.WriteLine(" trainer name: " + tra.TrainerName);

                        foreach (var cc in tra.caughtcreature)
                        {
                            Console.WriteLine(" creature name: " + cc.CreatureName);

                            int x = rnd.Next(2, 5);

                            int lvl = cc.XP.XPToLevel();

                            List<creature_learns_ability> possibleAbilities =
                                cc.creature.creature_learns_ability.
                                Where(a => a.LearnLevel <= cc.XP.XPToLevel()).ToList();

                            cc.creature.creature_evolution1.FirstOrDefault()?.creature
                                .creature_learns_ability.
                                Where(a => a.LearnLevel <= cc.XP.XPToLevel()).
                                ToList().ForEach(r => possibleAbilities.Add(r));

                            for (int i = 0; i < x; i++)
                            {
                                caughtcreature_ability ca = new caughtcreature_ability()
                                {
                                    CatchId = cc.CatchId,
                                    AbilityName = possibleAbilities[rnd.Next(possibleAbilities.Count - 1)].AbilityName
                                };



                                List<caughtcreature_ability> conflictingAbilities
                                    = cc.caughtcreature_ability.
                                    Where(cca => cca.AbilityName == ca.AbilityName).ToList();

                                string newAbilityName = string.Empty;

                                if (conflictingAbilities.Count > 0)
                                {
                                    foreach (var pA in possibleAbilities)
                                    {
                                        if (newAbilityName != string.Empty)
                                            break;

                                        bool success = true;
                                        foreach (var existingAbility in conflictingAbilities)
                                        {
                                            if (pA.AbilityName == existingAbility.AbilityName)
                                                success = false;

                                            foreach (var a in cc.caughtcreature_ability)
                                            {
                                                if (pA.AbilityName == a.AbilityName)
                                                {
                                                    success = false;
                                                }
                                            }
                                        }
                                        if (success)
                                        {
                                            newAbilityName = pA.AbilityName;
                                            ca.AbilityName = newAbilityName;
                                            break;
                                        }
                                    }
                                }
                                if ((conflictingAbilities.Count > 0 && newAbilityName != string.Empty) || conflictingAbilities.Count == 0)
                                {
                                    cc.caughtcreature_ability.Add(ca);
                                    Console.WriteLine(i + ": " + ca.AbilityName);
                                }




                            }
                        }
                        Console.WriteLine("...");
                        db.SaveChanges();

                    }
                }

            }
        }



        public static void evolveAllCreatures(int idGreaterThan)
        {
            List<account> accs = new List<account>();

            using (creaturesEntities db = new creaturesEntities())
            {
                accs = db.account.Where(a => a.AccountID > idGreaterThan).ToList();

                foreach (account acc in accs)
                {
                    Console.WriteLine(" ACC ID: " + acc.AccountID);

                    List<trainer> trainers = new List<trainer>();

                    trainers = acc.trainer.ToList();

                    foreach (var tra in trainers)
                    {
                        Console.WriteLine(" trainer name: " + tra.TrainerName);

                        foreach (var cc in tra.caughtcreature)
                        {
                            Console.WriteLine(" creature name: " + cc.CreatureName);

                            if (cc.creature.creature_evolution.Count > 0)
                            {

                            }

                        }
                        //db.SaveChanges();
                        Console.WriteLine("...");

                    }
                }

            }
        }
    }
}

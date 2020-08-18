using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkMariaDB
{
    class Program
    {
        static void Main(string[] args)
        {

            using (creaturesEntities db = new creaturesEntities())
                PrintAccountInfo(db.account.Find(1));


            /*SignIn.Instance.LogIn("andr4376@gmail.com", "4376");

            if (SignIn.OK)
            {
                using (creaturesEntities db = new creaturesEntities())
                    PrintAccountInfo(db.account.Find(SignIn.Instance.Account.AccountID));
            }
            */

            Console.ReadKey();
        }
        private static void PrintAllData()
        {
            using (creaturesEntities db = new creaturesEntities())
            {
                foreach (var account in db.account.ToList())
                {

                    PrintAccountInfo(account);

                }


                Console.WriteLine();
                db.type.ToList().ForEach(x => PrintAllCreaturesOfType(x));

            }
        }
        private static void PrintAccountInfo(account account)
        {
            Console.WriteLine("Account name: " + account.DisplayName + "\n");
            Console.WriteLine(" Account Email: " + account.Email);
            Console.WriteLine(" User Full Name: " + account.Firstname + " " + account.LastName);

            Console.WriteLine(" Friends: " + account.friendship.Count + "\n");

            account.friendship.ToList().ForEach(f => Console.WriteLine("    *" + f.account1.DisplayName));

            Console.WriteLine("________________________________________________\n");

            PrintTrainersInfo(account);


            Console.WriteLine("________________________________________________\n");
        }

        private static void PrintTrainersInfo(account account)
        {
            Console.WriteLine(account.DisplayName + " has " + account.trainer.Count + " trainer(s)...\n");

            foreach (var trainer in account.trainer.ToList())
            {

                Console.WriteLine(" Trainer name: " + trainer.TrainerName + "\n");

                int battlesTotal = trainer.trainer_battle.Count + trainer.trainer_battle1.Count;
                int battlesWon = trainer.trainer_battle2.Count();
                int battlesLost =
                            (trainer.trainer_battle.Where(b => b.trainer2 != trainer).Count() +
                            trainer.trainer_battle1.Where(b => b.trainer2 != trainer).Count());

                Console.WriteLine(" Total Battles: " + battlesTotal + "\n");
                Console.WriteLine(" Battles Won: " + battlesWon + "\n");
                Console.WriteLine(" Battles Lost: " + battlesLost + "\n");

                Console.WriteLine("     Creatures Caught: " + trainer.caughtcreature.ToList().Count + "\n");

                PrintCreaturesInfo(trainer);

            }
        }

        private static void PrintCreaturesInfo(trainer trainer)
        {
            foreach (var caughtCreature in trainer.caughtcreature.ToList())
            {
                Console.WriteLine("----------------------------------------------------------");

                PrintCaughtCreatureDescription(caughtCreature);

                PrintCaughtCreatureStats(caughtCreature);
                PrintCaughtCreatureAbilities(caughtCreature);

                PrintCaughtCreatureEvolutions(caughtCreature);


            }
        }

        private static void PrintCaughtCreatureDescription(caughtcreature caughtCreature)
        {
            string types = "";

            caughtCreature.creature.type.ToList().ForEach(n => types += n.TypeName + ",");

            List<string> ct = new List<string>();

            caughtCreature.creature.type.ToList().ForEach(r => ct.Add(r.TypeName));

            types = types.Remove(types.Length - 1);

            string gender = caughtCreature.Sex ? "Male" : "Female";

            Console.WriteLine(
                "\n  Creature Name: " + caughtCreature.CreatureName + "   => Type: " + types
                +
                 "\n\n        Creature Level: " + caughtCreature.XP.XPToLevel()
                + "\n        Creature XP: " + caughtCreature.XP
                + "\n\n        Nick Name: " + caughtCreature.NickName
                + "\n\n        Creature Description: " + caughtCreature.creature.Description
                + "\n        Creature height: " + caughtCreature.creature.Height + " cm"
                + "\n        Creature weight: " + caughtCreature.creature.Weight + " kg"
                + "\n        Creature Gender: " + gender
                + "\n");
        }
        private static void PrintCaughtCreatureAbilities(caughtcreature caughtCreature)
        {
            Console.WriteLine("     Moves:");

            List<ability> cAbilities = new List<ability>();
            caughtCreature.caughtcreature_ability.ToList().ForEach(x => cAbilities.Add(x.ability));

            for (int i = 0; i < 4; i++)
            {
                if (i < cAbilities.Count)
                {
                    string physical = cAbilities[i].IsPhysical ? "Physical" : "Non-Physical";
                    string effect = cAbilities[i].EffectName == null ? "NONE" : cAbilities[i].EffectName;

                    Console.WriteLine(
                        "       " + cAbilities[i].AbilityName + "" +
                        "     DMG:" + cAbilities[i].Damage + "  ACC:" + cAbilities[i].Accuracy
                        + "  Physical? => " + physical
                        + "   Effect: " + effect);
                }
                else
                {
                    Console.WriteLine("       --------");
                }
            }
        }
        private static void PrintCaughtCreatureEvolutions(caughtcreature caughtCreature)
        {
            Console.WriteLine("\n    Possible Evolutions: " + caughtCreature.creature.creature_evolution.ToList().Count);

            caughtCreature.creature.creature_evolution.ToList().
                ForEach(e => Console.WriteLine("            \"" + e.EvolutionName + "\" - lvl " + e.EvolutionLevel));
        }

        private static void PrintCaughtCreatureStats(caughtcreature caughtCreature)
        {

            int level = caughtCreature.XP.XPToLevel();
            int maxHP = caughtCreature.creature.Health * level;



            Console.WriteLine("\n\n     Stats:");
            Console.WriteLine("            HP: " + (caughtCreature.CurrentHealth) + "/" + maxHP);
            Console.WriteLine("           STR: " + caughtCreature.creature.Strenght * level);
            Console.WriteLine("           AGI: " + caughtCreature.creature.Agility * level);
            Console.WriteLine("           INT: " + caughtCreature.creature.Intelligence * level);
            Console.WriteLine("\n");

        }


        private static void PrintAllCreaturesOfType(type t)
        {
            Console.WriteLine("Creatures of type " + t.TypeName.ToUpper() + ": " + t.creature.Count);
            t.creature.ToList().ForEach(x => Console.WriteLine("          " + x.CreatureName));
            Console.WriteLine();
        }



    }





}


/*
 * var context = new entriesdbEntities();

            context.users.ToList().ForEach(
                e => Console.WriteLine(e.Username));

            Random rnd = new Random();

            using (entriesdbEntities db = new entriesdbEntities())
            {
                db.entries.ToList().ForEach(r => Console.WriteLine(r.EntryID));
            }


            using (entriesdbEntities db = new entriesdbEntities())
            {
                var join = (from p in db.entries
                            join u in db.users
                           on p.user equals u.Username
                            select new
                            {
                                t = p.user
                            }
                             ).ToList().FirstOrDefault();

                Console.WriteLine(join.t);
            }

            using (entriesdbEntities db = new entriesdbEntities())
            {
                var select = (from e in db.entries
                              select new
                              {
                                  t = e.Text
                              }
                             ).ToList().FirstOrDefault();

                Console.WriteLine(select.t);
            }
*/


/*
 * 
 * using (creaturesEntities db = new creaturesEntities())
        {
            foreach (var account in db.account.ToList())
            {
                foreach (var trainer in account.trainer.ToList())
                {
                    foreach (var caughtCreature in trainer.caughtcreature.ToList())
                    {
                        string types = "";

                        caughtCreature.creature.type.ToList().ForEach(n => types += n.TypeName+",");

                        List<string> ct = new List<string>();

                        caughtCreature.creature.type.ToList().ForEach(r => ct.Add(r.TypeName));


                       types =  types.Remove(types.Length-1);

                        Console.WriteLine("Account: " +account.DisplayName+
                            "\nTrainer: "+trainer.TrainerName+
                            "\nCreatureName: "+caughtCreature.CreatureName
                            +"\nCreatureType: "+types 
                            +"\nCreatureDescription: "+caughtCreature.creature.Description +
                            "\n___\n");
                    }
                }
            }
        }

        Console.ReadKey();
*/

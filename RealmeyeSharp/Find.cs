﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System.Collections.Generic;

namespace RealmeyeSharp
{
    public class Find
    {
        public static bool result = false;
        /// <summary>
        /// will find keys
        /// </summary>
        /// <param name="IGN"></param>
        /// <returns></returns>
        public static string FindKey(string keyName)
        {
            string result = "";
            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            try
            {
                Key key = new Key();
                WebPage Main = browser.NavigateToPage(new Uri("https://www.realmeye.com/items/keys"));

                var Table = Main.Html.CssSelect(".table-responsive").First().LastChild;
                Table = Table.SelectSingleNode("tbody/tr[" + key.keyList[keyName.ToLower()] + "]");
                result = Table.SelectSingleNode("td[3]").InnerText;
                result += " " + Table.SelectSingleNode("td[4]").InnerText;
            }
            catch (Exception)
            {
                result = "could not find key";

            }
            return result;
        }

        public static string FindBackpack()
        {
            string result = "";
            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            try
            {
                WebPage Main = browser.NavigateToPage(new Uri("https://www.realmeye.com/items/misc"));

                var Table = Main.Html.CssSelect(".table-responsive").First().LastChild;
                Table = Table.SelectSingleNode("tbody/tr[2]");
                result = Table.SelectSingleNode("td[3]").InnerText;
                result += " " + Table.SelectSingleNode("td[4]").InnerText;
            }
            catch (Exception)
            {
                result = "could not find backpack";

            }
            return result;
        }
      
        public static string FindClover()
        {
            string result = "";
            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            try
            {
                WebPage Main = browser.NavigateToPage(new Uri("https://www.realmeye.com/items/misc"));

                var Table = Main.Html.CssSelect(".table-responsive").First().LastChild;
                Table = Table.SelectSingleNode("tbody/tr[1]");
                result = Table.SelectSingleNode("td[3]").InnerText;
                result += " " + Table.SelectSingleNode("td[4]").InnerText;
            }
            catch (Exception)
            {
                result = "could not find clover";

            }
            return result;
        }
    }
    
    public class Key
    {
        public Dictionary<string, int> keyList = new Dictionary<string, int>();

        public Key()
        {
            keyList.Add("ice cave", 1);
            keyList.Add("puppet master's encore", 2);
            keyList.Add("puppet master's", 2);
            keyList.Add("master's", 2);
            keyList.Add("master's encore", 2);
            keyList.Add("encore", 2);
            keyList.Add("puppet master’s theatre", 3);
            keyList.Add("pup", 3);
            keyList.Add("theatre", 3);
            keyList.Add("shaitan", 4);
            keyList.Add("shaitan’s", 4);
            keyList.Add("shait", 4);
            keyList.Add("the nest", 5);
            keyList.Add("nest", 5);
            keyList.Add("shatters", 6);
            keyList.Add("shatts", 6);
            keyList.Add("the crawling depths", 7);
            keyList.Add("crawling depths", 7);
            keyList.Add("cdepths", 7);
            keyList.Add("depths", 7);
            keyList.Add("draconis", 8);
            keyList.Add("lod", 8);
            keyList.Add("woodland labyrinth", 9);
            keyList.Add("woodland", 9);
            keyList.Add("labyrinth", 9);
            keyList.Add("wlab", 9);
            keyList.Add("deadwater docks", 10);
            keyList.Add("deadwater", 10);
            keyList.Add("ddocks", 10);
            keyList.Add("docks", 10);
            keyList.Add("forest maze", 11);
            keyList.Add("cemetery", 12);
            keyList.Add("cem", 12);
            keyList.Add("candy", 13);
            keyList.Add("cland", 13);
            keyList.Add("mad lab", 14);
            keyList.Add("lab", 14);
            keyList.Add("davy jones’s locker", 15);
            keyList.Add("davy jones’ locker", 15);
            keyList.Add("davys", 15);
            keyList.Add("davy", 15);
            keyList.Add("manor of the immortals", 16);
            keyList.Add("manor", 16);
            keyList.Add("totem", 17);
            keyList.Add("forbidden jungle", 17);
            keyList.Add("ocean trench", 18);
            keyList.Add("trench", 18);
            keyList.Add("ocean", 18);
            keyList.Add("ot", 18);
            keyList.Add("lost halls", 19);
            keyList.Add("halls", 19);
            keyList.Add("lh", 19);
            keyList.Add("reef", 20);
            keyList.Add("magic woods", 21);
            keyList.Add("mwoods", 21);
            keyList.Add("parasite chambers ", 22);
            keyList.Add("chambers", 22);
            keyList.Add("parasite", 22);
            keyList.Add("para", 22);
            keyList.Add("sprite", 23);
            keyList.Add("sprite world", 23);
            keyList.Add("tomb of the ancients", 24);
            keyList.Add("tomb", 24);
            keyList.Add("snake pit", 25);
            keyList.Add("pit", 25);
            keyList.Add("abyss of demons", 26);
            keyList.Add("abyss", 26);
            keyList.Add("spider den", 27);
            keyList.Add("pirate cave", 28);
            keyList.Add("undead lair", 29);
            keyList.Add("udl", 29);
            keyList.Add("toxic sewers", 30);
            keyList.Add("sew", 30);
            keyList.Add("mountain temple", 31);
            keyList.Add("mtemple", 31);
            keyList.Add("the hive", 32);
        }
    }
}

﻿using Practice.Easy;
using Practice.VeryEasy;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Question38 question38 = new Question38();
            bool a;
            a= question38.IsLastCharacterN("asdad");
            Question39 question39 = new Question39();
            int[] ln = { 10, 5, 6, 8, 7, 4, 20 };
            int lnans=question39.FindLargestNum(ln);
            Question40 question40 = new Question40();
            double[] sn = { 2.2, -5, -62, 84, 78, 61 };
            double snans=question40.FindSmallNum(sn);
            Question41 question41 = new Question41();
            bool[] bt = { true, false, false, true, true };
            int btans=question41.CountTrue(bt);
            Question42 question42 = new Question42();
            string s421 = "abc";
            string s422 = "ABC";
            string s423 = "qhwe";
            bool a42 = question42.match(s421, s422);
            Question43 question43 = new Question43();
            int a43 =question43.DifferenceMaxMin(ln);
            Question44 question44 = new Question44();
            string s441 = "abchank";
            string s442 = "kqw";
            string s443 = "qsihankqwelkqw";
            bool a44 = question44.CheckEnding(s443 ,s442);
            Question45 question45 = new Question45();
            string a45 = question45.Wumbo("I LOVE MAKING CHALLENGES");
            Question46 question46 = new Question46();
            int a46 = question46.FindDigitAmount(5451313);
            Question47 question47 = new Question47();
            string a47 =question47.MissingAngle(30, 45);
            Question48 question48 = new Question48();
            int a48 = question48.PosCom(10);
            Question49 question49 = new Question49();
            double a49 = question49.SmashFactor(23.2, 25.4);
            Question50 question50 = new Question50();
            int a50 = question50.AddUp(5);
            Question51 question51 = new Question51();
            double a51 = question51.YenToUsd(1000);
            Question52 question52 = new Question52();
            string a52 = question52.LongBurp(5);
            Question53 question53 = new Question53();
            int a53 = question53.CountClaps("CCClaClClap!Clap!ClClClap!");
            Question54 question54 = new Question54();
            string a54 = question54.Go(5);
            Question55 question55 = new Question55();
            int a55 = question55.FindIndex(new string[] { "hi", "edabit", "fgh", "abc" }, "fgh");
            Question56 question56 = new Question56();
            int a56 = question56.Days(11, 2001);
            Question58 question58 = new Question58();
            int a58 = question58.NumberSyllables("on-o-mat-o-poe-ia");
            Question59 question59 = new Question59();
            int a59 = question59.CharCount('b', "big fat bubble");
            Question60 question60 = new Question60();
            int[] qa60 = new int[] { 1, 2, 3, 4, 5 };
            bool a60 = question60.hurdleJump(qa60, 5);
            Question61 question61 = new Question61();
            bool a61 = question61.IsSafeBridge("asdadsaasdasdad");
            Question62 question62 = new Question62();
            int[] a62 = new int[] { -3, -4, -10, -2, -3 };
            int a622 = question62.GetAbsSum(a62);
            Question63 question63 = new Question63();
            string a63 = question63.MonthName(5);
            Question64 question64 = new Question64();
            int[] t64 = new int[] { 1, 0, 3, 3, 7, 2, 1 };
            int[] a64 = question64.MultiplyByLength(t64);
            int a65 = new Question65().Factorial(5);
            string a66 = new Question66().SmallerNum("990", "896");
            double[] t67 = new double[] { 1, 2, 3, 4, 5 };
            double[] a67 = new Question67().FindMinMax(t67);
            long a68 = new Question68().CalculateExponent(9, 5);
            int a69 = new Question69().HammingDistance("abcde", "bcdef");
            int[] et2 = new int[] { 80, 29, 4, -95, -24, 85 };
            int [] e2= new Easy2().SortNumsAscending(et2);
            string e3 = new Easy3().NameShuffle("Donald Trump");
            bool e4 = new Easy4().isIdentical("aaaaaaa");
        }
    }
}

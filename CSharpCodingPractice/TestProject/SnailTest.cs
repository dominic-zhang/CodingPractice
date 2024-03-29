﻿using CodingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class SnailTest
    {
        [TestMethod]
        public void SnailTest1()
        {
            int[][] array =
            {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Test(array, r);
        }

        [TestMethod]
        public void SnailTest2()
        {
            int[][] array = { 
                new [] {114, 770, 288, 857, 658, 765, 684, 119, 47, 521, 577, 754, 770, 767, 201, 5, 607, 894, 508, 648, 826, 340, 197 },
                new [] {35, 368, 255, 286, 517, 987, 396, 205, 463, 820, 217, 474, 34, 635, 370, 839, 150, 781, 556, 294, 828, 862, 784},
                new [] {7, 898, 375, 549, 726, 951, 273, 672, 863, 690, 524, 836, 580, 498, 138, 696, 464, 658, 455, 133, 626, 335, 113},
                new [] {903, 984, 137, 456, 942, 260, 824, 798, 93, 373, 274, 680, 326, 355, 31, 22, 746, 485, 97, 901, 680, 343, 116},
                new [] {985, 877, 339, 58, 516, 819, 134, 846, 550, 642, 475, 850, 854, 479, 248, 623, 562, 653, 869, 131, 947, 998, 237},
                new [] {477, 654, 856, 386, 607, 109, 313, 678, 216, 788, 48, 268, 256, 138, 215, 411, 112, 831, 616, 727, 845, 820, 948},
                new [] {478, 1, 143, 928, 859, 469, 717, 351, 39, 666, 711, 19, 916, 326, 598, 448, 434, 53, 56, 986, 171, 672, 676},
                new [] {614, 596, 918, 700, 336, 230, 350, 724, 19, 127, 357, 387, 799, 55, 30, 645, 992, 829, 307, 139, 463, 191, 747},
                new [] {561, 664, 189, 788, 716, 473, 733, 691, 113, 331, 236, 933, 413, 777, 495, 972, 312, 73, 248, 421, 549, 526, 16},
                new [] {947, 832, 519, 434, 851, 193, 252, 202, 775, 454, 189, 777, 231, 791, 601, 672, 342, 844, 636, 679, 417, 151, 941},
                new [] {387, 959, 912, 29, 279, 191, 930, 573, 5, 913, 637, 433, 494, 545, 462, 89, 326, 389, 622, 758, 973, 955, 190},
                new [] {36, 625, 385, 469, 178, 247, 276, 952, 439, 387, 318, 960, 41, 30, 704, 17, 648, 494, 296, 960, 955, 580, 575},
                new [] {301, 227, 480, 927, 6, 425, 822, 404, 959, 269, 185, 579, 518, 189, 47, 196, 979, 136, 312, 405, 116, 83, 661},
                new [] {204, 308, 7, 764, 65, 410, 447, 722, 277, 451, 285, 338, 983, 341, 424, 168, 218, 740, 414, 399, 804, 429, 165},
                new [] {42, 365, 977, 769, 840, 435, 564, 720, 704, 496, 841, 755, 925, 124, 423, 293, 82, 919, 832, 109, 261, 910, 189},
                new [] {124, 836, 700, 349, 801, 376, 481, 182, 721, 724, 976, 778, 425, 944, 566, 633, 635, 994, 49, 96, 557, 772, 992},
                new [] {905, 176, 87, 12, 737, 815, 480, 300, 487, 274, 610, 503, 573, 942, 893, 5, 865, 521, 966, 419, 710, 123, 705},
                new [] {816, 717, 11, 455, 360, 911, 577, 913, 860, 167, 341, 773, 617, 123, 378, 480, 219, 648, 747, 854, 391, 102, 51},
                new [] {886, 795, 483, 58, 157, 906, 167, 31, 767, 937, 792, 170, 175, 206, 623, 271, 296, 365, 902, 777, 493, 894, 424},
                new [] {718, 502, 321, 837, 177, 988, 907, 61, 646, 666, 909, 718, 250, 652, 82, 380, 346, 451, 575, 215, 720, 690, 667},
                new [] {503, 134, 222, 7, 450, 506, 77, 338, 94, 242, 153, 941, 181, 370, 13, 147, 499, 790, 365, 526, 55, 77, 740},
                new [] {764, 798, 258, 751, 221, 14, 991, 927, 446, 73, 179, 262, 62, 477, 48, 924, 831, 379, 79, 437, 875, 568, 789},
                new [] {586, 994, 970, 177, 409, 845, 373, 455, 847, 92, 968, 221, 291, 214, 834, 422, 637, 872, 261, 44, 649, 425, 494}
            };

            var r = new[] { 114, 770, 288, 857, 658, 765, 684, 119, 47, 521, 577, 754, 770, 767, 201, 5, 607, 894, 508, 648, 826, 340, 197, 784, 113, 116, 237, 948, 676, 747, 16, 941, 190, 575, 661, 165, 189, 992, 705, 51, 424, 667, 740, 789, 494, 425, 649, 44, 261, 872, 637, 422, 834, 214, 291, 221, 968, 92, 847, 455, 373, 845, 409, 177, 970, 994, 586, 764, 503, 718, 886, 816, 905, 124, 42, 204, 301, 36, 387, 947, 561, 614, 478, 477, 985, 903, 7, 35, 368, 255, 286, 517, 987, 396, 205, 463, 820, 217, 474, 34, 635, 370, 839, 150, 781, 556, 294, 828, 862, 335, 343, 998, 820, 672, 191, 526, 151, 955, 580, 83, 429, 910, 772, 123, 102, 894, 690, 77, 568, 875, 437, 79, 379, 831, 924, 48, 477, 62, 262, 179, 73, 446, 927, 991, 14, 221, 751, 258, 798, 134, 502, 795, 717, 176, 836, 365, 308, 227, 625, 959, 832, 664, 596, 1, 654, 877, 984, 898, 375, 549, 726, 951, 273, 672, 863, 690, 524, 836, 580, 498, 138, 696, 464, 658, 455, 133, 626, 680, 947, 845, 171, 463, 549, 417, 973, 955, 116, 804, 261, 557, 710, 391, 493, 720, 55, 526, 365, 790, 499, 147, 13, 370, 181, 941, 153, 242, 94, 338, 77, 506, 450, 7, 222, 321, 483, 11, 87, 700, 977, 7, 480, 385, 912, 519, 189, 918, 143, 856, 339, 137, 456, 942, 260, 824, 798, 93, 373, 274, 680, 326, 355, 31, 22, 746, 485, 97, 901, 131, 727, 986, 139, 421, 679, 758, 960, 405, 399, 109, 96, 419, 854, 777, 215, 575, 451, 346, 380, 82, 652, 250, 718, 909, 666, 646, 61, 907, 988, 177, 837, 58, 455, 12, 349, 769, 764, 927, 469, 29, 434, 788, 700, 928, 386, 58, 516, 819, 134, 846, 550, 642, 475, 850, 854, 479, 248, 623, 562, 653, 869, 616, 56, 307, 248, 636, 622, 296, 312, 414, 832, 49, 966, 747, 902, 365, 296, 271, 623, 206, 175, 170, 792, 937, 767, 31, 167, 906, 157, 360, 737, 801, 840, 65, 6, 178, 279, 851, 716, 336, 859, 607, 109, 313, 678, 216, 788, 48, 268, 256, 138, 215, 411, 112, 831, 53, 829, 73, 844, 389, 494, 136, 740, 919, 994, 521, 648, 219, 480, 378, 123, 617, 773, 341, 167, 860, 913, 577, 911, 815, 376, 435, 410, 425, 247, 191, 193, 473, 230, 469, 717, 351, 39, 666, 711, 19, 916, 326, 598, 448, 434, 992, 312, 342, 326, 648, 979, 218, 82, 635, 865, 5, 893, 942, 573, 503, 610, 274, 487, 300, 480, 481, 564, 447, 822, 276, 930, 252, 733, 350, 724, 19, 127, 357, 387, 799, 55, 30, 645, 972, 672, 89, 17, 196, 168, 293, 633, 566, 944, 425, 778, 976, 724, 721, 182, 720, 722, 404, 952, 573, 202, 691, 113, 331, 236, 933, 413, 777, 495, 601, 462, 704, 47, 424, 423, 124, 925, 755, 841, 496, 704, 277, 959, 439, 5, 775, 454, 189, 777, 231, 791, 545, 30, 189, 341, 983, 338, 285, 451, 269, 387, 913, 637, 433, 494, 41, 518, 579, 185, 318, 960 };
            Test(array, r);
        }

        [TestMethod]
        public void SnailTestOne()
        {
            int[][] array = { new int[] { 1 } };
            var r = new int[] { 1 };
            Test(array, r);
        }

        [TestMethod]
        public void SnailTestEmpty()
        {
            int[][] array = { new int[] { } };
            var r = new int[] { };
            Test(array, r);
        }

        public string Int2dToString(int[][] a)
        {
            return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
        }

        public void Test(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            var r = SnailSolution.Snail(array);
 
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], r[i]);
            }
        }
    }
}

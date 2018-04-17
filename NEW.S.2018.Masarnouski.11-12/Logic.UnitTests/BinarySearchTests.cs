﻿using System;
using NUnit.Framework;
using NEW.S._2018.Masarnouski._11_12;
using System.Collections.Generic;

namespace Logic.UnitTests
{
    [TestFixture]
    public class BinarySearchTests
    {
       [Test]
        public void BinarySearch_IntArray_DefaultComparer_Succed()
        {
            int[] number = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };
            Assert.AreEqual(BinarySearch.Search<int>(number, 144), 144); 
        }

        [Test]
        public void BinarySearch_CharArray_DefaultComparer_Succed()
        {
            char[] strs = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            Assert.AreEqual(BinarySearch.Search<char>(strs, 'Я'), 'Я');
        }
        [Test]
        public void BinarySearch_StringArray_CustomComparer_Succed()
        {
            string[] strs = new string[] { "Алиса","Вася","Дима","Саша"};
            Assert.AreEqual(BinarySearch.Search<string>(strs, "Дима",new StringComparer()),"Дима");
        }
        [Test]
        public void BinarySearch_EmptyArray_ExceptionExpected()
        {
            int[] number = new int[0]{ };
            Assert.Throws<ArgumentException>(
               () => BinarySearch.Search<int>(number,0));
        }
        class StringComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Substring(0, 1).CompareTo(y.Substring(0, 1));
            }
        }
    }
}

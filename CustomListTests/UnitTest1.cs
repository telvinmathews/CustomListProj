using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingMutipleValuesToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 10;
            int itemToAdd3 = 10;
            int itemToAdd4= 10;
            int expected = 4;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddMutipleValuesToCustomList_AddedValueGoesToAnotherIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 11;
            int itemToAdd2 = 12;
            int itemToAdd3 = 13;
            int expected = 13;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMutipleValuesToList_CheckIfFirstIndexRemainsTheSame()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 13;
            int iteamToCheck4 = 14;
            int iteamToCheck5 = 15;
            int iteamToCheck6 = 16;
            int iteamToCheck7= 17;
            int iteamToCheck8 = 18;
            int expected = 10;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Add(iteamToCheck4);
            testList.Add(iteamToCheck5);
            testList.Add(iteamToCheck6);
            testList.Add(iteamToCheck7);
            testList.Add(iteamToCheck8);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_AddMutipleValuesToList_CheckIfTheValueAtSecondIndexIsRemoved()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 12;
            int expected = 11;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Remove(iteamToCheck2);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckIfTheFirstInstanceOfTheValueIsRemoved()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 11;
            int iteamToCheck4 = 12;
            int expected = 11;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Remove(iteamToCheck2);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckIfCountDecrease()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 11;
            int iteamToCheck4 = 12;
            int expected = 3;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Add(iteamToCheck4);
            testList.Remove(iteamToCheck2);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckIfCampcityIsTheSame()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 11;
            int iteamToCheck4 = 12;
            int expected = 4;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Add(iteamToCheck4);
            testList.Remove(iteamToCheck2);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemFromList_CheckIfIndexIsShifted()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int iteamToCheck1 = 10;
            int iteamToCheck2 = 11;
            int iteamToCheck3 = 11;
            int iteamToCheck4 = 12;
            int expected = 12;
            int actual;

            //act
            testList.Add(iteamToCheck1);
            testList.Add(iteamToCheck2);
            testList.Add(iteamToCheck3);
            testList.Add(iteamToCheck4);
            testList.Remove(iteamToCheck3);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //create a list, add three values, but the first index remains the same.
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
            // what happens to the last-added item?
            // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}

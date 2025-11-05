using account_testing0; //tämä saattaa olla eri nimellä ja voi joutua muuttamaan
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Account_1_1()
        {

            //arrange
            int param = 10;
           double balance, expectedBalance = 10.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

   
        }

        [TestMethod]
        public void Account_1_2()
        {

            //arrange
            double param = 10.5;
            double balance, expectedBalance = 10.5;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_3()
        {

            //arrange
            double param = 10.0;
            double balance, expectedBalance = 20.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            account.Transaction(param);
            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_4()
        {

            //arrange
            double param = 0.0;
            double balance, expectedBalance = 0.0;
            Account account = new Account(1);

            //act
           
            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_5()
        {

            //arrange
            
            double param = 10.0;

            double balance = 0.0;
            double expectedBalance = 10.0;
            Account account = new Account(1);



            //act
            for (int i = 0; i < 2; i++)
            {
                if (balance <= 0.0)
                    account.Transaction(param);
                else
                    param = 0.0;

                balance = account.Balance;


            }
            
            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_6()
        {

            //arrange
            double param = -10.0;
       
            double balance, expectedBalance = 0.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            
            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_7()
        {

            //arrange
            double param = 20.0;
            double param2 = -10.0;

            double balance, expectedBalance = 10.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            account.Transaction(param2);

            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_8()
        {

            //arrange
            double param = 10.0;
            double param2 = -10.0;

            double balance, expectedBalance = 0.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            account.Transaction(param2);

            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }

        [TestMethod]
        public void Account_1_9()
        {

            //arrange
            double param = 10.0;
            double param2 = -20.0;

            double balance, expectedBalance = -10.0;
            Account account = new Account(1);

            //act
            account.Transaction(param);
            account.Transaction(param2);

            balance = account.Balance;

            //assert 
            Assert.AreEqual(expectedBalance, balance);

        }
    }
}

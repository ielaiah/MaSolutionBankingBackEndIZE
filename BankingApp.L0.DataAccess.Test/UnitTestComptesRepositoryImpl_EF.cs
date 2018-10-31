using System;
using System.Collections.Generic;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L0.DataAccess.Test
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestCreate()
        {
            //Arrange
            var nouveau = new Compte { Numero = "C9000", Proprietaire="Seifeddine",Solde=9000M};
            var underTest = new ComptesRepositoryImpl_EF();

            //Act
            underTest.Create(nouveau);

            //ASSERT
        }

        [TestMethod]
        public void TestFindbyId_Nominal()
        {
            //Arrange
            //var nouveau = new Compte { Numero = "C9000", Proprietaire = "Seifeddine", Solde = 9000M };
            var underTest = new ComptesRepositoryImpl_EF();
            var numero = "C9000";
            var expected = new Compte { Numero = "C9000", Proprietaire = "Seifeddine", Solde = 9000M };
            //Act
            var actual = underTest.FindById(numero);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFindbyId_Degrade()
        {
            //Arrange
            //var nouveau = new Compte { Numero = "C9000", Proprietaire = "Seifeddine", Solde = 9000M };
            var underTest = new ComptesRepositoryImpl_EF();
            var numero = "C0000";
            
            //Act
            var actual = underTest.FindById(numero);

            //ASSERT
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestFindAll()
        {
            //Arrange
            var underTest = new ComptesRepositoryImpl_EF();
            
            //Act
            var actual = (List<Compte>) underTest.FindAll();

            //ASSERT
            Assert.AreEqual(actual.Count,5);
        }
    }
}

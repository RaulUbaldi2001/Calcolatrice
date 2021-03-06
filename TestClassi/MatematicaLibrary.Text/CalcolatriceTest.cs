﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatematicaLibrary;

namespace MatematicaLibrary.Text
{
    /// <summary>
    /// Descrizione del riepilogo per CalcolatriceTest
    /// </summary>
    [TestClass]
    public class CalcolatriceTest
    {
        public CalcolatriceTest()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ottiene o imposta il contesto del test che fornisce
        ///le informazioni e le funzionalità per l'esecuzione del test corrente.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributi di test aggiuntivi
        //
        // È possibile utilizzare i seguenti attributi aggiuntivi per la scrittura dei test:
        //
        // Utilizzare ClassInitialize per eseguire il codice prima di eseguire il primo test della classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilizzare ClassCleanup per eseguire il codice dopo l'esecuzione di tutti i test della classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilizzare TestInitialize per eseguire il codice prima di eseguire ciascun test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilizzare TestCleanup per eseguire il codice dopo l'esecuzione di ciascun test
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSomma()
        {
            double num1 = 7;
            double num2 = 2;
            double risultato = 9;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }

        [TestMethod]
        public void TestSommaPerZero01()
        {
            double num1 = 0;
            double num2 = 1;
            double risultato = 1;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }
    }
}
